// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Введите число: ");
          int number = Convert.ToInt32(Console.ReadLine()!);
          string number1 = Convert.ToString(number);
          ThirdDigit(number1);
        }

        static void ThirdDigit(string number1){

            if(number1.Length > 2){
              Console.WriteLine("Третья цифра = " + number1[2]);
            }
            else{
              Console.WriteLine("Третьей цифры нет");                    
            }           
        }
    }
}
