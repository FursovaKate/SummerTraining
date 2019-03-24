using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversePolishNotationCalc
{
    public static class Calculator
    {
        public static int Calculate(string input)
        {
            var inputList = input.Split(' ').ToList();
            var numberStack = new Stack<int>();
            
            for (var i = 0; i < inputList.Count; i++)
            {
                if (inputList.ElementAt(i).Equals("+"))
                {
                    var newValue = numberStack.Pop() + numberStack.Pop();
                    numberStack.Push(newValue);
                }
                else if (inputList.ElementAt(i).Equals("-"))
                {
                    var newValue = numberStack.Pop() - numberStack.Pop();
                    numberStack.Push(newValue);
                }
                else if (inputList.ElementAt(i).Equals("*"))
                {
                    var newValue = numberStack.Pop() * numberStack.Pop();
                    numberStack.Push(newValue);
                }
                else if (inputList.ElementAt(i).Equals("/"))
                {
                    var newValue = numberStack.Pop() / numberStack.Pop();
                    numberStack.Push(newValue);
                }
                else
                {
                    try
                    {
                        int.TryParse(inputList.ElementAt(i), out var result);
                        CheckIfInt(result);
                        numberStack.Push(result);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
            }
            return numberStack.Peek()*-1;
        }

        public static void CheckIfInt(int input)
        {
            if (input != (int)input)
            {
                Console.WriteLine("Argument is not integer");
            }
        }
    }
}
