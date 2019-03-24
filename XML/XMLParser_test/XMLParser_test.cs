using XMLParser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace XMLParser_test
{
    [TestClass]
    public class JsonSerializerTest
    {
        string output = @"output.xml";
        [TestMethod]
        public void SerializeTest()
        {
            var deserializedXml = XmlDeserializer.Deserialize(output);
            var actual = JsonSerializer.Serialize(deserializedXml);
            var expected = "{\"Planet\":[{\"Distance\":\"1\",\"Name\":{\"Region\":\"Inner Solar System\"}},{\"Distance\":\"2\",\"Name\":{\"Region\":\"Inner Solar System\"}},{\"Distance\":\"3\",\"Name\":{\"Region\":\"Inner Solar System\"}},{\"Distance\":\"4\",\"Name\":{\"Region\":\"Inner Solar System\"}},{\"Distance\":\"5\",\"Name\":{\"Region\":\"Outer Solar System\"}},{\"Distance\":\"6\",\"Name\":{\"Region\":\"Outer Solar System\"}},{\"Distance\":\"7\",\"Name\":{\"Region\":\"Outer Solar System\"}},{\"Distance\":\"8\",\"Name\":{\"Region\":\"Outer Solar System\"}}]}";
            Assert.AreEqual(expected, actual);
        }
    }
}
