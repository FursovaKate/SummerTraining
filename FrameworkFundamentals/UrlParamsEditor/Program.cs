using System;

namespace UrlParamsEditor
{
    class Program
    {
        public static void Main()
        {
            string url;
            string parameter;
            do
            {
                Console.WriteLine("Enter url");
                url = Console.ReadLine();
            } while (string.IsNullOrEmpty(url));

            do
            {
                Console.WriteLine("Enter parameter");
                parameter = Console.ReadLine();
            } while (string.IsNullOrEmpty(parameter));

            var resultUrl = UrlHelper.AddOrChangeUrlParameter(url, parameter);

            Console.WriteLine(resultUrl);

            Console.ReadLine();
        }
    }
}
