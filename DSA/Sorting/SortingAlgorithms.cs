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
            for(int i = 0; i < arr.Length -1; i++)
            {
                int minPos = i;

                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[minPos])
                    {
                        minPos = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = temp;
            }
        }
        #endregion

        #region Merge Sort
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;

            if(n < 2)
            {
                return;
            }

            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for(int i = 0; i <= mid-1; i++)
            {
                left[i] = arr[i];
            }
            for(int i = mid; i <= n-1; i++)
            {
                right[i - mid] = arr[i];
            }

            MergeSort(left);
            MergeSort(right);
            Merge(left, right, arr);
        }

        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int nL = left.Length;
            int nR = right.Length;

            int i = 0, j = 0, k = 0;
            
            while(i < nL && j < nR)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < nL)
            {
                arr[k] = left[i];
                k++;
                i++;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
        }
        #endregion
    }
}
