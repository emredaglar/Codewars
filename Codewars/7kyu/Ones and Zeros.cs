using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._7kyu
{
    internal class Ones_and_Zeros
    {
        //        Given an array of ones and zeroes, convert the equivalent binary value to an integer.

        //Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.

        //Examples:

        //Testing: [0, 0, 0, 1] ==> 1
        //Testing: [0, 0, 1, 0] ==> 2
        //Testing: [0, 1, 0, 1] ==> 5
        //Testing: [1, 0, 0, 1] ==> 9
        //Testing: [0, 0, 1, 0] ==> 2
        //Testing: [0, 1, 1, 0] ==> 6
        //Testing: [1, 1, 1, 1] ==> 15
        //Testing: [1, 0, 1, 1] ==> 11
        //However, the arrays can have varying lengths, not just limited to 4.

        //My Solution
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int result = 0;


            for (int i = 0; i < BinaryArray.Length; i++)
            {
                result = result * 2 + BinaryArray[i];
            }

            return result;
        }
    }

}
}
