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

            // <userdata><dir>を探す
            foreach (XmlNode dirnode in nodes)
            {
                UserDir dir = new UserDir();
                dir.dir = ((XmlElement)dirnode).GetAttribute("name");
                dir.data = new ArrayList();

                if (dir.dir == "")
                {
                    // magic name
                    dir.dir = "__nodir";
                }

                // 子供があれば
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
                                    udata.timezone = userdetailnode.InnerText;
                                    break;
                                case "eventlist":
                                    // userdetailnode.Value = <eventlist>
                                    List<UserEvent> usereventlist = new List<UserEvent>();
                                    foreach (XmlNode eventlist in userdetailnode)
                                    {
                                        // eventlist.Value = <event>
                                        UserEvent userevent = new UserEvent();
                                        foreach (XmlNode eventnode in eventlist)
                                        {
                                            // eventnode.Value = <event_name>
                                            switch (eventnode.Name)
                                            {
                                                case "event_name":
                                                    userevent.event_name = eventnode.InnerText;
                                                    break;
                                                case "event_detail":
                                                    if (eventnode.FirstChild != null)
                                                    {
                                                        userevent.event_detail = true;
                                                        foreach (XmlNode eventdetail in eventnode)
                                                        {
                                                            switch (eventdetail.Name)
                                                            {
                                                                case "event_year":
                                                                    userevent.event_year = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_month":
                                                                    userevent.event_month = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_day":
                                                                    userevent.event_day = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_hour":
                                                                    userevent.event_hour = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_minute":
                                                                    userevent.event_minute = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_second":
                                                                    userevent.event_second = int.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_place":
                                                                    userevent.event_place = eventdetail.InnerText;
                                                                    break;
                                                                case "event_lat":
                                                                    userevent.event_lat = double.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_lng":
                                                                    userevent.event_lng = double.Parse(eventdetail.InnerText);
                                                                    break;
                                                                case "event_timezone":
                                                                    userevent.event_timezone = eventdetail.InnerText;
                                                                    break;
                                                                case "event_memo":
                                                                    userevent.event_memo = eventdetail.InnerText;
                                                                    break;
                                                            }
                                                        }
                                                    } else
                                                    {
                                                        userevent.event_detail = false;
                                                    }
                                                    break;
                                            }
                                        }
                                        usereventlist.Add(userevent);
                                    }
                                    udata.userevent = usereventlist;
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
