using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[,] matrixA = new int[10, 10];
            int rowsArray = 0;
            int columnsArray = 1;
            int greatestNumberMatrixA = 0;
            int amountGreatestNumberMatrixA = 0;
            int maximumNumberMatrixA = 10;
            int minimumNumberMatrixA = 1;

            for (int currentRow = 0; currentRow < matrixA.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrixA.GetLength(columnsArray); currentColumn++)
                {
                    matrixA[currentRow, currentColumn] = random.Next(minimumNumberMatrixA, maximumNumberMatrixA);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Исходная матрица");
            Console.WriteLine(" -----------------------------------------");
            for (int currentRow = 0; currentRow < matrixA.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrixA.GetLength(columnsArray); currentColumn++)
                {
                    Console.Write(" | " + matrixA[currentRow, currentColumn]);
                }
                Console.WriteLine(" | ");
            }
            Console.WriteLine(" -----------------------------------------");

            for (int currentRow = 0; currentRow < matrixA.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrixA.GetLength(columnsArray); currentColumn++)
                {
                    if (greatestNumberMatrixA <= matrixA[currentRow, currentColumn])
                    {
                        greatestNumberMatrixA = matrixA[currentRow, currentColumn];
                    }
                }
            }

            for (int currentRow = 0; currentRow < matrixA.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrixA.GetLength(columnsArray); currentColumn++)
                {
                    if (greatestNumberMatrixA == matrixA[currentRow, currentColumn])
                    {
                        matrixA[currentRow, currentColumn] = 0;
                        amountGreatestNumberMatrixA += 1;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n -----------------------------------------");
            Console.WriteLine($" Наибольшее число матрицы: {greatestNumberMatrixA} | Всего таких чисел в матрице: {amountGreatestNumberMatrixA}");
            Console.WriteLine(" -----------------------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Полученная матрица");
            Console.WriteLine(" -----------------------------------------");
            for (int currentRow = 0; currentRow < matrixA.GetLength(rowsArray); currentRow++)
            {
                for (int currentColumn = 0; currentColumn < matrixA.GetLength(columnsArray); currentColumn++)
                {
                    Console.Write(" | " + matrixA[currentRow, currentColumn]);
                }
                Console.WriteLine(" | ");
            }
            Console.WriteLine(" -----------------------------------------");
        }
    }
}