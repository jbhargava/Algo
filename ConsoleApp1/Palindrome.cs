using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        public static bool IsPalindrome(char[] a, int low, int high)
        {
            bool result = false;

            if (low >= high)
                return result;

            if (a[low] == a[high])
            {
                result = true;
                IsPalindrome(a, ++low, --high);
               // return result;
            }

            return result;
        }
    }
}
