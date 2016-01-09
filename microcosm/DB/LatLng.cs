using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.DB
{
    public class LatLng
    {
        public string addr;
        public double lat;
        public double lng;

        public LatLng(string addr, double lat, double lng)
        {
            this.addr = addr;
            this.lat = lat;
            this.lng = lng;
        }
    }
}
