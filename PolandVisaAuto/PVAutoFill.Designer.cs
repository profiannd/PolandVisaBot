using System.Windows.Forms;

namespace PolandVisaAuto
{
    partial class PVAutoFill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVAutoFill));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chbProxy = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.radioinfo = new System.Windows.Forms.RadioButton();
            this.radiocom = new System.Windows.Forms.RadioButton();
            this.restoreButton = new Button();
            this.chbAutoResolveImage = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.btnaddTask = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtGreenLine = new System.Windows.Forms.DateTimePicker();
            this.dtRedLine = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.dtEndPass = new System.Windows.Forms.DateTimePicker();
            this.cbxNation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBillNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.numCountC = new System.Windows.Forms.NumericUpDown();
            this.numCountA = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPurpose = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.duplColumn = new DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.restoreColumn = new DataGridViewButtonColumn();
            this.cityDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.redLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.greenLineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.priorityComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.purposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countAdultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countChildDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.deleteButton2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cityColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultColumn = new DataGridViewTextBoxColumn();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1094, 662);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1086, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить задание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.chbProxy);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.radioinfo);
            this.groupBox7.Controls.Add(this.radiocom);
            this.groupBox7.Controls.Add(this.restoreButton);
            this.groupBox7.Controls.Add(this.chbAutoResolveImage);
            this.groupBox7.Location = new System.Drawing.Point(34, 460);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(469, 159);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Настройки приложения";
            // 
            // chbProxy
            // 
            this.chbProxy.AutoSize = true;
            this.chbProxy.Location = new System.Drawing.Point(10, 132);
            this.chbProxy.Name = "chbProxy";
            this.chbProxy.Size = new System.Drawing.Size(288, 21);
            this.chbProxy.TabIndex = 4;
            this.chbProxy.Text = "Использовать прокси";
            this.chbProxy.UseVisualStyleBackColor = true;
            this.chbProxy.CheckedChanged += new System.EventHandler(this.chbProxy_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Сервер для распознования";
            // 
            // radioinfo
            // 
            this.radioinfo.AutoSize = true;
            this.radioinfo.Location = new System.Drawing.Point(14, 105);
            this.radioinfo.Name = "radioinfo";
            this.radioinfo.Size = new System.Drawing.Size(152, 21);
            this.radioinfo.TabIndex = 2;
            this.radioinfo.TabStop = true;
            this.radioinfo.Text = "api.de-captcher.info";
            this.radioinfo.UseVisualStyleBackColor = true;
            this.radioinfo.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radiocom
            // 
            this.radiocom.AutoSize = true;
            this.radiocom.Location = new System.Drawing.Point(14, 77);
            this.radiocom.Name = "radiocom";
            this.radiocom.Size = new System.Drawing.Size(155, 21);
            this.radiocom.TabIndex = 1;
            this.radiocom.TabStop = true;
            this.radiocom.Text = "api.de-captcher.com";
            this.radiocom.UseVisualStyleBackColor = true;
            this.radiocom.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            //
            //restoreButton
            //
            this.restoreButton.BackColor = System.Drawing.Color.YellowGreen;
            this.restoreButton.Location = new System.Drawing.Point(280, 60);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(120, 75);
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Text = "Восстановить удаленную задачу";
            this.restoreButton.Click += restoreButton_Click;
            // 
            // chbAutoResolveImage
            // 
            this.chbAutoResolveImage.AutoSize = true;
            this.chbAutoResolveImage.Location = new System.Drawing.Point(10, 22);
            this.chbAutoResolveImage.Name = "chbAutoResolveImage";
            this.chbAutoResolveImage.Size = new System.Drawing.Size(288, 21);
            this.chbAutoResolveImage.TabIndex = 0;
            this.chbAutoResolveImage.Text = "Распознавать картинки автоматически";
            this.chbAutoResolveImage.UseVisualStyleBackColor = true;
            this.chbAutoResolveImage.CheckedChanged += new System.EventHandler(this.chbAutoResolveImage_CheckedChanged);
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
            this.groupBox6.Location = new System.Drawing.Point(530, 460);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(526, 159);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(237, 17);
            this.label16.TabIndex = 16;
            this.label16.Text = "Крайняя дата подачи документов ";
            // 
            // cbxPriority
            // 
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Location = new System.Drawing.Point(283, 53);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(222, 24);
            this.cbxPriority.TabIndex = 18;
            // 
            // btnaddTask
            // 
            this.btnaddTask.BackColor = System.Drawing.Color.YellowGreen;
            this.btnaddTask.Location = new System.Drawing.Point(149, 115);
            this.btnaddTask.Name = "btnaddTask";
            this.btnaddTask.Size = new System.Drawing.Size(244, 40);
            this.btnaddTask.TabIndex = 2;
            this.btnaddTask.Text = "Добавить задание";
            this.btnaddTask.UseVisualStyleBackColor = false;
            this.btnaddTask.Click += new System.EventHandler(this.btnaddTask_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Приоритет заявки";
            // 
            // dtRedLine
            // 
            this.dtRedLine.CustomFormat = "dd/MM/yyyy";
            this.dtRedLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRedLine.Location = new System.Drawing.Point(283, 17);
            this.dtRedLine.Name = "dtRedLine";
            this.dtRedLine.Size = new System.Drawing.Size(222, 23);
            this.dtRedLine.TabIndex = 15;
            this.dtRedLine.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtArrivalDate);
            this.groupBox5.Controls.Add(this.dtDob);
            this.groupBox5.Controls.Add(this.dtEndPass);
            this.groupBox5.Controls.Add(this.cbxNation);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtLastName);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbxStatus);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(530, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 276);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Призначити дату подачі документів 5";
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.CustomFormat = "dd/MM/yyyy";
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalDate.Location = new System.Drawing.Point(285, 197);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.Size = new System.Drawing.Size(222, 23);
            this.dtArrivalDate.TabIndex = 16;
            this.dtArrivalDate.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // dtDob
            // 
            this.dtDob.CustomFormat = "dd/MM/yyyy";
            this.dtDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDob.Location = new System.Drawing.Point(285, 158);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(222, 23);
            this.dtDob.TabIndex = 15;
            this.dtDob.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // dtEndPass
            // 
            this.dtEndPass.CustomFormat = "dd/MM/yyyy";
            this.dtEndPass.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndPass.Location = new System.Drawing.Point(285, 22);
            this.dtEndPass.Name = "dtEndPass";
            this.dtEndPass.Size = new System.Drawing.Size(222, 23);
            this.dtEndPass.TabIndex = 14;
            this.dtEndPass.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // cbxNation
            // 
            this.cbxNation.FormattingEnabled = true;
            this.cbxNation.Location = new System.Drawing.Point(285, 235);
            this.cbxNation.Name = "cbxNation";
            this.cbxNation.Size = new System.Drawing.Size(222, 24);
            this.cbxNation.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Національність";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Дата повернення";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Дата народження";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(285, 124);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(222, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Прізвище";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(285, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 23);
            this.txtName.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ім\'я";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(285, 56);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(222, 24);
            this.cbxStatus.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата закінчення терміну дії паспорту";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtPass);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Location = new System.Drawing.Point(34, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 156);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Призначити дату подачі документів 4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сделать бяку\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCreateEmail_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Пароль";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Email адреса";
            // 
            // txtPass
            // 
            this.emailErrorProvider.SetIconPadding(this.txtPass, 2);
            this.txtPass.Location = new System.Drawing.Point(217, 98);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.Validated += new System.EventHandler(this.txtPass_Validated);
            // 
            // txtEmail
            // 
            this.emailErrorProvider.SetIconPadding(this.txtEmail, 2);
            this.txtEmail.Location = new System.Drawing.Point(217, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtBillNum);
            this.groupBox3.Location = new System.Drawing.Point(34, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 97);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Призначити дату подачі документів 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Номер квитанції";
            // 
            // txtBillNum
            // 
            this.txtBillNum.Location = new System.Drawing.Point(217, 43);
            this.txtBillNum.Name = "txtBillNum";
            this.txtBillNum.Size = new System.Drawing.Size(200, 23);
            this.txtBillNum.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCategory);
            this.groupBox2.Controls.Add(this.numCountC);
            this.groupBox2.Controls.Add(this.numCountA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(530, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Призначити дату подачі документів 2";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(285, 90);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(207, 24);
            this.cbxCategory.TabIndex = 5;
            // 
            // numCountC
            // 
            this.numCountC.Location = new System.Drawing.Point(285, 55);
            this.numCountC.Name = "numCountC";
            this.numCountC.Size = new System.Drawing.Size(76, 23);
            this.numCountC.TabIndex = 4;
            // 
            // numCountA
            // 
            this.numCountA.Location = new System.Drawing.Point(285, 19);
            this.numCountA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCountA.Name = "numCountA";
            this.numCountA.Size = new System.Drawing.Size(76, 23);
            this.numCountA.TabIndex = 3;
            this.numCountA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Візова категорія";
            // 
            // dtGreenLine
            // 
            this.dtGreenLine.CustomFormat = "dd/MM/yyyy";
            this.dtGreenLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGreenLine.Location = new System.Drawing.Point(283, 85);
            this.dtGreenLine.Name = "dtGreenLine";
            this.dtGreenLine.Size = new System.Drawing.Size(222, 23);
            this.dtGreenLine.TabIndex = 19;
            this.dtGreenLine.Value = new System.DateTime(2015, 3, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "К-сть дітей вписаних у паспорт батьків";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Кількість заявників";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxPurpose);
            this.groupBox1.Controls.Add(this.cbxCity);
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Призначити дату подачі документів 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Мета візиту";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пункт Прийому Візових Анкет";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(253, 17);
            this.label19.TabIndex = 20;
            this.label19.Text = "Начальная дата подачи документов ";
            // 
            // cbxPurpose
            // 
            this.cbxPurpose.FormattingEnabled = true;
            this.cbxPurpose.Location = new System.Drawing.Point(217, 72);
            this.cbxPurpose.Name = "cbxPurpose";
            this.cbxPurpose.Size = new System.Drawing.Size(200, 24);
            this.cbxPurpose.TabIndex = 1;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(217, 28);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(200, 24);
            this.cbxCity.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статус заданий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteColumn,
            this.duplColumn,
            this.cityDataGridViewComboBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.greenLineDataGridViewTextBoxColumn,
            this.redLineDataGridViewTextBoxColumn,
            this.priorityComboBoxColumn,
            this.purposeDataGridViewTextBoxColumn,
            this.countAdultDataGridViewTextBoxColumn,
            this.countChildDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.receiptDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.passportEndDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.arrivalDtDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 369);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "Удалить";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            //
            //duplColumn
            //
            this.duplColumn.HeaderText = "";
            this.duplColumn.Name = "duplColumn";
            this.duplColumn.Text = "Дублировать";
            this.duplColumn.UseColumnTextForButtonValue = true;
            //
            //restoreColumn
            //
            this.restoreColumn.HeaderText = "";
            this.restoreColumn.Name = "restoreColumn";
            this.restoreColumn.Text = "Восстановить";
            this.restoreColumn.UseColumnTextForButtonValue = true;
            // 
            // cityDataGridViewComboBoxColumn
            // 
            this.cityDataGridViewComboBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewComboBoxColumn.HeaderText = "Город";
            this.cityDataGridViewComboBoxColumn.Name = "City";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastNameDataGridViewTextBoxColumn.Name = "LastName";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "Name";
            // 
            // redLineDataGridViewTextBoxColumn
            // 
            this.redLineDataGridViewTextBoxColumn.DataPropertyName = "RedLine";
            this.redLineDataGridViewTextBoxColumn.HeaderText = "Крайняя дата";
            this.redLineDataGridViewTextBoxColumn.Name = "redLineDataGridViewTextBoxColumn";
            // 
            // greenLineDataGridViewTextBoxColumn
            // 
            this.greenLineDataGridViewTextBoxColumn.DataPropertyName = "GreenLine";
            this.greenLineDataGridViewTextBoxColumn.HeaderText = "Начальная дата";
            this.greenLineDataGridViewTextBoxColumn.Name = "greenLineDataGridViewTextBoxColumn";

            // 
            // priorityComboBoxColumn
            // 
            this.priorityComboBoxColumn.DataPropertyName = "Priority";
            this.priorityComboBoxColumn.HeaderText = "Приоритет";
            this.priorityComboBoxColumn.Name = "priorityComboBoxColumn";
            this.priorityComboBoxColumn.ValueMember = "Value";
            this.priorityComboBoxColumn.DisplayMember = "Description"; 
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            this.purposeDataGridViewTextBoxColumn.DataPropertyName = "Purpose";
            this.purposeDataGridViewTextBoxColumn.HeaderText = "Цель визита";
            this.purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            // 
            // countAdultDataGridViewTextBoxColumn
            // 
            this.countAdultDataGridViewTextBoxColumn.DataPropertyName = "CountAdult";
            this.countAdultDataGridViewTextBoxColumn.HeaderText = "К-во взрослых";
            this.countAdultDataGridViewTextBoxColumn.Name = "countAdultDataGridViewTextBoxColumn";
            // 
            // countChildDataGridViewTextBoxColumn
            // 
            this.countChildDataGridViewTextBoxColumn.DataPropertyName = "CountChild";
            this.countChildDataGridViewTextBoxColumn.HeaderText = "К-во детей";
            this.countChildDataGridViewTextBoxColumn.Name = "countChildDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // receiptDataGridViewTextBoxColumn
            // 
            this.receiptDataGridViewTextBoxColumn.DataPropertyName = "Receipt";
            this.receiptDataGridViewTextBoxColumn.HeaderText = "Квитанция";
            this.receiptDataGridViewTextBoxColumn.Name = "receiptDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // passportEndDateDataGridViewTextBoxColumn
            // 
            this.passportEndDateDataGridViewTextBoxColumn.DataPropertyName = "PassportEndDate";
            this.passportEndDateDataGridViewTextBoxColumn.HeaderText = "Дата оконч. пасспорта";
            this.passportEndDateDataGridViewTextBoxColumn.Name = "passportEndDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "Status";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // arrivalDtDataGridViewTextBoxColumn
            // 
            this.arrivalDtDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDt";
            this.arrivalDtDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.arrivalDtDataGridViewTextBoxColumn.Name = "arrivalDtDataGridViewTextBoxColumn";
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Национальность";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteButton2,
            this.restoreColumn,
            this.cityColumn2,
            this.LastNameColumn2,
            this.NameColumn2,
            this.ResultColumn});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 378);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1080, 252);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // deleteButton2
            // 
            this.deleteButton2.HeaderText = "";
            this.deleteButton2.Name = "deleteColumn2";
            this.deleteButton2.Text = "Удалить";
            this.deleteButton2.UseColumnTextForButtonValue = true;
            // 
            // cityColumn2
            // 
            this.cityColumn2.DataPropertyName = "City";
            this.cityColumn2.HeaderText = "Город";
            this.cityColumn2.Name = "City2";
            // 
            // LastNameColumn2
            // 
            this.LastNameColumn2.DataPropertyName = "LastName";
            this.LastNameColumn2.HeaderText = "Фамилия";
            this.LastNameColumn2.Name = "LastName2";
            // 
            // NameColumn2
            // 
            this.NameColumn2.DataPropertyName = "Name";
            this.NameColumn2.HeaderText = "Имя";
            this.NameColumn2.Name = "Name2";
            //
            //ResultColumn
            //
            this.ResultColumn.DataPropertyName = "RegistrationInfo";
            this.ResultColumn.HeaderText = "Регистрация";
            this.ResultColumn.Name = "RegistrationInfo";
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.BlinkRate = 500;
            this.emailErrorProvider.ContainerControl = this;
            // 
            // PasserrorProvider
            // 
            this.PasserrorProvider.BlinkRate = 500;
            this.PasserrorProvider.ContainerControl = this;
            // 
            // PVAutoFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 662);
            this.MinimumSize = new System.Drawing.Size(1094, 662);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PVAutoFill";
            this.Text = "Poland Visa Auto  ";
            this.Load += new System.EventHandler(this.PvAutoLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasserrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnaddTask;
        private GroupBox groupBox2;
        private ComboBox cbxCategory;
        private NumericUpDown numCountC;
        private NumericUpDown numCountA;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbxPurpose;
        private ComboBox cbxCity;
        private TabPage tabPage2;
        private GroupBox groupBox5;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtLastName;
        private Label label9;
        private TextBox txtName;
        private Label label8;
        private ComboBox cbxStatus;
        private Label label7;
        private Label label6;
        private GroupBox groupBox4;
        private Label label15;
        private Label label14;
        private TextBox txtPass;
        private TextBox txtEmail;
        private GroupBox groupBox3;
        private Label label13;
        private TextBox txtBillNum;
        private ComboBox cbxNation;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DateTimePicker dtEndPass;
        private DateTimePicker dtArrivalDate;
        private DateTimePicker dtDob;
        private ErrorProvider emailErrorProvider;
        private ErrorProvider PasserrorProvider;
        private ComboBox cbxPriority;
        private Label label17;
        private Label label16;
        private DateTimePicker dtRedLine;
        private DataGridViewComboBoxColumn cityDataGridViewComboBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countAdultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countChildDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receiptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passportEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arrivalDtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn greenLineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn redLineDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn priorityComboBoxColumn;
        private Button button1;
        private DataGridViewButtonColumn duplColumn;
        private DataGridViewButtonColumn deleteColumn;
        private DataGridViewButtonColumn restoreColumn;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private RadioButton radioinfo;
        private RadioButton radiocom;
        private Button restoreButton;
        private CheckBox chbAutoResolveImage;
        private Label label18;
        private DataGridViewButtonColumn deleteButton2;
        private DataGridViewTextBoxColumn cityColumn2;
        private DataGridViewTextBoxColumn LastNameColumn2;
        private DataGridViewTextBoxColumn NameColumn2;
        private DataGridViewTextBoxColumn ResultColumn;
        private CheckBox chbProxy;
        private Label label19;
        private DateTimePicker dtGreenLine;

    }
}

