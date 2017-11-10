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
        public Language()
        {
            InitializeComponent();
        }

        private void Tviet_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap dn = new dangnhap();
            dn.Show();
            
        }

    }
}
