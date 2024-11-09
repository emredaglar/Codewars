using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._8kyu
{
    internal class Opposites_Attract
    {
        //        Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each.If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

        //Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.

        //My Solution 1
        public static bool lovefunc(int flower1, int flower2)
        {
            //Moment of truth...
            if ((flower1 % 2 == 0 && flower2 % 2 != 0) || flower2 % 2 == 0 && flower1 % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //My Solution 2
        public static bool lovefunc2(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }

        //My Solution 3
        public static bool lovefunc3(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }
    }
}
