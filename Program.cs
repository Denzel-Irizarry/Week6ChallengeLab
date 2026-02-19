using System.Data;

namespace Week6ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize array
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            //{
            //    int count = 0;
            //    Console.WriteLine(matrix[i, count]);
            //    //Console.WriteLine(matrix[count,i]);
            //    count++;
            //    Console.WriteLine("second for starts here");
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {

            //        Console.WriteLine(matrix[j, i]);

            //    }
            //    Console.WriteLine("third for start here");
            //    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
            //    {
            //        Console.WriteLine(matrix[j, i]);
            //    }

            //    Console.WriteLine();
            //}

            int matrixLength = matrix.GetLength(0);

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = matrixLength - 1; j >= 0; j--)
                {
                    int temp = matrix[i, j];
                    matrix[i,j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }
            
            for (int i = 0; i < matrixLength; i++)
            {
                for(int j= 0; j < matrixLength / 2; j++)
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[i,matrixLength -1 - j];
                    matrix[i,matrixLength -1 - j] = temp;
                }
            }
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
       
    }
}
