// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


using System;

namespace task10
{
    class Program
    {
         static void Main(string[] args)
        {
          Console.Write("Введите число: ");
          int number = int.Parse(Console.ReadLine()!);
          SecondDigit(number);

        }

        static void SecondDigit(int number){

            int second_digit = (number/10)%10;
            Console.WriteLine("Вторая цифра = " + second_digit);
        }
    }
}
