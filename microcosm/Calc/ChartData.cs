using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Calc
{
    public class ChartData
    {
        public List<PlanetData> planet_list;

        public ChartData()
        {
            planet_list = new List<PlanetData>();

            PlanetData sun = new PlanetData(0);
            PlanetData moon = new PlanetData(1);
            PlanetData mercury = new PlanetData(2);
            PlanetData venus = new PlanetData(3);
            PlanetData mars = new PlanetData(4);
            PlanetData jupiter = new PlanetData(5);
            PlanetData saturn = new PlanetData(6);
            PlanetData uranus = new PlanetData(7);
            PlanetData neptune = new PlanetData(8);
            PlanetData pluto = new PlanetData(9);
            PlanetData asc = new PlanetData(10000);
            PlanetData mc = new PlanetData(10001);
            PlanetData dh = new PlanetData(10002);
        }



    }
}
