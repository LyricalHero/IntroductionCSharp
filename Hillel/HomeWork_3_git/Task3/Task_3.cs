using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*3. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым. */

namespace Task3 {
    class Task_3 {
        static void Main(string[] args) {
            uint number = 0, summLeft=0, summRight = 0;
            string strNumber = "";

            Write("Ведите Ваш номер билетика и мы скажем счастливый ли он: ");
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
//проверка является ли это число в нужном нам диапазоне(от 0 до 999999)
                if (number <= 0 & number >= 999999) {
                    WriteLine("Вы ввели число, которое не входит в диапазон от {0} до {1}\nПопробуйте еще раз!", 0, 999999);
                    continue;
                }
 //проверка является ли введеное число шестизначным
                else {
                    strNumber += number;
                    if (strNumber.Length < 6) {
                        WriteLine("Введите шестизначное число!");
                        continue;
                    }
                    else
                        break;

                }
            }
//цикл, который проходит по каждой цифре в нашем числе  
//используем Char.GetNumericValue(buffStr[i]) что бы получить символ который находится на нужной нам позии 
//и конвертируем этот символ в int, так как buffStr[i] нам возвращает ASCII код символа
            for (int i = 0; i < strNumber.Length; i++) {
                //если текущее число находится с левой стороны то мы суммируем к summLeft
                if (i <= 2)
                    summLeft += (uint)(Char.GetNumericValue(strNumber[i]));
                //если текущая цифра находится с правой стороны чисел билетика
                else
                    summRight += (uint)(Char.GetNumericValue(strNumber[i]));
            }
//вывод результата пользователю

            if (summLeft == summRight)
                WriteLine("Вам попался частливый билетик :) ");
            else
                WriteLine("Увы, Ваш билетик не счастливый");


            Write("\n\nНажмите 'Enter' для выхода из программы ");
            ReadLine();
        }
    }
}
