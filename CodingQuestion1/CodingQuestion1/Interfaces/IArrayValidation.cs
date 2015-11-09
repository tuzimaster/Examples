using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestion1.Interfaces
{
    interface IArrayValidation
    {
        bool HasOpenSquareBracket(string s);
        bool HasCloseSquareBracket(string s);
        bool IsValidArrayIntegers(string s);
        bool HasEvenNumber(int[] array);
        bool HasOddNumber(int[] array);
    }
}
