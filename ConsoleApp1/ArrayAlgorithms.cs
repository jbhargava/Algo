using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayAlgorithms
    {
        public static void RotateArray(int[] arr)
        {
            int ctr = 0, arrLength = arr.Length - 1, mv=1 ;
            while (true)
            {
                if (ctr > 2)
                    break;
                int temp0 = arr[0];                
                for (int i=0; i<=arrLength-1;)
                {
                    arr[i] = arr[++i];
                    Console.Write(arr[i].ToString() + " ");
                }
                arr[arrLength] = temp0;
                Console.Write(arr[arrLength] + " ");
                ctr++;
            }
        }

    }
}
