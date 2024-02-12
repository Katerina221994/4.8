using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведиете количество строк: \n");
            int strings = int.Parse(Console.ReadLine());


            Console.WriteLine("\nВведите количество столбцов: \n");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix_1 = new int[strings, columns];

            Random random = new Random();

            int elementSum = 0;


            Console.WriteLine("\nМатрица: \n");
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix_1[i, j] = random.Next(10);

                    elementSum += matrix_1[i, j];

                    Console.Write(" " + matrix_1[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine($"\nСумма элиметов матрицы: {elementSum}. При нажатии на любую кнопку будет переход ко второму заданию");

            Console.ReadLine();



            Console.WriteLine(" \nПервая матрица: \n");

            int[,] matrix_2 = new int[strings, columns];


            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix_2[i, j] = random.Next(10);

                    Console.Write(" " + matrix_2[i, j]);
                }
                Console.WriteLine();



            }
            Console.WriteLine(" \nВторая матрица:\n");
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix_1[i, j] = random.Next(10);

                    Console.Write(" " + matrix_1[i, j]);
                }
                Console.WriteLine();
            }

            int[,] matrixSumm = new int[strings, columns];
            Console.WriteLine(" \nСумма матриц:\n");
            for (int i = 0; i < strings; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixSumm[i, j] = matrix_1[i, j] + matrix_2[i, j];
                    Console.Write($"{matrixSumm[i, j]}");

                }
                Console.WriteLine();

            }

            Console.ReadLine();

        }

    }
}
 

        
    

