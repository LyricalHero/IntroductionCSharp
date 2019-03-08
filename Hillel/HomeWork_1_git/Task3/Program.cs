using System;
using static System.Console;

/*Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.*/

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
 //для читабельности создал переменную string 
            string str = "  ";
            byte a = 7, b = 15, c = 100; 

            WriteLine(a + str + b + str + c);

            ReadLine();

        }
    }
}
