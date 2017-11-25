using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Useraction : Form
    {
        public string Languages;
        public Useraction()
        {
            InitializeComponent();
        }

        private void Useraction_Load(object sender, EventArgs e)
        {

        }
        public void SetLanguages(string cultureName)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("ATM.Lang.MyResource", typeof(dangnhap).Assembly);
            btnChuyentien.Text = rm.GetString("chuyentien", culture);
            btnDoiPIN.Text = rm.GetString("doiPIN", culture);
            btnHuongdan.Text = rm.GetString("huongdan", culture);
            btnNaptien.Text = rm.GetString("naptien", culture);
            btnRuttien.Text = rm.GetString("ruttien", culture);
            btnThoat.Text = rm.GetString("thoat", culture);
            btnVantin.Text = rm.GetString("vantin", culture);
        }

        private void btnDoiPIN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMK dmk = new DoiMK();
            dmk.Show();
        }
    }
}
