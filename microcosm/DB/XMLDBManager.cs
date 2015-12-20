using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace microcosm.DB
{
    class XMLDBManager : DBManager
    {
        private List<UserData> ulist;

        public XMLDBManager(string xmlFile)
        {
            ulist = new List<UserData>();
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlFile);

            XmlNodeList nodelist = xml.SelectNodes("userdata");


        }
    }
}
