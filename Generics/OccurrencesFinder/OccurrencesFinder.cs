using System.Collections.Generic;

namespace OccurrencesFinder
{
    public static class OccurrencesFinder
    {
        public static int FindOccurences(List<string> inputList, string inputToFind)
        {
            var occurences = new List<string>();
            foreach (var item in inputList)
            {
                if (item == inputToFind)
                {
                    occurences.Add(item);
                }
            }
            return occurences.Count;
        }
    }
}
