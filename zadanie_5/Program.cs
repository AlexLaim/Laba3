using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа перемножения двух матриц 5х5");
            int[,] myArray = new int[5, 5];
            Random rand = new Random();
            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(1, 10);
                    Console.Write(" " + myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");

            int[,] myArray2 = new int[5, 5];
            Console.WriteLine("Вторая матрица: ");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rand.Next(1, 10);
                    Console.Write(" " + myArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Перемножение матриц");
            int[,] Mul = new int[5, 5];
            for (int i = 0; i < Mul.GetLength(0); i++)
            {
                for (int j = 0; j < Mul.GetLength(1); j++)
                {
                    Mul[i, j] = myArray[i, j] * myArray2[i, j];
                    Console.Write("  " + Mul[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");
        }
    }
}
