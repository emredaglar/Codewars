using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Codewars._8kyu
{
    internal class Are_You_Playing_Banjo
    {
        //        Create a function which answers the question "Are you playing banjo?".
        //If your name starts with the letter "R" or lower case "r", you are playing banjo!

        //The function takes a name as its only argument, and returns one of the following strings:

        ////name + " plays banjo" 
        //name + " does not play banjo"
        //Names given are always valid strings.

        //My Solution
        

        public static string AreYouPlayingBanjo(string name)
        {
            //Implement me
            if (name.StartsWith("R") || name.StartsWith("r"))
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }

        }
        //My Solution 2
        public static string AreYouPlayingBanjo2(string name)
        {
            //Implement me
            return name.ToLower()[0] == 'r' ? name + " plays banjo" : name + " does not play banjo";
        }
    }
}
