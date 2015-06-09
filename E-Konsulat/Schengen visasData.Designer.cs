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
            this.dateTimeto2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimefrom2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeto1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimefrom1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chcBoxNo = new System.Windows.Forms.CheckBox();
            this.chcBoxYes = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeto2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimefrom2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimeto1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimefrom1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chcBoxNo);
            this.groupBox1.Controls.Add(this.chcBoxYes);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шенгенские визы, выданные за последние пять лет";
            // 
            // dateTimeto2
            // 
            this.dateTimeto2.Location = new System.Drawing.Point(351, 100);
            this.dateTimeto2.Name = "dateTimeto2";
            this.dateTimeto2.Size = new System.Drawing.Size(122, 20);
            this.dateTimeto2.TabIndex = 10;
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
            // dateTimefrom2
            // 
            this.dateTimefrom2.Location = new System.Drawing.Point(107, 100);
            this.dateTimefrom2.Name = "dateTimefrom2";
            this.dateTimefrom2.Size = new System.Drawing.Size(122, 20);
            this.dateTimefrom2.TabIndex = 8;
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
            // dateTimeto1
            // 
            this.dateTimeto1.Location = new System.Drawing.Point(351, 74);
            this.dateTimeto1.Name = "dateTimeto1";
            this.dateTimeto1.Size = new System.Drawing.Size(122, 20);
            this.dateTimeto1.TabIndex = 6;
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
            // dateTimefrom1
            // 
            this.dateTimefrom1.Location = new System.Drawing.Point(107, 74);
            this.dateTimefrom1.Name = "dateTimefrom1";
            this.dateTimefrom1.Size = new System.Drawing.Size(122, 20);
            this.dateTimefrom1.TabIndex = 4;
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
            // chcBoxNo
            // 
            this.chcBoxNo.AutoSize = true;
            this.chcBoxNo.Location = new System.Drawing.Point(7, 44);
            this.chcBoxNo.Name = "chcBoxNo";
            this.chcBoxNo.Size = new System.Drawing.Size(210, 17);
            this.chcBoxNo.TabIndex = 1;
            this.chcBoxNo.Text = "Да. Срок действия (год-месяц-день)";
            this.chcBoxNo.UseVisualStyleBackColor = true;
            this.chcBoxNo.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chcBoxYes
            // 
            this.chcBoxYes.AutoSize = true;
            this.chcBoxYes.Location = new System.Drawing.Point(7, 20);
            this.chcBoxYes.Name = "chcBoxYes";
            this.chcBoxYes.Size = new System.Drawing.Size(45, 17);
            this.chcBoxYes.TabIndex = 0;
            this.chcBoxYes.Text = "Нет";
            this.chcBoxYes.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.DateTimePicker dateTimeto2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimefrom2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeto1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimefrom1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chcBoxNo;
        private System.Windows.Forms.CheckBox chcBoxYes;
    }
}
