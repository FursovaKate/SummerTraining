using System.Text;
using System.Text.RegularExpressions;
using NLog;
using System;

namespace UrlParamsEditor
{
    public static class UrlHelper
    {
        public static string AddOrChangeUrlParameter(string url, string parameter)
        {
            try
            {
                CheckInput(url);
                CheckUrl(url);

                CheckInput(parameter);
                CheckParameters(parameter);
            }
            catch (Exception e)
            {
                throw e;
            }
           
            var constructedUrl = new StringBuilder(url);
            if (url.IndexOf("?") > 0)
            {
                var urlParams = url.Split('?')[1];
                var inputKeyParameter = parameter.Split('=')[0];
                var inputValueParameter = parameter.Split('=')[1];
                if (urlParams.IndexOf(inputKeyParameter) >= 0)
                {
                    var keyParameterIndex = urlParams.IndexOf(inputKeyParameter) + inputKeyParameter.Length;

                    var searchKey = urlParams.Substring(keyParameterIndex, inputKeyParameter.Length);
                    var valueParameterIndex =
                        urlParams.Substring(keyParameterIndex + 1, (urlParams.Length - searchKey.Length - 1));
                    var newUrlParams = Regex.Replace(urlParams, valueParameterIndex, inputValueParameter);
                    constructedUrl.Replace(urlParams, newUrlParams);
                }
                else
                {
                    constructedUrl.Append("&" + parameter);
                }
            }
            else
            {
                constructedUrl.Append("?" + parameter);
            }
            return constructedUrl.ToString();
        }

        public static bool CheckUrl(string url)
        {
            var urlPattern = @"www.\w.\w";
            var match = Regex.IsMatch(url, urlPattern, RegexOptions.IgnoreCase);
            if (!match)
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("Url is incorrect");
                return false;
            }
            return true;
        }

        public static bool CheckParameters(string parameter)
        {
            var paramsPattern = @"\w=\w";
            var match = Regex.IsMatch(parameter, paramsPattern, RegexOptions.IgnoreCase);
            if (!match)
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("Parameter  is incorrect");
                return false;
            }

            return true;
        }

        private static void CheckInput(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("String is empty");
                Console.WriteLine("String is empty");
            }
        }
    }
}