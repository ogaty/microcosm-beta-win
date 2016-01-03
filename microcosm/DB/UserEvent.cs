using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.DB
{
    public class UserEvent
    {
        public string event_name;
        public bool event_detail;
        public int event_year;
        public int event_month;
        public int event_day;
        public int event_hour;
        public int event_minute;
        public int event_second;
        public string event_place;
        public double event_lat;
        public double event_lng;
        public string event_timezone;
        public string event_memo;
    }
}
