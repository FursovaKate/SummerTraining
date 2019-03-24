using System;
using System.Collections.Generic;
using System.Linq;

namespace StackImplementation
{
    public class Iterator : IStackIterator
    {
        private List<int> stack;
        private int elementPosition;

        public Iterator(List<int> inputStack, int inputPosition)
        {
            stack = inputStack;
            elementPosition = inputPosition;
        }

        public int GetNext()
        {
            try
            {
                StackHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }

            return stack.ElementAt(elementPosition + 1);
        }

        public int GetPrevious()
        {
            try
            {
                StackHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }

            return stack.ElementAt(elementPosition - 1);
        }

        public int CountElements()
        {
            return stack.Count;
        }

        public void AddElement(int input)
        {
            try
            {
                StackHelper.CheckIfInt(input);
            }
            catch (Exception e)
            {
                throw e;
            }
             stack.Add(input);
        }

        public void RemoveElement(int elementPosition)
        {
            try
            {
                StackHelper.CheckIfInt(elementPosition);
            }
            catch (Exception e)
            {
                throw e;
            }

            stack.Remove(stack.ElementAt(elementPosition));
        }
    }
}
