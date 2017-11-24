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
    public partial class MainAdmin : Form
    {
        public string Languages;
        public MainAdmin()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccount addacc = new AddAccount();
            addacc.Languages = Languages;
            addacc.SetLanguages(Languages);
            addacc.Show();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }
        public void SetLanguages(string cultureName)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("ATM.Lang.MyResource", typeof(MainAdmin).Assembly);
            btnChangeBalane.Text= rm.GetString("changebalance", culture);
            btnChangPIN.Text= rm.GetString("changepin", culture);
            btnCreatnew.Text= rm.GetString("creatnew", culture);
            btnHisTran.Text= rm.GetString("tranhis", culture);
            btnListUser.Text= rm.GetString("listaccount", culture);
            btnPINreisuse.Text= rm.GetString("pinreisue", culture);
        }
    }
}
