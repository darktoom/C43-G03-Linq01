using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Linq01
{
    internal static class IntExtension
    {
        public static int reverse(this int number) {

            int reversednumber = 0, reminder=0;
            while (number != 0) { 
            reminder = number % 10;
                reversednumber = reversednumber * 10+reminder;
                number = number / 10;   
            
            }
            return reversednumber;
        }


    }
}
