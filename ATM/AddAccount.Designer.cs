namespace ATM
{
    partial class AddAccount
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
            System.Windows.Forms.Label lbage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.lbid = new System.Windows.Forms.Label();
            this.lbpin = new System.Windows.Forms.Label();
            this.lbbalance = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblChutk = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTentk = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            lbage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbage
            // 
            lbage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            lbage.Location = new System.Drawing.Point(88, 83);
            lbage.Name = "lbage";
            lbage.Size = new System.Drawing.Size(100, 23);
            lbage.TabIndex = 8;
            lbage.Text = "Nhập Tuổi :";
            lbage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbid
            // 
            this.lbid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbid.Location = new System.Drawing.Point(88, 144);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(100, 23);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "Nhập Mã Số Tài Khoản";
            this.lbid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbpin
            // 
            this.lbpin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbpin.Location = new System.Drawing.Point(88, 176);
            this.lbpin.Name = "lbpin";
            this.lbpin.Size = new System.Drawing.Size(100, 23);
            this.lbpin.TabIndex = 1;
            this.lbpin.Text = "Nhập Mã Pin :";
            this.lbpin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbbalance
            // 
            this.lbbalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbbalance.Location = new System.Drawing.Point(88, 208);
            this.lbbalance.Name = "lbbalance";
            this.lbbalance.Size = new System.Drawing.Size(100, 23);
            this.lbbalance.TabIndex = 2;
            this.lbbalance.Text = "Nhập Số Tiền :";
            this.lbbalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(226, 144);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(123, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtpin
            // 
            this.txtpin.Location = new System.Drawing.Point(226, 176);
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(123, 20);
            this.txtpin.TabIndex = 4;
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(226, 208);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(123, 20);
            this.txtbalance.TabIndex = 5;
            // 
            // lblChutk
            // 
            this.lblChutk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblChutk.Location = new System.Drawing.Point(54, 57);
            this.lblChutk.Name = "lblChutk";
            this.lblChutk.Size = new System.Drawing.Size(134, 23);
            this.lblChutk.TabIndex = 6;
            this.lblChutk.Text = "Nhập Tên Chủ Tài Khoản :";
            this.lblChutk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(226, 60);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(123, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(226, 86);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(123, 20);
            this.txtage.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblTentk
            // 
            this.lblTentk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTentk.Location = new System.Drawing.Point(57, 113);
            this.lblTentk.Name = "lblTentk";
            this.lblTentk.Size = new System.Drawing.Size(131, 23);
            this.lblTentk.TabIndex = 12;
            this.lblTentk.Text = "Nhập Tên Tài Khoản :";
            this.lblTentk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(226, 113);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(123, 20);
            this.txtusername.TabIndex = 13;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 341);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblTentk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(lbage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblChutk);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txtpin);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbbalance);
            this.Controls.Add(this.lbpin);
            this.Controls.Add(this.lbid);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbpin;
        private System.Windows.Forms.Label lbbalance;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpin;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblChutk;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTentk;
        private System.Windows.Forms.TextBox txtusername;
    }
}