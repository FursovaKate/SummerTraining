using System.Xml.Serialization;

namespace XMLParser
{
    public class Name
    {
        [XmlAttribute("region")]
        public string Region { get; set; }
    }
}
