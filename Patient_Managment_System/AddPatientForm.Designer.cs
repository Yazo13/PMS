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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
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
            labelName.Location = new Point(155, 16);
            labelName.Name = "labelName";
            labelName.Size = new Size(64, 17);
            labelName.TabIndex = 0;
            labelName.Text = "სახელი";
            labelName.Click += labelFullName_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(223, 16);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(176, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelDob
            // 
            labelDob.Location = new Point(128, 141);
            labelDob.Name = "labelDob";
            labelDob.Size = new Size(94, 17);
            labelDob.TabIndex = 2;
            labelDob.Text = "დაბ თარიღი";
            // 
            // dateTimePickerDob
            // 
            dateTimePickerDob.Format = DateTimePickerFormat.Short;
            dateTimePickerDob.ImeMode = ImeMode.NoControl;
            dateTimePickerDob.Location = new Point(223, 140);
            dateTimePickerDob.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDob.Name = "dateTimePickerDob";
            dateTimePickerDob.Size = new Size(176, 23);
            dateTimePickerDob.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.Location = new Point(134, 68);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(88, 17);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "ტელეფონი";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(223, 65);
            textBoxPhone.Margin = new Padding(3, 2, 3, 2);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(176, 23);
            textBoxPhone.TabIndex = 7;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // labelAddress
            // 
            labelAddress.Location = new Point(138, 118);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(83, 17);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "მისამართი";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(223, 116);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(176, 23);
            textBoxAddress.TabIndex = 9;
            textBoxAddress.Text = "მაგ. თბილისი";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(223, 177);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(66, 27);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "შენახვა";
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(314, 177);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(84, 27);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "გაუქმება";
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // labelFamilyName
            // 
            labelFamilyName.Location = new Point(167, 43);
            labelFamilyName.Name = "labelFamilyName";
            labelFamilyName.Size = new Size(51, 17);
            labelFamilyName.TabIndex = 12;
            labelFamilyName.Text = "გვარი";
            // 
            // textBoxFamilyName
            // 
            textBoxFamilyName.Location = new Point(223, 40);
            textBoxFamilyName.Margin = new Padding(3, 2, 3, 2);
            textBoxFamilyName.Name = "textBoxFamilyName";
            textBoxFamilyName.Size = new Size(176, 23);
            textBoxFamilyName.TabIndex = 13;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "მამრობითი", "მდედრობითი" });
            comboBoxGender.Location = new Point(223, 90);
            comboBoxGender.Margin = new Padding(3, 2, 3, 2);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(176, 23);
            comboBoxGender.TabIndex = 5;
            comboBoxGender.Tag = "";
            // 
            // labelGender
            // 
            labelGender.Location = new Point(173, 92);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(48, 17);
            labelGender.TabIndex = 14;
            labelGender.Text = "სქესი";
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 233);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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