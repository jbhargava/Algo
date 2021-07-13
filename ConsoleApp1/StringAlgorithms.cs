using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringAlgorithms
    {


        public static string SortString(string str)
        {
            char[] chrs = str.ToCharArray();
            for (int i=0; i<=chrs.Length-1;i++)
            {
                for (int j=i+1;j<=chrs.Length-1;j++)
                {
                    if (chrs[j]<chrs[i])
                    {
                        char tmp = chrs[i];
                        chrs[i] = chrs[j];
                        chrs[j] = tmp;
                    }
                }
            }

            return chrs.ToString();
        }

        public static string ReverseRecursion(string str)
        {
            int start = 0;
            int end = str.Length - 1;
            var s = rev(str.ToCharArray(), start, end);

            return string.Join("", s);
        }
        private static char[] rev(char[] str, int start, int end)
        {
            string result = string.Empty;
            if (start > (end / 2))
            {
                return str;
            }
            char tmp = str[start];
            str[start] = str[end];
            str[end] = tmp;

           return rev(str, ++start, --end);
        }

        public static bool match(String first, String second)
        {
            Console.WriteLine(first + " ============= " + second);
            // If we reach at the end of both strings, 
            // we are done
            if (first.Length == 0 && second.Length == 0)
                return true;

            // Make sure that the characters after '*' 
            // are present in second string. 
            // This function assumes that the first
            // string will not contain two consecutive '*'
            if (first.Length > 1 && first[0] == '*' &&
                                      second.Length == 0)
                return false;

            // If the first string contains '?', 
            // or current characters of both strings match
            if ((first.Length > 1 && first[0] == '?') ||
                (first.Length != 0 && second.Length != 0 &&
                 first[0] == second[0]))
                return match(first.Substring(1),
                             second.Substring(1));

            // If there is *, then there are two possibilities
            // a) We consider current character of second string
            // b) We ignore current character of second string.
            if (first.Length > 0 && first[0] == '*')
                return match(first.Substring(1), second) ||
                       match(first, second.Substring(1));
            return false;
        }

        public static int String2Int(string val)
        {
            int result = 0;
            if (string.IsNullOrWhiteSpace(val))
            {
                return result;
            }
            else
            {
                foreach(char c in val.ToCharArray())
                {
                    if (c >= '0' && c <= '9')
                    {
                        result *= 10;
                        result += c - '0';
                    }
                }
            }

            return result;
        }



        public static string StringCopy(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1))
                return "String can't be empty";
            if (string.IsNullOrWhiteSpace(s2))
                s2 = string.Empty;
            return stcp(s1.ToCharArray(), s2.ToCharArray(), 0).ToString();
        }

        private static char[] stcp(char[] s1, char[] s2, int idx)
        {
            if ( idx >= s1.Length)
                return s2;
            if (s2.Length < s1.Length)
                s2 = new char[s1.Length];
            s2[idx] = s1[idx];
            
           return stcp(s1, s2, ++idx);
        }

        public static Boolean IsPangram(string s1)
        {
            bool result = true;
            char[] alphabets = new char[] { 'a', 'b',  'd', 'c'};
            char[] alphabetCount = new char[] { '0', '0', '0' ,'0'};
            for (int i = 0; i <= s1.ToCharArray().Length - 1; i++)
            {
                for (int j = 0; j <= alphabets.Length - 1; j++)
                {
                    if(s1[i].Equals(alphabets[j]))
                    {
                        alphabetCount[j] = '1';
                    }
                }
            }

            for (int j = 0; j <= alphabetCount.Length - 1; j++)
            {
                if (alphabetCount[j] == '0')
                {
                    result = false;
                }
            }


            return result;
        }

        public static char[] ArrayReverse(char[] arr)
        {
            int arrLength = arr.Length-1 , mid = arr.Length / 2;
            for(int i =0; i<= mid-1;i++)
            {
                char temp = arr[i];
                arr[i] = arr[arrLength];
                arr[arrLength] = temp;
                arrLength--;
            }
            return arr;
        }

        public static int[] ZeroAtEnd()
        {
            int[] arr = new int[] { 1, 0, 0,0, 3, 0, 6, 4 };
            int arrLength = arr.Length-1, arrMid = arrLength / 2, start=0;

            for (int i=0;i<=arrLength;i++)
            {
        
                    if (arr[start] == 0 && arr[arrLength]>0)
                    {
                        int temp = arr[start];
                        arr[start] = arr[arrLength];
                        arr[arrLength] = temp;
                        start++;
                        arrLength--;
                    }
                    else if (arr[arrLength] == 0)
                    {
                        arrLength--;
                    }
                    else if (arr[start] > 0)
                        start++;                
            }

            return arr;
        }

        public static int[] SortNegative()
        {
            int[] arr = new int[] { 12, 11, -13, -5, 6, -7, 5, -3, -6 };

            return sortArray(arr);

        }

        private static int[] sortArray(int[] arr)
        {
            for (int i= 0; i<=arr.Length-1;i++)
            {
                for(int j=1; j<=i; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }


        // Function that matches input str with
        // given wildcard pattern
        public static Boolean strmatch(String str,
                                String pattern,
                                int n, int m)
        {
            // empty pattern can only match with
            // empty string
            if (m == 0)
                return (n == 0);

            // lookup table for storing results of
            // subproblems
            Boolean[,] lookup = new Boolean[n + 1, m + 1];

            // initailze lookup table to false
            for (int i = 0; i < n + 1; i++)
                for (int j = 0; j < m + 1; j++)
                    lookup[i, j] = false;

            // empty pattern can match with
            // empty string
            lookup[0, 0] = true;

            // Only '*' can match with empty string
            for (int j = 1; j <= m; j++)
                if (pattern[j - 1] == '*')
                    lookup[0, j] = lookup[0, j - 1];

            // fill the table in bottom-up fashion
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    // Two cases if we see a '*'
                    // a) We ignore '*'' character and move
                    // to next character in the pattern,
                    //     i.e., '*' indicates an empty
                    //     sequence.
                    // b) '*' character matches with ith
                    //     character in input
                    if (pattern[j - 1] == '*')
                        lookup[i, j] = lookup[i, j - 1]
                                       || lookup[i - 1, j];

                    // Current characters are considered as
                    // matching in two cases
                    // (a) current character of pattern is '?'
                    // (b) characters actually match
                    else if (pattern[j - 1] == '?'
                             || str[i - 1] == pattern[j - 1])
                        lookup[i, j] = lookup[i - 1, j - 1];

                    // If characters don't match
                    else
                        lookup[i, j] = false;
                }
            }
            return lookup[n, m];
        }

    }
}
