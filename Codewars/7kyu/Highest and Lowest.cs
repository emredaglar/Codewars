﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._7kyu
{
    internal class Highest_and_Lowest
    {
        //        In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

        //Examples
        //Kata.HighAndLow("1 2 3 4 5"); // return "5 1"
        //        Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        //Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"
        //Notes
        //All numbers are valid Int32, no need to validate them.
        //There will always be at least one number in the input string.
        //Output string must be two numbers separated by a single space, and highest number is first.

        //My Solution
        public static string HighAndLow(string numbers)
        {
            // Code here or
            var numArray = numbers.Split(' ').Select(int.Parse).ToArray();
            int max = numArray.Max();
            int min = numArray.Min();

            return $"{max} {min}";
        }
    }
}
