using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OccurrencesFinder
{
    public static class FileReader
    {
        public static List<string> ReadFile()
        {
            var resultList = new List<string>();
            try
            {
                using (var streamReader = new StreamReader("Text.txt"))
                {
                    var readString = streamReader.ReadToEnd();
                    resultList = readString.Split(' ').ToList();
                    return resultList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                throw e;
            }
        }
    }
}
