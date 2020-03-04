using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]{ {1,1000,2}, {500,100,60}, {70000,800,90} };

            int sum = MaxSumPath(arr);

            Console.Write(sum);
        }

        #region Function to return the max sum path ina 2d array
            public static int MaxSumPath(int[,] arr)
            {
                int numRows = arr.GetLength(0);
                int numCols = arr.GetLength(1);
                int[,] arr2 = new int[numRows, numCols];

                for(int i = 0; i < numRows; i++)
                {
                    for(int j = 0; j < numCols; j++)
                    {
                        int leftIndex = j - 1 >= 0 ? j-1 : 0;
                        int topIndex = i - 1 >= 0 ? i -1: 0;

                        int leftVal = j == 0 ? 0 : arr2[i,leftIndex];
                        int topVal = i == 0 ? 0 : arr2[topIndex,j];

                        if(j == 0 && i == 0)
                        {
                            arr2[i, j] = arr[i, j];
                        }
                        else
                        {
                            int maxVal = arr[i, j] + leftVal > arr[i,j] + topVal ? arr[i, j] + leftVal : arr[i,j] + topVal;
                            arr2[i,j] = maxVal;                            
                        }
                    }
                }

                return arr2[numRows-1, numCols-1];             
            }
        #endregion
    }
}
