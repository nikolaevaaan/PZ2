// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Введите число: ");
          int number = int.Parse(Console.ReadLine()!);
          Days(number);
        }

        static void Days(int number){
            if(number >= 6){
               Console.WriteLine("Выходной день");
            }
            else{
                Console.WriteLine("Рабочий день");
            }
        }
    }
}
