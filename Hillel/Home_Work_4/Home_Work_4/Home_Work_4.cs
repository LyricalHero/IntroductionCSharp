using System;
using static System.Console;

/*Домашнее задание 4*/

namespace Home_Work_4 {
    class Home_Work_4 {
        static void Main(string[] args) {
            int a = 0, b = 0, c = 0, positiveNumber = 0, negativeNumber = 0; 
            //инициализация переменніх пользователем
            UserInput("Введите значение переменной A: ", ref a);
            UserInput("Введите значение переменной B:", ref b);
            UserInput("Введите значение переменной C:", ref c);

            Task_1(ref a,ref b,ref c);
            Task_2();
            Task_5();
            Write("\nКоличество положительных цифр в вашем наборе ({0}, {1}, {2}) = {3}",a,b,c, Task_6(a, b, c) );
           


            WriteLine("\nДля продолжения нажмите \"Enter \"");
            ReadLine();
        }

        /* Метод для пользователя - запрос на введение значений 
            и проверка корректности ввода значения для  целочисленых чисел
            и будет запрос до тех пор , пока не введет целочисленное значение*/
        static void UserInput(string message, ref int variable) {
            Write(message);
            for (; ; ) {
                try {
                    variable = Convert.ToInt32(ReadLine());
                    break;
                }
                catch {
                    Write("Вы ввели не целочиcленное значение, попробуйте еще раз: ");
                    continue;
                }
            }
        }

            /*Task 1: Даны переменные A, B, C.
             * Изменить их значения, переместив содержимое A в B, B — в C, C — в A,
             * и вывести новые значения переменных A, B, C.
             * передаю параметры по ссылку что бы внутри менялись значеня
             поставил пользователю ограничение на то, что он может вводить только int*/
            static void Task_1 (ref int A ,ref int B ,ref int C ) {
            int temp = 0;
            temp = A;
            A = C;
            C = B;
            B = temp;
            WriteLine($"Если изменить значения Ваших переменных " +
                $"переместив содержимое A в B, B — в C, C — в A, " +
                $"То получим А = {A}, B = {B}, C = {C} \n");
        }

        /*2. Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы). 
         * Для нахождения десятков использовать операцию деления нацело, 
         * для нахождения единиц — операцию взятия остатка от деления 
         */
        static void Task_2() {
            int number = 0, leftNumber = 0, rightNumber = 0;
//цикл заппроса введения числа до тех пор, пока пользователь не введет двухзначное
            for (; ; ) {
                UserInput("Введите целое двузначное число: ",ref number);
                if ((number >= 10 && number <= 99) | (number >= -99 && number <= -10)) { break; }
                    else { continue;  }
            }
            leftNumber = number / 10;
            rightNumber = number % 10;
            WriteLine("Левая цифра (десятки) = {0}, " +
                "правая цифра (единицы) = {1}.", leftNumber, rightNumber);
        }

        /*5. Дано целое число. Если оно является положительным, то прибавить к нему 1; 
         * если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10.
         * Вывести полученное число.*/
        static void Task_5() {
            int number = 0;
            string sOutput = "Ваше число ";
            UserInput("Введите целое число: ", ref number);
            if (number > 0) {
                number += 1;
                sOutput += "- положительное, мы прибавили к нему 1 и оно равно " + number;
            }
             else if (number < 0) {
                number -= 2;
                sOutput += "- отрицательное, мы вычли из него 2 и оно равно " + number;
            }
                else {
                number = 10;
                sOutput += "равно нулю, мы заменили его на 10" ;
            }
            Write( sOutput+ "\n");
        }

        /*6. Даны три целых числа. Найти количество положительных чисел в исходном наборе */
        static byte Task_6(int A, int B, int C) {
            byte result = 0;
            if (A >= 0) { result++; }
            if (B>=0) { result++; }
            if (C >= 0) { result++; }
            return result;
        }

        /*7. Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
         * для нахождения кол-ва положительных чисел использовал метод Task_6 который выполняет эту логику
         в передаваемых параметрах переменные для количества положительных и отрицательных чисел указал через 
         параметр out ,поскольку нет возможности вернуть 2 параметра(не используя перечисления, массивы и Tuple)*/
        static void Task_7 (int A, int B, int C, out int positiveNumber , out int negativeNumber ) {
            positiveNumber = Task_6(A,B,C);
            negativeNumber = 0;
            if (A < 0) { negativeNumber++; }
            if (B < 0) { negativeNumber++; }
            if (C < 0) { negativeNumber++; }
        }



    }
}
