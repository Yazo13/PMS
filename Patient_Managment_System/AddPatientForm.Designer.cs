namespace Patient_Managment_System
{
    partial class AddPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxName = new TextBox();
            labelDob = new Label();
            dateTimePickerDob = new DateTimePicker();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelFamilyName = new Label();
            textBoxFamilyName = new TextBox();
            comboBoxGender = new ComboBox();
            labelGender = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Location = new Point(177, 21);
            labelName.Name = "labelName";
            labelName.Size = new Size(73, 23);
            labelName.TabIndex = 0;
            labelName.Text = "სახელი";
            labelName.Click += labelFullName_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(255, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelDob
            // 
            labelDob.Location = new Point(146, 188);
            labelDob.Name = "labelDob";
            labelDob.Size = new Size(107, 23);
            labelDob.TabIndex = 2;
            labelDob.Text = "დაბ თარიღი";
            // 
            // dateTimePickerDob
            // 
            dateTimePickerDob.ImeMode = ImeMode.NoControl;
            dateTimePickerDob.Location = new Point(255, 187);
            dateTimePickerDob.Name = "dateTimePickerDob";
            dateTimePickerDob.Size = new Size(200, 27);
            dateTimePickerDob.TabIndex = 3;
            dateTimePickerDob.Format = DateTimePickerFormat.Short;
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(153, 90);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(100, 23);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "ტელეფონი";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(255, 87);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 27);
            textBoxPhone.TabIndex = 7;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(158, 157);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(95, 23);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "მისამართი";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(255, 154);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(200, 27);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.Text = "მაგ. თბილისი";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(255, 236);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 36);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "შენახვა";
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(359, 236);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(96, 36);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "გაუქმება";
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelFamilyName
            // 
            labelFamilyName.Location = new Point(191, 57);
            labelFamilyName.Name = "labelFamilyName";
            labelFamilyName.Size = new Size(58, 23);
            labelFamilyName.TabIndex = 12;
            labelFamilyName.Text = "გვარი";
            // 
            // textBoxFamilyName
            // 
            textBoxFamilyName.Location = new Point(255, 54);
            textBoxFamilyName.Name = "textBoxFamilyName";
            textBoxFamilyName.Size = new Size(200, 27);
            textBoxFamilyName.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "მამრობითი", "მდედრობითი" });
            comboBoxGender.Location = new Point(255, 120);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(200, 28);
            comboBoxGender.TabIndex = 5;
            comboBoxGender.Tag = "";
            // 
            // labelGender
            // 
            labelGender.Location = new Point(198, 123);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(55, 23);
            labelGender.TabIndex = 14;
            labelGender.Text = "სქესი";
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 311);
            Controls.Add(labelGender);
            Controls.Add(comboBoxGender);
            Controls.Add(labelFamilyName);
            Controls.Add(textBoxFamilyName);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelDob);
            Controls.Add(dateTimePickerDob);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Name = "AddPatientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "პაციენტის დამატება/რედაქტირება";
            Load += AddPatientForm_Load;
            ResumeLayout(false);
            PerformLayout();



        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelDob;
        private DateTimePicker dateTimePickerDob;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelFamilyName;
        private TextBox textBoxFamilyName;
        private ComboBox comboBoxGender;
        private Label labelGender;
    }
}