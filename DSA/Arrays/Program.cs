using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr1 = new int[]{1,0,0,2,1,1,0,0,2,1,0,1,0};

            // int[] sortedArr = SortOneAndtwo(arr1);

            // foreach(int i in sortedArr)
            // {
            //     Console.Write(i + "  ");
            // }

            // Console.WriteLine("\n======================================================\n");
            // int[] arr2 = new int[]{2,4,7,10,15,25};

            // PrintSumPair(arr2, 17);

            //string str = "abz";
            // FirstNonRepeatingSubStringOnce(str);

            int[] arr = new int[] {1,2,3,4,5};
            RotateLeftByK(arr, 4);

            foreach (int item in arr)
            {
                Console.Write(item + " , ");
            }

            Console.ReadLine();
        }

        #region Function to sort the array of 0's , 1's and 2's
        public static int[] SortOneAndtwo(int[] arr)
        {
            int j, countOne = 0, countTwo = 0, countZero = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    countZero++;
                }
                else if(arr[i] == 1)
                {
                    countOne++;
                }
                else if(arr[i] == 2)
                {
                    countTwo++;
                }
            }

            j = 0;

            while(countZero > 0)
            {
                arr[j] = 0;
                countZero--;
                j++;
            }
            while(countOne > 0)
            {
                arr[j] = 1;
                countOne--;
                j++;
            }
            while(countTwo > 0)
            {
                arr[j] = 2;
                countTwo--;
                j++;
            }

            return arr;
        }
        #endregion

        #region Function to print the pairs whose sum is equal to given sum in an ordered array
        public static void PrintSumPair(int[] arr, int sum)
        {
            int start = 0;
            int end = arr.Length - 1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[start] + arr[end] == sum)
                {
                    Console.WriteLine(arr[start] + " , " + arr[end]);
                    end--;
                }
                else if(arr[start] + arr[end] > sum)
                {
                    end--;
                }
                else if(arr[start] + arr[end] < sum)
                {
                    start++;
                }
            }
        }
        #endregion

        #region Function to print the first non repeating character in string
        public static void FirstNonRepeatingSubString(string str)
        {
            int[] check = new int[256];

            for(int i = 0; i < str.Length; i++)
            {
                check[(int)str[i]]++;
            }

            for(int i = 0; i < str.Length; i++)
            {
                if(check[(int)str[i]] == 1)
                {
                    Console.WriteLine(str[i]);
                    break;
                }
            }
        }
        #endregion

        #region Function to print the first non repeating character in string by iterarting the string once
        public static void FirstNonRepeatingSubStringOnce(string str)
        {
            int[] check = Enumerable.Repeat(-1, 256).ToArray();

            int MinVal = Int32.MaxValue;

            for(int i = 0; i < str.Length; i++)
            {
                if(check[(int)str[i]] == -1)
                {
                    check[(int)str[i]] = i;
                }
                else
                {
                    check[(int)str[i]] = -5;
                }
            }

            for(int i = 0; i < check.Length; i++)
            {
                if(check[i] >= 0 && check[i] < MinVal)
                {
                    MinVal = check[i];
                }
            }

            Console.WriteLine(str[MinVal]);
        }
        #endregion

        #region Just a test function
        public static void TestFunction(string str)
        {
            int[] arr = new int[26];

            for(int i = 0; i < str.Length; i++)
            {
                arr[str[i] - 'a']++;
            }
            for(int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region Function to reverse an array in place
            public static int[] ReverseArray(int[] arr, int low, int high)
            {
                int start = low;
                int end = high;

                while(start <= end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }

                return arr;
            }
        #endregion

        #region Function to rotate an array left once
            public static int[] RotateLeftOnce(int[] arr)
            {
                int start = 0;
                int end = arr.Length - 1;

                while(end >= start)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    end--;
                }

                return arr;
            }
        #endregion

        #region Function to rotate an array right once
            public static int[] RotateRightOnce(int[] arr)
            {
                int start = 0;
                int end = arr.Length - 1;

                while (start <= end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                }

                return arr;
            }
        #endregion

        #region Function to rotate an array right by k position
            public static int[] RotateRightByK(int[] arr, int k)
            {
                arr = ReverseArray(arr, arr.Length-k, arr.Length-1);
                arr = ReverseArray(arr, 0, arr.Length-k-1);
                return ReverseArray(arr, 0, arr.Length-1);
            }
        #endregion

        #region Function to rotate an array left by k position
            public static int[] RotateLeftByK(int[] arr, int k)
            {
                return RotateRightByK(arr, arr.Length - k);
            }
        #endregion
    }
}
