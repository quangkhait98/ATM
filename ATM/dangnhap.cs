using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ATM
{
    public partial class dangnhap : Form
    {
        public string Languages;
        public dangnhap()
        {
            InitializeComponent();


        }

        void SerializeToAdmin()
        {
            Admin adm = new Admin();
            XmlSerializer seri = new XmlSerializer(typeof(Admin));
            StreamWriter sw = new StreamWriter(new FileStream("Admin", FileMode.Create));
            seri.Serialize(sw, adm);
            sw.Close();
        }
        void DeSerializeAdmin()
        {
            Admin adm = new Admin();
            XmlSerializer seri = new XmlSerializer(typeof(Admin));
            StreamReader Rw = new StreamReader(new FileStream("Admin", FileMode.Open));
            adm = (Admin)seri.Deserialize(Rw);
            Rw.Close();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            SerializeToAdmin();
        }

        private void btn_adok_Click_1(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            FileStream fs = new FileStream("Admin", FileMode.Open, FileAccess.Read);
            doc.Load(fs);
            foreach (XmlNode node in doc.SelectNodes("Admin"))
            {
                string taikhoan = node.SelectSingleNode("tk").InnerText;
                string Pass = node.SelectSingleNode("pass").InnerText;
                if (taikhoan.Equals(tkadm.Text) && Pass.Equals(mkadm.Text))
                {
                    this.Hide();
                    
                    MainAdmin madm = new MainAdmin();
                    madm.Languages = Languages;
                    madm.SetLanguages(Languages);
                    madm.Show();
                }
                else
                {
                    MessageBox.Show("nhap lai");
                    tkadm.Clear();
                    tkadm.Focus();
                    mkadm.Clear();
                }
            }
        }

        public void SetLanguages(string cultureName)
        {
            CultureInfo culture;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("ATM.Lang.MyResource", typeof(dangnhap).Assembly);
            lblMatk.Text = rm.GetString("id", culture);
            lblMaPIN.Text = rm.GetString("pin", culture);
            lblTKadmin.Text = rm.GetString("account", culture);
            lblMKadmin.Text = rm.GetString("password", culture);
        }

        private void bnt_ok_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            XmlDocument doc = new XmlDocument();
            FileStream bs = new FileStream("users.xml", FileMode.Open, FileAccess.Read);
            doc.Load(bs);
            foreach (XmlNode node in doc.SelectNodes("users.xml"))
            {
                string mataikhoan = node.SelectSingleNode("Username").InnerText;
                string Pin = node.SelectSingleNode("Password").InnerText;
                if (mataikhoan.Equals(matkcus.Text) && Pin.Equals(mapincus.Text))
                {
                    MessageBox.Show("s");
                }
                else
                {
                    MessageBox.Show("tai khoan hoac mat khau sai. xin nhap lai...!!!");
                    matkcus.Clear();
                    mapincus.Clear();
                }
            }
//=======
//            //XmlDocument doc = new XmlDocument();
//            //FileStream fs = new FileStream("User", FileMode.Open, FileAccess.Read);
//            //doc.Load(fs);
//            //foreach (XmlNode node in doc.SelectNodes("User"))
//            //{
//            //    string taikhoan = node.SelectSingleNode("tk").InnerText;
//            //    string Pass = node.SelectSingleNode("pass").InnerText;
//            //    if (taikhoan.Equals(tkadm.Text) && Pass.Equals(mkadm.Text))
//            //    {
//                    this.Hide();

//                    Useraction madm2 = new Useraction();
//                    madm2.Languages = Languages;
//                    madm2.SetLanguages(Languages);
//                    madm2.Show();
//            //    }
//            //    else
//            //    {
//            //        MessageBox.Show("nhap lai");
//            //        tkadm.Clear();
//            //        tkadm.Focus();
//            //        mkadm.Clear();
//            //    }
//            //}
//>>>>>>> phuc
//        }

    }
}      

