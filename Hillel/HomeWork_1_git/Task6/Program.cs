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
            double SomeNumber;

            Write("Введите какое-нибудь число: ");
            SomeNumber = Convert.ToDouble(ReadLine());
 //вівод квадрата числа
            WriteLine("Квадрат числа " + SomeNumber + " равен " + (SomeNumber*=SomeNumber));

            ReadLine();
        }
    }
}
