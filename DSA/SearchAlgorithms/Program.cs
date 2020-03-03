using System;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12 };

            int index = BinarySearch(arr, 11);

            Console.WriteLine(arr[index]);

            Console.ReadLine();
        }


        #region Binary Search
        /// <summary>
        /// This method search for the given value in the given integer array. The array must be sorted.
        /// </summary>
        /// <param name="arr">An integer array to search in</param>
        /// <param name="searchValue">The value to search for</param>
        /// <returns></returns>
        public static int BinarySearch(int[] arr, int searchValue)
        {
            int low = 0;
            int high = arr.Length - 1;

            while(high >= low)
            {
                int mid = low + (high - low) / 2;

                if(arr[mid] == searchValue)
                {
                    return mid;
                }
                else if(arr[mid] < searchValue)
                {
                    low = mid + 1;
                }
                else if(arr[mid] > searchValue)
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
        #endregion
    }
}
