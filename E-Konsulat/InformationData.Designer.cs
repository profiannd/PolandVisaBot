namespace E_Konsulat
{
    partial class InformationData
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
            this.groupInformation = new System.Windows.Forms.GroupBox();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimeArrival = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumberDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWaiver = new System.Windows.Forms.ComboBox();
            this.comboBoxdestination = new System.Windows.Forms.ComboBox();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.radioButtonDouble = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiple = new System.Windows.Forms.RadioButton();
            this.groupInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInformation
            // 
            this.groupInformation.Controls.Add(this.radioButtonMultiple);
            this.groupInformation.Controls.Add(this.radioButtonDouble);
            this.groupInformation.Controls.Add(this.radioButtonSingle);
            this.groupInformation.Controls.Add(this.dateTimeCheckOut);
            this.groupInformation.Controls.Add(this.label10);
            this.groupInformation.Controls.Add(this.label11);
            this.groupInformation.Controls.Add(this.dateTimeArrival);
            this.groupInformation.Controls.Add(this.label9);
            this.groupInformation.Controls.Add(this.label8);
            this.groupInformation.Controls.Add(this.label7);
            this.groupInformation.Controls.Add(this.textBoxNumberDay);
            this.groupInformation.Controls.Add(this.label6);
            this.groupInformation.Controls.Add(this.label3);
            this.groupInformation.Controls.Add(this.label5);
            this.groupInformation.Controls.Add(this.label1);
            this.groupInformation.Controls.Add(this.label2);
            this.groupInformation.Controls.Add(this.label4);
            this.groupInformation.Controls.Add(this.comboBoxWaiver);
            this.groupInformation.Controls.Add(this.comboBoxdestination);
            this.groupInformation.Location = new System.Drawing.Point(0, 0);
            this.groupInformation.Name = "groupInformation";
            this.groupInformation.Size = new System.Drawing.Size(422, 347);
            this.groupInformation.TabIndex = 0;
            this.groupInformation.TabStop = false;
            this.groupInformation.Text = "Сведения, касающиеся поездки";
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.Location = new System.Drawing.Point(135, 282);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(122, 20);
            this.dateTimeCheckOut.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Польша (год-месяц-день)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Планируемая дата выезда из Республики ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateTimeArrival
            // 
            this.dateTimeArrival.Location = new System.Drawing.Point(135, 219);
            this.dateTimeArrival.Name = "dateTimeArrival";
            this.dateTimeArrival.Size = new System.Drawing.Size(122, 20);
            this.dateTimeArrival.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Польша (год-месяц-день)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Планируемая дата прибытия в Республику ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "дней (>90)";
            // 
            // textBoxNumberDay
            // 
            this.textBoxNumberDay.Location = new System.Drawing.Point(299, 141);
            this.textBoxNumberDay.Name = "textBoxNumberDay";
            this.textBoxNumberDay.Size = new System.Drawing.Size(23, 20);
            this.textBoxNumberDay.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Запрашивается виза на";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Виза запрашивается для ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Страна (ы) назначения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Продолжительность пребывания или транзита. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Указать количество дней ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Страна первого въезда";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxWaiver
            // 
            this.comboBoxWaiver.FormattingEnabled = true;
            this.comboBoxWaiver.Location = new System.Drawing.Point(232, 60);
            this.comboBoxWaiver.Name = "comboBoxWaiver";
            this.comboBoxWaiver.Size = new System.Drawing.Size(184, 21);
            this.comboBoxWaiver.TabIndex = 1;
            this.comboBoxWaiver.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBoxdestination
            // 
            this.comboBoxdestination.FormattingEnabled = true;
            this.comboBoxdestination.Location = new System.Drawing.Point(6, 60);
            this.comboBoxdestination.Name = "comboBoxdestination";
            this.comboBoxdestination.Size = new System.Drawing.Size(184, 21);
            this.comboBoxdestination.TabIndex = 1;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(6, 122);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(137, 17);
            this.radioButtonSingle.TabIndex = 16;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Однократного въезда";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            // 
            // radioButtonDouble
            // 
            this.radioButtonDouble.AutoSize = true;
            this.radioButtonDouble.Location = new System.Drawing.Point(6, 143);
            this.radioButtonDouble.Name = "radioButtonDouble";
            this.radioButtonDouble.Size = new System.Drawing.Size(131, 17);
            this.radioButtonDouble.TabIndex = 17;
            this.radioButtonDouble.TabStop = true;
            this.radioButtonDouble.Text = "Двукратного въезда";
            this.radioButtonDouble.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiple
            // 
            this.radioButtonMultiple.AutoSize = true;
            this.radioButtonMultiple.Location = new System.Drawing.Point(6, 166);
            this.radioButtonMultiple.Name = "radioButtonMultiple";
            this.radioButtonMultiple.Size = new System.Drawing.Size(143, 17);
            this.radioButtonMultiple.TabIndex = 18;
            this.radioButtonMultiple.TabStop = true;
            this.radioButtonMultiple.Text = "Многократного въезда";
            this.radioButtonMultiple.UseVisualStyleBackColor = true;
            // 
            // InformationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupInformation);
            this.Name = "InformationData";
            this.Size = new System.Drawing.Size(422, 347);
            this.Load += new System.EventHandler(this.InformationData_Load);
            this.groupInformation.ResumeLayout(false);
            this.groupInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInformation;
        private System.Windows.Forms.ComboBox comboBoxWaiver;
        private System.Windows.Forms.ComboBox comboBoxdestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumberDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeArrival;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButtonMultiple;
        private System.Windows.Forms.RadioButton radioButtonDouble;
        private System.Windows.Forms.RadioButton radioButtonSingle;
    }
}
