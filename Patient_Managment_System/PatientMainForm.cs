using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Patient_Managment_System
{
    public partial class PatientMainForm : Form
    {
        private readonly string _connString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        public PatientMainForm()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(_connString))
            {
                MessageBox.Show("Connection String-ის პოვნა ვერ მოხერხდა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Patient_GetAll(object sender, EventArgs e) // Bring "Patients" table from database
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "dbo.Patient_GetAll";
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
                    }
                }
                dataGridView1.DataSource = dt;

                #region changing colimn headers to Geo
                    if (dataGridView1.Columns.Contains("FullName"))
                    {
                        dataGridView1.Columns["FullName"].HeaderText = "პაციენტის გვარი სახელი";
                    }
                    if (dataGridView1.Columns.Contains("Dob"))
                    {
                        dataGridView1.Columns["Dob"].HeaderText = "დაბ თარიღი";
                    }
                    if (dataGridView1.Columns.Contains("GenderName"))
                    {
                        dataGridView1.Columns["GenderName"].HeaderText = "სქესი";
                    }
                    if (dataGridView1.Columns.Contains("Phone"))
                    {
                        dataGridView1.Columns["Phone"].HeaderText = "ტელეფონი";
                    }
                    if (dataGridView1.Columns.Contains("Address"))
                    {
                        dataGridView1.Columns["Address"].HeaderText = "მისამართი";
                    }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "მოხდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Patient_GetAll(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    MessageBox.Show("Connection String-ის პოვნა ვერ მოხერხდა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (AddPatientForm form = new(_connString))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        Patient_GetAll(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}\nStack Trace: {ex.StackTrace}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    MessageBox.Show("Connection String-ის პოვნა ვერ მოხერხდა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("გთხოვთ, აირჩიოთ პაციენტი რედაქტირებისთვის.", "ყურადღება",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int patientId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                using (AddPatientForm form = new AddPatientForm(_connString, patientId))
                {
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        Patient_GetAll(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"წარმოიშვა შეცდომა: {ex.Message}\nStack Trace: {ex.StackTrace}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_connString))
                {
                    MessageBox.Show("Connection String-ის პოვნა ვერ მოხერხდა", "შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("გთხოვთ, აირჩიოთ პაციენტი წასაშლელად.", "ყურადღება",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int patientId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;
                DialogResult result = MessageBox.Show("დარწმუნებული ხართ, რომ გსურთ ამ პაციენტის წაშლა?", "დადასტურება",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new(_connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new("dbo.Patient_Delete", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", patientId);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Patient_GetAll(sender, e);
                                MessageBox.Show("პაციენტი წარმატებით წაიშალა.", "შეტყობინება",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("პაციენტი არ მოიძებნა ან წაშლა ვერ მოხერხდა.", "შეცდომა",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"მონაცემთა ბაზის შეცდომა: {ex.Message}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"პაციენტის წაშლა ვერ მოხერხდა: {ex.Message}\nStack Trace: {ex.StackTrace}", "შეცდომა",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}