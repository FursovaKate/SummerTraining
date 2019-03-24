using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueImplementation
{
    public class Iterator : ISetIterator
    {
        private List<int> list;
        private int elementPosition;

        public Iterator(List<int> inputList, int inputPosition)
        {
            list = inputList;
            elementPosition = inputPosition;
        }

        public int GetNext()
        {
            try
            {
                SetHelper.CheckIfInt(elementPosition);

            }
            catch (Exception e)
            {
                throw e;
            }
            return list.ElementAt(elementPosition + 1);
        }

        public int GetPrevious()
        {
            try
            {
                SetHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }
            return list.ElementAt(elementPosition - 1);
        }

        public int CountElements()
        {
            try
            {
                SetHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }
            return list.Count;
        }

        public void AddElement(int numberToAdd)
        {
            try
            {
                SetHelper.CheckIfInt(elementPosition);
                SetHelper.CheckUnique(numberToAdd, list);

            }
            catch (Exception e)
            {
                throw e;
            }
            list.Add(numberToAdd);
        }

        public void RemoveElement(int elementPosition)
        {
            try
            {
                SetHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }
            list.Remove(list.ElementAt(elementPosition));
        }


    }
}
