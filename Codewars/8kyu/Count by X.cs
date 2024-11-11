using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._8kyu
{
    internal class Count_by_X
    {
        //        Create a function with two arguments that will return an array of the first n multiples of x.

        //Assume both the given number and the number of times to count will be positive numbers greater than 0.

        //Return the results as an array or list(depending on language ).

        //Examples
        //x = 1, n = 10-- > [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        //x = 2, n = 5  --> [2, 4, 6, 8, 10]

        //My Solution
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];



            for (int i = 1; i <= n; i++)
            {
                z[i - 1] = x * i;
            }
            return z;
        }
    }
}

