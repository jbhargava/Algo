using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class BackTracking
    {
        #region "Sum of Array"
        public static bool ArrayTargetSearch(int[] arr, int target)
        {
            bool result = false;
            if (arr != null && arr.Length == 0)
            {
                return false;
            }
            else
            {
                CalcArr(arr, null, 8, 0,0,0);
            }

            return result;
        }
        private static void CalcArr(int[] arr, int[] parr, int target, int currIdx, int currIdxSub, int pIndx) 
        { 
            bool result = false;
            if (arr.Length == currIdxSub || currIdx >= arr.Length-1) return;
            if (parr == null)
            {
                parr = new int[arr.Length];
            }
            parr[pIndx++] = arr[currIdxSub++];

            int sum = 0;
            foreach (int i in parr)
            {
                sum = sum + i;
            }

            if (sum == target || pIndx == arr.Length)
            {
                if (sum == target)
                {
                    result = true;
                    PrintArr(parr);
                    ClearArr(parr, currIdx+1);
                }

                if (pIndx >= arr.Length || currIdxSub >= arr.Length)
                return;
            }
            else if (sum > target)
            {
                ClearArr(parr, currIdx + 1);
            }

            CalcArr(arr, parr, target, currIdx, currIdxSub, pIndx);
            for (int i = 0; i<=parr.Length -1; i++)
            {
                parr[i] = 0;
            }
            CalcArr(arr, parr, target, ++currIdx, currIdx++, 0);
            
            return;
        }
        private static void PrintArr(int[] arr)
        {
            Console.WriteLine("");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i]);
            }
                
        }
        private static void ClearArr(int[] arr, int bInx)
        {
            for (int i = bInx; i <= arr.Length - 1; i++)
            {
                arr[i] = 0;
            }

        }
        #endregion

        private static List<string> lstString = new List<string>();

        public static void findString()
        {
            string str = "catsanddogs";
            Hashtable ht = new Hashtable();
            ht.Add("cats","cats");
            ht.Add("dogs","dogs");
            ht.Add("sand", "sand");
            // FindInStringWithoutBT(str, 0, ht);

            FindInStringWithBT(str, ht, new List<string>());
        }

        public static void FindInStringWithoutBT(string str, int wordLength,  Hashtable  d )
        {
            if (wordLength >= str.Length - 1)
                return;

            int loopCtr = (str.Length - 1) / wordLength;
            for (int i=0; i<= str.Length-1; i++)
            {
                if (str.Length >= i + wordLength)
                {
                    string s = str.Substring(i, wordLength);
                    if (d.Contains(s))
                        lstString.Add(s);
                }
            }
            FindInStringWithoutBT(str, ++wordLength, d);
        }

        public static void FindInStringWithBT(string str, Hashtable d, 
                                            List<string> partial)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(partial.ToString());
                return;
            }
                
            for (int i = 0; i<str.Length;i++)
            {
                string word = str.Substring(0, i + 1);
                if (d.Contains(word))
                {
                    partial.Add(word);
                    FindInStringWithBT(str.Substring(i + 1), d, partial);
                    partial.Remove(word);
                }
            }
           
        }
    }
}
