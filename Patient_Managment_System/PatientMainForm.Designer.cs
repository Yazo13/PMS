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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMainForm));
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            imageList1 = new ImageList(components);
            buttonEdit = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(858, 253);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            buttonAdd.Location = new Point(14, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(5);
            buttonAdd.Size = new Size(125, 40);
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
            buttonEdit.Location = new Point(135, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(5);
            buttonEdit.Size = new Size(158, 40);
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
            buttonDelete.Location = new Point(289, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(5);
            buttonDelete.Size = new Size(106, 40);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "წაშლა";
            buttonDelete.TextAlign = ContentAlignment.MiddleRight;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // PatientMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(882, 336);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 0);
            Name = "PatientMainForm";
            Text = "Patient Management System";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private ImageList imageList1;
    }
}
