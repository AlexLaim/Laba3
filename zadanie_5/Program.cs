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
            //for (int r = 0; r < Mul.GetLength(0); r++)
            //{
            //    for (int c = 0; c < Mul.GetLength(1); c++)
            //    {
            //        Mul[r, c] += myArray[r, c] * myArray2[c, r];// + myArray[r + 1, c + 1]
            //        Console.Write("  " + Mul[r, c]+" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("________________________________________________________________________________");  
            for (int r = 0; r < myArray.GetLength(0); r++)
            {
                for (int c = 0; c < myArray.GetLength(1); c++)
                {
                    for (int k = 0; k < myArray.GetLength(0); k++)
                    {
                        Mul[r, c] += myArray[r, k] * myArray2[k, c];
                    }
                }
            }
            for (int r = 0; r < myArray.GetLength(0); r++) 
            {
                for (int c = 0; c < myArray.GetLength(1); c++)
                {
                    Console.Write(" " + Mul[r, c] + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
