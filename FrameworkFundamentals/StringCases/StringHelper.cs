using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using NLog;

namespace StringCases
{
    public static class StringHelper
    {
        public static string ConvertToStringCase(string inputString, string exceptionalWords = null)
        {
            var culture = new CultureInfo("en-US", false).TextInfo;
            var resultString = culture.ToTitleCase(inputString.ToLower());

            if (exceptionalWords != null)
            {
                var exceptionalWordsArray = exceptionalWords.Split(' ').ToArray();
                for (var i = 0; i < exceptionalWordsArray.Length; i++)
                {
                    resultString = Regex.Replace(resultString, exceptionalWordsArray[i], culture.ToLower(exceptionalWordsArray[i]), RegexOptions.IgnoreCase);
                }
            }

            var logger = LogManager.GetCurrentClassLogger();
            logger.Info("No exceptional words were entered");

            resultString = culture.ToTitleCase(resultString.Remove(1)) + resultString.Substring(1);
            
            return resultString;
        }
    }
}
