using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringPatterMatching
    {

        public static string Naive(char[] Txt, char[] pattern)
        {
            /*      string txt = "ABCEABCDABCEABCD"; 
                    string pat = "ABCD"; 
            */
            string matchIndexes = string.Empty;
            bool matchFound = false;
            for (int i = 0; i < Txt.Length - 1; i++)
            {
                int j = 0;
                for (; j < pattern.Length; j++)
                {
                    if (Txt[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == pattern.Length)
                {
                    matchFound = true;
                    matchIndexes = matchIndexes + i.ToString() + ", ";
                }
            }

            return matchIndexes;
        }

    }
}
