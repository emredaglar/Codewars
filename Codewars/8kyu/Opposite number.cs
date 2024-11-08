using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._8kyu
{
    internal class Opposite_number
    {
        //Description:
        //Very simple, given a number(integer / decimal / both depending on the language), find its opposite(additive inverse).

        //Examples:

        //1: -1
        //14: -14
        //-34: 34

        //My Solution 1
        public static int Opposite(int number)
        {
            // Happy Coding
            int sonuc = number - (number * 2);
            return sonuc;
        }
        //My Solution 2
        
        public static int Opposite2(int number)
        {
            // Happy Coding
            return -number;
        }
        //My Solution 3
        public static int Opposite3(int n)
        {
            return n * -1;
        }

    }
}
