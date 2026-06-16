using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, sum;
            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
            }
            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
            }
            sum = num1 + num2;
            Console.WriteLine($"Сумма: {num1} + {num2} = {sum}");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}