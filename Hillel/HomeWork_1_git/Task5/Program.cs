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
            double a, b, result;
            Write("Введите одно число: ");
            a = Convert.ToDouble(ReadLine());
            Write("\b введите второе число: ");
            b = Convert.ToDouble(ReadLine());
 // после того, как пользователь ввел числа выводим результат, 
 //конвертируем в любом случае к 'double', т.к. результат деления может біть с плавающей точкой
            result = (a + b) / 2;
            WriteLine("Среднее арифметическое этих чисел равно {0}", result);


            ReadLine();
        }
    }
}
