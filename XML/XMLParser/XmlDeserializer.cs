using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XMLParser
{
    public static class XmlDeserializer
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static SolarSystem Deserialize(string outputFile)
        {
            var planets = new SolarSystem();
            if (File.Exists(outputFile))
            {
                var serializer = new XmlSerializer(typeof(SolarSystem));
                using (var output = new StreamReader(outputFile))
                {
                    try
                    {
                        planets = (SolarSystem)serializer.Deserialize(output);
                    }
                    catch (XmlException e)
                    {
                        logger.Error("Deserialize error: \n" + e);
                    }
                }
            }
            else
            {
                logger.Error("File does not exist");
            }
            return planets;
        }
    }
}
