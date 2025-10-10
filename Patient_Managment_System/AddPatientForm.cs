using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Patient_Managment_System
{
    public partial class AddPatientForm : Form
    {
        private readonly string? _connString;
        private readonly int? _patientId;

        public AddPatientForm(string connString, int? patientId = null)
        {
            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("Connection String-ის პოვნა ვერ მოხერხდა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _connString = connString;
            _patientId = patientId;
            InitializeComponent();
            LoadGenders();
            if (patientId.HasValue) LoadPatientData(patientId.Value);
        }

        private void LoadGenders()
        {
            if (comboBoxGender == null)
            {
                MessageBox.Show("სქესის გენერირებისას მოხდა შეცდომა", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using SqlConnection conn = new(_connString);
                {
                    conn.Open();
                    using SqlCommand cmd = new("SELECT GenderID, GenderName FROM dbo.Gender", conn);
                    {
                        SqlDataAdapter da = new(cmd);
                        DataTable dt = new();
                        da.Fill(dt);

                        comboBoxGender.DataSource = dt;

                        comboBoxGender.DisplayMember = "GenderName";
                        comboBoxGender.ValueMember = "GenderID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"სქესის მონაცემთა ბაზიდან ჩატვირთვა ვერ მოხერხდა: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBoxGender.Items.Count > 0 && comboBoxGender.SelectedValue == null)
            {
                comboBoxGender.SelectedIndex = 0;
            }
        }

        private void LoadPatientData(int patientId)  // პაციენტის მონაცემების ბაზიდან წამოღება
        {

            using SqlConnection conn = new(_connString);
            try
            {
                conn.Open();
                using SqlCommand cmd = new("SELECT FullName, Dob, GenderID, Phone, Address FROM dbo.Patients WHERE ID = @ID", conn);
                {
                    cmd.Parameters.AddWithValue("@ID", patientId);
                    using SqlDataReader dr = cmd.ExecuteReader();
                    {
                        if (dr.Read())
                        {
                            // FullName-ის უსაფრთხო გაყოფა (კრიტიკული შესწორება)
                            string fullName = dr["FullName"] as string ?? dr["FullName"]?.ToString() ?? string.Empty;
                            string[] fullNameParts = fullName.Split(new char[] { ' ' }, 2);

                            textBoxFamilyName.Text = fullNameParts[0];
                            textBoxName.Text = fullNameParts.Length > 1 ? fullNameParts[1] : string.Empty;

                            // Check for DBNull before accessing DateTime value
                            if (dr["Dob"] is not DBNull)
                            {
                                dateTimePickerDob.Value = dr.GetDateTime(dr.GetOrdinal("Dob"));
                            }

                            int genderId = dr.GetInt32(dr.GetOrdinal("GenderID"));
                            comboBoxGender.SelectedValue = genderId;

                            if (comboBoxGender.SelectedIndex == -1 && comboBoxGender.Items.Count > 0)
                            {
                                MessageBox.Show($"Gender ID {genderId} ვერ მოიძებნა სიაში. შეამოწმეთ სქესის ცხრილი.", "გაფრთხილება",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                comboBoxGender.SelectedIndex = 0;
                            }
                            // Phone და Address-ის უსაფრთხო მიღება (ასევე შესწორებული)
                            textBoxPhone.Text = dr["Phone"] as string ?? string.Empty;
                            textBoxAddress.Text = dr["Address"] as string ?? string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"პაციენტის მონაცემების ჩატვირთვის შეცდომა: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // შენახვის ლოგიკა
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validations
                // ვალიდაცია გვარზე
                if (string.IsNullOrWhiteSpace(textBoxFamilyName.Text))
                {
                    MessageBox.Show("გვარი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ვალიდაცია სახელზე
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                {
                    MessageBox.Show("სახელი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ვალიდაცია სქესზე
                if (comboBoxGender.SelectedIndex == -1)
                {
                    MessageBox.Show("სქესი სავალდებულოა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ვალიდაცია ტელეფონის ნომერზე (ახალი, სუფთა Regex)
                if (!string.IsNullOrWhiteSpace(textBoxPhone.Text))
                {
                    if (!Regex.IsMatch(textBoxPhone.Text, @"^5\d{8}$"))
                    {
                        MessageBox.Show("ტელეფონის ნომერი უნდა იწყებოდეს 5-ით და შეიცავდეს 9 ციფრს.", "შეცდომა",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                #endregion

                string fullName = (textBoxFamilyName.Text.Trim() + " " + textBoxName.Text.Trim()).Trim();
                int genderId = -1;

                if (comboBoxGender.SelectedValue != null && comboBoxGender.SelectedValue != DBNull.Value)
                {
                    genderId = (int)comboBoxGender.SelectedValue;
                }
                else
                {
                    MessageBox.Show("სქესის ID ვერ მოიძებნა.", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using SqlConnection conn = new(_connString);
                {
                    conn.Open();
                    using SqlCommand cmd = conn.CreateCommand();
                    {
                        cmd.CommandText = "dbo.Patient_Save"; // დამატების ან რედაქტირების პროცედურა

                        cmd.CommandType = CommandType.StoredProcedure;

                        // ID პარამეტრი (თუ რედაქტირებაა, გადაეცემა ID; თუ დამატებაა, გადაეცემა DBNull)
                        cmd.Parameters.AddWithValue("@ID", _patientId.HasValue ? (object)_patientId.Value : DBNull.Value);

                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Dob", dateTimePickerDob.Value);
                        cmd.Parameters.AddWithValue("@GenderID", genderId);

                        cmd.Parameters.AddWithValue("@Phone", string.IsNullOrEmpty(textBoxPhone.Text) ? (object)DBNull.Value : textBoxPhone.Text);
                        cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(textBoxAddress.Text) ? (object)DBNull.Value : textBoxAddress.Text);

                        cmd.ExecuteNonQuery();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"პაციენტის მონაცემების შენახვის შეცდომა: {ex.Message}", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // გაუქმების ლოგიკა
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void labelFullName_Click(object sender, EventArgs e) { }
        private void textBoxPhone_TextChanged(object sender, EventArgs e) { }
        private void AddPatientForm_Load(object sender, EventArgs e) { }
    }
}