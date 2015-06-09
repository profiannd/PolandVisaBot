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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNotForMe = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bossAddressData1 = new E_Konsulat.BossAddressData();
            this.countryData1 = new E_Konsulat.CountryData();
            this.childData1 = new E_Konsulat.ChildData();
            this.childData2 = new E_Konsulat.ChildData();
            this.addressData1 = new E_Konsulat.AddressData();
            this.passportData1 = new E_Konsulat.PassportData();
            this.personalData1 = new E_Konsulat.PersonalData();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtGreenLine = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtRedLine = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chbProxy = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radioinfo = new System.Windows.Forms.RadioButton();
            this.radiocom = new System.Windows.Forms.RadioButton();
            this.restoreButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.chbAutoResolveImage = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 851);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Профессиональная деятельность в настоящее время";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 869);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 21);
            this.comboBox1.TabIndex = 19;
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
            // bossAddressData1
            // 
            this.bossAddressData1.Location = new System.Drawing.Point(533, 896);
            this.bossAddressData1.Name = "bossAddressData1";
            this.bossAddressData1.Size = new System.Drawing.Size(470, 351);
            this.bossAddressData1.TabIndex = 21;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.dtGreenLine);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.cbxPriority);
            this.groupBox6.Controls.Add(this.btnAddTask);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.dtRedLine);
            this.groupBox6.Location = new System.Drawing.Point(533, 1644);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(470, 159);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(192, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Начальная дата подачи документов ";
            // 
            // dtGreenLine
            // 
            this.dtGreenLine.CustomFormat = "dd/MM/yyyy";
            this.dtGreenLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGreenLine.Location = new System.Drawing.Point(224, 85);
            this.dtGreenLine.Name = "dtGreenLine";
            this.dtGreenLine.Size = new System.Drawing.Size(222, 20);
            this.dtGreenLine.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(180, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Крайняя дата подачи документов ";
            // 
            // cbxPriority
            // 
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(224, 53);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(222, 21);
            this.cbxPriority.TabIndex = 18;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddTask.Location = new System.Drawing.Point(117, 114);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(244, 40);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Добавить задание";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Приоритет заявки";
            // 
            // dtRedLine
            // 
            this.dtRedLine.CustomFormat = "dd/MM/yyyy";
            this.dtRedLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRedLine.Location = new System.Drawing.Point(224, 17);
            this.dtRedLine.Name = "dtRedLine";
            this.dtRedLine.Size = new System.Drawing.Size(222, 20);
            this.dtRedLine.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.chbProxy);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.radioinfo);
            this.groupBox7.Controls.Add(this.radiocom);
            this.groupBox7.Controls.Add(this.restoreButton);
            this.groupBox7.Controls.Add(this.exportButton);
            this.groupBox7.Controls.Add(this.chbAutoResolveImage);
            this.groupBox7.Location = new System.Drawing.Point(40, 1644);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(469, 159);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Настройки приложения";
            // 
            // chbProxy
            // 
            this.chbProxy.AutoSize = true;
            this.chbProxy.Location = new System.Drawing.Point(10, 132);
            this.chbProxy.Name = "chbProxy";
            this.chbProxy.Size = new System.Drawing.Size(138, 17);
            this.chbProxy.TabIndex = 4;
            this.chbProxy.Text = "Использовать прокси";
            this.chbProxy.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Сервер для распознования";
            // 
            // radioinfo
            // 
            this.radioinfo.AutoSize = true;
            this.radioinfo.Location = new System.Drawing.Point(14, 105);
            this.radioinfo.Name = "radioinfo";
            this.radioinfo.Size = new System.Drawing.Size(119, 17);
            this.radioinfo.TabIndex = 2;
            this.radioinfo.TabStop = true;
            this.radioinfo.Text = "api.de-captcher.info";
            this.radioinfo.UseVisualStyleBackColor = true;
            // 
            // radiocom
            // 
            this.radiocom.AutoSize = true;
            this.radiocom.Location = new System.Drawing.Point(14, 77);
            this.radiocom.Name = "radiocom";
            this.radiocom.Size = new System.Drawing.Size(122, 17);
            this.radiocom.TabIndex = 1;
            this.radiocom.TabStop = true;
            this.radiocom.Text = "api.de-captcher.com";
            this.radiocom.UseVisualStyleBackColor = true;
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.YellowGreen;
            this.restoreButton.Location = new System.Drawing.Point(320, 20);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(120, 75);
            this.restoreButton.TabIndex = 5;
            this.restoreButton.Text = "Восстановить удаленную задачу";
            this.restoreButton.UseVisualStyleBackColor = false;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.YellowGreen;
            this.exportButton.Location = new System.Drawing.Point(320, 120);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(120, 30);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Экспорт в Excel";
            this.exportButton.UseVisualStyleBackColor = false;
            // 
            // chbAutoResolveImage
            // 
            this.chbAutoResolveImage.AutoSize = true;
            this.chbAutoResolveImage.Location = new System.Drawing.Point(10, 22);
            this.chbAutoResolveImage.Name = "chbAutoResolveImage";
            this.chbAutoResolveImage.Size = new System.Drawing.Size(228, 17);
            this.chbAutoResolveImage.TabIndex = 0;
            this.chbAutoResolveImage.Text = "Распознавать картинки автоматически";
            this.chbAutoResolveImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "E-Konsulat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
        private BossAddressData bossAddressData1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtGreenLine;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtRedLine;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chbProxy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioinfo;
        private System.Windows.Forms.RadioButton radiocom;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.CheckBox chbAutoResolveImage;
    }
}

