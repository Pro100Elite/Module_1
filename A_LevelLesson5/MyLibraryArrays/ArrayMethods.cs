using System;

namespace MyLibraryArrays
{
    public class ArrayMethods
    {
        static int num = 0;
        static int count = 0;
        static int[][,] StepsArray = new int[count][,];

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);

            var result = new int [columns, rows];

            for (var c = 0; c < columns; c++)
            {
                for (var r = 0; r < rows; r++)
                {
                    result[c, r] = matrix[r, c];
                }
            }
            return result;
        }

        public static int[][,] ArrayCreation(int n)
        {
            Array.Resize(ref StepsArray, count++);
            Random rand = new Random();
            int[,] array = new int[n, n];
            StepsArray[num] = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int min = rand.Next(0, 100);
                int max = rand.Next(min + 1, 200);
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(min, max);
                    StepsArray[num][i, j] = array[i, j];
                }
            }
            num++;

            return StepsArray;
        }
    }
}
