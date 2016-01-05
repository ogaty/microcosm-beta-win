using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace microcosm.DB
{
    public class UserEvent
    {
        [XmlElement("event_name")]
        public string event_name;
        [XmlElement("event_year")]
        public int event_year;
        [XmlElement("event_month")]
        public int event_month;
        [XmlElement("event_day")]
        public int event_day;
        [XmlElement("event_hour")]
        public int event_hour;
        [XmlElement("event_minute")]
        public int event_minute;
        [XmlElement("event_second")]
        public int event_second;
        [XmlElement("event_place")]
        public string event_place;
        [XmlElement("event_lat")]
        public double event_lat;
        [XmlElement("event_lng")]
        public double event_lng;
        [XmlElement("event_timezone")]
        public string event_timezone;
        [XmlElement("event_memo")]
        public string event_memo;
    }
}
