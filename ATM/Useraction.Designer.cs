namespace ATM
{
    partial class Useraction
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
            this.btnRuttien = new System.Windows.Forms.Button();
            this.btnVantin = new System.Windows.Forms.Button();
            this.btnChuyentien = new System.Windows.Forms.Button();
            this.btnDoiPIN = new System.Windows.Forms.Button();
            this.btnNaptien = new System.Windows.Forms.Button();
            this.btnHuongdan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRuttien
            // 
            this.btnRuttien.Location = new System.Drawing.Point(12, 64);
            this.btnRuttien.Name = "btnRuttien";
            this.btnRuttien.Size = new System.Drawing.Size(132, 42);
            this.btnRuttien.TabIndex = 0;
            this.btnRuttien.Text = "Rút tiền";
            this.btnRuttien.UseVisualStyleBackColor = true;
            // 
            // btnVantin
            // 
            this.btnVantin.Location = new System.Drawing.Point(498, 64);
            this.btnVantin.Name = "btnVantin";
            this.btnVantin.Size = new System.Drawing.Size(132, 42);
            this.btnVantin.TabIndex = 0;
            this.btnVantin.Text = "Vấn tin tài khoản";
            this.btnVantin.UseVisualStyleBackColor = true;
            // 
            // btnChuyentien
            // 
            this.btnChuyentien.Location = new System.Drawing.Point(12, 143);
            this.btnChuyentien.Name = "btnChuyentien";
            this.btnChuyentien.Size = new System.Drawing.Size(132, 42);
            this.btnChuyentien.TabIndex = 0;
            this.btnChuyentien.Text = "Chuyển tiền";
            this.btnChuyentien.UseVisualStyleBackColor = true;
            // 
            // btnDoiPIN
            // 
            this.btnDoiPIN.Location = new System.Drawing.Point(498, 143);
            this.btnDoiPIN.Name = "btnDoiPIN";
            this.btnDoiPIN.Size = new System.Drawing.Size(132, 42);
            this.btnDoiPIN.TabIndex = 0;
            this.btnDoiPIN.Text = "Đổi mã PIN";
            this.btnDoiPIN.UseVisualStyleBackColor = true;
            // 
            // btnNaptien
            // 
            this.btnNaptien.Location = new System.Drawing.Point(12, 222);
            this.btnNaptien.Name = "btnNaptien";
            this.btnNaptien.Size = new System.Drawing.Size(132, 42);
            this.btnNaptien.TabIndex = 0;
            this.btnNaptien.Text = "Nạp tiền";
            this.btnNaptien.UseVisualStyleBackColor = true;
            // 
            // btnHuongdan
            // 
            this.btnHuongdan.Location = new System.Drawing.Point(498, 222);
            this.btnHuongdan.Name = "btnHuongdan";
            this.btnHuongdan.Size = new System.Drawing.Size(132, 42);
            this.btnHuongdan.TabIndex = 0;
            this.btnHuongdan.Text = "Hướng dẫn";
            this.btnHuongdan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(498, 293);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(132, 42);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblThongtin
            // 
            this.lblThongtin.Location = new System.Drawing.Point(175, 64);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(305, 200);
            this.lblThongtin.TabIndex = 1;
            this.lblThongtin.Text = "Xin chào bạn : ";
            // 
            // Useraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 364);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuongdan);
            this.Controls.Add(this.btnDoiPIN);
            this.Controls.Add(this.btnVantin);
            this.Controls.Add(this.btnNaptien);
            this.Controls.Add(this.btnChuyentien);
            this.Controls.Add(this.btnRuttien);
            this.Name = "Useraction";
            this.Text = "Useraction";
            this.Load += new System.EventHandler(this.Useraction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRuttien;
        private System.Windows.Forms.Button btnVantin;
        private System.Windows.Forms.Button btnChuyentien;
        private System.Windows.Forms.Button btnDoiPIN;
        private System.Windows.Forms.Button btnNaptien;
        private System.Windows.Forms.Button btnHuongdan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblThongtin;
    }
}