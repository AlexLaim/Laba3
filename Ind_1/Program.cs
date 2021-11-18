using System;

namespace Ind_1
{
    class Program
    {
        static void Main(string[] args)
        {//Вриант 7
            Console.WriteLine("Программа заполняющая и отображающая на экране двумерный массив 9х9");
            Console.WriteLine("________________________________________________________________________________");
            int[,] myArray = new int[9, 9];
            int x = 1, k = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if ((j < i || j > myArray.GetLength(0)-1 - i) && i < myArray.GetLength(0)/2+1 || (j > i || j < myArray.GetLength(0) - 1 - i) && i >= myArray.GetLength(0)/2+1)
                    {
                        myArray[i, j] = x;
                        x++;
                    }
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("\t" + myArray[i, j]);
                    k++;
                    while (k == 9)
                    {
                        Console.WriteLine();
                        k = 0;
                    }
                }
            }
        }
    }
}
