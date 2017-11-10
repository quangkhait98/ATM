using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ATM
{
    class UsersManager
    {
        static string dataPath = "users.xml";

        UsersList items;

        public UsersList Items
        {
            get { return items; }
            set { items = value; }
        }

        public UsersManager()
        {
            //items = new UsersList();
            Deserialize();
        }

        public void Serialize()
        {
            SerializeToXML(items, dataPath);
        }

        public void Deserialize()
        {
            items = (UsersList)DeserializeFromXML(dataPath);
            if (items == null)
                items = new UsersList();
        }

        public void SerializeToXML(object data, string filePath)
        {
            FileStream fs;
            FileInfo f = new FileInfo(filePath);
            if (f.Exists)
            {
                fs = new FileStream(filePath, FileMode.Truncate, FileAccess.ReadWrite);
            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            XmlSerializer sr = new XmlSerializer(typeof(UsersList));
            sr.Serialize(fs, data);
            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(UsersList));
            try
            {
                object obj = sr.Deserialize(fs);
                fs.Close();
                return obj;
            }
            catch (System.InvalidOperationException)
            {
                fs.Close();
                return null;
            }
        }
    }
}

