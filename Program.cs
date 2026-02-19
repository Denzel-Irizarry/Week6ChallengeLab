using System.Data;

namespace Week6ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matrix2 = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
            int[,] reverse = RotateArray(matrix);
            int[,] reverse2 = RotateArray(matrix2);
            
            for(int i = 0; i < reverse.GetLength(0); i++)
            {
                for(int j = 0; j < reverse.GetLength(1); j++)
                {
                    Console.Write(reverse[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for(int i = 0; i < reverse2.GetLength(0); i++)
            {
                for(int j = 0; j < reverse2.GetLength(1); j++)
                {
                    Console.Write(reverse2[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
        static int[,] RotateArray(int[,] matrix)
        {
            int matrixLength = matrix.GetLength(0);

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = i; j < matrixLength; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength / 2; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, matrixLength - 1 - j];
                    matrix[i, matrixLength - 1 - j] = temp;
                }
            }

            return matrix;
        }
       
    }
}
