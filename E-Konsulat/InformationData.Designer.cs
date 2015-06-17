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
            this.gBInformation = new System.Windows.Forms.GroupBox();
            this.radioMultiple = new System.Windows.Forms.RadioButton();
            this.radioDouble = new System.Windows.Forms.RadioButton();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumbDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWaiver = new System.Windows.Forms.ComboBox();
            this.txtDestination = new System.Windows.Forms.ComboBox();
            this.gBInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBInformation
            // 
            this.gBInformation.Controls.Add(this.radioMultiple);
            this.gBInformation.Controls.Add(this.radioDouble);
            this.gBInformation.Controls.Add(this.radioSingle);
            this.gBInformation.Controls.Add(this.dtCheckOut);
            this.gBInformation.Controls.Add(this.label10);
            this.gBInformation.Controls.Add(this.label11);
            this.gBInformation.Controls.Add(this.dtArrival);
            this.gBInformation.Controls.Add(this.label9);
            this.gBInformation.Controls.Add(this.label8);
            this.gBInformation.Controls.Add(this.label7);
            this.gBInformation.Controls.Add(this.txtNumbDay);
            this.gBInformation.Controls.Add(this.label6);
            this.gBInformation.Controls.Add(this.label3);
            this.gBInformation.Controls.Add(this.label5);
            this.gBInformation.Controls.Add(this.label1);
            this.gBInformation.Controls.Add(this.label2);
            this.gBInformation.Controls.Add(this.label4);
            this.gBInformation.Controls.Add(this.txtWaiver);
            this.gBInformation.Controls.Add(this.txtDestination);
            this.gBInformation.Location = new System.Drawing.Point(0, 0);
            this.gBInformation.Name = "gBInformation";
            this.gBInformation.Size = new System.Drawing.Size(422, 347);
            this.gBInformation.TabIndex = 0;
            this.gBInformation.TabStop = false;
            this.gBInformation.Text = "Сведения, касающиеся поездки";
            // 
            // radioMultiple
            // 
            this.radioMultiple.AutoSize = true;
            this.radioMultiple.Location = new System.Drawing.Point(6, 166);
            this.radioMultiple.Name = "radioMultiple";
            this.radioMultiple.Size = new System.Drawing.Size(143, 17);
            this.radioMultiple.TabIndex = 18;
            this.radioMultiple.TabStop = true;
            this.radioMultiple.Text = "Многократного въезда";
            this.radioMultiple.UseVisualStyleBackColor = true;
            // 
            // radioDouble
            // 
            this.radioDouble.AutoSize = true;
            this.radioDouble.Location = new System.Drawing.Point(6, 143);
            this.radioDouble.Name = "radioDouble";
            this.radioDouble.Size = new System.Drawing.Size(131, 17);
            this.radioDouble.TabIndex = 17;
            this.radioDouble.TabStop = true;
            this.radioDouble.Text = "Двукратного въезда";
            this.radioDouble.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(6, 122);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(137, 17);
            this.radioSingle.TabIndex = 16;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Однократного въезда";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Location = new System.Drawing.Point(135, 282);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(122, 20);
            this.dtCheckOut.TabIndex = 15;
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
            // 
            // dtArrival
            // 
            this.dtArrival.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtArrival.Location = new System.Drawing.Point(135, 219);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(122, 20);
            this.dtArrival.TabIndex = 12;
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
            // txtNumbDay
            // 
            this.txtNumbDay.Location = new System.Drawing.Point(299, 141);
            this.txtNumbDay.Name = "txtNumbDay";
            this.txtNumbDay.Size = new System.Drawing.Size(23, 20);
            this.txtNumbDay.TabIndex = 8;
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
            // 
            // txtWaiver
            // 
            this.txtWaiver.FormattingEnabled = true;
            this.txtWaiver.Location = new System.Drawing.Point(232, 60);
            this.txtWaiver.Name = "txtWaiver";
            this.txtWaiver.Size = new System.Drawing.Size(184, 21);
            this.txtWaiver.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.FormattingEnabled = true;
            this.txtDestination.Location = new System.Drawing.Point(6, 60);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(184, 21);
            this.txtDestination.TabIndex = 1;
            // 
            // InformationData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBInformation);
            this.Name = "InformationData";
            this.Size = new System.Drawing.Size(422, 347);
            this.gBInformation.ResumeLayout(false);
            this.gBInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBInformation;
        private System.Windows.Forms.ComboBox txtWaiver;
        private System.Windows.Forms.ComboBox txtDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumbDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioMultiple;
        private System.Windows.Forms.RadioButton radioDouble;
        private System.Windows.Forms.RadioButton radioSingle;
    }
}
