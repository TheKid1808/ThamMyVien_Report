namespace ThamMyVien_Report
{
    partial class Form_DSKhamBenh
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
            this.cryRpt_DSKhamBenh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRpt_DSKhamBenh
            // 
            this.cryRpt_DSKhamBenh.ActiveViewIndex = -1;
            this.cryRpt_DSKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRpt_DSKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryRpt_DSKhamBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRpt_DSKhamBenh.Location = new System.Drawing.Point(0, 0);
            this.cryRpt_DSKhamBenh.Name = "cryRpt_DSKhamBenh";
            this.cryRpt_DSKhamBenh.Size = new System.Drawing.Size(800, 450);
            this.cryRpt_DSKhamBenh.TabIndex = 0;
            // 
            // Form_DSKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryRpt_DSKhamBenh);
            this.Name = "Form_DSKhamBenh";
            this.Text = "Form_DSKhamBenh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRpt_DSKhamBenh;
    }
}