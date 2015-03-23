using System.Windows.Forms;

namespace PolandVisaMonitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.intTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNotif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbMess = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cellDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbxVisas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIntMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSett = new System.Windows.Forms.Label();
            this.dataGridViewSettings = new System.Windows.Forms.DataGridView();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.citySett = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSett = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 390);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1032, 2);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 231);
            this.panel2.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1032, 231);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // intTimer
            // 
            this.intTimer.Interval = 10000;
            this.intTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 60000;
            this.mainTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 390);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewResults);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtNotif);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.rtbMess);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.cellDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.cbxVisas);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtInt);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtIntMain);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblSett);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSettings);
            this.splitContainer1.Size = new System.Drawing.Size(1032, 390);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Date});
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(336, 390);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "DateStr";
            this.Date.HeaderText = "Свободная дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "на свободную визу";
            // 
            // txtNotif
            // 
            this.txtNotif.Location = new System.Drawing.Point(534, 103);
            this.txtNotif.Name = "txtNotif";
            this.txtNotif.Size = new System.Drawing.Size(31, 20);
            this.txtNotif.TabIndex = 15;
            this.txtNotif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Количество звуковых сигналов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(463, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Сообщения";
            // 
            // rtbMess
            // 
            this.rtbMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMess.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMess.Location = new System.Drawing.Point(346, 235);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.Size = new System.Drawing.Size(346, 155);
            this.rtbMess.TabIndex = 12;
            this.rtbMess.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(436, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить настройки";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Отслеживать тип визы ";
            // 
            // cellDateTimePicker
            // 
            this.cellDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.cellDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cellDateTimePicker.Location = new System.Drawing.Point(96, 325);
            this.cellDateTimePicker.Name = "cellDateTimePicker";
            this.cellDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.cellDateTimePicker.TabIndex = 2;
            this.cellDateTimePicker.Visible = false;
            this.cellDateTimePicker.ValueChanged += new System.EventHandler(this.cellDateTimePickerValueChanged);
            // 
            // cbxVisas
            // 
            this.cbxVisas.FormattingEnabled = true;
            this.cbxVisas.Location = new System.Drawing.Point(502, 133);
            this.cbxVisas.Name = "cbxVisas";
            this.cbxVisas.Size = new System.Drawing.Size(146, 21);
            this.cbxVisas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Увеличить при медленном инете";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "секунд(а).";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(533, 58);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(31, 20);
            this.txtInt.TabIndex = 6;
            this.txtInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Задержка между действиями";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "минут(у)";
            // 
            // txtIntMain
            // 
            this.txtIntMain.Location = new System.Drawing.Point(533, 33);
            this.txtIntMain.Name = "txtIntMain";
            this.txtIntMain.Size = new System.Drawing.Size(31, 20);
            this.txtIntMain.TabIndex = 3;
            this.txtIntMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обновлять данные раз в ";
            // 
            // lblSett
            // 
            this.lblSett.AutoSize = true;
            this.lblSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSett.Location = new System.Drawing.Point(463, 6);
            this.lblSett.Name = "lblSett";
            this.lblSett.Size = new System.Drawing.Size(71, 13);
            this.lblSett.TabIndex = 1;
            this.lblSett.Text = "Настройки";
            // 
            // dataGridViewSettings
            // 
            this.dataGridViewSettings.AllowUserToAddRows = false;
            this.dataGridViewSettings.AllowUserToDeleteRows = false;
            this.dataGridViewSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsChecked,
            this.citySett,
            this.dateSett});
            this.dataGridViewSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSettings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewSettings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSettings.Name = "dataGridViewSettings";
            this.dataGridViewSettings.Size = new System.Drawing.Size(346, 390);
            this.dataGridViewSettings.TabIndex = 0;
            this.dataGridViewSettings.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewSettings_CellBeginEdit);
            this.dataGridViewSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSettings_CellValueChanged);
            this.dataGridViewSettings.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewSettings_CurrentCellDirtyStateChanged);
            this.dataGridViewSettings.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewSettings_DataError);
            // 
            // IsChecked
            // 
            this.IsChecked.DataPropertyName = "IsChecked";
            this.IsChecked.HeaderText = "Отслеживать";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsChecked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // citySett
            // 
            this.citySett.DataPropertyName = "City";
            this.citySett.HeaderText = "Город";
            this.citySett.Name = "citySett";
            this.citySett.ReadOnly = true;
            this.citySett.Width = 62;
            // 
            // dateSett
            // 
            this.dateSett.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateSett.DataPropertyName = "DateStr";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.dateSett.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateSett.HeaderText = "Дата визы";
            this.dateSett.Name = "dateSett";
            // 
            // timerNotify
            // 
            this.timerNotify.Interval = 1000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Poland Visa Monitor  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer intTimer;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label lblSett;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxVisas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private DateTimePicker cellDateTimePicker;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Date;
        private Label label7;
        private RichTextBox rtbMess;
        private DataGridView dataGridViewSettings;
        private DataGridViewCheckBoxColumn IsChecked;
        private DataGridViewTextBoxColumn citySett;
        private DataGridViewTextBoxColumn dateSett;
        private Timer timerNotify;
        private TextBox txtNotif;
        private Label label9;
        private Label label8;
    }
}

