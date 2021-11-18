using System;

namespace zadanie_8
{
    class Program
    {
        static double RecDet(int[,] myArray)
        {
            if (myArray.Length == 1)
                return myArray[0,0];
            if (myArray.Length == 4)
                return myArray[0, 0] * myArray[1, 1] - myArray[1, 0] * myArray[0, 1];
            else
            {
                double Det = 0;

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        int[,] m = Minor(myArray, i, j);
                        Det += Math.Pow(-1, i) * myArray[0, i] * RecDet(m);
                    }
                }
                return Det;
            }
        }
        static int[,] Minor(int[,] myArray, int col, int lin)
        {
            int[,] min = new int[myArray.GetLength(0) - 1, myArray.GetLength(1) - 1];
            int x = 0, z = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                z = 0;
                if (i == col)
                    continue;
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j == lin)
                        continue;
                    min[x, z] = myArray[i, j];
                    z++;
                }
                x++;
            }
            return min;
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Программа рекурсивно вычисляющая определитель матрицы.");
                Console.WriteLine("Введите двумерный массив вида [N,N]");
                Console.WriteLine("Введите N: ");
                int N = int.Parse(Console.ReadLine());
                int[,] myArray = new int[N, N];
                Random rand = new Random();
                Console.WriteLine("Ваша матрица: ");
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
            Console.WriteLine("Определитель матрицы равен:" + RecDet(myArray));
            }
    }
}
