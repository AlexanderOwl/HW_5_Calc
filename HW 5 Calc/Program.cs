using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"Калькулятор
         - Умножение *
         - Деление /
         - Сложение +
         - Вычитание -
         - Возведение числа в степень ^
         - Остаток от деления !
         - Корень &");
            for (; ; )
            {
                Console.WriteLine("Вводите через пробел(выход - Alt+F4)");
                Console.ForegroundColor = ConsoleColor.Red;
                string text = Console.ReadLine();
                string[] splitText = text.Split(new char[] { ' ' });
                double a = double.Parse(splitText[0]), b = double.Parse(splitText[2]);
                string op = splitText[1];

                Console.WriteLine(' ');
                if (op == "*")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат умножения = {0}", a * b);
                }
                if (op == "/" )
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль!!!");
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат деления = {0}", a / b);
                }
                if (op == "+")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат сложения = {0}", a + b);
                }
                if (op == "-")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат вычитания = {0}", a - b);
                }
                if (op == "^")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
                }
                if (op == "%")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Остаток от деления {a}/{b} = {a % b}"); ;
                }
                if (op == "&")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Корень {a} из {b} = {Math.Pow(a, (1 / b))}");
                }
                Console.ReadKey();
            }
        }
    }
}
