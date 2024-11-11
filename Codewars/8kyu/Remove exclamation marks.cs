using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._8kyu
{
    internal class Remove_exclamation_marks
    {
        //Write function RemoveExclamationMarks which removes all exclamation marks from a given string.
        //My Solution
        public static string RemoveExclamationMarks(string s)
        {
            // Your code goes here
            return s.Replace("!", "");
        }
    }
}
