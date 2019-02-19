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

            WriteLine(7 + str + 15 + str + 100);

            ReadLine();

        }
    }
}
