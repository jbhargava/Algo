using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Programs
    {
        static void Main(string[] args)
        {

            String esn = "356509100194463";
            if (Luhn.checkLuhn(esn))
                Console.WriteLine("Valid ESN");
            else
                Console.WriteLine("Invalid ESN");


            int[] sq = { 1, 2, 3,5,6,5, 1, 4,  };

            Regex rx2 = new Regex(@"^\d+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Define a test string.


            string text1 = "Th1S";
            MatchCollection mtchDigits = rx2.Matches(text1);

            var revRecursion = StringAlgorithms.ReverseRecursion("jagdeep");
            var sortstring =  StringAlgorithms.SortString("jagdeep");

            Regex rx = new Regex(@"\b(\S+)\s+\1\b",RegexOptions.Compiled | RegexOptions.IgnoreCase);
            // Define a test string.
            string text = "The the quick brown fox  fox jumps over the lazy dog dog.";

            // Find matches.
            MatchCollection matches = rx.Matches(text);

            var matchss= Regex.Matches(text, @"(.)\1+");

            LinkedList l1 = new LinkedList();
            l1.AddNode(1);
            l1.AddNode(2);
            l1.AddNode(3);
            l1.AddNode(4);
            l1.AddNode(5);

            LinkedList l2 = new LinkedList();
            l1.AddNode(6);
            l1.AddNode(7);

            var resultList = l1.MergeLinklist(l1, l2);

            var node2 = l1.reverse();
            var node1 = l1.MiddleNode();
            l1.DeleteNode(5);
            var i = l1.CountNodes();
            var a = l1.ReverseList();

            var dups = IntAlgorithm.RemoveDuplicate(sq);
            IntAlgorithm.ReverseArray(sq);
            IntAlgorithm.FindDuplicate(sq);

            IntAlgorithm.Pair2Sum(sq, 3);
            IntAlgorithm.FindSmallestLargest(sq);
            IntAlgorithm.MissingSequence(sq);

            IntAlgorithm.SwapWithoutTemp(5, 7);

            var ints =  IntAlgorithm.TwoSum(new int[] { 3,2,3 }, 6);

            String str = "baaabab";

            //test("g*ks", "geeks");

            var stringMatch = StringAlgorithms.match("g*ks", "geeks");

            var sx = str.Substring(1);

            String pattern = "ba*ab";
            if (StringAlgorithms.strmatch(str, pattern, str.Length,
                     pattern.Length))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


            IntAlgorithm.Int2String(-1200);

           var isPalindrome =  IntAlgorithm.IsPalindrome(121);

           int iint= StringAlgorithms.String2Int("-12");
            Node node = default;

            Trees t = new Trees();
            t.Insert(3);
            t.Insert(2);
            t.Insert(4);
            t.Insert(5);
            t.Insert(6);
            t.Insert(7);

            t.Height(t.RootNode);
            Console.WriteLine("Pre - Order ====> ");
            t.PreOrder(t.RootNode);
            Console.WriteLine("InOrder ====> ");
            t.InOrder(t.RootNode);

            Console.WriteLine("Post Order ====> ");
            t.PostOrder(t.RootNode);



            var s = StringPatterMatching.Naive("ABCEABCDABCEABCD".ToCharArray(), "ABCD".ToCharArray());

            BackTrackingAlgorithms.CalcArraryToTarget();
            int[] sortNegative = StringAlgorithms.SortNegative();
            int[] zeroAtEnd = StringAlgorithms.ZeroAtEnd();
            char[] arrReverse = StringAlgorithms.ArrayReverse("String".ToCharArray());
            bool IsPangram = StringAlgorithms.IsPangram("bad");
            string s1 =  StringAlgorithms.StringCopy("This is test", default);
            int[] sortArray = new int[] { 3, 1, 7, 9,2 , 4};
            int[] sortArray2 = new int[] { 4, 6 };

            ArrayAlgorithms.RotateArray(sortArray);


            Console.WriteLine("Merge Sorted arrays:");
             Array.ForEach(
                 MergeTwoSortedArrays.Run(new int[] { 7, 9 }, new int[] { 1, 3, 5, 4, 6 })
                 , p => Console.WriteLine(p));

            Console.WriteLine("Insertion Sort Ascending:" );
            Array.ForEach(InsertionSort.AscendingOrderRun(sortArray), p => Console.WriteLine(p));
            
            Console.WriteLine("Insertion Sort Descending:" );
            Array.ForEach(InsertionSort.DescendingOrderRun(sortArray), p => Console.WriteLine(p));

            Console.WriteLine("Bubble Sort:");
            Array.ForEach(BubbleSort.Run(sortArray), p => Console.WriteLine(p));

            Console.WriteLine("Merge Sort:");
            Array.ForEach(MergeSort.Run(sortArray), p => Console.WriteLine(p));

            Console.WriteLine("Quick Sort:");
            Array.ForEach(QuickSortWithForLoop.Run(sortArray, 0, sortArray.Length - 1), p => Console.WriteLine(p));

            Console.WriteLine("Selection Sort:");
            Array.ForEach(SelectionSort.Run(sortArray), p => Console.WriteLine(p));
            


            // Array.ForEach(QuickSortWithForLoop.Run(sortArray, 0, sortArray.Length - 1), p => Console.WriteLine(p));


            var list = new List<int>() { 1, 2, 3, 4 };

            var target = list.ConvertAll(xt => (char)xt);

            var listAsString = String.Join("", list.ConvertAll(xx => xx.ToString()).ToArray());
            Console.WriteLine(listAsString);
            int result = Int32.Parse(listAsString);
            Console.WriteLine(result);


            //ChainR c = new ChainR();
            //c.AssignStatus("Processed1");

            var sev = multiplyBySeven(3);
            var powerof2 = isPowerOfTwo(3);
            var powerof21 = isPowerOfTwo(4);

            var val = Programs.ToggleCase("Jagdeep");

            ChainOfResponsibility cr = new ChainOfResponsibility();
            cr.run();



            BackTracking.findString();
            
            int[] arrint = new int[] { 2, 3, 5, 8, 10 };

            BackTracking.ArrayTargetSearch(arrint, 10);

            int[] aint = new int[] { 1, 2, 3, 6, 5, 6 };
            string palTest = "ACLSCA";
            bool isArrSorted = SortedArray.IsArraySorted(aint, 1, aint.Length-1);
           bool isPal = Palindrome.IsPalindrome(palTest.ToArray(), 0, palTest.ToArray().Length - 1);

            int narr = 4;
            int[] arrr = { 1, 5, 6,7};
            for (int ictr=0; ictr < narr; ictr++)
            {
                Console.WriteLine(arrr[ictr]);
            }
            Console.WriteLine("========>>>");

            int total = 1 << narr;
            for (int k = 1; k < total; k++)
            {            
                for (int iic = 0; iic < narr-1; iic++)
                {
                    int xkk = k & (1 << iic);
                   if (xkk <4)
                    {
                        Console.WriteLine(k +"  " + iic + "  " + xkk + "  " + arrr[xkk]);
                    }
                   else
                    {
                        Console.WriteLine(xkk);
                    }
                }
            }

           // Flip the bits of numbers:
            double n = 7; // output 0
            double bit = Math.Floor(Math.Log(n, 2.0) + 1);

            int m = 1 << ((int)bit - 1);
            m = m | m - 1;
            var m1 = (int)n^m;
            Console.WriteLine(m1);



            // Vidoe 5 bit manipulation  https://www.youtube.com/watch?v=dGx0Zk6UF4w&list=PLfQN-EvRGF39Vz4UO18BtA1ocnUhGkvk5&index=5
            int ii = 11;
            int x =1 << 1;
            int x1 = 1 << 2;
            int x2 = 1 << 3;
            int x3 = 1 << -1;

            Console.WriteLine(ii & x);
            Console.WriteLine(ii & x1);
            Console.WriteLine(ii & x2);

            int n7 = 5;
            int count7 = 0;
            while (n7 >0)
            {
                count7++;
                n7 = (n7 & (n7 - 1));
                
            }
            Console.WriteLine(count7);

            LinkedList l = new LinkedList();
            l1.AddNode(1);
            l1.AddNode(2);
            l1.AddNode(3);
            l1.AddNode(4);
            l1.AddNode(5);
            l1.DeleteNode(5);
            var i1 = l1.CountNodes();
            var a1 = l1.ReverseList();

            l1.AddDoubleNode(1);
            l1.AddDoubleNode(2);
            l1.AddDoubleNode(3);

            var d = l1.ReverseDoubleList();

            ////var s = GFG.decToBin(38);
            int[] arr = { 9, 4, 2, 7, 65, 10, 1 };


            DuplicateStringByBit obj = new DuplicateStringByBit();
            string input = "GeekforGeeks";

            if (obj.uniqueCharacters(input))
            {
                Console.WriteLine("The String " + input + " has all unique characters");
            }
            else
            {
                Console.WriteLine("The String " + input + " has duplicate characters");
            }


            var arr1 = MGS.MergeSort(arr);

            //clsMergeSort.mergeSort(arr);

            //clsQuickSort.quickSort(arr, 0, arr.Length-1);
        }

        public static string ToggleCase(string s)
        {
            char[] chs = s.ToCharArray();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char ch = chs[i];
                if (char.IsLetter(ch))
                {
                    char foo = (char)(ch & ~0x20);
                    if ((foo >= 0x41 && foo <= 0x5a) ||
                        (foo >= 0xc0 && foo <= 0xde && foo != 0xd7))
                        chs[i] = (char)(ch ^ 0x20);
                    else if ((foo == 0xdf || ch > 0xff))
                        chs[i] = char.IsLower(ch) ?
                                 char.ToUpper(ch) :
                                 char.ToLower(ch);
                }
            }
            return (new String(chs));
        }

        public static bool isPowerOfTwo(int x)
        {
            // First x in the below expression  
            // is for the case when x is 0 
            return x != 0 && ((x & (x - 1)) == 0);

        }

        static int multiplyBySeven(int n)
        {
            /* Note the inner bracket here. This is needed  
            because precedence of '-' operator is higher  
            than '<<' */
            return ((n << 3) - n);
        }


    }
}
