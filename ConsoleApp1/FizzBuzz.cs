using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzz
    {
        public static string Run(int data)
        {
            string returnVal = default;

            if (data % 3 == 0 && data % 5 == 0)
            {
                returnVal = "FizzBuzz";
            }
            else if (data % 3 == 0)
            {
                returnVal = "Fizz";
            }
            else if (data % 5 == 0)
            {
                returnVal = "Buzz";
            }

            return returnVal;
        }
    }
}
