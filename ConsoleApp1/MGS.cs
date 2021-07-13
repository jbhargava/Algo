using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MGS
    {

        public static int[] MergeSort (int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (arr.Length <= 1)
                return arr;


            int mid = arr.Length / 2;
            left = new int[mid];


            if (arr.Length % 2 == 0)
                right = new int[mid];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[mid + 1];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }



            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to  midpont
            for (int i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }
            //{ 9, 4, 2, 7, 65, 10, 1 }





            left = MergeSort(left);
            right = MergeSort(right);

            result =  Merge(left, right);

            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int indexLeft = 0;
            int indexRight = 0;
            int indexResult = 0;

           while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = left[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

          
            return result;
        }

    }
}
