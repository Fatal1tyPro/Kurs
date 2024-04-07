using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            class Program1
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Введите первое число [0-255]: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Введите второе число [0-255]: ");
                    int num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Результат деления: " + (num1 / num2));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введено не число");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число вне допустимого диапазона");
                }
            }
        }

    }
}

