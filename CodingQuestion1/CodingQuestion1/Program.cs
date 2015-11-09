using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingQuestion1.Domain;
using CodingQuestion1.Interfaces;

namespace CodingQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Enter an array of integers, beginning with an open square bracket, ending with a a closing square bracket, and delimited by spaces.");
            string arrayString = Console.ReadLine().Trim();

            //get the validation class for the array.  Normally this should call the DI container to get the validation interface implementation from the container
            IArrayValidation validation = new ArrayValidation();

            //determine if the array entered passes validation so that it can at least be turned into an int[]
            if(!(validation.HasOpenSquareBracket(arrayString) && validation.HasCloseSquareBracket(arrayString) && validation.IsValidArrayIntegers(arrayString)))
            {
                Console.WriteLine("Array entered is not valid.  Press any key to continue.");
                Console.ReadLine();
                return;
            }

            //since the string is valid, parse it.
            IArrayParser parser = new ArrayParser();
            int[] array = parser.ParseArray(arrayString);

            //check to see if there is at least 1 odd number and at least 1 even number in the array
            if(!(validation.HasEvenNumber(array) && validation.HasOddNumber(array)))
            {
                Console.WriteLine("The array does not have at least 1 even and at least one odd number");
                Console.ReadLine();
                return;
            }

            //sort the array.  since the example uses an integer array - the easiest coding way now would be to use Array.Sort included by default 
            //but for complex types/classes you'd implement IComparable.
            Array.Sort(array);

            //Do the calculation
            IAction calculator = new Calculator();
            string result = calculator.Calculate(array);

            //Print the result
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
