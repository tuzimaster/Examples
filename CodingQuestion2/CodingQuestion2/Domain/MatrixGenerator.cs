using System;
using CodingQuestion2.Interfaces;

namespace CodingQuestion2.Domain
{
    public class MatrixGenerator : IGenerator
    {
        public int[,] GenerateMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows,columns];
            FillMatrix(matrix);
            return matrix;
        }

        private void FillMatrix(int[,] matrix)
        {
            //we know we have a 2d dimension matrix;  0 rows, 1 columns
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int number = 1;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = number;
                    number++;
                }
            }
        }

        public string PrintMatrix(int[,] matrix)
        {
            //we know we have a 2d dimension matrix;  0 rows, 1 columns
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            string result = string.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += matrix[i, j] + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}