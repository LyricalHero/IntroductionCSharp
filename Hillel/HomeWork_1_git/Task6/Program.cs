using System;
using static System.Console;

/*написать программу, которая вычисляет квадрат любого, введенного числа. */

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
 //переменная для любого числа
            double SomeNumber, result=0;

            Write("Введите какое-нибудь число: ");
            SomeNumber = Convert.ToDouble(ReadLine());
 //вівод квадрата числа
            result = SomeNumber * SomeNumber;
            WriteLine("Квадрат числа " + SomeNumber + " равен " + result);

            ReadLine();
        }
    }
}
