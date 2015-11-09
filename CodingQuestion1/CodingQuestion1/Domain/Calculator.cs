using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingQuestion1.Interfaces;

namespace CodingQuestion1.Domain
{
    public class Calculator : IAction
    {
        public string Calculate(int[] array)
        {
            int largestEvenInteger = GetLargestEvenInteger(array);
            int smallestOddInteger = GetSmallestOddInteger(array);

            int result = largestEvenInteger - smallestOddInteger;
            return string.Format("{0} (={1} - {2})", result, largestEvenInteger, smallestOddInteger);
        }

        private static int GetSmallestOddInteger(int[] array)
        {
            //this method assumes an arary that is sorted from smallest at index zero, and the largest value at array.length - 1
            int i = 0;
            while (true)
            {
                if (array[i] % 2 != 0)
                {
                    return array[i];
                }

                i++;

                if (i == array.Length)
                {
                    throw new Exception("There are no odd integers in the array to return");
                }
            }
        }

        private static int GetLargestEvenInteger(int[] array)
        {
            //this method assumes an arary that is sorted from smallest at index zero, and the largest value at array.length - 1
            int i = array.Length - 1;
            while (true)
            {
                if (array[i] % 2 == 0)
                {
                    return array[i];
                }

                if (i == 0)
                {
                    throw new Exception("There are no even integers in the array to return");
                }
                i--;
            }
        }
    }
}
