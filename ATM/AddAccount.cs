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
    public partial class AddAccount : Form
    {
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

      
    }
}
