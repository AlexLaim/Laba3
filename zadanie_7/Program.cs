using System;

namespace zadanie_7
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа демонстрирует рекурсивную  функцию  для  нахождения  n-ого  члена  ряда Фибоначчи по формулам, приведенным в лабораторной работе No2");
            Console.WriteLine("Введите номер элемента значение которого вы хотите знать.");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                while (x == 0)
                {
                    Console.WriteLine("Счёт элементов начинается с 1!");
                    x = int.Parse(Console.ReadLine());
                }
            }
            double rec(int x)
            {

                if (x == 1 || x == 2)
                {
                    return 1;
                }
                else
                {
                    return rec(x - 1) + rec(x - 2);
                } 
            }
            Console.WriteLine($"Значение элемента под номером {x} = {rec(x)}");
        } 
    } 
}
