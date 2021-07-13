using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class IntAlgorithm
    {

        public static int[] RemoveDuplicate(int[] arr)
        {
            //Remove duplicate numbers 
            int[] arrDups = new int[arr.Length];
            int dups = -1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                bool result = false;
                int last = arr.Length - 1;
                for (int x = i + 1; x <= last; x++, last--)
                {
                    if (arr[x] == num || arr[last] == num)
                    {                        
                        result = true;
                        break;
                    }                    
                }
                if (result == false)
                    arrDups[++dups] = arr[i];


                Console.WriteLine("{0} {1}", arr[i], result);
            }

            return arrDups;

        }


        public static int[] ReverseArray(int[] arr)
        {
            int[] retArr = new int[arr.Length];

            for(int i=0,last=arr.Length-1;i<=last;i++,last--)
            {
                retArr[last] = arr[i];
                retArr[i] = arr[last];
            }

            return retArr;
        }

        public static void FindDuplicate(int[] arr)
        {
            //How do you find duplicate numbers in an array if it contains multiple duplicates?
            for (int i=0; i< arr.Length;i++)
            {
                bool found = findNumber(arr, i, arr[i]);
                Console.WriteLine("{0} {1}", arr[i], found);
               
            }

        }
        private static bool findNumber(int[] arr, int idx, int num)
        {
            bool result = false;
            int last = arr.Length-1;
            for(int x=idx+1; x<=last ;x++,last--)
            {
                if (arr[x] == num || arr[last] == num)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ret = new int[2];
            if (nums.Length > 1)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    for (int i = 1; i <= nums.Length - 1; i++)
                    {
                        if ((nums[j] + nums[i]) == target && i != j)
                        {
                            ret[0] = j;
                            ret[1] = i;
                            return ret;
                        }
                    }
                }
            }
            return ret;
        }

        public static bool IsPalindrome(int num)
        {
            int  r, sum = 0, t;

            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }
            if (t == sum)
                return true;
            else
                return false;
        }

        public static string Int2String(int val)
        {
            var chars = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int ctr = 0;
            bool isNegative = (val < 0?true:false);
            var str = string.Empty;
            for (int i = Math.Abs(val); i >0; i=i/10)
            {
                str = chars[i % 10] + str;
                Console.WriteLine(i);
            }
            if (isNegative)
                str = "-" + str;
            return str;
        }

        public static void SwapWithoutTemp(int a,  int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a={0}, b={1}", a, b);
        }

        public static bool MissingSequence(int[] arr)
        {
            bool result = false;
            int start = 1, end = arr.Length;
            for (int i=start;i<end;i++)
            {
                if ((arr[i] - arr[i-1]) != 1)
                {
                    Console.WriteLine(arr[i] + "    " +  arr[i - 1]);
                    result = false;
                }
            }

            return result;
        }


        public static void FindSmallestLargest(int[] arr)
        {
            int largest, smallest;
            largest = smallest = arr[0];

            for (int i=0;i<arr.Length;i++)
            {
                if (smallest > arr[i])
                    smallest = arr[i];

                if (arr[i] > largest)
                    largest = arr[i];
            }

            Console.WriteLine("Smallest = {0}, Largest = {1}", smallest, largest);
        }

        public static void Pair2Sum(int[] arr, int target)
        {
            // {7, 10, 4, 3, 20, 15} 
            int arrLn = arr.Length;
            int[] arrsum = new int[arrLn];
            for (int i=0; i<arr.Length;i++)
            {
                arrsum[i] = arr[i];
                int sum = CalculateArray(arrsum);
                if (sum == target)
                {
                    PrintArr(arrsum, 0);                    
                }
                else if (sum < target)
                {                    
                    calcSum(arr, i, i+1, arrsum, target);    
                }

                ClearArr(arrsum, 0);
            }
        }

        private static void calcSum(int[] arr, int idx, int nxtIdx, int[] arrsum, int target)
        {
            bool found = false;
            for (int j = nxtIdx; j < arr.Length; j++)
            {
                int sum = 0;
                for (int x = 0; x < arrsum.Length; x++)
                    sum = sum + arrsum[x];

                if (sum < target)
                    arrsum[j] = arr[j];
                else if (sum > target)
                {
                    
                    ClearArr(arrsum, j-1);
                }
                else if (sum == target)
                {
                    PrintArr(arrsum, 0);
                    ClearArr(arrsum, j-1);
                }
            }
        }

        private static int CalculateArray(int[] arrsum)
        {
            int sum = 0;
            for (int x = 0; x < arrsum.Length; x++)
                sum = sum + arrsum[x];
            return sum;

        }
        private static void PrintArr(int[] arr, int idx)
        {
            for (int i = idx; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine(" ");
        }
        private static void ClearArr(int[] arr, int bInx)
        {
            for (int i = bInx; i <= arr.Length - 1; i++)
            {
                arr[i] = 0;
            }

        }

    }
    
}
