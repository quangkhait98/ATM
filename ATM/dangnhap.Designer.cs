﻿namespace ATM
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.tabctrKH = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.bnt_ok = new System.Windows.Forms.Button();

            this.mapincus = new System.Windows.Forms.TextBox();
            this.matkcus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMaPIN = new System.Windows.Forms.Label();
            this.lblMatk = new System.Windows.Forms.Label();

            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_adok = new System.Windows.Forms.Button();
            this.mkadm = new System.Windows.Forms.TextBox();
            this.tkadm = new System.Windows.Forms.TextBox();
            this.lblMKadmin = new System.Windows.Forms.Label();
            this.lblTKadmin = new System.Windows.Forms.Label();
            this.tabctrKH.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrKH
            // 
            this.tabctrKH.Controls.Add(this.tabPage1);
            this.tabctrKH.Controls.Add(this.tabPage2);
            this.tabctrKH.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabctrKH.Location = new System.Drawing.Point(0, 1);
            this.tabctrKH.Name = "tabctrKH";
            this.tabctrKH.SelectedIndex = 0;
            this.tabctrKH.Size = new System.Drawing.Size(573, 405);
            this.tabctrKH.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.bnt_cancel);
            this.tabPage1.Controls.Add(this.bnt_ok);

            this.tabPage1.Controls.Add(this.mapincus);
            this.tabPage1.Controls.Add(this.matkcus);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);

            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblMaPIN);
            this.tabPage1.Controls.Add(this.lblMatk);

            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.Location = new System.Drawing.Point(461, 289);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bnt_cancel.TabIndex = 5;
            this.bnt_cancel.Text = "CANCEL";
            this.bnt_cancel.UseVisualStyleBackColor = true;
            // 
            // bnt_ok
            // 
            this.bnt_ok.Location = new System.Drawing.Point(340, 289);
            this.bnt_ok.Name = "bnt_ok";
            this.bnt_ok.Size = new System.Drawing.Size(75, 23);
            this.bnt_ok.TabIndex = 4;
            this.bnt_ok.Text = "OK";
            this.bnt_ok.UseVisualStyleBackColor = true;
            this.bnt_ok.Click += new System.EventHandler(this.bnt_ok_Click);
            // 
            // mapincus
            // 
            this.mapincus.Location = new System.Drawing.Point(381, 245);
            this.mapincus.Name = "mapincus";
            this.mapincus.Size = new System.Drawing.Size(128, 20);
            this.mapincus.TabIndex = 3;
            this.mapincus.UseSystemPasswordChar = true;
            // 
            // matkcus
            // 
            this.matkcus.Location = new System.Drawing.Point(381, 196);
            this.matkcus.Name = "matkcus";
            this.matkcus.Size = new System.Drawing.Size(128, 20);
            this.matkcus.TabIndex = 2;
            this.matkcus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaPIN
            // 
            this.lblMaPIN.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMaPIN.Location = new System.Drawing.Point(275, 242);
            this.lblMaPIN.Name = "lblMaPIN";
            this.lblMaPIN.Size = new System.Drawing.Size(100, 23);
            this.lblMaPIN.TabIndex = 1;
            this.lblMaPIN.Text = "Nhập Mã Pin :";
            this.lblMaPIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatk
            // 
            this.lblMatk.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMatk.Location = new System.Drawing.Point(245, 196);
            this.lblMatk.Name = "lblMatk";
            this.lblMatk.Size = new System.Drawing.Size(130, 23);
            this.lblMatk.TabIndex = 0;
            this.lblMatk.Text = "Mã Tài Khoản :";
            this.lblMatk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btn_adok);
            this.tabPage2.Controls.Add(this.mkadm);
            this.tabPage2.Controls.Add(this.tkadm);
            this.tabPage2.Controls.Add(this.lblMKadmin);
            this.tabPage2.Controls.Add(this.lblTKadmin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Admin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_adok
            // 
            this.btn_adok.Location = new System.Drawing.Point(342, 287);
            this.btn_adok.Name = "btn_adok";
            this.btn_adok.Size = new System.Drawing.Size(75, 23);
            this.btn_adok.TabIndex = 4;
            this.btn_adok.Text = "OK";
            this.btn_adok.UseVisualStyleBackColor = true;
            this.btn_adok.Click += new System.EventHandler(this.btn_adok_Click_1);
            // 
            // mkadm
            // 
            this.mkadm.Location = new System.Drawing.Point(390, 226);
            this.mkadm.Name = "mkadm";
            this.mkadm.PasswordChar = '*';
            this.mkadm.Size = new System.Drawing.Size(128, 20);
            this.mkadm.TabIndex = 3;
            this.mkadm.UseSystemPasswordChar = true;
            // 
            // tkadm
            // 
            this.tkadm.Location = new System.Drawing.Point(390, 177);
            this.tkadm.Name = "tkadm";
            this.tkadm.Size = new System.Drawing.Size(128, 20);
            this.tkadm.TabIndex = 2;
            this.tkadm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMKadmin
            // 
            this.lblMKadmin.Location = new System.Drawing.Point(278, 223);
            this.lblMKadmin.Name = "lblMKadmin";
            this.lblMKadmin.Size = new System.Drawing.Size(100, 23);
            this.lblMKadmin.TabIndex = 1;
            this.lblMKadmin.Text = "Mật Khẩu :";
            this.lblMKadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTKadmin
            // 
            this.lblTKadmin.Location = new System.Drawing.Point(278, 174);
            this.lblTKadmin.Name = "lblTKadmin";
            this.lblTKadmin.Size = new System.Drawing.Size(106, 23);
            this.lblTKadmin.TabIndex = 0;
            this.lblTKadmin.Text = "Tài Khoản :";
            this.lblTKadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 405);
            this.Controls.Add(this.tabctrKH);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            this.tabctrKH.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrKH;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_adok;
        private System.Windows.Forms.TextBox mkadm;
        private System.Windows.Forms.TextBox tkadm;
        private System.Windows.Forms.Label lblMKadmin;
        private System.Windows.Forms.Label lblTKadmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.Button bnt_ok;

        private System.Windows.Forms.TextBox mapincus;
        private System.Windows.Forms.TextBox matkcus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMaPIN;
        private System.Windows.Forms.Label lblMatk;

    }
}