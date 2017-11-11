﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ATM
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
            

         }
       
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

        private void dangnhap_Load(object sender, EventArgs e)
        {
            DeSerializeAdmin();
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

        private void bnt_ok_Click(object sender, EventArgs e)
        {

        }
    }

        
}