using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Serialization;
using System.IO;

namespace microcosm.DB
{
    public class XMLDBManager : DBManager
    {
        private string xmlFile;

        public XMLDBManager(string xmlFile)
        {
            this.xmlFile = xmlFile;
        }

        public new UserData getObject()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserData));
            FileStream fs = new FileStream(xmlFile, FileMode.Open);
            UserData udata = (UserData)serializer.Deserialize(fs);
            fs.Close();

            return udata;
        }

    }
}
