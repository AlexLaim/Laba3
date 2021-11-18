using System;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, которая запрашивает число элементов массива, после чего  создает  массив, заполняет  его  случайными  целыми  числами и выводит его на экран");
            Console.WriteLine("Введите кол-во эллементов массива: ");
            int x = int.Parse(Console.ReadLine());
            int[] myArray = new int[x];
            int j = 0;
            if (x == 0)
            {
                while (x == 0)
                {
                    Console.WriteLine("Кол-во эллементов массива не может быть равно нулю! Введите число отличное от нуля.");
                    x = int.Parse(Console.ReadLine());
                }
            }
                Random rand = new Random();
            Console.WriteLine("Вывод элементов массива заполненного случайными числами в диапазоне от -30 до 45 ");
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(-35, 45);
                    Console.Write("{0}\t", myArray[i], 4);
                    j++;
                    while (j == 10)
                    {
                        Console.WriteLine();
                        j = 0;
                    }
            }
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Вывод массива в обратном порядке игнорируя отрицательные значения");
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                if (myArray[i] >= 0)
                {
                    
                    Console.Write("{0}\t", myArray[i], 4);
                    j++;
                        while (j == 10)
                    {
                        Console.WriteLine();
                        j = 0;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
