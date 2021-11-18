using System;

namespace zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для поэлементного сложения и вычитания двумерных массивов, а после выводит среднее значение всех эллементов входных массивов.");
            int[,] myArray = new int[3, 3];
            Random rand = new Random();
            Console.WriteLine("Первый массив: ");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = rand.Next(1,10);
                    Console.Write(" " + myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");

            int[,] myArray2 = new int[3, 3];
            Console.WriteLine("Второй массив: ");
            for (int i = 0; i < myArray2.GetLength(0); i++)
            {
                for (int j = 0; j < myArray2.GetLength(1); j++)
                {
                    myArray2[i, j] = rand.Next(1,10);
                    Console.Write(" " + myArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Введите действие которое вам необходимо: '+','-' или 'Sr' (Среднее значение): ");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "+":
                    Console.WriteLine("Сумма массивов равна: ");
                    int[,] Sum = new int[3, 3];
                    for (int i = 0; i < Sum.GetLength(0); i++)
                    {
                        for (int j = 0; j < Sum.GetLength(1); j++)
                        {
                            Sum[i, j] = myArray[i, j] + myArray2[i, j];
                            Console.Write("  "+ Sum[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("________________________________________________________________________________");
                    break;
                case "-":
                    Console.WriteLine("Разность массивов равна: ");
                    int[,] Dif = new int[3, 3];
                    for (int i = 0; i < Dif.GetLength(0); i++)
                    {
                        for (int j = 0; j < Dif.GetLength(1); j++)
                        {
                            Dif[i, j] = myArray[i, j] - myArray2[i, j];
                            Console.Write("  " + Dif[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("________________________________________________________________________________");
                   break;
                case "Sr":
                    Console.WriteLine("Среднее значение массивов равно: ");
                    int[,] Sr = new int[3, 3];
                    for (int i = 0; i < Sr.GetLength(0); i++)
                    {
                        for (int j = 0; j < Sr.GetLength(1); j++)
                        {
                            Sr[i, j] = (myArray[i, j] + myArray2[i, j]) / 2;
                            Console.Write("  " + Sr[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("________________________________________________________________________________");
                    break;
                default:
                    Console.WriteLine("Программа не может распознать данное действие.");
                    break;
            }
        }
    }
}
