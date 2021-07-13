using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BackTrackingAlgorithms
    {
        public static void CalcArraryToTarget()
        {
            int[] arr = new int[] { 3, 5, 8, 2, 5, 6, 4,  10 };
            //int[,] arrComb = new int[arr.Length - 1, arr.Length-1] ;
            int target = 10, currIdx = 0, prevIdx = 0;
            int high = arr.Length; 
            int min = 0, mid = high / 2;
            int[] innerArr = new int[arr.Length];
            for (int i = currIdx; i<= high - 1; i++)
            {
                if (CalcArray(arr, i, target, innerArr, 0))
                {
                    Console.WriteLine("Target found");
                }
            }

        }

        private static bool CalcArray(int[] arr, int currIdx, int target, int[] innerArr, int innerIdx)
        {
            bool result = false;
            if (currIdx > arr.Length - 1)
                return false;

            int x = innerIdx, nextIdx = currIdx + 1;
            innerArr[x++] = arr[currIdx];
            int sum = 0;
            for (int ii = 0; ii <= innerArr.Length -1; ii++)
            {
                sum = sum + innerArr[ii];
            }

            if (sum >= target)
            {
                if (sum == target)
                {
                    Console.WriteLine("Target found");

                    result = true;
                    PrintArr(innerArr);
                    ClearArr(innerArr, --x);
                }
                else if (sum > target)
                {
                    ClearArr(innerArr, --x);
                }
            }

            innerIdx = x;
            return CalcArray(arr, nextIdx, target, innerArr, innerIdx);
        }

        private static void ClearArr(int[] arr, int bInx)
        {
            for (int i = bInx; i <= arr.Length - 1; i++)
            {
                arr[i] = 0;
            }

        }

        private static void PrintArr(int[] arr)
        {
            Console.WriteLine("");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write(arr[i]);
            }

        }

    }
}
