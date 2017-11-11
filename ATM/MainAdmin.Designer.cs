namespace ATM
{
    partial class MainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.btnCreatnew = new System.Windows.Forms.Button();
            this.btnChangPIN = new System.Windows.Forms.Button();
            this.btnPINreisuse = new System.Windows.Forms.Button();
            this.btnHisTran = new System.Windows.Forms.Button();
            this.btnChangeBalane = new System.Windows.Forms.Button();
            this.btnListUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreatnew
            // 
            this.btnCreatnew.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreatnew.Location = new System.Drawing.Point(2, 116);
            this.btnCreatnew.Name = "btnCreatnew";
            this.btnCreatnew.Size = new System.Drawing.Size(154, 53);
            this.btnCreatnew.TabIndex = 0;
            this.btnCreatnew.Text = "Tạo Tài Khoản Mới";
            this.btnCreatnew.UseVisualStyleBackColor = false;
            this.btnCreatnew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangPIN
            // 
            this.btnChangPIN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangPIN.Location = new System.Drawing.Point(2, 205);
            this.btnChangPIN.Name = "btnChangPIN";
            this.btnChangPIN.Size = new System.Drawing.Size(154, 53);
            this.btnChangPIN.TabIndex = 1;
            this.btnChangPIN.Text = "Đổi Mật Khẩu";
            this.btnChangPIN.UseVisualStyleBackColor = false;
            // 
            // btnPINreisuse
            // 
            this.btnPINreisuse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPINreisuse.Location = new System.Drawing.Point(2, 302);
            this.btnPINreisuse.Name = "btnPINreisuse";
            this.btnPINreisuse.Size = new System.Drawing.Size(154, 53);
            this.btnPINreisuse.TabIndex = 2;
            this.btnPINreisuse.Text = "Cấp Lại Mật Khẩu";
            this.btnPINreisuse.UseVisualStyleBackColor = false;
            // 
            // btnHisTran
            // 
            this.btnHisTran.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHisTran.Location = new System.Drawing.Point(413, 116);
            this.btnHisTran.Name = "btnHisTran";
            this.btnHisTran.Size = new System.Drawing.Size(154, 53);
            this.btnHisTran.TabIndex = 3;
            this.btnHisTran.Text = "Lịch Sử Giao Dịch";
            this.btnHisTran.UseVisualStyleBackColor = false;
            // 
            // btnChangeBalane
            // 
            this.btnChangeBalane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangeBalane.Location = new System.Drawing.Point(413, 205);
            this.btnChangeBalane.Name = "btnChangeBalane";
            this.btnChangeBalane.Size = new System.Drawing.Size(154, 53);
            this.btnChangeBalane.TabIndex = 4;
            this.btnChangeBalane.Text = "Thay Đổi Số Dư";
            this.btnChangeBalane.UseVisualStyleBackColor = false;
            // 
            // btnListUser
            // 
            this.btnListUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListUser.Location = new System.Drawing.Point(413, 302);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(154, 53);
            this.btnListUser.TabIndex = 5;
            this.btnListUser.Text = "Danh Sách Tài Khoản";
            this.btnListUser.UseVisualStyleBackColor = false;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 368);
            this.Controls.Add(this.btnListUser);
            this.Controls.Add(this.btnChangeBalane);
            this.Controls.Add(this.btnHisTran);
            this.Controls.Add(this.btnPINreisuse);
            this.Controls.Add(this.btnChangPIN);
            this.Controls.Add(this.btnCreatnew);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreatnew;
        private System.Windows.Forms.Button btnChangPIN;
        private System.Windows.Forms.Button btnPINreisuse;
        private System.Windows.Forms.Button btnHisTran;
        private System.Windows.Forms.Button btnChangeBalane;
        private System.Windows.Forms.Button btnListUser;
    }
}