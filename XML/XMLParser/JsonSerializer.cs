using System;
using Newtonsoft.Json;

namespace XMLParser
{
    public static class JsonSerializer
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static string Serialize(SolarSystem input)
        {
            if (input == null)
            {
                logger.Error("input is empty");
            }
            try
            {
                return JsonConvert.SerializeObject(input);
            }
            catch (JsonException e)
            {
                logger.Error("Cannot serialize object: \n" + e);
                return "";
            }
        }
    }
}
