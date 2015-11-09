using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingQuestion1.Interfaces;

namespace CodingQuestion1.Domain
{
    public class ArrayValidation : IArrayValidation
    {
        private const char _whiteSpaceCharacter = ' ';

        public bool HasCloseSquareBracket(string s)
        {
            if(s[s.Length-1] == ']')
            {
                return true;
            }
            return false;
        }

        public bool HasOpenSquareBracket(string s)
        {
            if (s[0] == '[')
            {
                return true;
            }
            return false;
        }

        public bool IsValidArrayIntegers(string s)
        {
            //Ideally I'd use a regex of [0-9, plus white space character] here - but I'd have to look it up for the exact correct syntax [0-9 ] I think.
            string test = s.Substring(1, s.Length - 2);

            //test to see if there is at least one numeric - we could have been given a string of empty spaces
            if(!test.Any(x => Char.IsNumber(x)))
            {
                return false;
            }

            bool result = true;
            int i = 0;
            foreach(char c in test.ToCharArray())
            {
                if(!int.TryParse(c.ToString(), out i) && c != _whiteSpaceCharacter)
                {
                    return false;
                }
            }
            return result;
        }

        public bool HasOddNumber(int[] array)
        {
            return array.Any(x => x % 2 != 0);
        }

        public bool HasEvenNumber(int[] array)
        {
            return array.Any(x => x % 2 == 0);
        }
    }
}
