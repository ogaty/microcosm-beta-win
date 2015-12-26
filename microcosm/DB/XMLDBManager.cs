using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Collections;

namespace microcosm.DB
{
    public class XMLDBManager : DBManager
    {
        protected new List<UserDir> ulist;
        private XmlDocument xml;

        public XMLDBManager(string xmlFile)
        {
            ulist = new List<UserDir>();
            xml = new XmlDocument();
            xml.Load(xmlFile);
        }

        public new List<UserDir> getObject()
        {

            XmlNodeList nodedata = xml.SelectNodes("userdata");
            XmlNode nodes = nodedata[0];

            foreach (XmlNode dirnode in nodes)
            {
                UserDir dir = new UserDir();
                dir.dir = dirnode.Name;
                dir.data = new ArrayList();

                if (dirnode.ChildNodes != null)
                {
                    foreach (XmlNode usernode in dirnode)
                    {
                        UserData udata = new UserData();
                        foreach (XmlNode userdetailnode in usernode)
                        {
                            switch (userdetailnode.Name)
                            {
                                case "name":
                                    udata.name = userdetailnode.InnerText;
                                    break;
                                case "furigana":
                                    udata.furigana = userdetailnode.InnerText;
                                    break;
                                case "birth_year":
                                    udata.birth_year = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_month":
                                    udata.birth_month = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_day":
                                    udata.birth_day = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_hour":
                                    udata.birth_hour = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_minute":
                                    udata.birth_minute = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_seconde":
                                    udata.birth_second = int.Parse(userdetailnode.InnerText);
                                    break;
                                case "birth_place":
                                    udata.birth_place = userdetailnode.InnerText;
                                    break;
                                case "lat":
                                    udata.lat = double.Parse(userdetailnode.InnerText);
                                    break;
                                case "lng":
                                    udata.lng = double.Parse(userdetailnode.InnerText);
                                    break;
                                case "memo":
                                    udata.memo = userdetailnode.InnerText;
                                    break;
                                case "timezone":
                                    udata.timezone = double.Parse(userdetailnode.InnerText);
                                    break;

                            }
                        }
                        dir.data.Add(udata);
                    }
                }
                ulist.Add(dir);
            }


            return ulist;
        }

    }
}
