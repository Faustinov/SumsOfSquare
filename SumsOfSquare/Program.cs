using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Напишите программу, которая вводит натуральные числа a и b, 
            и выводит сумму квадратов натуральных чисел в диапазоне от a до b.
            */

            Console.Write("Input number 'a': ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input number 'b' (should be greater then 'a'): ");
            int b = int.Parse(Console.ReadLine());
            // если второе число меньше первого то выводим ошибку
            if(a > b)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error. Number 'b' should be greater or equal then 'a'");
                return;
            }
            int result = 0;
            // задаем диапазон
            for (int i = a; i <= b; i++)
            {
                result += i * i;      // возводим в квадрат число из диапазона
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result is: " + result);                        
        }
    }
}
