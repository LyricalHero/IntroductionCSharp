using System;
using static System.Console;

/* Написать программу, вычисляющую среднее арифметическое двух чисел.*/

namespace Task5
{
    class Task_5
    {
        static void Main(string[] args)
        {
 // не факт, что пользователь вводит целые числа, поэтому 'double'
            double a, b;
            Write("Введите одно число: ");
            a = Convert.ToDouble(ReadLine());
            Write("\b введите второе число: ");
            b = Convert.ToDouble(ReadLine());
 // после того, как пользователь ввел числа выводим результат, не обязательно для этого создавать новую переменную,
 //конвертируем в любом случае к 'double', т.к. результат деления может біть с плавающей точкой

            WriteLine("Среднее арифметическое этих чисел равно {0}", (double)(a+b)/2.0);


            ReadLine();
        }
    }
}
