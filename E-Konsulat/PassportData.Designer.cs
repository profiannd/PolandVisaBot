namespace E_Konsulat
{
    partial class PassportData
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioAnother = new System.Windows.Forms.RadioButton();
            this.radioOsobi = new System.Windows.Forms.RadioButton();
            this.radioOficial = new System.Windows.Forms.RadioButton();
            this.radioSluz = new System.Windows.Forms.RadioButton();
            this.radioDippass = new System.Windows.Forms.RadioButton();
            this.radioPass = new System.Windows.Forms.RadioButton();
            this.txtAnother = new System.Windows.Forms.TextBox();
            this.txtPassNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWhom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Паспортные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnother);
            this.groupBox2.Controls.Add(this.radioAnother);
            this.groupBox2.Controls.Add(this.radioOsobi);
            this.groupBox2.Controls.Add(this.radioOficial);
            this.groupBox2.Controls.Add(this.radioSluz);
            this.groupBox2.Controls.Add(this.radioDippass);
            this.groupBox2.Controls.Add(this.radioPass);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 191);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип проездного документа ";
            // 
            // radioAnother
            // 
            this.radioAnother.AutoSize = true;
            this.radioAnother.Location = new System.Drawing.Point(18, 136);
            this.radioAnother.Name = "radioAnother";
            this.radioAnother.Size = new System.Drawing.Size(244, 17);
            this.radioAnother.TabIndex = 11;
            this.radioAnother.TabStop = true;
            this.radioAnother.Text = "Иной проездной документ (указать, какой)";
            this.radioAnother.UseVisualStyleBackColor = true;
            // 
            // radioOsobi
            // 
            this.radioOsobi.AutoSize = true;
            this.radioOsobi.Location = new System.Drawing.Point(18, 113);
            this.radioOsobi.Name = "radioOsobi";
            this.radioOsobi.Size = new System.Drawing.Size(109, 17);
            this.radioOsobi.TabIndex = 10;
            this.radioOsobi.TabStop = true;
            this.radioOsobi.Text = "Особый паспорт";
            this.radioOsobi.UseVisualStyleBackColor = true;
            // 
            // radioOficial
            // 
            this.radioOficial.AutoSize = true;
            this.radioOficial.Location = new System.Drawing.Point(18, 90);
            this.radioOficial.Name = "radioOficial";
            this.radioOficial.Size = new System.Drawing.Size(141, 17);
            this.radioOficial.TabIndex = 9;
            this.radioOficial.TabStop = true;
            this.radioOficial.Text = "Официальный паспорт";
            this.radioOficial.UseVisualStyleBackColor = true;
            // 
            // radioSluz
            // 
            this.radioSluz.AutoSize = true;
            this.radioSluz.Location = new System.Drawing.Point(18, 67);
            this.radioSluz.Name = "radioSluz";
            this.radioSluz.Size = new System.Drawing.Size(127, 17);
            this.radioSluz.TabIndex = 8;
            this.radioSluz.TabStop = true;
            this.radioSluz.Text = "Служебный паспорт";
            this.radioSluz.UseVisualStyleBackColor = true;
            // 
            // radioDippass
            // 
            this.radioDippass.AutoSize = true;
            this.radioDippass.Location = new System.Drawing.Point(18, 44);
            this.radioDippass.Name = "radioDippass";
            this.radioDippass.Size = new System.Drawing.Size(162, 17);
            this.radioDippass.TabIndex = 7;
            this.radioDippass.TabStop = true;
            this.radioDippass.Text = "Дипломатический паспорт";
            this.radioDippass.UseVisualStyleBackColor = true;
            // 
            // radioPass
            // 
            this.radioPass.AutoSize = true;
            this.radioPass.Location = new System.Drawing.Point(18, 19);
            this.radioPass.Name = "radioPass";
            this.radioPass.Size = new System.Drawing.Size(116, 17);
            this.radioPass.TabIndex = 6;
            this.radioPass.TabStop = true;
            this.radioPass.Text = "Обычный паспорт";
            this.radioPass.UseVisualStyleBackColor = true;
            // 
            // txtAnother
            // 
            this.txtAnother.Location = new System.Drawing.Point(18, 160);
            this.txtAnother.Name = "txtAnother";
            this.txtAnother.Size = new System.Drawing.Size(189, 20);
            this.txtAnother.TabIndex = 12;
            // 
            // txtPassNumber
            // 
            this.txtPassNumber.Location = new System.Drawing.Point(229, 44);
            this.txtPassNumber.Name = "txtPassNumber";
            this.txtPassNumber.Size = new System.Drawing.Size(229, 20);
            this.txtPassNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер проездного документа";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(229, 90);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(229, 20);
            this.dtFrom.TabIndex = 18;
            this.dtFrom.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Дата выдачи (год-месяц-день)";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(229, 135);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(229, 20);
            this.dtTo.TabIndex = 20;
            this.dtTo.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Действителен до (год-месяц-день)";
            // 
            // txtWhom
            // 
            this.txtWhom.Location = new System.Drawing.Point(229, 179);
            this.txtWhom.Name = "txtWhom";
            this.txtWhom.Size = new System.Drawing.Size(229, 20);
            this.txtWhom.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Кем выдан";
            // 
            // PassportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PassportData";
            this.Size = new System.Drawing.Size(470, 232);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAnother;
        private System.Windows.Forms.RadioButton radioAnother;
        private System.Windows.Forms.RadioButton radioOsobi;
        private System.Windows.Forms.RadioButton radioOficial;
        private System.Windows.Forms.RadioButton radioSluz;
        private System.Windows.Forms.RadioButton radioDippass;
        private System.Windows.Forms.RadioButton radioPass;
        private System.Windows.Forms.TextBox txtPassNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label4;
    }
}
