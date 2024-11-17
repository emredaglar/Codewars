using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._8kyu
{
    internal class Remove_First_and_Last_Character
    {
        //It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry about strings with less than two characters.

        //My Solution
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}
