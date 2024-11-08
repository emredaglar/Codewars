using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Codewars._8kyu
{
    internal class Sum_Arrays
    {
        //        Write a function that takes an array of numbers and returns the sum of the numbers.The numbers can be negative or non-integer.If the array does not contain any numbers then you should return 0.

        //Examples
        //        Input: [1, 5.2, 4, 0, -1]
        //        Output: 9.2

        //Input: []
        //        Output: 0

        //Input: [-2.398]
        //        Output: -2.398

        //Assumptions
        //You can assume that you are only given numbers.
        //You cannot assume the size of the array.
        //You can assume that you do get an array and if the array is empty, return 0.
        //What We're Testing
        //We're testing basic loops and math operations. This is for beginners who are just learning loops and math operations.
        //Advanced users may find this extremely easy and can easily write this in one line.    



        //My Solution 1
        public static double SumArray(double[] array)
        {
            double toplam = 0;

            foreach (double sayi in array)
            {
                toplam += sayi;
            }
            return toplam;
        }
        //My Solution 2
        public static double SumArray2(double[] array)
        {
            return array.Sum();
        }
    }
}
