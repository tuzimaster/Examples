using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingQuestion1.Interfaces;

namespace CodingQuestion1.Domain
{
    public class ArrayParser : IArrayParser
    {
        public int[] ParseArray(string s)
        {
            //assuming that the first and last characters are [ ] bracket characters.
            var intergerSubstrings = s.Substring(1, s.Length - 2).Trim().Split(' ');
            return Array.ConvertAll(intergerSubstrings, int.Parse);
        }
    }
}
