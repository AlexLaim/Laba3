using System;

namespace Ind_2
{
    class Program
    {
        static void Main(string[] args)
        {//Вариант 7
            Console.WriteLine("программа, которая выводит на экран TRUE, если все суммы симметричных элементов массива равны, иначе – FALSE.");
            Console.WriteLine("Введите кол-во эллементов массива: ");
            int x = int.Parse(Console.ReadLine());
            int[] myArray = new int[x];
            if (x == 0)
            {
                while (x == 0)
                {
                    Console.WriteLine("Кол-во эллементов массива не может быть равно нулю! Введите число отличное от нуля.");
                    x = int.Parse(Console.ReadLine());
                }
            }
            if (x % 2 == 1)
            {
                while (x % 2 == 1)
                {
                    Console.WriteLine("Кол-во эллементов массива должно быть четным! Введите четное число.");
                    x = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("Задайте значение элемента массива ");
                int b = int.Parse(Console.ReadLine());
                myArray[i] = b;
            }
            Console.WriteLine("Исходный массив: ");
            int k = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(" " + myArray[i]);
                k++;
                while (k == 10)
                {
                    Console.WriteLine();
                    k = 0;
                }
            }
            Console.WriteLine();
            Console.WriteLine("________________________________________________________________________________");
            int a = myArray[0] + myArray[x - 1];  // симметрия {1, 2, 3, 1, 2, 3}  0+5=1+4=2+3
                                                  //индексы    0  1  2  3  4  5
            int  o = 0, q1, p = 0;
            for (int i = 1; i < myArray.Length; i++)
            {
                q1 = myArray[0 + i] + myArray[x - 1 - i];
                if (q1 == a)
                {
                    p ++;
                }if(q1 != a)
                {
                    o++;
                    p--;
                }
                if(p == 1)
                {
                    Console.WriteLine("True");
                }
                if(o==1)
                {
                    Console.WriteLine("False");
                } 
            }
        }
    }
}
