using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLParser
{
    [XmlRoot("planets")]
    public class SolarSystem
    {
        [XmlElement("planet")]
        public List<Planet> Planet { get; set; }
    }
}
