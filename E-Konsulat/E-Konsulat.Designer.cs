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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chbProxy = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radioinfo = new System.Windows.Forms.RadioButton();
            this.radiocom = new System.Windows.Forms.RadioButton();
            this.restoreButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.chbAutoResolveImage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtGreenLine = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.btnaddTask = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtRedLine = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNotForMe = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.theseEUCitizenData1 = new E_Konsulat.TheseEUCitizenData();
            this.infreceivingData1 = new E_Konsulat.InfreceivingData();
            this.informationData1 = new E_Konsulat.InformationData();
            this.bossAddressData1 = new E_Konsulat.BossAddressData();
            this.countryData1 = new E_Konsulat.CountryData();
            this.addressData1 = new E_Konsulat.AddressData();
            this.passportData1 = new E_Konsulat.PassportData();
            this.personsCostsData1 = new E_Konsulat.PersonsCostsData();
            this.fingerprintsData1 = new E_Konsulat.FingerprintsData();
            this.schengen_visasData1 = new E_Konsulat.Schengen_visasData();
            this.targetData1 = new E_Konsulat.TargetData();
            this.childData1 = new E_Konsulat.ChildData();
            this.childData2 = new E_Konsulat.ChildData();
            this.personalData1 = new E_Konsulat.PersonalData();
            this.okCancelControl1 = new E_Konsulat.OkCancelControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.okCancelControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить задание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.theseEUCitizenData1);
            this.panel1.Controls.Add(this.infreceivingData1);
            this.panel1.Controls.Add(this.informationData1);
            this.panel1.Controls.Add(this.bossAddressData1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.countryData1);
            this.panel1.Controls.Add(this.addressData1);
            this.panel1.Controls.Add(this.passportData1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 439);
            this.panel1.TabIndex = 113;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
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
            this.groupBox7.Location = new System.Drawing.Point(521, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(490, 159);
            this.groupBox7.TabIndex = 52;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 1471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Профессиональная деятельность в настоящее время";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(521, 1487);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(453, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.personsCostsData1);
            this.flowLayoutPanel1.Controls.Add(this.fingerprintsData1);
            this.flowLayoutPanel1.Controls.Add(this.schengen_visasData1);
            this.flowLayoutPanel1.Controls.Add(this.targetData1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.personalData1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 2237);
            this.flowLayoutPanel1.TabIndex = 34;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.dtGreenLine);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.cbxPriority);
            this.groupBox6.Controls.Add(this.btnaddTask);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.dtRedLine);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(474, 279);
            this.groupBox6.TabIndex = 40;
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
            this.dtGreenLine.Location = new System.Drawing.Point(214, 84);
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
            this.cbxPriority.Location = new System.Drawing.Point(214, 52);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(222, 21);
            this.cbxPriority.TabIndex = 18;
            // 
            // btnaddTask
            // 
            this.btnaddTask.BackColor = System.Drawing.Color.YellowGreen;
            this.btnaddTask.Location = new System.Drawing.Point(94, 225);
            this.btnaddTask.Name = "btnaddTask";
            this.btnaddTask.Size = new System.Drawing.Size(244, 40);
            this.btnaddTask.TabIndex = 2;
            this.btnaddTask.Text = "Добавить задание";
            this.btnaddTask.UseVisualStyleBackColor = false;
            this.btnaddTask.Click += new System.EventHandler(this.btnAddTask_Click);
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
            this.dtRedLine.Location = new System.Drawing.Point(214, 16);
            this.dtRedLine.Name = "dtRedLine";
            this.dtRedLine.Size = new System.Drawing.Size(222, 20);
            this.dtRedLine.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNotForMe);
            this.groupBox1.Controls.Add(this.childData1);
            this.groupBox1.Controls.Add(this.childData2);
            this.groupBox1.Location = new System.Drawing.Point(3, 1094);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 770);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Для несовершеннолетних: фамилия, имя, адрес (если отличается от адреса заявителя)" +
    " и гражданство лица с полномочием родителей / законного представителя";
            // 
            // chkNotForMe
            // 
            this.chkNotForMe.AutoSize = true;
            this.chkNotForMe.Location = new System.Drawing.Point(6, 30);
            this.chkNotForMe.Name = "chkNotForMe";
            this.chkNotForMe.Size = new System.Drawing.Size(88, 17);
            this.chkNotForMe.TabIndex = 4;
            this.chkNotForMe.Text = "не касается";
            this.chkNotForMe.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1041, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список заданий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // theseEUCitizenData1
            // 
            this.theseEUCitizenData1.DobEuCitizen = new System.DateTime(2015, 6, 17, 7, 14, 29, 330);
            this.theseEUCitizenData1.KinRadioEuCitizen = "";
            this.theseEUCitizenData1.LastNameEuCitizen = "";
            this.theseEUCitizenData1.Location = new System.Drawing.Point(521, 167);
            this.theseEUCitizenData1.Name = "theseEUCitizenData1";
            this.theseEUCitizenData1.NameEuCitizen = "";
            this.theseEUCitizenData1.PassNumberEuCitizen = "";
            this.theseEUCitizenData1.Size = new System.Drawing.Size(421, 230);
            this.theseEUCitizenData1.TabIndex = 51;
            // 
            // infreceivingData1
            // 
            this.infreceivingData1.AddressInferec = "";
            this.infreceivingData1.ApNumberInferec = "";
            this.infreceivingData1.CityInferec = "";
            this.infreceivingData1.EmailInferec = "";
            this.infreceivingData1.FaxInferec = "";
            this.infreceivingData1.FaxPrefixInferec = "";
            this.infreceivingData1.FirmManRadioInferec = false;
            this.infreceivingData1.HouseNumberInferec = "";
            this.infreceivingData1.LastNameInferec = "";
            this.infreceivingData1.Location = new System.Drawing.Point(521, 403);
            this.infreceivingData1.Name = "infreceivingData1";
            this.infreceivingData1.NameInferec = "";
            this.infreceivingData1.PostcodeInferec = "";
            this.infreceivingData1.PrefixInferec = "";
            this.infreceivingData1.Size = new System.Drawing.Size(427, 345);
            this.infreceivingData1.StateInferec = "";
            this.infreceivingData1.TabIndex = 50;
            this.infreceivingData1.TelNumberInferec = "";
            this.infreceivingData1.TitleInferec = "";
            // 
            // informationData1
            // 
            this.informationData1.ArrivalInform = new System.DateTime(2015, 6, 17, 7, 14, 29, 375);
            this.informationData1.CheckOutInform = new System.DateTime(2015, 6, 17, 7, 14, 29, 375);
            this.informationData1.DestinationInform = "";
            this.informationData1.EntryStateRadioInform = "";
            this.informationData1.Location = new System.Drawing.Point(521, 754);
            this.informationData1.Name = "informationData1";
            this.informationData1.NumbDayInform = "";
            this.informationData1.Size = new System.Drawing.Size(422, 352);
            this.informationData1.TabIndex = 49;
            this.informationData1.WaiverInform = "";
            // 
            // bossAddressData1
            // 
            this.bossAddressData1.AddressBossAddress = "";
            this.bossAddressData1.BLRadioBossAddress = false;
            this.bossAddressData1.CityBossAddress = "";
            this.bossAddressData1.CountryBossAddress = "";
            this.bossAddressData1.EmailBossAddress = "";
            this.bossAddressData1.FaxBossAddress = "";
            this.bossAddressData1.FaxPrefixBossAddress = "";
            this.bossAddressData1.Location = new System.Drawing.Point(521, 1112);
            this.bossAddressData1.Name = "bossAddressData1";
            this.bossAddressData1.PrefixBossAddress = "";
            this.bossAddressData1.Size = new System.Drawing.Size(470, 356);
            this.bossAddressData1.StateBossAddress = "";
            this.bossAddressData1.TabIndex = 48;
            this.bossAddressData1.TelNumberBossAddress = "";
            this.bossAddressData1.ZipBossAddress = "";
            // 
            // countryData1
            // 
            this.countryData1.DocumentRadioCountry = false;
            this.countryData1.FromCountry = new System.DateTime(2015, 6, 17, 7, 14, 29, 404);
            this.countryData1.Location = new System.Drawing.Point(521, 1514);
            this.countryData1.Name = "countryData1";
            this.countryData1.PassNumber = "";
            this.countryData1.Size = new System.Drawing.Size(470, 118);
            this.countryData1.TabIndex = 45;
            // 
            // addressData1
            // 
            this.addressData1.AddressAddress = "";
            this.addressData1.CityAddress = "";
            this.addressData1.CountryAddress = "";
            this.addressData1.EmailAddress = "";
            this.addressData1.Location = new System.Drawing.Point(521, 1638);
            this.addressData1.Name = "addressData1";
            this.addressData1.PrefixAddress = "";
            this.addressData1.Size = new System.Drawing.Size(470, 356);
            this.addressData1.StateAddress = "";
            this.addressData1.TabIndex = 44;
            this.addressData1.TelNumberAddress = "";
            this.addressData1.ZipAddress = "";
            // 
            // passportData1
            // 
            this.passportData1.Location = new System.Drawing.Point(521, 2000);
            this.passportData1.Name = "passportData1";
            this.passportData1.PassportFromDate = new System.DateTime(2015, 6, 17, 7, 14, 29, 419);
            this.passportData1.PassportNumber = "";
            this.passportData1.PassportSource = "";
            this.passportData1.PassportToDate = new System.DateTime(2015, 6, 17, 7, 14, 29, 419);
            this.passportData1.PassportTypeRadio = "";
            this.passportData1.Size = new System.Drawing.Size(479, 237);
            this.passportData1.TabIndex = 43;
            // 
            // personsCostsData1
            // 
            this.personsCostsData1.AllCostsPersCost = false;
            this.personsCostsData1.CardPersCost = false;
            this.personsCostsData1.ChecksPersCost = false;
            this.personsCostsData1.CostRadioPersCost = false;
            this.personsCostsData1.DateInsurancePersCost = new System.DateTime(2015, 6, 17, 7, 14, 29, 345);
            this.personsCostsData1.InsurancePersCost = false;
            this.personsCostsData1.Location = new System.Drawing.Point(3, 288);
            this.personsCostsData1.LocationPersCost = false;
            this.personsCostsData1.MoneyPersCost = false;
            this.personsCostsData1.Name = "personsCostsData1";
            this.personsCostsData1.OtheCostsPersCost = "";
            this.personsCostsData1.OthePersCost = "";
            this.personsCostsData1.OtherCostsPersCost = false;
            this.personsCostsData1.OtherPersCost = false;
            this.personsCostsData1.ReferredPersCost = false;
            this.personsCostsData1.Size = new System.Drawing.Size(470, 411);
            this.personsCostsData1.TabIndex = 39;
            this.personsCostsData1.TransportPersCost = false;
            // 
            // fingerprintsData1
            // 
            this.fingerprintsData1.FingYNFingerprints = false;
            this.fingerprintsData1.Location = new System.Drawing.Point(3, 705);
            this.fingerprintsData1.Name = "fingerprintsData1";
            this.fingerprintsData1.Size = new System.Drawing.Size(477, 91);
            this.fingerprintsData1.TabIndex = 38;
            // 
            // schengen_visasData1
            // 
            this.schengen_visasData1.From1Visa = new System.DateTime(2015, 6, 17, 7, 14, 29, 375);
            this.schengen_visasData1.From2Visa = new System.DateTime(2015, 6, 17, 7, 14, 29, 360);
            this.schengen_visasData1.Location = new System.Drawing.Point(3, 802);
            this.schengen_visasData1.Name = "schengen_visasData1";
            this.schengen_visasData1.Size = new System.Drawing.Size(483, 141);
            this.schengen_visasData1.TabIndex = 37;
            this.schengen_visasData1.To1Visa = new System.DateTime(2015, 6, 17, 7, 14, 29, 375);
            this.schengen_visasData1.To2Visa = new System.DateTime(2015, 6, 17, 7, 14, 29, 360);
            this.schengen_visasData1.YNVisa = false;
            // 
            // targetData1
            // 
            this.targetData1.CultureTarget = false;
            this.targetData1.DealTarget = false;
            this.targetData1.FamilyTarget = false;
            this.targetData1.LearningTarget = false;
            this.targetData1.Location = new System.Drawing.Point(3, 949);
            this.targetData1.Name = "targetData1";
            this.targetData1.OfficialTarget = false;
            this.targetData1.OtherTarget = false;
            this.targetData1.Size = new System.Drawing.Size(482, 139);
            this.targetData1.SportTarget = false;
            this.targetData1.TabIndex = 36;
            this.targetData1.TextOtherTarget = "";
            this.targetData1.TourismTarget = false;
            this.targetData1.TreatmentTarget = false;
            // 
            // childData1
            // 
            this.childData1.AddressChild = "";
            this.childData1.CitizenshipChild = "";
            this.childData1.CityChild = "";
            this.childData1.CountryChild = "";
            this.childData1.FirstNameChild = "";
            this.childData1.LastNameChild = "";
            this.childData1.Location = new System.Drawing.Point(3, 53);
            this.childData1.Name = "childData1";
            this.childData1.Size = new System.Drawing.Size(470, 356);
            this.childData1.StateChild = "";
            this.childData1.TabIndex = 2;
            this.childData1.ZipChild = "";
            // 
            // childData2
            // 
            this.childData2.AddressChild = "";
            this.childData2.CitizenshipChild = "";
            this.childData2.CityChild = "";
            this.childData2.CountryChild = "";
            this.childData2.FirstNameChild = "";
            this.childData2.LastNameChild = "";
            this.childData2.Location = new System.Drawing.Point(3, 404);
            this.childData2.Name = "childData2";
            this.childData2.Size = new System.Drawing.Size(470, 356);
            this.childData2.StateChild = "";
            this.childData2.TabIndex = 3;
            this.childData2.ZipChild = "";
            // 
            // personalData1
            // 
            this.personalData1.CitizenshipPersonal = "";
            this.personalData1.DobCityPersonal = "";
            this.personalData1.DobCountryPersonal = "";
            this.personalData1.DobPersonal = new System.DateTime(2015, 6, 9, 22, 17, 55, 442);
            this.personalData1.FamilyStateRadioPersonal = "";
            this.personalData1.FirstNamePersonal = "";
            this.personalData1.LastNamePersonal = "";
            this.personalData1.Location = new System.Drawing.Point(3, 1870);
            this.personalData1.Name = "personalData1";
            this.personalData1.NationalityPersonal = "";
            this.personalData1.PreviousLastNamePersonal = "";
            this.personalData1.SexMRadioPersonal = false;
            this.personalData1.Size = new System.Drawing.Size(474, 358);
            this.personalData1.TabIndex = 34;
            // 
            // okCancelControl1
            // 
            this.okCancelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.okCancelControl1.Location = new System.Drawing.Point(3, 3);
            this.okCancelControl1.Name = "okCancelControl1";
            this.okCancelControl1.Size = new System.Drawing.Size(1035, 50);
            this.okCancelControl1.TabIndex = 14;
            this.okCancelControl1.Visible = false;
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chbProxy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioinfo;
        private System.Windows.Forms.RadioButton radiocom;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.CheckBox chbAutoResolveImage;
        private TheseEUCitizenData theseEUCitizenData1;
        private InfreceivingData infreceivingData1;
        private InformationData informationData1;
        private BossAddressData bossAddressData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CountryData countryData1;
        private AddressData addressData1;
        private PassportData passportData1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtGreenLine;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.Button btnaddTask;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtRedLine;
        private PersonsCostsData personsCostsData1;
        private FingerprintsData fingerprintsData1;
        private Schengen_visasData schengen_visasData1;
        private TargetData targetData1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNotForMe;
        private ChildData childData1;
        private ChildData childData2;
        private PersonalData personalData1;
        private OkCancelControl okCancelControl1;
    }
}

