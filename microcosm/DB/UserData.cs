using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm
{
    public class UserData
    {
        public int no { get; set; }
        public string name { get; set; }
        public string furigana { get; set; }
        public int birth_year { get; set; }
        public int birth_month { get; set; }
        public int birth_day { get; set; }
        public int birth_hour { get; set; }
        public int birth_minute { get; set; }
        public int birth_second { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string birth_place { get; set; }
        public string memo { get; set; }
        public int timezone { get; set; }

        public UserData()
        {

        }

        public void setData(
            int no,
            string name,
            string furigana,
            int birth_year,
            int birth_month,
            int birth_day,
            int birth_hour,
            int birth_minute,
            int birth_second,
            string lat,
            string lng,
            string birth_place,
            string memo,
            int timezone
            )
        {
            this.no = no;
            this.name = name;
            this.furigana = furigana;
            this.birth_year = birth_year;
            this.birth_month = birth_month;
            this.birth_day = birth_day;
            this.birth_hour = birth_hour;
            this.birth_minute = birth_minute;
            this.birth_second = birth_second;
            this.lat = lat;
            this.lng = lng;
            this.birth_place = birth_place;
            this.memo = memo;
            this.timezone = timezone;
        }
    }
}
