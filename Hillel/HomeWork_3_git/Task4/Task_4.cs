using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.*/

namespace Task4 {
    class Task_4 {
        static void Main(string[] args) {
            uint number = 0;
            string strNumber = "", strOutput="";

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
            //перезапись в новую строку strOutput входную строку задом наперед
            for (int i=2;i>=0;i--) {
                strOutput += strNumber[i];
            }
            //перезаписываем новое значение в числовом формате входного числа только задом-наперед
            number = Convert.ToUInt32(strOutput);

            WriteLine("Ваше число в обратном порядке: {0}", number);

            Write("\n\nНажмите 'Enter' что бы выйти из программы");
            ReadLine();
        }
    }
}
