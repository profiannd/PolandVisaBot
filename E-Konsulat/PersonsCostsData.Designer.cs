namespace E_Konsulat
{
    partial class PersonsCostsData
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInsurance = new System.Windows.Forms.DateTimePicker();
            this.txtOtherCosts = new System.Windows.Forms.TextBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.chkOtherCosts = new System.Windows.Forms.CheckBox();
            this.chkAllCosts = new System.Windows.Forms.CheckBox();
            this.chkTransport = new System.Windows.Forms.CheckBox();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.chkCard = new System.Windows.Forms.CheckBox();
            this.chkChecks = new System.Windows.Forms.CheckBox();
            this.chkMoney = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkReferred = new System.Windows.Forms.CheckBox();
            this.radioSponsors = new System.Windows.Forms.RadioButton();
            this.radioHim = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные лица, несущего расходы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtInsurance);
            this.groupBox3.Controls.Add(this.txtOtherCosts);
            this.groupBox3.Controls.Add(this.chkInsurance);
            this.groupBox3.Controls.Add(this.chkOtherCosts);
            this.groupBox3.Controls.Add(this.chkAllCosts);
            this.groupBox3.Controls.Add(this.chkTransport);
            this.groupBox3.Controls.Add(this.chkLocation);
            this.groupBox3.Controls.Add(this.chkCard);
            this.groupBox3.Controls.Add(this.chkChecks);
            this.groupBox3.Controls.Add(this.chkMoney);
            this.groupBox3.Location = new System.Drawing.Point(0, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 246);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Средства на покрытие расходов на пребывание: ";
            // 
            // dtInsurance
            // 
            this.dtInsurance.Location = new System.Drawing.Point(8, 185);
            this.dtInsurance.Name = "dtInsurance";
            this.dtInsurance.Size = new System.Drawing.Size(143, 20);
            this.dtInsurance.TabIndex = 9;
            // 
            // txtOtherCosts
            // 
            this.txtOtherCosts.Location = new System.Drawing.Point(6, 136);
            this.txtOtherCosts.Name = "txtOtherCosts";
            this.txtOtherCosts.Size = new System.Drawing.Size(319, 20);
            this.txtOtherCosts.TabIndex = 8;
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(6, 162);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.Size = new System.Drawing.Size(473, 17);
            this.chkInsurance.TabIndex = 7;
            this.chkInsurance.Text = "Страхование поездки / медицинское страхование. Действительно до (год-месяц-день):" +
    "";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // chkOtherCosts
            // 
            this.chkOtherCosts.AutoSize = true;
            this.chkOtherCosts.Location = new System.Drawing.Point(6, 113);
            this.chkOtherCosts.Name = "chkOtherCosts";
            this.chkOtherCosts.Size = new System.Drawing.Size(103, 17);
            this.chkOtherCosts.TabIndex = 6;
            this.chkOtherCosts.Text = "Иные (указать)";
            this.chkOtherCosts.UseVisualStyleBackColor = true;
            // 
            // chkAllCosts
            // 
            this.chkAllCosts.AutoSize = true;
            this.chkAllCosts.Location = new System.Drawing.Point(8, 90);
            this.chkAllCosts.Name = "chkAllCosts";
            this.chkAllCosts.Size = new System.Drawing.Size(294, 17);
            this.chkAllCosts.TabIndex = 5;
            this.chkAllCosts.Text = "Обеспечиваются все расходы во время пребывания";
            this.chkAllCosts.UseVisualStyleBackColor = true;
            this.chkAllCosts.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chkTransport
            // 
            this.chkTransport.AutoSize = true;
            this.chkTransport.Location = new System.Drawing.Point(192, 43);
            this.chkTransport.Name = "chkTransport";
            this.chkTransport.Size = new System.Drawing.Size(148, 17);
            this.chkTransport.TabIndex = 4;
            this.chkTransport.Text = "Предоплачен транспорт";
            this.chkTransport.UseVisualStyleBackColor = true;
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Location = new System.Drawing.Point(192, 20);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(92, 17);
            this.chkLocation.TabIndex = 3;
            this.chkLocation.Text = "Размещение";
            this.chkLocation.UseVisualStyleBackColor = true;
            // 
            // chkCard
            // 
            this.chkCard.AutoSize = true;
            this.chkCard.Location = new System.Drawing.Point(6, 66);
            this.chkCard.Name = "chkCard";
            this.chkCard.Size = new System.Drawing.Size(129, 17);
            this.chkCard.TabIndex = 2;
            this.chkCard.Text = "Кредитная карточка";
            this.chkCard.UseVisualStyleBackColor = true;
            this.chkCard.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkChecks
            // 
            this.chkChecks.AutoSize = true;
            this.chkChecks.Location = new System.Drawing.Point(6, 43);
            this.chkChecks.Name = "chkChecks";
            this.chkChecks.Size = new System.Drawing.Size(107, 17);
            this.chkChecks.TabIndex = 1;
            this.chkChecks.Text = "Дорожные чеки";
            this.chkChecks.UseVisualStyleBackColor = true;
            this.chkChecks.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkMoney
            // 
            this.chkMoney.AutoSize = true;
            this.chkMoney.Location = new System.Drawing.Point(6, 20);
            this.chkMoney.Name = "chkMoney";
            this.chkMoney.Size = new System.Drawing.Size(115, 17);
            this.chkMoney.TabIndex = 0;
            this.chkMoney.Text = "Наличные деньги";
            this.chkMoney.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOther);
            this.groupBox2.Controls.Add(this.chkOther);
            this.groupBox2.Controls.Add(this.chkReferred);
            this.groupBox2.Controls.Add(this.radioSponsors);
            this.groupBox2.Controls.Add(this.radioHim);
            this.groupBox2.Location = new System.Drawing.Point(0, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расходы заявителя на проезд и во время пребывания оплачивает";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(8, 115);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(316, 20);
            this.txtOther.TabIndex = 4;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(7, 92);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(103, 17);
            this.chkOther.TabIndex = 3;
            this.chkOther.Text = "Иные (указать)";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkReferred
            // 
            this.chkReferred.AutoSize = true;
            this.chkReferred.Location = new System.Drawing.Point(7, 68);
            this.chkReferred.Name = "chkReferred";
            this.chkReferred.Size = new System.Drawing.Size(120, 17);
            this.chkReferred.TabIndex = 2;
            this.chkReferred.Text = "упомянутые ранее";
            this.chkReferred.UseVisualStyleBackColor = true;
            // 
            // radioSponsors
            // 
            this.radioSponsors.AutoSize = true;
            this.radioSponsors.Location = new System.Drawing.Point(7, 44);
            this.radioSponsors.Name = "radioSponsors";
            this.radioSponsors.Size = new System.Drawing.Size(370, 17);
            this.radioSponsors.TabIndex = 1;
            this.radioSponsors.TabStop = true;
            this.radioSponsors.Text = "Спонсор (приглашающее лицо, предприятие, организация), указать";
            this.radioSponsors.UseVisualStyleBackColor = true;
            // 
            // radioHim
            // 
            this.radioHim.AutoSize = true;
            this.radioHim.Location = new System.Drawing.Point(7, 20);
            this.radioHim.Name = "radioHim";
            this.radioHim.Size = new System.Drawing.Size(102, 17);
            this.radioHim.TabIndex = 0;
            this.radioHim.TabStop = true;
            this.radioHim.Text = "Сам заявитель";
            this.radioHim.UseVisualStyleBackColor = true;
            // 
            // PersonsCostsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonsCostsData";
            this.Size = new System.Drawing.Size(470, 406);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkInsurance;
        private System.Windows.Forms.CheckBox chkOtherCosts;
        private System.Windows.Forms.CheckBox chkAllCosts;
        private System.Windows.Forms.CheckBox chkTransport;
        private System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.CheckBox chkCard;
        private System.Windows.Forms.CheckBox chkChecks;
        private System.Windows.Forms.CheckBox chkMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkReferred;
        private System.Windows.Forms.RadioButton radioSponsors;
        private System.Windows.Forms.RadioButton radioHim;
        private System.Windows.Forms.DateTimePicker dtInsurance;
        private System.Windows.Forms.TextBox txtOtherCosts;
    }
}
