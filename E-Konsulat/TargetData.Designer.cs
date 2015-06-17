namespace E_Konsulat
{
    partial class TargetData
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
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkOfficial = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.chkLearning = new System.Windows.Forms.CheckBox();
            this.chkTreatment = new System.Windows.Forms.CheckBox();
            this.chkSport = new System.Windows.Forms.CheckBox();
            this.chkCulture = new System.Windows.Forms.CheckBox();
            this.chkFamily = new System.Windows.Forms.CheckBox();
            this.chkDeal = new System.Windows.Forms.CheckBox();
            this.chkTourism = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOther);
            this.groupBox1.Controls.Add(this.chkOfficial);
            this.groupBox1.Controls.Add(this.chkOther);
            this.groupBox1.Controls.Add(this.chkLearning);
            this.groupBox1.Controls.Add(this.chkTreatment);
            this.groupBox1.Controls.Add(this.chkSport);
            this.groupBox1.Controls.Add(this.chkCulture);
            this.groupBox1.Controls.Add(this.chkFamily);
            this.groupBox1.Controls.Add(this.chkDeal);
            this.groupBox1.Controls.Add(this.chkTourism);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Главная цель поездки";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(6, 97);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(464, 20);
            this.txtOther.TabIndex = 9;
            // 
            // chkOfficial
            // 
            this.chkOfficial.AutoSize = true;
            this.chkOfficial.Location = new System.Drawing.Point(236, 74);
            this.chkOfficial.Name = "chkOfficial";
            this.chkOfficial.Size = new System.Drawing.Size(96, 17);
            this.chkOfficial.TabIndex = 8;
            this.chkOfficial.Text = "Официальная";
            this.chkOfficial.UseVisualStyleBackColor = true;
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(375, 74);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(101, 17);
            this.chkOther.TabIndex = 7;
            this.chkOther.Text = "Иная (указать)";
            this.chkOther.UseVisualStyleBackColor = true;
            // 
            // chkLearning
            // 
            this.chkLearning.AutoSize = true;
            this.chkLearning.Location = new System.Drawing.Point(375, 51);
            this.chkLearning.Name = "chkLearning";
            this.chkLearning.Size = new System.Drawing.Size(57, 17);
            this.chkLearning.TabIndex = 6;
            this.chkLearning.Text = "Учеба";
            this.chkLearning.UseVisualStyleBackColor = true;
            // 
            // chkTreatment
            // 
            this.chkTreatment.AutoSize = true;
            this.chkTreatment.Location = new System.Drawing.Point(375, 28);
            this.chkTreatment.Name = "chkTreatment";
            this.chkTreatment.Size = new System.Drawing.Size(69, 17);
            this.chkTreatment.TabIndex = 5;
            this.chkTreatment.Text = "Лечение";
            this.chkTreatment.UseVisualStyleBackColor = true;
            // 
            // chkSport
            // 
            this.chkSport.AutoSize = true;
            this.chkSport.Location = new System.Drawing.Point(236, 51);
            this.chkSport.Name = "chkSport";
            this.chkSport.Size = new System.Drawing.Size(56, 17);
            this.chkSport.TabIndex = 4;
            this.chkSport.Text = "Спорт";
            this.chkSport.UseVisualStyleBackColor = true;
            // 
            // chkCulture
            // 
            this.chkCulture.AutoSize = true;
            this.chkCulture.Location = new System.Drawing.Point(236, 28);
            this.chkCulture.Name = "chkCulture";
            this.chkCulture.Size = new System.Drawing.Size(72, 17);
            this.chkCulture.TabIndex = 3;
            this.chkCulture.Text = "Культура";
            this.chkCulture.UseVisualStyleBackColor = true;
            this.chkCulture.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkFamily
            // 
            this.chkFamily.AutoSize = true;
            this.chkFamily.Location = new System.Drawing.Point(6, 74);
            this.chkFamily.Name = "chkFamily";
            this.chkFamily.Size = new System.Drawing.Size(224, 17);
            this.chkFamily.TabIndex = 2;
            this.chkFamily.Text = "Посещение родственников или друзей";
            this.chkFamily.UseVisualStyleBackColor = true;
            this.chkFamily.CheckedChanged += new System.EventHandler(this.checkBoxFamily_CheckedChanged);
            // 
            // chkDeal
            // 
            this.chkDeal.AutoSize = true;
            this.chkDeal.Location = new System.Drawing.Point(6, 51);
            this.chkDeal.Name = "chkDeal";
            this.chkDeal.Size = new System.Drawing.Size(71, 17);
            this.chkDeal.TabIndex = 1;
            this.chkDeal.Text = "Деловая";
            this.chkDeal.UseVisualStyleBackColor = true;
            // 
            // chkTourism
            // 
            this.chkTourism.AutoSize = true;
            this.chkTourism.Location = new System.Drawing.Point(6, 28);
            this.chkTourism.Name = "chkTourism";
            this.chkTourism.Size = new System.Drawing.Size(64, 17);
            this.chkTourism.TabIndex = 0;
            this.chkTourism.Text = "Туризм";
            this.chkTourism.UseVisualStyleBackColor = true;
            // 
            // TargetData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TargetData";
            this.Size = new System.Drawing.Size(482, 134);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkOfficial;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.CheckBox chkLearning;
        private System.Windows.Forms.CheckBox chkTreatment;
        private System.Windows.Forms.CheckBox chkSport;
        private System.Windows.Forms.CheckBox chkCulture;
        private System.Windows.Forms.CheckBox chkFamily;
        private System.Windows.Forms.CheckBox chkDeal;
        private System.Windows.Forms.CheckBox chkTourism;
    }
}
