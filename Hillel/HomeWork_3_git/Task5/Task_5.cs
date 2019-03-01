using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*5. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.*/

namespace Task5 {
    class Task_5 {
        static void Main(string[] args) {
            uint number = 0;
            string strNumber = "", strOutput = "";

            Write("Введите трехзначное число: ");
            //бесконечный цикл, который считывает ввобимое пользователем значение
            //завершается только при условии что введены корректные данные и иони в нужном нам диапазоне значений
            for (; ; ) {
                try {
                    number = Convert.ToUInt32(ReadLine());

                }
                catch {
                    WriteLine("Вы ввели некорректное значение, попробуйте еще раз!");
                    continue;
                }
                //проверка является ли это число трехзначным (в нужном нам диапазоне от 100 до 1000)
                if (number < 100 | number >= 1000) {
                    WriteLine("Вы ввели не трёхзначное число \nПопробуйте еще раз!");
                    continue;
                }
                else
                    break;

            }

            strNumber += number;
            //тут не придумал универсального алгоритма, меняющего 1ю цифру со второй местами
            strOutput += strNumber[1];
            strOutput += strNumber[0];
            strOutput += strNumber[2];
 //вывод результата пользователю
            WriteLine("Если в вашем числе {0} поменять местами первую цифру со второй, то получим число {1}", number, Convert.ToUInt32(strOutput));




            Write("Нажмите 'Enter' для выхода из программы");
            ReadLine();
        }
    }
}
