using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class SortingAlgorithms
    {
        #region Bubble Sort
        public static void BubbleSort(int[] arr)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped == true);
        }
        #endregion

        #region Insertion Sort
        public static void InsertionSort(int[] arr)
        {
            int newValue;

            for (int i = 1; i < arr.Length; i++)
            {
                newValue = arr[i];

                int j = i;

                while (j > 0 && arr[j-1] > newValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = newValue;
            }
        }
        #endregion

        #region Selection Sort
        public static void SelectionSort(int[] arr)
        {
            
        }
        #endregion
    }
}
