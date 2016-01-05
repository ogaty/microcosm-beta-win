using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace microcosm.DB
{
    [XmlRoot("eventlist")]
    public class UserEvents
    {
        [XmlElement("event")]
        public List<UserEvent> events { get; set; }
    }
}
