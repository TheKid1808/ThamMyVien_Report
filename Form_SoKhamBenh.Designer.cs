namespace ThamMyVien_Report
{
    partial class Form_SoKhamBenh
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
            this.cryRptViewer_SoKhamBenh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryRptViewer_SoKhamBenh
            // 
            this.cryRptViewer_SoKhamBenh.ActiveViewIndex = -1;
            this.cryRptViewer_SoKhamBenh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryRptViewer_SoKhamBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryRptViewer_SoKhamBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryRptViewer_SoKhamBenh.Location = new System.Drawing.Point(0, 0);
            this.cryRptViewer_SoKhamBenh.Name = "cryRptViewer_SoKhamBenh";
            this.cryRptViewer_SoKhamBenh.Size = new System.Drawing.Size(800, 450);
            this.cryRptViewer_SoKhamBenh.TabIndex = 0;
            // 
            // Form_SoKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cryRptViewer_SoKhamBenh);
            this.Name = "Form_SoKhamBenh";
            this.Text = "Sổ Khám Bệnh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryRptViewer_SoKhamBenh;
    }
}