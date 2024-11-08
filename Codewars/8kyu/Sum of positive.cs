using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._8kyu
{
    internal class Sum_of_positive
    {
        //        Description:
        //You get an array of numbers, return the sum of all of the positives ones.

        //Example [1, -4, 7, 12] => 1 + 7 + 12 = 20

        //Note: if there is nothing to sum, the sum is default to 0.

        //My Solution 1
        public static int PositiveSum(int[] arr)
        {
            
            int toplam = 0;
            foreach (int sayi in arr)
            {
                if (sayi > 0)
                {
                    toplam += sayi;
                }
            }
            return toplam;
        }
        //My Solution 2
        
        public static int PositiveSum2(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
        //My Solution 3
        public static int PositiveSum3(int[] arr)
        {
            return arr.Sum(c => (c < 0 ? 0 : c));
        }
    }
}
