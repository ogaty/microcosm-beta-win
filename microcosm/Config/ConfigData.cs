using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace microcosm.Config
{
    public enum ECentric
    {
        GEO_CENTRIC = 0,
        HERIO_SENCTRIC = 1
    }
    public class ConfigData
    {
        public ECentric centric { get; set; }

        public ConfigData()
        {
            centric = ECentric.GEO_CENTRIC;
        }

    }
}
