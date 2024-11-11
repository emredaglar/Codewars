using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._8kyu
{
    public class Calculate_average
    {
        //       Write a function which calculates the average of the numbers in a given array.

        //Note: Empty arrays should return 0.

        //My Solution
        
        public static double FindAverage(double[] array)
        {
            // Your code here
            if (array.Length == 0)
            {
                return 0;
            }

            double plus = 0;
            foreach (double num in array)
            {
                plus += num;
            }
            return plus / array.Length;
        }
        //My Solution 2
        public static double FindAverage2(double[] array)
        {
            return array.Length == 0 ? 0 : array.Average();
        }
    }
}
