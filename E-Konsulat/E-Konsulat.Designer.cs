namespace E_Konsulat
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNotForMe = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countryData1 = new E_Konsulat.CountryData();
            this.childData1 = new E_Konsulat.ChildData();
            this.childData2 = new E_Konsulat.ChildData();
            this.addressData1 = new E_Konsulat.AddressData();
            this.passportData1 = new E_Konsulat.PassportData();
            this.personalData1 = new E_Konsulat.PersonalData();
            this.bossAddressData1 = new E_Konsulat.BossAddressData();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Controls.Add(this.bossAddressData1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.countryData1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.addressData1);
            this.panel1.Controls.Add(this.passportData1);
            this.panel1.Controls.Add(this.personalData1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 489);
            this.panel1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNotForMe);
            this.groupBox1.Controls.Add(this.childData1);
            this.groupBox1.Controls.Add(this.childData2);
            this.groupBox1.Location = new System.Drawing.Point(34, 495);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 765);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для несовершеннолетних: фамилия, имя, адрес (если отличается от адреса заявителя)" +
    " и гражданство лица с полномочием родителей / законного представителя";
            // 
            // chkNotForMe
            // 
            this.chkNotForMe.AutoSize = true;
            this.chkNotForMe.Location = new System.Drawing.Point(6, 31);
            this.chkNotForMe.Name = "chkNotForMe";
            this.chkNotForMe.Size = new System.Drawing.Size(88, 17);
            this.chkNotForMe.TabIndex = 4;
            this.chkNotForMe.Text = "не касается";
            this.chkNotForMe.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 869);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 851);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Профессиональная деятельность в настоящее время";
            // 
            // countryData1
            // 
            this.countryData1.Location = new System.Drawing.Point(516, 731);
            this.countryData1.Name = "countryData1";
            this.countryData1.Size = new System.Drawing.Size(470, 113);
            this.countryData1.TabIndex = 18;
            // 
            // childData1
            // 
            this.childData1.Location = new System.Drawing.Point(6, 44);
            this.childData1.Name = "childData1";
            this.childData1.Size = new System.Drawing.Size(470, 351);
            this.childData1.TabIndex = 2;
            // 
            // childData2
            // 
            this.childData2.Location = new System.Drawing.Point(6, 392);
            this.childData2.Name = "childData2";
            this.childData2.Size = new System.Drawing.Size(470, 351);
            this.childData2.TabIndex = 3;
            // 
            // addressData1
            // 
            this.addressData1.Location = new System.Drawing.Point(519, 374);
            this.addressData1.Name = "addressData1";
            this.addressData1.Size = new System.Drawing.Size(470, 351);
            this.addressData1.TabIndex = 15;
            // 
            // passportData1
            // 
            this.passportData1.Location = new System.Drawing.Point(510, 136);
            this.passportData1.Name = "passportData1";
            this.passportData1.Size = new System.Drawing.Size(479, 232);
            this.passportData1.TabIndex = 14;
            // 
            // personalData1
            // 
            this.personalData1.Location = new System.Drawing.Point(30, 136);
            this.personalData1.Name = "personalData1";
            this.personalData1.Size = new System.Drawing.Size(474, 353);
            this.personalData1.TabIndex = 13;
            // 
            // bossAddressData1
            // 
            this.bossAddressData1.Location = new System.Drawing.Point(533, 896);
            this.bossAddressData1.Name = "bossAddressData1";
            this.bossAddressData1.Size = new System.Drawing.Size(470, 351);
            this.bossAddressData1.TabIndex = 21;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(872, 1269);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(131, 23);
            this.btnAddTask.TabIndex = 22;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "E-Konsulat";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private CountryData countryData1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNotForMe;
        private ChildData childData1;
        private ChildData childData2;
        private AddressData addressData1;
        private PassportData passportData1;
        private PersonalData personalData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddTask;
        private BossAddressData bossAddressData1;
    }
}

