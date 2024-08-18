namespace _2212410_WDF48
{
    partial class frmDemoComboBox
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
            this.lbChoNgoaiNgu = new System.Windows.Forms.Label();
            this.comboBox_NgoaiNgu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbChoNgoaiNgu
            // 
            this.lbChoNgoaiNgu.AutoSize = true;
            this.lbChoNgoaiNgu.Location = new System.Drawing.Point(31, 34);
            this.lbChoNgoaiNgu.Name = "lbChoNgoaiNgu";
            this.lbChoNgoaiNgu.Size = new System.Drawing.Size(100, 16);
            this.lbChoNgoaiNgu.TabIndex = 0;
            this.lbChoNgoaiNgu.Text = "Chọn ngoại ngữ";
            // 
            // comboBox_NgoaiNgu
            // 
            this.comboBox_NgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NgoaiNgu.FormattingEnabled = true;
            this.comboBox_NgoaiNgu.Items.AddRange(new object[] {
            "\t",
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Việt",
            "Tiếng Nhật"});
            this.comboBox_NgoaiNgu.Location = new System.Drawing.Point(194, 34);
            this.comboBox_NgoaiNgu.Name = "comboBox_NgoaiNgu";
            this.comboBox_NgoaiNgu.Size = new System.Drawing.Size(121, 24);
            this.comboBox_NgoaiNgu.TabIndex = 1;
            this.comboBox_NgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.comboBox_NgoaiNgu_SelectedIndexChanged);
            // 
            // frmDemoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 251);
            this.Controls.Add(this.comboBox_NgoaiNgu);
            this.Controls.Add(this.lbChoNgoaiNgu);
            this.Name = "frmDemoComboBox";
            this.Text = "DemoComboBox";
            this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChoNgoaiNgu;
        private System.Windows.Forms.ComboBox comboBox_NgoaiNgu;
    }
}

