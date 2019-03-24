using System.Xml.Serialization;

namespace XMLParser
{
    public class Planet
    {
        [XmlAttribute("distance")]
        public string Distance { get; set; }
        [XmlElement("name")]
        public Name Name { get; set; }
    }
}
