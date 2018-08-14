using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Консольный калькулятор (версия 1.0)");
                Console.WriteLine(' ');
                Console.WriteLine(@"Выберите арифметическое действие: 
             - Умножение (введите *) 
             - Деление (введите /) 
             - Сложение (введите +) 
             - Вычитание (введите -)");
                string q = Console.ReadLine();
                double a, b;
                Console.WriteLine(' ');
                Console.WriteLine("Введите первое значение");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе значение");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(' ');
                if (q == "*")
                    Console.WriteLine("Результат умножения = {0}", a * b);
                if (q == "/")
                    Console.WriteLine("Результат деления = {0}", a / b);
                if (q == "+")
                    Console.WriteLine("Результат сложения = {0}", a + b);
                if (q == "-")
                    Console.WriteLine("Результат вычитания = {0}", a - b);

                Console.ReadKey();
                Console.Clear();
                ////
            }
        }
    }
}