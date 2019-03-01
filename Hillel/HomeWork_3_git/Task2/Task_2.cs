using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

/*2. Ввести с клавиатуры число в диапазоне от 100 до 100000000 (введенное число проверяется). 
Подсчитать количество четных и нечетных цифр в этом числе в процентном отношении. */

namespace Task2 {
    class Task_2 {
        static void Main(string[] args) {
 //объявление переменных для хранения самого числа вводимого с клавиатуры, и числовых диапазов для условия
 //+ переменные-счетчики для количества четных и нечетных цифр
            uint number = 0, firstRange = 100, secondRange = 100000000;
            uint numEven = 0, numOdd = 0;    //even - четное odd - нечетное
   
            WriteLine("Введите число в диапазоне от {0} до {1}: ", firstRange, secondRange);
 //бесконечный цикл, который считывает ввобимое пользователем значение
 //завершается только при условии что введены корректные данные и иони в нужном нам диапазоне значений
            for(; ; ) {
                try {
                    number = Convert.ToUInt32(ReadLine());
                }
                catch {
                    WriteLine("Вы ввели некорректное значение, попробуйте еще раз!");
                    continue;
                }

                if (number < firstRange || number > secondRange) {
                    WriteLine("Вы ввели число, которое не входит в диапазон от {0} до {1}\nПопробуйте еще раз!", firstRange, secondRange);
                    continue;
                }
                else
                    break;
            }

//что бы узнать количество цифр, которые ввел пользователь запишем его число в строку
//c этой строкой в дальнейшем будем работать

            string buffStr = "";
            buffStr += number;
            int countNumbers = buffStr.Length;
            
 //цикл, который проходит по каждой цифре в нашем числе           
            for (int i=0; i < countNumbers ; i++) {
                //используем Char.GetNumericValue(buffStr[i]) что бы получить символ который находится на нужной нам позии 
                //и конвертируем этот символ в int, так как buffStr[i] нам возвращает ASCII код символа
                //тут же проверяем на четность/нечетность
                if ((int)(Char.GetNumericValue(buffStr[i])) % 2 == 1)
                    numOdd++;
                else
                    numEven++;               
            }

            //вывод результата пользователю
            WriteLine("В вашем числе {0} {1} четных и {2} нечетных чисел\nВ процентном соотнешинии {3}% четных и {4}% нечетных чисел :)", 
                number, numEven ,numOdd,(numEven*100/countNumbers), (numOdd*100/countNumbers) );
            Write("\n\nНажмите 'Enter' для выхода из программы ");
            ReadLine();

        }
    }
}
