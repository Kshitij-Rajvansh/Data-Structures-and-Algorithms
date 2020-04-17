using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 5, 2, 4, 9, 10, 7,19,16,11,14,21 };

            Console.WriteLine("Before : [ 3, 5, 2, 4, 9, 10, 7 ]");

            SortingAlgorithms.MergeSort(arr);

            foreach (int num in arr)
            {
                Console.Write(num + " , ");
            }

            Console.ReadLine();
        }
    }
}
