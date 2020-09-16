using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5_Calc
{
    public class Program
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
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Вводите через пробел(выход - Alt+F4)");
                Console.ForegroundColor = ConsoleColor.Red;

                double a = 0, b = 0;
                string[] splitText = null;
                bool parse = false;
                do
                {
                    try
                    {
                        string text = Console.ReadLine();
                        splitText = text.Split(new char[] { ' ' });
                        a = double.Parse(splitText[0]);
                        b = double.Parse(splitText[2]);
                        parse = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Неправильный ввод!");
                        parse = false;
                    }
                } while (!parse);
                string op = splitText[1];
                try
                {
                    Console.WriteLine(' ');
                    if (op == "*")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат умножения = {0}", multiply(a, b));
                       
                    }
                    if (op == "/")
                    {
                        if (b == 0)
                        {
                            throw new Exception("Деление на ноль!!!");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат деления = {0}",divide(a,b));
                    }
                    if (op == "+")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат сложения = {0}", add(a,b));
                    }
                    if (op == "-")
                    {
                        substring(a, b);
                    }
                    if (op == "^")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
                    }
                    if (op == "%")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Остаток от деления {a}/{b} = {modulo(a,b)}");
                    }
                    if (op == "&")
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            double sqrtres = sqrt(a, b);
                            if (sqrtres.Equals(Double.NaN))
                                throw new Exception(" \"Result not a number!\" ");

                            Console.WriteLine($"Корень {a} из {b} = {sqrtres}");

                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Возникло исключение:" + ex.Message);

                        }

                    }
                    Console.ReadKey();
                }
                catch (Exception ex) when (op == "/")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникло исключение:" + ex.Message);
                }
            }
        }
        static public double divide(double a, double b)
        {   
            return a / b;
        }
        static public double multiply(double a, double b)
        {
            return a * b;
        }
        static public double add(double a, double b)
        {
            return a + b;
        }
        static void substring(double a, double b)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Результат вычитания = {0}", a - b);
        }
        static public double power(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static public double modulo(double a, double b)
        {
            return a % b;
        }
        static public double sqrt(double a, double b)
        {
            return Math.Pow(a, (1 / b));
        }
    }
}
