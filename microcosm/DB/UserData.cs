using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm
{
    public class UserData
    {
        private int no { get; set; }
        private string name { get; set; }
        private string furigana { get; set; }
        private int birth_year { get; set; }
        private int birth_month { get; set; }
        private int birth_day { get; set; }
        private int birth_hour { get; set; }
        private int birth_minute { get; set; }
        private int birth_second { get; set; }
        private string lat { get; set; }
        private string lng { get; set; }
        private string birth_place { get; set; }
        private string memo { get; set; }
        private int jisa { get; set; }

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
            int jisa
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
            this.jisa = jisa;
        }
    }
}
