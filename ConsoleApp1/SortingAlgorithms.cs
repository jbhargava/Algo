using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class SortedArray
    {
        public static bool IsArraySorted(int[] a, int low, int high)
        {
            bool result = false;
            if (low > high)
                return true;

            if (a[low - 1] < a[low])
            {
                return IsArraySorted(a, ++low, high);

            }
            else
                return false;
        }
    }

    public class MergeTwoSortedArrays
    {
        // Big o = N
        public static int[] Run(int[] arr1, int[] arr2)
        {
            int totalLength = arr1.Length + arr2.Length;
            int[] arr3 = new int[totalLength];
            
            int i =0, j = 0;
            for (int x=0; x <= totalLength-1; x++)
            {
                if ((i <= arr1.Length - 1 && j <= arr2.Length - 1 && arr1[i] <= arr2[j]) || j >= arr2.Length)
                {
                    arr3[x] = arr1[i];
                    i++;
                }
                else if ((j <= arr2.Length - 1 && i <= arr1.Length - 1 && arr2[j] < arr1[i]) || i >= arr1.Length)
                {
                    arr3[x] = arr2[j];
                    j++;
                }           
               
            }          
            return arr3;

        }
    }
    
    public class BubbleSort
    {
        public static int[] Run(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = arr.Length; j <= arr.Length - 1; j++) // for bubble sort
                //for (int j = i; j <= arr.Length - 1; j++) // for insertion sort
                    {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }
    }

    #region InsertionSorting
    /*
        Time Complexity: O(n^2) , Auxiliary Space: O(1), Algorithmic Paradigm: Incremental Approach
        Boundary Cases: Insertion sort takes maximum time to sort if elements are sorted in reverse order. And it takes minimum time (Order of n) when elements are already sorted.
        Uses: Insertion sort is used when number of elements is small. It can also be useful when input array is almost sorted, only few elements are misplaced in complete big array.
    */
    public class InsertionSort
    { //3, 1, 7, 9, 5, 2
        public static int[] AscendingOrderRun(int[] arr) // Ascending order
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        public static int[] DescendingOrderRun(int[] arr) // Ascending order
        {
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
    #endregion

    #region QuickSort
    public class QuickSortWithForLoop
    {
        //  3, 1, 7, 9, 5, 2
        public static int[] Run(int[] arr, int low, int high)
        {
            int right = 0;
            if (low < high)
            {
                right = partition(arr, low, high);

                Run(arr, low, right - 1);
                Run(arr, right + 1, high);
            }

            return arr;
        }

        private static void swap(int[] ar, int a, int b)
        {
            int temp = ar[a];
            ar[a] = ar[b];
            ar[b] = temp;
        }

        private static int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;

            for (int j = low; j < high ; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    swap(input, i, j);
                }
            }
            swap(input, i + 1, high);
            return i ;
        }

    }

    public class QuickSortWithWhileLoop
    {

        private static int pi;



        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is now
                   at right place */
                pi = Partition(arr, low, high);

                quickSort(arr, low, pi - 1);  // Before pi
                quickSort(arr, pi + 1, high); // After pi
            }
        }

        static public int Partition(int[] arr, int left, int right)
        {
            // { 9, 4, 2, 7, 65, 10, 1 }
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

    }
    #endregion

    public class MergeSort
    {
        public static int[] Run(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            if (array.Length <= 1)
                return array;

            int midPoint = array.Length / 2;
            left = new int[midPoint];

            if (array.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];
        
            left = array.Take(midPoint).ToArray();
            right = array.Skip(midPoint).Take((array.Length - (midPoint - 1))).ToArray();            
            
            left = Run(left);
            right = Run(right);
            result = Merge(left, right);
            return result;
        }

        public static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int leftLength = leftArray.Length;
            int rightLength = rightArray.Length;
            int totalLength = leftLength + rightLength;

            int[] mergeArray = new int[totalLength];

            int x = 0, y = 0;
            for (int i=0;i<totalLength;i++)
            {
                if (leftLength > x && rightLength > y)
                {
                    if (leftArray[x] <= rightArray[y])
                    {
                        mergeArray[i] = leftArray[x];
                        x++;
                    }
                    else
                    {
                        mergeArray[i] = rightArray[y];
                        y++;
                    }

                }
                else if (leftLength > x)
                {
                    mergeArray[i] = leftArray[x];
                   x++;
                }
                else if (rightLength > y)
                {
                    mergeArray[i] = rightArray[y];
                    y++;
                }
            }

            return mergeArray;

        }

    }

/*
    Time Complexity: O(n2) as there are two nested loops., Auxiliary Space: O(1)
    The good thing about selection sort is it never makes more than O(n) swaps and can be useful when memory write is a costly operation.
   */

    public class SelectionSort
    {
        private static void swap(ref int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        public static int[] Run(int[] array)
        {
            int[] result = new int[array.Length];
            int arrLength = array.Length - 1;

            for (int x = 0; x <= arrLength; x++)
            {
                int min_Idx = x;
                for (int i = x+1; i <= arrLength; i++)
                {
                    if (array[min_Idx] > array[i])                        
                        min_Idx = i;
                }

                if (min_Idx > -1)
                {
                    swap(ref array, x, min_Idx);
                    min_Idx = x;
                }
            }

            return array;
        }


    }

}
