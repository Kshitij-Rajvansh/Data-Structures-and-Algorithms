using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]{ {1,2,3}, {4,5,6}, {7,8,9} };

            int sum = MaxSumPath(arr);
        }

        #region Function to return the max sum path ina 2d array
            public static int MaxSumPath(int[,] arr)
            {
                int i = 0, j = 0;
                int sum = arr[i ,j];

                while( i < arr.GetLength(0) && j < arr.GetLength(1))
                {
                    if(arr[i, j+1] > arr[i+1, j])
                    {
                        sum += arr[i, j+1];
                        j = j+1;
                    }
                    else
                    {
                        sum += arr[i+1, j];
                        i = i+1;
                    }
                }

                return sum;               
            }
        #endregion
    }
}
