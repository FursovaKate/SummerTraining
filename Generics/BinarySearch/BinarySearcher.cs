using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    public static class BinarySearcher
    {
        public static List<int> SortList(List<int> inputList)
        {
            inputList.Sort();
            return inputList;
        }

        public static int BinarySearch(List<int> sortedList, int numberToSearch)
        {
            return sortedList.ElementAt(sortedList.BinarySearch(numberToSearch));
        }
    }
}
