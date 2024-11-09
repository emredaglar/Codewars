using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._8kyu
{
    internal class Basic_Mathematical_Operations
    {
        //        Your task is to create a function that does four basic mathematical operations.
        //        The function should take three arguments - operation(string/char), value1(number), value2(number).
        //The function should return result of numbers after applying the chosen operation.
        //        Examples(Operator, value1, value2) --> output
        //('+', 4, 7) --> 11
        //('-', 15, 18) --> -3
        //('*', 5, 5) --> 25
        //('/', 49, 7) --> 7

        //My Solution
        public static double basicOp(char operation, double value1, double value2)
        {

            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    return value1 / value2;
                default:
                    throw new ArgumentException("Geçersiz işlem");
            }
        }
}
