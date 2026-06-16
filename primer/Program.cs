using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;
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
            Console.Write("Введите операцию (+, -, *, /): ");
            string inputOperation = Console.ReadLine();

            while (string.IsNullOrEmpty(inputOperation) || !"+-*/".Contains(inputOperation))
            {
                Console.WriteLine("Некорректный символ операции. Попробуйте еще раз:");
                inputOperation = Console.ReadLine();
            }

            operation = inputOperation[0];

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case '/':
                    if (IsZero(num2))
                    {
                        Console.WriteLine("Ошибка: деление на ноль невозможно.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        static bool IsZero(double number)
        {
            const double epsilon = 1e-10;
            return Math.Abs(number) < epsilon;
        }
    }
}