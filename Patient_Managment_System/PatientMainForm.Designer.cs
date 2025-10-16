namespace Patient_Managment_System
{
    partial class PatientMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMainForm));
            dataGridViewPatients = new DataGridView();
            buttonAdd = new Button();
            imageList1 = new ImageList(components);
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPatients
            // 
            dataGridViewPatients.AllowUserToResizeColumns = false;
            dataGridViewPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPatients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPatients.BackgroundColor = SystemColors.Window;
            dataGridViewPatients.BorderStyle = BorderStyle.None;
            dataGridViewPatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPatients.ColumnHeadersHeight = 29;
            dataGridViewPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPatients.GridColor = Color.Black;
            dataGridViewPatients.Location = new Point(10, 53);
            dataGridViewPatients.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPatients.Name = "dataGridViewPatients";
            dataGridViewPatients.ReadOnly = true;
            dataGridViewPatients.RightToLeft = RightToLeft.No;
            dataGridViewPatients.RowHeadersVisible = false;
            dataGridViewPatients.RowHeadersWidth = 51;
            dataGridViewPatients.ScrollBars = ScrollBars.None;
            dataGridViewPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatients.Size = new Size(751, 190);
            dataGridViewPatients.TabIndex = 0;
            dataGridViewPatients.CellContentClick += dataGridView1_CellContentClick;

            dataGridViewPatients.AutoGenerateColumns = true;
            dataGridViewPatients.Columns.Clear();
            #region Column-ზე სახელების გადათარგმნა
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID",
                Visible = true,
                Width = 50
            });

            // სრული სახელი
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FullName",
                HeaderText = "პაციენტის გვარი სახელი",
                DataPropertyName = "FullName",
            });

            // დაბადების თარიღი
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Dob",
                HeaderText = "დაბ თარიღი",
                DataPropertyName = "Dob"
            });

            // სქესი
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "GenderName",
                HeaderText = "სქესი",
                DataPropertyName = "GenderName"
            });

            // ტელეფონი
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Phone",
                HeaderText = "ტელეფონი",
                DataPropertyName = "Phone"
            });

            // მისამართი
            dataGridViewPatients.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Address",
                HeaderText = "მისამართი",
                DataPropertyName = "Address"
            });
            #endregion
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.Menu;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Sylfaen", 9F);
            buttonAdd.ForeColor = Color.Black;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.ImageIndex = 0;
            buttonAdd.ImageList = imageList1;
            buttonAdd.Location = new Point(12, 9);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(4);
            buttonAdd.Size = new Size(109, 32);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "დამატება";
            buttonAdd.TextAlign = ContentAlignment.MiddleRight;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "green-plus-11975 (1).png");
            imageList1.Images.SetKeyName(1, "Untitled design.png");
            imageList1.Images.SetKeyName(2, "red-x-10333.png");
            // 
            // buttonEdit
            // 
            buttonEdit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEdit.BackColor = SystemColors.Menu;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Sylfaen", 9F);
            buttonEdit.ForeColor = Color.Black;
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.ImageIndex = 1;
            buttonEdit.ImageList = imageList1;
            buttonEdit.Location = new Point(118, 9);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(4);
            buttonEdit.Size = new Size(138, 32);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "რედაქტირება";
            buttonEdit.TextAlign = ContentAlignment.MiddleRight;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click_1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.Menu;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Sylfaen", 9F);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.ImageIndex = 2;
            buttonDelete.ImageList = imageList1;
            buttonDelete.Location = new Point(253, 9);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(4);
            buttonDelete.Size = new Size(93, 32);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "წაშლა";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // PatientMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(774, 252);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewPatients);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(790, 39);
            Name = "PatientMainForm";
            Text = "Patient Management System";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPatients;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private ImageList imageList1;
    }
}
