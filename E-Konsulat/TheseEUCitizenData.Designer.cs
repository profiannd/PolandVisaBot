namespace E_Konsulat
{
    partial class TheseEUCitizenData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxNotApply = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonSpouse = new System.Windows.Forms.RadioButton();
            this.radioButtonChild = new System.Windows.Forms.RadioButton();
            this.radioButtonGrandson = new System.Windows.Forms.RadioButton();
            this.radioButtonDependent = new System.Windows.Forms.RadioButton();
            this.groupBoxName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.groupBox2);
            this.groupBoxName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(421, 223);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Данные гражданина ЕС";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDependent);
            this.groupBox2.Controls.Add(this.radioButtonGrandson);
            this.groupBox2.Controls.Add(this.radioButtonChild);
            this.groupBox2.Controls.Add(this.radioButtonSpouse);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBoxNationality);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxPassportNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePickerBirth);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.textBoxSurname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxNotApply);
            this.groupBox2.Location = new System.Drawing.Point(0, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 203);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персональные данные гражданина ЕС или ЕЭП, на содержании которого Вы находитесь. " +
    "Касается только членов семьи гражданина ЕС или ЕЭП";
            // 
            // checkBoxNotApply
            // 
            this.checkBoxNotApply.AutoSize = true;
            this.checkBoxNotApply.Location = new System.Drawing.Point(7, 35);
            this.checkBoxNotApply.Name = "checkBoxNotApply";
            this.checkBoxNotApply.Size = new System.Drawing.Size(88, 17);
            this.checkBoxNotApply.TabIndex = 0;
            this.checkBoxNotApply.Text = "не касается";
            this.checkBoxNotApply.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(93, 52);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(315, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(240, 88);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(146, 20);
            this.dateTimePickerBirth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата рождения (год-месяц-день)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер паспорта";
            // 
            // textBoxPassportNumber
            // 
            this.textBoxPassportNumber.Location = new System.Drawing.Point(124, 115);
            this.textBoxPassportNumber.Name = "textBoxPassportNumber";
            this.textBoxPassportNumber.Size = new System.Drawing.Size(69, 20);
            this.textBoxPassportNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Гражданство";
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(294, 118);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNationality.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Родство";
            // 
            // radioButtonSpouse
            // 
            this.radioButtonSpouse.AutoSize = true;
            this.radioButtonSpouse.Location = new System.Drawing.Point(108, 151);
            this.radioButtonSpouse.Name = "radioButtonSpouse";
            this.radioButtonSpouse.Size = new System.Drawing.Size(73, 17);
            this.radioButtonSpouse.TabIndex = 12;
            this.radioButtonSpouse.TabStop = true;
            this.radioButtonSpouse.Text = "Супруг/-а";
            this.radioButtonSpouse.UseVisualStyleBackColor = true;
            // 
            // radioButtonChild
            // 
            this.radioButtonChild.AutoSize = true;
            this.radioButtonChild.Location = new System.Drawing.Point(108, 180);
            this.radioButtonChild.Name = "radioButtonChild";
            this.radioButtonChild.Size = new System.Drawing.Size(68, 17);
            this.radioButtonChild.TabIndex = 13;
            this.radioButtonChild.TabStop = true;
            this.radioButtonChild.Text = "Ребенок";
            this.radioButtonChild.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrandson
            // 
            this.radioButtonGrandson.AutoSize = true;
            this.radioButtonGrandson.Location = new System.Drawing.Point(218, 151);
            this.radioButtonGrandson.Name = "radioButtonGrandson";
            this.radioButtonGrandson.Size = new System.Drawing.Size(77, 17);
            this.radioButtonGrandson.TabIndex = 14;
            this.radioButtonGrandson.TabStop = true;
            this.radioButtonGrandson.Text = "Внук/- чка";
            this.radioButtonGrandson.UseVisualStyleBackColor = true;
            // 
            // radioButtonDependent
            // 
            this.radioButtonDependent.AutoSize = true;
            this.radioButtonDependent.Location = new System.Drawing.Point(218, 180);
            this.radioButtonDependent.Name = "radioButtonDependent";
            this.radioButtonDependent.Size = new System.Drawing.Size(83, 17);
            this.radioButtonDependent.TabIndex = 15;
            this.radioButtonDependent.TabStop = true;
            this.radioButtonDependent.Text = "Иждивенец";
            this.radioButtonDependent.UseVisualStyleBackColor = true;
            // 
            // TheseEUCitizenData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxName);
            this.Name = "TheseEUCitizenData";
            this.Size = new System.Drawing.Size(421, 225);
            this.groupBoxName.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNotApply;
        private System.Windows.Forms.RadioButton radioButtonDependent;
        private System.Windows.Forms.RadioButton radioButtonGrandson;
        private System.Windows.Forms.RadioButton radioButtonChild;
        private System.Windows.Forms.RadioButton radioButtonSpouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassportNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
    }
}
