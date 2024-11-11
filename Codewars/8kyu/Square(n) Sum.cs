using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Codewars._8kyu
{
    internal class Square_n__Sum
    {
        //        Complete the square sum function so that it squares each number passed into it and then sums the results together.

        //For example, for [1, 2, 2] it should return 9 because
        //1
        //2
        //+
        //2
        //2
        //+
        //2
        //2
        //=
        //9
        //1 
        //2
        // +2 
        //2
        // +2 
        //2
        // =9.

        //My Solution
        public static int SquareSum(int[] numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x * x;
            }
            return sum;
        }

        //My Solution 2
        public static int SquareSum2(int[] n) => n.Sum(i => i * i);

        //My Solution 3
        public static int SquareSum3(int[] n)
        {
            return n.Sum(x => x * x);
        }



    }
}
