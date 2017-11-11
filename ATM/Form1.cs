using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Language : Form
    {
        public string Languages;
        public Language()
        {
            InitializeComponent();
        }

        private void Tviet_Click(object sender, EventArgs e)
        {
            Languages = "vi-US";
            this.Hide();
            dangnhap dn = new dangnhap();
            dn.Languages = this.Languages;
            dn.SetLanguages(Languages);
            dn.Show();
            
        }

        private void english_Click(object sender, EventArgs e)
        {
            Languages = "en-US";
            this.Hide();
            dangnhap dn = new dangnhap();
            dn.Languages = this.Languages;
            dn.SetLanguages(Languages);
            dn.Show();
        }
    }
}
