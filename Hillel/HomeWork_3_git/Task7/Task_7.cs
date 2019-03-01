using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*7. Дано трехзначное число. Найти: 
    а) число единиц в нем;  (Как я понял это не количество "1")
    б) число десятков в нем; 
    в) сумму его цифр; 
    г) произведение его цифр.
 */

namespace Task7 {
    class Task_7 {
        static void Main(string[] args) {
            uint number = 0, numD = 0, numE = 0, sum = 0, mult = 1;
            string sbuff = "";


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
            //число десятков
            numD = number / 10;
            //число единиц
            numE = number % 10;
            sbuff += number;
            //цикл прохода по каждой цифре числа в отдельности с помощью строк
            //т.к. sbuff[i]  возвращает нам ASCII код символа, то преобразовуем его к числовому типу,
            //и поторм преобразуем у uint
            for (int i=0;i<3;i++) {
                sum += (uint)Char.GetNumericValue(sbuff[i]);
                mult*= (uint)Char.GetNumericValue(sbuff[i]);
            }

            //вывод результата пользователю на экран
            WriteLine("Число единиц  в вашем числе: {0}\n" +
                "Число десятков в нём: {1} \n" +
                "Сумма цифр в вашем числе: {2}\n" +
                "Произведение цифр в вашем числе: {3}", numE, numD, sum, mult);




            Write("\n\nНажмите \"Enter\" для выхода из программы ");
            ReadLine();
        }
    }
}
