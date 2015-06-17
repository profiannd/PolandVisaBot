namespace E_Konsulat
{
    partial class Schengen_visasData
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
            this.dtTo2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioYes);
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.dtTo2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtTo1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtFrom1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шенгенские визы, выданные за последние пять лет";
            // 
            // dtTo2
            // 
            this.dtTo2.Location = new System.Drawing.Point(351, 100);
            this.dtTo2.Name = "dtTo2";
            this.dtTo2.Size = new System.Drawing.Size(122, 20);
            this.dtTo2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "до (год-месяц-день):";
            // 
            // dtFrom2
            // 
            this.dtFrom2.Location = new System.Drawing.Point(107, 100);
            this.dtFrom2.Name = "dtFrom2";
            this.dtFrom2.Size = new System.Drawing.Size(122, 20);
            this.dtFrom2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "с (год-месяц-день):";
            // 
            // dtTo1
            // 
            this.dtTo1.Location = new System.Drawing.Point(351, 74);
            this.dtTo1.Name = "dtTo1";
            this.dtTo1.Size = new System.Drawing.Size(122, 20);
            this.dtTo1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "до (год-месяц-день):";
            // 
            // dtFrom1
            // 
            this.dtFrom1.Location = new System.Drawing.Point(107, 74);
            this.dtFrom1.Name = "dtFrom1";
            this.dtFrom1.Size = new System.Drawing.Size(122, 20);
            this.dtFrom1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "с (год-месяц-день):";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(9, 19);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(44, 17);
            this.radioNo.TabIndex = 11;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Нет";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(9, 42);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(209, 17);
            this.radioYes.TabIndex = 12;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Да. Срок действия (год-месяц-день)";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // Schengen_visasData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Schengen_visasData";
            this.Size = new System.Drawing.Size(483, 136);
            this.Load += new System.EventHandler(this.Schengen_visasData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFrom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
    }
}
