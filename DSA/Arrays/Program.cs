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
            int[] arr = new int[] {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9};

            int profit = MinJumpToEnd(arr);

            Console.WriteLine(profit);
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

        #region Function to print pairs whose product is divisible by a given number
            public static void PrintProdPairs(int[] arr, int k)
            {
                int start = 0;
                int end = arr.Length-1;

                while(start <= end)
                {
                    int prod = arr[start] * arr[end];

                    if(prod % k == 0)
                    {
                        Console.WriteLine(arr[start] + " , " + arr[end]);
                        start++;
                        
                    }
                    else
                    {
                        end--;
                    }
                }
            }
        #endregion

        #region Function to find a sub-array with the given sum
            public static void SubArrayWithSum(int[] arr, int givenSum)
            {
                int sum = arr[0];
                int start = 0;

                for(int i = 1; i < arr.Length; i++)
                {
                    while(sum > givenSum && start < i)
                    {
                        sum = sum - arr[start];
                        start++;
                    }

                    if( sum == givenSum)
                    {
                        for(int k = start; k < i; k++)
                        {
                            Console.Write( arr[k] +" , ");
                        }

                    }

                    sum = sum + arr[i];
                }
            }
        #endregion

        #region Function to print the sum of all the sub-arrays of an array
            /*
                for [1,2,3] = {1},{2},{3},{1,2},{2,3},{1,2,3}
                arr[i] = the sub-arrays starting with arr[i] are equal to n-i,
                arr[i] = the sub-arrays where arr[i] is not first term are equal to (n-i)*i
            */
            public static void PrintSumOfAllSubArrays(int[] arr)
            {
                int sum = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    sum += (arr[i] * (arr.Length - i) * (i + 1));
                }

                Console.WriteLine(sum);
            }
        #endregion

        #region Function to print the max sum of K consecutive numbers in the given array
        public static void PrintMaxSumOfConsecutive(int[] arr, int k)
        {
            int maxSum = Int32.MinValue;

            for(int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for(int j = i; j < (k+i); j++)
                {
                    if(j < arr.Length)
                    {
                        sum = sum + arr[j];
                    }
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            Console.WriteLine(maxSum);
        }
        #endregion

        #region Function to find the smallest positive number

        //using hash table
        public static void SmallestPositiveNumber1(int[] arr)
        {
            Dictionary<int , int> hashTable = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    if(hashTable.ContainsKey(arr[i]))
                    {
                        int val = hashTable[arr[i]];
                        hashTable.Remove(arr[i]);
                        hashTable.Add(arr[i], val+1);
                    }
                    else
                    {
                        hashTable.Add(arr[i], 1);
                    }
                }
            }

            int index = 1;
            bool flag = true;

            while(flag)
            {
                if(!hashTable.ContainsKey(index))
                {
                    Console.WriteLine(index);
                    flag = false;
                }
                index++;
            }
        }

        // in constant space and 0(n) time
        public static void SmallestPositiveNumber2(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end)
            {
                if(arr[start] > 0 && arr[end] > 0)
                {
                    start++;
                }
                else if(arr[start] <= 0 && arr[end] > 0)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    
                    start++;
                    end--;
                }
                else
                {
                    start++;
                    end--;
                }
            }
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    arr[i] = 5000;
                }
            }

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0 && arr[i] < arr.Length)
                {
                    arr[arr[i]] = arr[arr[i]] * -1;
                }
            }

            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        #endregion

        #region Function to count the frequency of numbers from 1 to n
        // O(n) and O(n) space solution
        public static void CountFrequencyUsingHashTable(int[] arr)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(hashTable.ContainsKey(arr[i]))
                {
                    int val = hashTable[arr[i]];

                    hashTable.Remove(arr[i]);
                    hashTable.Add(arr[i], val+1);
                }
                else
                {
                    hashTable.Add(arr[i] , 1);
                }
            }

            foreach( var key in hashTable)
            {
                Console.WriteLine(key.Key + " --> " + key.Value );
            }
        } 

        // O(n) time and O(1) space
        public static void CountFrequency(int[] arr)
        {
            int i = 0;

            while(i < arr.Length)
            {
                if(arr[i] <= 0)
                {
                    i++;   
                }
                else
                {
                    int index = arr[i] -1;

                    if(arr[index] > 0)
                    {
                        arr[i] = arr[index];
                        arr[index] = -1;
                    }
                    else
                    {
                        arr[index]--;
                        arr[i] = 0;
                        i++;
                    }
                }
            }

            for(int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(j +1 + " --> " + arr[j] * -1);
            }
        }
        #endregion

        #region Function To rotate a 2d array(n X n) by 90degree clockwise
        public static int[,] Rotate2DArray(int[,] arr)
        {
            // first transpose the matrix
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = i; j < arr.GetLength(1); j++)
                {
                    int temp = arr[i,j];
                    arr[i,j] = arr[j,i];
                    arr[j,i] = temp;
                }
            }

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0, n = arr.GetLength(1); j < (arr.GetLength(1) / 2) && n > (arr.GetLength(1) / 2);  j++, n--)
                {
                    int temp = arr[i,j];
                    arr[i,j] = arr[i,n-1];
                    arr[i,n-1] = temp;
                }
            }

            return arr;
        }
        #endregion

        #region Function to find the max subarray sum in given array Kadanes Algorithm
        public static void MaxSubArraySum(int[] arr)
        {
            int maxSum = arr[0];
            int currentSum = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                int sum = currentSum + arr[i];

                if(arr[i] > sum)
                {
                    currentSum = arr[i];
                }
                else
                {
                    currentSum = sum;
                }

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

            }

            Console.WriteLine(maxSum);
        }
        #endregion

        #region Max stock profit problem
            public static int MaxStockProfit(int[] arr)
            {
                int min = arr[0];
                int profit = 0;
                for(int i = 1; i < arr.Length; i++)
                {
                    profit = arr[i] - min > profit ? arr[i] - min : profit;
                    min = arr[i] < min ? arr[i] : min;
                }

                return profit;
            }
        #endregion

        #region Minimum jumps to reach the end
            public static int MinJumpToEnd(int[] arr)
            {
                int jumps = 0;
                int furthest = -1, target = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    furthest = Math.Max(arr[i] + i, furthest);
                    if (i == target)
                    {
                        jumps++;
                        target = furthest;
                    }
                }
                return jumps;
            }
        #endregion
    }
}
