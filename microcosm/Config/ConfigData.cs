using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace microcosm.Config
{
    public enum ECentric
    {
        GEO_CENTRIC = 0,
        HELIO_CENTRIC = 1
    }
    public enum Esidereal
    {
        TROPICAL = 0,
        SIDEREAL = 1
    }
    public class ConfigData
    {
        [XmlElement("ephepath")]
        public string ephepath;
        [XmlElement("centric")]
        public ECentric centric { get; set; }
        [XmlElement("sidereal")]
        public Esidereal sidereal { get; set; }
        [XmlElement("defaultPlace")]
        public string defaultPlace { get; set; }
        [XmlElement("lat")]
        public double lat { get; set; }
        [XmlElement("lng")]
        public double lng { get; set; }

        public ConfigData()
        {
            centric = ECentric.GEO_CENTRIC;
        }

    }
}
