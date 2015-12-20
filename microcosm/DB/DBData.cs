using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm
{
    public class DBData
    {
        private int no;
        private string name;
        private string furigana;
        private string birthday;
        private string lat;
        private string lng;
        private string birth_place;
        private string memo;
        private int jisa;

        public DBData()
        {

        }

        public void setData(
            int no,
            string name,
            string furigana,
            string birthday,
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
            this.birthday = birthday;
            this.lat = lat;
            this.lng = lng;
            this.birth_place = birth_place;
            this.memo = memo;
            this.jisa = jisa;
        }
    }
}
