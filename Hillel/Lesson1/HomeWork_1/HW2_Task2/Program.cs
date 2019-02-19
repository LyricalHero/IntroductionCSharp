using System;
using static System.Console;

/*  Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение "Вы ввели число".​*/

namespace HW2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
 //хоть задание со звездочкой, с считыванием вводимого пользователем числа разобрался ранее

            double Number;
            WriteLine("Введите число: ");
 //обязательно нужно конвертировать в строку, т.к. Console.ReadLine() возвращает нам string

            Number = Convert.ToDouble(ReadLine());

            WriteLine("Вы ввели число " + Number);

            ReadLine();
        }
    }
}
