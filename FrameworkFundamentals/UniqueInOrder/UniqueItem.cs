using System;
using System.Collections.Generic;
using System.Linq;
using NLog;

namespace UniqueInOrder
{
    public static class UniqueItem
    {
        public static IEnumerable<T> UniqueInOrder<T>(this IEnumerable<T> input)
        {
            try
            {
                CheckInput(input);
            }
            catch (Exception e)
            {
                throw e;
            }

            var firstIteration = true;
            T nextElement = default(T);
            foreach (var element in input)
            {
                if (firstIteration || !object.Equals(element, nextElement))
                {
                    yield return element;
                    nextElement = element;
                    firstIteration = false;
                }
            }
            if (input.Count() == 0)
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("List is empty");
            }
        }

        private static void CheckInput<T>(IEnumerable<T> input)
        {
            if (input == null && !input.Any())
            {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error("String is empty");
                throw new ArgumentNullException("String is empty");
            }
        }
    }
}
