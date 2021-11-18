using System;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа циклического сдвига массива на k позиций влево.");
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
            Console.WriteLine("Введите число k элементов на которые будет сдвинут массив (влево): ");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[x];
            if (k == 0)
            {
                while (k == 0)
                {
                    Console.WriteLine("k = 0. Массив останется без изменений. Введите отличное от 0 число.");
                    k = int.Parse(Console.ReadLine());
                }
            }
            Random rand = new Random();
            Console.WriteLine("Начальный массив заполненый рандомными значениями до 10-ти: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1,10);
                Console.Write(" " + myArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < k; ++i)
            {
                int aLast = myArray[0];
                for (int j = 0; j < x - 1; j++)
                    myArray[j] = myArray[j + 1];
                myArray[x - 1] = aLast;
            }
            for (int i = 0; i < x; ++i)
                Console.Write(" " + myArray[i]);
            Console.WriteLine();
        }
    }
}
