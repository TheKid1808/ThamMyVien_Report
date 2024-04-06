namespace ThamMyVien_Report
{
    partial class Tham_My_Vien
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
            this.button_HienThiThongTin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label_MaBenhNhan = new System.Windows.Forms.Label();
            this.label_TenBenhNhan = new System.Windows.Forms.Label();
            this.cBox_MaBenhNhan = new System.Windows.Forms.ComboBox();
            this.tBox_TenBenhNhan = new System.Windows.Forms.TextBox();
            this.button_DSKhamBenh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_HienThiThongTin
            // 
            this.button_HienThiThongTin.Location = new System.Drawing.Point(58, 297);
            this.button_HienThiThongTin.Name = "button_HienThiThongTin";
            this.button_HienThiThongTin.Size = new System.Drawing.Size(120, 45);
            this.button_HienThiThongTin.TabIndex = 0;
            this.button_HienThiThongTin.Text = "Hiện Thông Tin";
            this.button_HienThiThongTin.UseVisualStyleBackColor = true;
            this.button_HienThiThongTin.Click += new System.EventHandler(this.button_HienThiThongTin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tiếp Tục";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_MaBenhNhan
            // 
            this.label_MaBenhNhan.AutoSize = true;
            this.label_MaBenhNhan.Location = new System.Drawing.Point(55, 44);
            this.label_MaBenhNhan.Name = "label_MaBenhNhan";
            this.label_MaBenhNhan.Size = new System.Drawing.Size(95, 16);
            this.label_MaBenhNhan.TabIndex = 3;
            this.label_MaBenhNhan.Text = "Mã Bệnh Nhân";
            // 
            // label_TenBenhNhan
            // 
            this.label_TenBenhNhan.AutoSize = true;
            this.label_TenBenhNhan.Location = new System.Drawing.Point(55, 92);
            this.label_TenBenhNhan.Name = "label_TenBenhNhan";
            this.label_TenBenhNhan.Size = new System.Drawing.Size(100, 16);
            this.label_TenBenhNhan.TabIndex = 4;
            this.label_TenBenhNhan.Text = "Tên Bệnh Nhân";
            // 
            // cBox_MaBenhNhan
            // 
            this.cBox_MaBenhNhan.FormattingEnabled = true;
            this.cBox_MaBenhNhan.Location = new System.Drawing.Point(210, 41);
            this.cBox_MaBenhNhan.Name = "cBox_MaBenhNhan";
            this.cBox_MaBenhNhan.Size = new System.Drawing.Size(168, 24);
            this.cBox_MaBenhNhan.TabIndex = 5;
            this.cBox_MaBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cBox_MaBenhNhan_SelectedIndexChanged);
            // 
            // tBox_TenBenhNhan
            // 
            this.tBox_TenBenhNhan.Location = new System.Drawing.Point(210, 92);
            this.tBox_TenBenhNhan.Name = "tBox_TenBenhNhan";
            this.tBox_TenBenhNhan.Size = new System.Drawing.Size(168, 22);
            this.tBox_TenBenhNhan.TabIndex = 6;
            // 
            // button_DSKhamBenh
            // 
            this.button_DSKhamBenh.Location = new System.Drawing.Point(391, 297);
            this.button_DSKhamBenh.Name = "button_DSKhamBenh";
            this.button_DSKhamBenh.Size = new System.Drawing.Size(120, 45);
            this.button_DSKhamBenh.TabIndex = 7;
            this.button_DSKhamBenh.Text = "Danh Sách Khám Bệnh";
            this.button_DSKhamBenh.UseVisualStyleBackColor = true;
            this.button_DSKhamBenh.Click += new System.EventHandler(this.button_DSKhamBenh_Click);
            // 
            // Tham_My_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DSKhamBenh);
            this.Controls.Add(this.tBox_TenBenhNhan);
            this.Controls.Add(this.cBox_MaBenhNhan);
            this.Controls.Add(this.label_TenBenhNhan);
            this.Controls.Add(this.label_MaBenhNhan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_HienThiThongTin);
            this.Name = "Tham_My_Vien";
            this.Text = "Thẩm Mỹ Viện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_HienThiThongTin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label_MaBenhNhan;
        private System.Windows.Forms.Label label_TenBenhNhan;
        private System.Windows.Forms.ComboBox cBox_MaBenhNhan;
        private System.Windows.Forms.TextBox tBox_TenBenhNhan;
        private System.Windows.Forms.Button button_DSKhamBenh;
    }
}

