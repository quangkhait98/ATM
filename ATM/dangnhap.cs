using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ATM
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            SerializeToAdmin();
            DeSerializeAdmin();

         }
        List<Admin> listadmin= new List<Admin>();
       void SerializeToAdmin()
        {
            Admin adm = new Admin();
            XmlSerializer seri = new XmlSerializer(typeof(Admin));
            StreamWriter sw = new StreamWriter(new FileStream("ADMIN", FileMode.Create));
            seri.Serialize(sw, adm);
            sw.Close();
        }
        void DeSerializeAdmin()
        {
            Admin adm = new Admin();
            XmlSerializer seri = new XmlSerializer(typeof(Admin));
            StreamReader Rw = new StreamReader(new FileStream("ADMIN", FileMode.Open));
            adm=(Admin)seri.Deserialize(Rw);
            Rw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tkadm.Text==)
        }
    }

        
}
