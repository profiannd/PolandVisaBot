namespace E_Konsulat
{
    partial class FingerprintsData
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
            this.groupFingerprints = new System.Windows.Forms.GroupBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.groupFingerprints.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFingerprints
            // 
            this.groupFingerprints.Controls.Add(this.radioYes);
            this.groupFingerprints.Controls.Add(this.radioNo);
            this.groupFingerprints.Location = new System.Drawing.Point(0, 0);
            this.groupFingerprints.Name = "groupFingerprints";
            this.groupFingerprints.Size = new System.Drawing.Size(522, 86);
            this.groupFingerprints.TabIndex = 0;
            this.groupFingerprints.TabStop = false;
            this.groupFingerprints.Text = "Отпечатки пальцев, предоставленные ранее при подаче заявки на получение шенгенско" +
    "й визы";
            this.groupFingerprints.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(6, 42);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(40, 17);
            this.radioYes.TabIndex = 3;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Да";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(6, 19);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(44, 17);
            this.radioNo.TabIndex = 2;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Нет";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // FingerprintsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupFingerprints);
            this.Name = "FingerprintsData";
            this.Size = new System.Drawing.Size(523, 86);
            this.groupFingerprints.ResumeLayout(false);
            this.groupFingerprints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFingerprints;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
    }
}
