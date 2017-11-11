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
    public partial class AddAccount : Form
    {
        public string Languages;
        UsersManager usermg;
        public AddAccount()
        {
            InitializeComponent();
            usermg = new UsersManager();
            usermg.Deserialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users(Convert.ToInt32(txtid.Text), txtname.Text, txtusername.Text, txtpin.Text, Convert.ToInt32(txtage.Text), (float)Convert.ToDouble(txtbalance.Text));
            usermg.Items.Add(user);
            usermg.Serialize();
            Console.WriteLine("aaaaa");
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }

        public void SetLanguages(string cultureName)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("ATM.Lang.MyResource", typeof(MainAdmin).Assembly);
            lblChutk.Text = rm.GetString("accountholder", culture);
            lblTentk.Text = rm.GetString("accountname", culture);
            lbbalance.Text = rm.GetString("balance", culture);
            lbid.Text = rm.GetString("id", culture);
            lbpin.Text = rm.GetString("pin", culture);
        }
    }
}
