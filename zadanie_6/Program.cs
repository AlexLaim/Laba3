using System;

namespace zadanie_6
{
    class Program
    {
        //Итерационно
        static int SumIter(int[] myArray)
        {

            int sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i]; // sum = sum + mas[i]
            }

            return sum;
        }
        static int MinIter (int[] myArray)
        {
            int min = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            return min;
        }

        //Рекурсия
        static int SumRec(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return 0;
            return myArray[i] + SumRec(myArray, i + 1);
        }
         static int MinRec(int[] myArray, int pos, int min)
         {
            if (pos == myArray.Length)
            {
                return min;
            }
            if (myArray[pos] < min)
            {
              min = myArray[pos];
            }
            pos++;
            return MinRec(myArray, pos, min);
         }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа демонстрирующая работу следующих функций: sumIterative, sumRecursive, minIterative, minRecursive");
            Console.WriteLine("Введите кол-во элементов массива: ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                while (x == 0)
                {
                    Console.WriteLine("Кол-во эллементов массива не может быть равно нулю! Введите число отличное от нуля.");
                    x = int.Parse(Console.ReadLine());
                }
            }
            int[] myArray = new int[x];
            int j = 0;
            Random rand = new Random();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1, 10);
                Console.Write(" " + myArray[i]);
                j++;
                while (j == 5)
                {
                    Console.WriteLine();
                    j = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("sumIterative = " + SumIter(myArray));
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("minIterative = " + MinIter(myArray));
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("sumRecursive = " + SumRec(myArray));
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("minRecursive = " + MinRec(myArray, 0, myArray[0]));
        }
    }
}
