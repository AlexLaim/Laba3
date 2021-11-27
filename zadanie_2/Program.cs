using System;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа поворота двумерного массива  размерности 7х7  на 90 градусов вправо");
            int[,] myArray = new int[7, 7];
            Random rand = new Random();
            Console.WriteLine("Начальный массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(10);
                    Console.Write(" " + myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");
            //Console.WriteLine("Перевернутый массив: ");
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{ 
            //    for (int j = myArray.GetLength(1) - 1; j>=0; j--)
            //    {
            //        Console.Write(" " + myArray[j, i]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("________________________________________________________________________________");
            //Поворот массива на 90 градусов по часовой стрелке
            int[,] myArray2 = new int[7, 7];
            Console.WriteLine("Перевернутый массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                   myArray2[i, j] = myArray[j, i];
                }
            }
            for (int i = 0; i < myArray.GetLength(0) / 2; i++) //myArray.GetLength(0)/2 - кол-во слоёв, которые мы вращаем.
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {

                    int mas = myArray2[j, i];
                    myArray2[j, i] = myArray2[j, myArray.GetLength(1) - 1 - i];
                    myArray2[j, myArray.GetLength(1) - 1 - i] = mas;
                }
            }
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(" " + myArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");
            // Еще 1 способ поворота массива по часовой стрелке на 90 градусов
            int[,] myArray3 = new int[7, 7];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray3[i, j] = myArray[myArray.GetLength(0) - j - 1, i];
                    Console.Write(" " + myArray3[i, j]);
                }
                  Console.WriteLine();
            }
             Console.WriteLine("________________________________________________________________________________");
        }
    }
}
