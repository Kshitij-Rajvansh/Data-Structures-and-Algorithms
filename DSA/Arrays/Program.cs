using System;
using System.Collections.Generic;
using System.Collections;

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

            string str = "!abbac@ddc";
            FirstNonRepeatingSubString(str);

            Console.ReadLine();
        }

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

        public static void FirstNonRepeatingSubStringOnce(string str)
        {
            int[] check = new int[256];

            for(int i = 0; i < str.Length; i++)
            {
                check[(int)str[i]]++;
            }
        }
    }
}
