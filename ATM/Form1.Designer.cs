namespace ATM
{
    partial class Language
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Language));
            this.Tviet = new System.Windows.Forms.Button();
            this.english = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tviet
            // 
            this.Tviet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Tviet.Location = new System.Drawing.Point(392, 186);
            this.Tviet.Name = "Tviet";
            this.Tviet.Size = new System.Drawing.Size(199, 65);
            this.Tviet.TabIndex = 0;
            this.Tviet.Text = "VIETNAMESE";
            this.Tviet.UseVisualStyleBackColor = false;
            this.Tviet.Click += new System.EventHandler(this.Tviet_Click);
            // 
            // english
            // 
            this.english.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.english.Location = new System.Drawing.Point(392, 275);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(199, 65);
            this.english.TabIndex = 1;
            this.english.Text = "ENGLISH";
            this.english.UseVisualStyleBackColor = false;
            // 
            // Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 390);
            this.Controls.Add(this.english);
            this.Controls.Add(this.Tviet);
            this.Name = "Language";
            this.Text = "LANGUAGE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tviet;
        private System.Windows.Forms.Button english;
    }
}

