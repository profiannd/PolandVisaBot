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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHim = new System.Windows.Forms.RadioButton();
            this.radioButtonSponsors = new System.Windows.Forms.RadioButton();
            this.checkBoxReferred = new System.Windows.Forms.CheckBox();
            this.checkBoxOther = new System.Windows.Forms.CheckBox();
            this.textBoxOther = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxMoney = new System.Windows.Forms.CheckBox();
            this.checkBoxChecks = new System.Windows.Forms.CheckBox();
            this.checkBoxCard = new System.Windows.Forms.CheckBox();
            this.checkBoxLocation = new System.Windows.Forms.CheckBox();
            this.checkBoxTransport = new System.Windows.Forms.CheckBox();
            this.checkBoxAllCosts = new System.Windows.Forms.CheckBox();
            this.checkBoxOtherCosts = new System.Windows.Forms.CheckBox();
            this.chcBoxInsurance = new System.Windows.Forms.CheckBox();
            this.textBoxOtherCosts = new System.Windows.Forms.TextBox();
            this.dateTimePickerInsurance = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOther);
            this.groupBox2.Controls.Add(this.checkBoxOther);
            this.groupBox2.Controls.Add(this.checkBoxReferred);
            this.groupBox2.Controls.Add(this.radioButtonSponsors);
            this.groupBox2.Controls.Add(this.radioButtonHim);
            this.groupBox2.Location = new System.Drawing.Point(0, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расходы заявителя на проезд и во время пребывания оплачивает";
            // 
            // radioButtonHim
            // 
            this.radioButtonHim.AutoSize = true;
            this.radioButtonHim.Location = new System.Drawing.Point(7, 20);
            this.radioButtonHim.Name = "radioButtonHim";
            this.radioButtonHim.Size = new System.Drawing.Size(102, 17);
            this.radioButtonHim.TabIndex = 0;
            this.radioButtonHim.TabStop = true;
            this.radioButtonHim.Text = "Сам заявитель";
            this.radioButtonHim.UseVisualStyleBackColor = true;
            // 
            // radioButtonSponsors
            // 
            this.radioButtonSponsors.AutoSize = true;
            this.radioButtonSponsors.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSponsors.Name = "radioButtonSponsors";
            this.radioButtonSponsors.Size = new System.Drawing.Size(370, 17);
            this.radioButtonSponsors.TabIndex = 1;
            this.radioButtonSponsors.TabStop = true;
            this.radioButtonSponsors.Text = "Спонсор (приглашающее лицо, предприятие, организация), указать";
            this.radioButtonSponsors.UseVisualStyleBackColor = true;
            // 
            // checkBoxReferred
            // 
            this.checkBoxReferred.AutoSize = true;
            this.checkBoxReferred.Location = new System.Drawing.Point(7, 68);
            this.checkBoxReferred.Name = "checkBoxReferred";
            this.checkBoxReferred.Size = new System.Drawing.Size(247, 17);
            this.checkBoxReferred.TabIndex = 2;
            this.checkBoxReferred.Text = "упомянутые в Данных принимающего лица";
            this.checkBoxReferred.UseVisualStyleBackColor = true;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.AutoSize = true;
            this.checkBoxOther.Location = new System.Drawing.Point(7, 92);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(103, 17);
            this.checkBoxOther.TabIndex = 3;
            this.checkBoxOther.Text = "Иные (указать)";
            this.checkBoxOther.UseVisualStyleBackColor = true;
            // 
            // textBoxOther
            // 
            this.textBoxOther.Location = new System.Drawing.Point(8, 115);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(316, 20);
            this.textBoxOther.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerInsurance);
            this.groupBox3.Controls.Add(this.textBoxOtherCosts);
            this.groupBox3.Controls.Add(this.chcBoxInsurance);
            this.groupBox3.Controls.Add(this.checkBoxOtherCosts);
            this.groupBox3.Controls.Add(this.checkBoxAllCosts);
            this.groupBox3.Controls.Add(this.checkBoxTransport);
            this.groupBox3.Controls.Add(this.checkBoxLocation);
            this.groupBox3.Controls.Add(this.checkBoxCard);
            this.groupBox3.Controls.Add(this.checkBoxChecks);
            this.groupBox3.Controls.Add(this.checkBoxMoney);
            this.groupBox3.Location = new System.Drawing.Point(0, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 246);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Средства на покрытие расходов на пребывание: ";
            // 
            // checkBoxMoney
            // 
            this.checkBoxMoney.AutoSize = true;
            this.checkBoxMoney.Location = new System.Drawing.Point(6, 20);
            this.checkBoxMoney.Name = "checkBoxMoney";
            this.checkBoxMoney.Size = new System.Drawing.Size(115, 17);
            this.checkBoxMoney.TabIndex = 0;
            this.checkBoxMoney.Text = "Наличные деньги";
            this.checkBoxMoney.UseVisualStyleBackColor = true;
            // 
            // checkBoxChecks
            // 
            this.checkBoxChecks.AutoSize = true;
            this.checkBoxChecks.Location = new System.Drawing.Point(6, 43);
            this.checkBoxChecks.Name = "checkBoxChecks";
            this.checkBoxChecks.Size = new System.Drawing.Size(107, 17);
            this.checkBoxChecks.TabIndex = 1;
            this.checkBoxChecks.Text = "Дорожные чеки";
            this.checkBoxChecks.UseVisualStyleBackColor = true;
            this.checkBoxChecks.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxCard
            // 
            this.checkBoxCard.AutoSize = true;
            this.checkBoxCard.Location = new System.Drawing.Point(6, 66);
            this.checkBoxCard.Name = "checkBoxCard";
            this.checkBoxCard.Size = new System.Drawing.Size(129, 17);
            this.checkBoxCard.TabIndex = 2;
            this.checkBoxCard.Text = "Кредитная карточка";
            this.checkBoxCard.UseVisualStyleBackColor = true;
            this.checkBoxCard.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBoxLocation
            // 
            this.checkBoxLocation.AutoSize = true;
            this.checkBoxLocation.Location = new System.Drawing.Point(192, 20);
            this.checkBoxLocation.Name = "checkBoxLocation";
            this.checkBoxLocation.Size = new System.Drawing.Size(92, 17);
            this.checkBoxLocation.TabIndex = 3;
            this.checkBoxLocation.Text = "Размещение";
            this.checkBoxLocation.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransport
            // 
            this.checkBoxTransport.AutoSize = true;
            this.checkBoxTransport.Location = new System.Drawing.Point(192, 43);
            this.checkBoxTransport.Name = "checkBoxTransport";
            this.checkBoxTransport.Size = new System.Drawing.Size(148, 17);
            this.checkBoxTransport.TabIndex = 4;
            this.checkBoxTransport.Text = "Предоплачен транспорт";
            this.checkBoxTransport.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllCosts
            // 
            this.checkBoxAllCosts.AutoSize = true;
            this.checkBoxAllCosts.Location = new System.Drawing.Point(6, 89);
            this.checkBoxAllCosts.Name = "checkBoxAllCosts";
            this.checkBoxAllCosts.Size = new System.Drawing.Size(294, 17);
            this.checkBoxAllCosts.TabIndex = 5;
            this.checkBoxAllCosts.Text = "Обеспечиваются все расходы во время пребывания";
            this.checkBoxAllCosts.UseVisualStyleBackColor = true;
            this.checkBoxAllCosts.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBoxOtherCosts
            // 
            this.checkBoxOtherCosts.AutoSize = true;
            this.checkBoxOtherCosts.Location = new System.Drawing.Point(6, 113);
            this.checkBoxOtherCosts.Name = "checkBoxOtherCosts";
            this.checkBoxOtherCosts.Size = new System.Drawing.Size(103, 17);
            this.checkBoxOtherCosts.TabIndex = 6;
            this.checkBoxOtherCosts.Text = "Иные (указать)";
            this.checkBoxOtherCosts.UseVisualStyleBackColor = true;
            // 
            // chcBoxInsurance
            // 
            this.chcBoxInsurance.AutoSize = true;
            this.chcBoxInsurance.Location = new System.Drawing.Point(6, 162);
            this.chcBoxInsurance.Name = "chcBoxInsurance";
            this.chcBoxInsurance.Size = new System.Drawing.Size(473, 17);
            this.chcBoxInsurance.TabIndex = 7;
            this.chcBoxInsurance.Text = "Страхование поездки / медицинское страхование. Действительно до (год-месяц-день):" +
    "";
            this.chcBoxInsurance.UseVisualStyleBackColor = true;
            // 
            // textBoxOtherCosts
            // 
            this.textBoxOtherCosts.Location = new System.Drawing.Point(6, 136);
            this.textBoxOtherCosts.Name = "textBoxOtherCosts";
            this.textBoxOtherCosts.Size = new System.Drawing.Size(319, 20);
            this.textBoxOtherCosts.TabIndex = 8;
            // 
            // dateTimePickerInsurance
            // 
            this.dateTimePickerInsurance.Location = new System.Drawing.Point(8, 185);
            this.dateTimePickerInsurance.Name = "dateTimePickerInsurance";
            this.dateTimePickerInsurance.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerInsurance.TabIndex = 9;
            // 
            // PersonsCostsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonsCostsData";
            this.Size = new System.Drawing.Size(470, 406);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chcBoxInsurance;
        private System.Windows.Forms.CheckBox checkBoxOtherCosts;
        private System.Windows.Forms.CheckBox checkBoxAllCosts;
        private System.Windows.Forms.CheckBox checkBoxTransport;
        private System.Windows.Forms.CheckBox checkBoxLocation;
        private System.Windows.Forms.CheckBox checkBoxCard;
        private System.Windows.Forms.CheckBox checkBoxChecks;
        private System.Windows.Forms.CheckBox checkBoxMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOther;
        private System.Windows.Forms.CheckBox checkBoxOther;
        private System.Windows.Forms.CheckBox checkBoxReferred;
        private System.Windows.Forms.RadioButton radioButtonSponsors;
        private System.Windows.Forms.RadioButton radioButtonHim;
        private System.Windows.Forms.DateTimePicker dateTimePickerInsurance;
        private System.Windows.Forms.TextBox textBoxOtherCosts;
    }
}
