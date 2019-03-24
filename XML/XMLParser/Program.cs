using System;
using System.Xml;

namespace XMLParser
{
    class Program
    {
        private const string planetsName = "Planets.xml";
        const string input = @planetsName;
        const string output = @"Output.xml";
        const string transformationSchema = @"Transformation.xslt";
        private const string planetsXsd = "Planets.xsd";

        static void Main()
        {
            XmlValidator.CreateSchema(input, planetsName, planetsXsd);
            XsltConverter.Convert(transformationSchema, input, output);
            var deserializedXml = XmlDeserializer.Deserialize(output);
            var serializedJson = JsonSerializer.Serialize(deserializedXml);
            Console.Write(serializedJson);
        }
    }
}
