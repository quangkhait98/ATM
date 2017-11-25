using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATM
{
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(dangnhap.truyengt.Mktk==mkcutxt.Text)
            {
                XElement xelement = XElement.Load("users.xml");
               var query = from c in xelement.Elements("Users")
                            where (string)c.Element("Username").Value == dangnhap.truyengt.Mktk
                           select c;
                foreach (XElement Users in query)
                {
                    Users.SetElementValue("Password", mkmoitxt.Text) ;
                }
                xelement.Save("users.xml");

            }
            else
            {
                MessageBox.Show("mat khau cu khong dung");
            }

        }
    }
}
