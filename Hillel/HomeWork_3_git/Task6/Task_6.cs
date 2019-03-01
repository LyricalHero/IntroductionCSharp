using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/*6. Дано двузначное число. Найти: 
    а) число десятков в нем; 
    б) число единиц в нем; (как я понял это не количество "1")
    в) сумму его цифр; 
    г) произведение его цифр.
 */

namespace Task6 {
    class Task_6 {
        static void Main(string[] args) {
            uint number = 0, numD = 0, numE = 0, sum = 0, mult=0;
            string sbuff;

            Write("Введите двузначное число: ");
            //бесконечный цикл, который считывает ввобимое пользователем значение
            //завершается только при условии что введены корректные данные и они в нужном нам диапазоне значений
            for (; ; ) {
                try {
                    number = Convert.ToUInt32(ReadLine());

                }
                catch {
                    WriteLine("Вы ввели некорректное значение, попробуйте еще раз!");
                    continue;
                }
                //проверка является ли это число двузначным(в нужном нам диапазоне от 10 до 99)
                if (number >= 10 & number <=99) 
                    break;
                else {
                    WriteLine("Вы ввели не двузначное  число \nПопробуйте еще раз!");
                    continue;
                }                 

            }
            //число десятков
            numD = number / 10;
            //число единиц
            numE = number % 10;
            //сумма цифр
            sum = numD + numE;
            //произведение цифр
            mult = numD * numE;

            //Ввывод результата пользователю
            WriteLine("Число десятков в вашем числе: {0}\n" +
                "Число единиц в нём: {1} \n" +
                "Сумма цифр в вашем числе: {2}\n" +
                "Произведение цифр в вашем числе: {3}", numD, numE, sum, mult);


            Write("\n\nДля выхода из программы нажмите 'Enter' ");
            ReadLine();
        }
    }
}
