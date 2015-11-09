using System;
using CodingQuestion2.Domain;
using CodingQuestion2.Interfaces;

namespace CodingQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of rows");
            string rowString = Console.ReadLine();

            int rows, columns;
            if(!int.TryParse(rowString, out rows) && rows > 0)
            {
                Console.WriteLine("The value provided is not a positive integer integer.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the number of columns");
            string columnString = Console.ReadLine();

            if (!int.TryParse(columnString, out columns) && columns > 0)
            {
                Console.WriteLine("The value provided is not a positive integer integer.");
                Console.ReadLine();
                return;
            }

            IGenerator generator = new MatrixGenerator();
            int[,] matrix = generator.GenerateMatrix(rows, columns);
            string result = generator.PrintMatrix(matrix);

            Console.WriteLine("The generated matrix:");
            Console.WriteLine(result);

            ITraversal traversal = new MatrixTraversal(matrix);
            string traversalString = traversal.TraverseMultidimensionalMatrx();
            Console.WriteLine("The traversal is: " + traversalString);

            Console.ReadLine();
        }
    }
}
