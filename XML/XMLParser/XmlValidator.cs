using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using static System.Xml.Schema.XmlSeverityType;

namespace XMLParser
{
    public static class XmlValidator
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void CreateSchema(string input, string name, string planetsXsd)
        {
            if (File.Exists(input) && File.Exists(planetsXsd) && name != null)
            {
                try
                {
                    var planetInfo = new XmlReaderSettings();
                    planetInfo.Schemas.Add(input, planetsXsd);
                    planetInfo.ValidationType = ValidationType.Schema;
                    planetInfo.ValidationEventHandler += PlanetsDataValidate;
                    var planets = XmlReader.Create(name, planetInfo);
                    planets.Read();
                }
                catch (Exception e)
                {
                    logger.Error("Validation error: \n" + e);
                }
            }
            else
            {
                logger.Error("File does not resist or name is empty");

            }

        }

        public static void PlanetsDataValidate(object input, ValidationEventArgs error)
        {
            if (error.Severity == Warning || error.Severity == Error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}