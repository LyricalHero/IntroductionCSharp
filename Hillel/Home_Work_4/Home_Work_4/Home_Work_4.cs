﻿using System;
using static System.Console;

/*Домашнее задание 4*/

namespace Home_Work_4 {
    class Home_Work_4 {
        static void Main(string[] args) {
            int userSelectTask = 0; //флаг для выбора Таска
            //переменные для работы программ
            int a = 0, b = 0, c = 0, positiveNumber = 0, negativeNumber = 0, result = 0;
            string tempString = "";
            //бесконечный цикл который запрашивает у пользователя выбор программы при вводе 0 - завершение программы
            // если пользователь введет неправильный номер - спросит еще
            for (; ; ) {
                UserInput("\nВведите номер Задания от 1 до 25. Для выхода нажмите 0.\n",ref userSelectTask);
                if(userSelectTask == 0) { break; }
                switch (userSelectTask) {
                    case 1 :
                        Task_1(ref a, ref b, ref c);
                        break;
                    case 2:
                        Task_2();
                        break;
                    case 3:
                        Task_3();
                        break;
                    case 4:
                        Task_4();
                        break;
                    case 5:
                        result = Task_5();
                        Write(result);
                        break;
                    case 6:
                        Write("\nКоличество положительных цифр в вашем наборе ({0}, {1}, {2}) = {3}", a, b, c, Task_6(ref a,ref b,ref c));
                        break;
                    case 7:
                        Task_7(ref a, ref b, ref c, out positiveNumber, out negativeNumber);
                        Write("\nВ Вашем наборе ({0}, {1}, {2}) " +
                            "\nколичество положительных цифр = {3}" +
                            "\nколичество отрицательных цифр = {4}", a, b, c, positiveNumber, negativeNumber);
                        break;
                    case 8:
                        Task_8(ref a, ref b);
                        break;
                    case 9:
                        if (Task_9(ref a)) { WriteLine("Ваше число четное"); }
                        else { WriteLine("Ваше число нечетное"); }
                        break;
                    case 10:
                        WriteLine("Дина отрезка = {0} метр.", Task_10());
                        break;
                    case 11:
                        Task_11();
                        break;
                    case 12:
                        tempString = Task_12(ref result);
                        WriteLine("Вы ввели {0} {1}", result, tempString);
                        break;
                    case 13:
                        Task_13();
                        break;
                    case 14:
                        Task_14(ref a, ref b, ref c,ref result);
                        break;


                    default:
                        break;                   
                }

            }
                
            


            
            
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
        /*Еще один перегруженный метод запроса ввода для пользователя( 3х значений)  */
        static void UserInput (ref int A, ref int B, ref int C) {
            UserInput("Введите значение переменной A: ", ref A);
            UserInput("Введите значение переменной B:", ref B);
            UserInput("Введите значение переменной C:", ref C);
        }

        /*Task 1: Даны переменные A, B, C.
         * Изменить их значения, переместив содержимое A в B, B — в C, C — в A,
         * и вывести новые значения переменных A, B, C.
         * передаю параметры по ссылку что бы внутри менялись значеня
         поставил пользователю ограничение на то, что он может вводить только int*/
        static void Task_1 (ref int A ,ref int B ,ref int C ) {
            UserInput(ref A, ref B, ref C);
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
        static int Task_5() {
            int number = 0;
            string sOutput = "Ваше число ";
            UserInput("Введите целое число: ", ref number);
            if (number > 0) {
                number += 1;
                sOutput += "- положительное, мы прибавили к нему 1 и оно равно " ;
            }
             else if (number < 0) {
                number -= 2;
                sOutput += "- отрицательное, мы вычли из него 2 и оно равно " ;
            }
                else {
                number = 10;
                sOutput += "равно нулю, мы заменили его на 10" ;
            }
            Write( sOutput);
            return number;
        }

        /*6. Даны три целых числа. Найти количество положительных чисел в исходном наборе */
        static byte Task_6(ref int A,ref int B,ref int C) {
            UserInput(ref A, ref B, ref C);
            byte result = 0;
            if (A >= 0) { result++; }
            if (B >= 0) { result++; }
            if (C >= 0) { result++; }
            return result;
        }

        /*7. Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.
         * для нахождения кол-ва положительных чисел использовал метод Task_6 который выполняет эту логику
         в передаваемых параметрах переменные для количества положительных и отрицательных чисел указал через 
         параметр out ,поскольку нет возможности вернуть 2 параметра(не используя перечисления, массивы и Tuple)*/
        static void Task_7 (ref int A, ref int B, ref int C, out int positiveNumber , out int negativeNumber ) {
            positiveNumber = Task_6(ref A,ref B,ref C);
            negativeNumber = 0;
            if (A < 0) { negativeNumber++; }
            if (B < 0) { negativeNumber++; }
            if (C < 0) { negativeNumber++; }
        }

        /*8. Даны две переменные целого типа: A и B.
         * Если их значения не равны, то присвоить каждой переменной сумму этих значений, 
         * а если равны, то присвоить переменным нулевые значения.
         * Вывести новые значения переменных A и B.
         *  передаю параметры через ref - этим изменим значения*/
         static void Task_8(ref int A, ref int B) {
            UserInput("Введите значение переменной А: ", ref A);
            UserInput("Введите значение переменной B: ", ref B);
            if (A != B) {
                A = B = A + B;
                WriteLine($"Значения Ваших переменных не равны, поэтому мы присвоили каждой переменной сумму этих значений: " +
                    $"A = {A}, B = {B}");
            }
            else {
                A = B = 0;
                WriteLine($"Значения Ваших переменных равны, поэтому мы присвоили каждой переменной нулевое значение: " +
                    $"A = {A}, B = {B}");
            }
         }

        /*9. Напишите программу, проверяющую число на четность.*/
        static bool Task_9(ref int A) {
            UserInput("Введите число: ", ref A);
            if (A % 2 == 0) {
                return true;
            }
            else {
                return false;
            }
        }

        /*10. Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр. 
         * Дан номер единицы длины (целое число в диапазоне 1–5) и длина отрезка в этих единицах (вещественное число).
         * Найти длину отрезка в метрах. */
        static double Task_10() {
            double result = 0.0;
            int userLenght = 0, userChoice = 0;
            WriteLine("Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр.");
        //проверка на условие ввел ли пользователь значение в диапазоне от 1 до 5
            for (; ; ) {
                UserInput("Выберите единицу длины: ",ref userChoice);
                if(userChoice>0 && userChoice <= 5) {
                    break;
                }
                else {
                    WriteLine("Вы ввели чило не в диапазоне 1 - 5");
                }
            }
            UserInput("Введите длину отрезка: ", ref userLenght);
            switch (userChoice) {
            // дециметр
                case 1:
                    result = userLenght / 10.0;
                    break;
             //километр
                case 2:
                    result = userLenght * 1000.0;
                    break;
             //метр
                case 3:
                    result = userLenght * 100.0;
                    break;
             //милиметр
                case 4:
                    result = userLenght / 1000.0;
                    break;
            //сантиметры
                default:
                    result = userLenght /100.0;
                    break;
            }
            return result;
        }

        /*11. Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток) 
         * и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо.
         * Дан символ C — исходное направление робота и целое число N — посланная ему команда. 
         * Вывести направление робота после выполнения полученной команды. 
         сделал так, что выводит не 1 раз а можно игратся направлениями пока не надоест
         и после каждого изменения направления выводит текущее направление движения робота
         если надоест - пользователь вводит 2
         */
        static void Task_11() {
            WriteLine("Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток)" +
          "\nи принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. 2 - Выйти из Таска" +
          "\nСейчас он движется на Север.");
            int command = 0, flagActiveDirection = 0;
            string selectDirection = "СЗЮВ";
            char actualDirection = 'С';
            for(; ; ) {
                //цикл проверки корректного ввода команды пользователем
                for (; ; ) {
                    UserInput("Подайте комманду роботу: ", ref command);
                    if (command >= -1 & command <= 2) {
                        break;
                    }
                    else {
                        WriteLine("Роботу можно послать только команды: -1 , 0 , 1!");
                        continue;
                    }
                }
                switch (command) {
                    //прямо
                    case 0:
                        break;
                    //поворот направо
                    case -1:
                        if (flagActiveDirection == 0) { flagActiveDirection = 4; }
                        flagActiveDirection--;
                        actualDirection = selectDirection[flagActiveDirection];
                        break;
                    //поворот налево
                    case 1:
                        if (flagActiveDirection == 3) { flagActiveDirection = -1; }
                        flagActiveDirection++;
                        actualDirection = selectDirection[flagActiveDirection];
                        break;
                    //если пользователю надоело ,то нажал 2 и мы выходим из метода
                    default:
                        return;
                }
                WriteLine("Текущее направление Робота: " + actualDirection);
            } 
        }

        /*2. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). 
         * Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», 
         * например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год» 
         * (Есть несколько решений - найдите оптимальное)
         Решение, которое нашел :
         "Год" - только у чисел , которые заканчиваются на 1
         "Года" - у чисел, которые заканчиваются на 2,3,4
          Все остальные окончания чисел -  "Лет"*/
        static string Task_12(ref int age) {
            int yearSwich = 0;
            string strAnswer = "";
            for (; ; ) {
                UserInput("Введите целое число в диапазоне 20-69, определяющее возвраст(в годах): ", ref age);
                if(age >=20 & age <= 69) {
                    break;
                }
                else {
                    WriteLine("Вы ввели значение, которое не входит в диапазон от 20 до 69!");
                    continue;
                }
            }
            yearSwich = age % 10;
            if (yearSwich == 1) {
                strAnswer = "год.";
            }
            else if (yearSwich >=2 & yearSwich <=4) {
                strAnswer = "года.";
            }
            else {
                strAnswer = "лет.";
            }
            return strAnswer;
        }

        /*13. Угадать число, которое загадал пользователь, используя только инструкцию if-else. 
         поставил ограничение, что пользователь может загадать число от 1 до 3, т.к. может быть очень много else-if*/
        static void Task_13() {
            WriteLine("Загадайте число от 1 до 3 :)");
            int number = 0;
            string strOut = "Я угадал :)";
            UserInput("Вы загадали 2? Если Да - Нажмите 1, если Нет - любую цифру: ", ref number);
            if(number == 1) {
                WriteLine(strOut);
                return;
            }
            else {
                UserInput("Вы загадали 1 ? Если Да - нажмите 1 , если нет - любую цифру: ", ref number);
                if(number == 1) {
                    WriteLine(strOut);
                    return;
                }
                else{ 
                    UserInput("Тогда Вы точно загадали число 3, если да - нажмите 1 , если нет - любую цифру: ", ref number);
                    if(number == 1) {
                        WriteLine(strOut);
                        return;
                    }
                    else {
                        WriteLine("Так не честно, ты мухлюешь, надо было загадать число от 1 до 3");
                    }
                }
            }
        }

        /*14. Среди трех чисел найти среднее. Если среди чисел есть равные, вывести сообщение "Ошибка"*/
        static void Task_14(ref int A, ref int B, ref int C, ref int result) {
            
            UserInput(ref A, ref B, ref C);
            if (A==B | B==C | C==A) {
                WriteLine("Ошибка!");
                return;
            }
            

            
        }



        /*Task 3 и 4 - теоретические но выведется по запросу пользователя в качестве текста
         * 3. Если сделать объявление int i=11; чему будет равно значение выражения i / 5?*/
        static void Task_3() {
            string strOutput = "Если сделать объявление int i=11; чему будет равно значение выражения i / 5?" +
                "\n Ответ: 2\n";
            WriteLine(strOutput);
        }

        /*4. Каким будет значение b, если bool b=(double)(1/2) 
         4.1 Какого типа переменные подойдут для хранения следующей информации:
         Возраст человека Население города Число звезд в галактике Один байт ОЗУ Средняя зарплата за год 
         Сведения спортсмен или нет Цвет фигуры Длина в мм. 
         Длина в см. Фамилия человека Время года Пол человека */
        static void Task_4() {
            string strOutput = "4. Каким будет значение b, если bool b=(double)(1/2)" +
                "\nОтвет: Ошибка компиляции, т.к. недьзя приводить double k bool" +
                "\n4.1 Какого типа переменные подойдут для хранения следующей информации: " +
                "\nВозраст человека - byte достаточно, т.к. диапазон до 255." +
                "\nНаселение города - uint т.к. население не может быть отрицательным и вряд-ли население города превыcит 4 млн. человек" +
                "\nЧисло звезд в галактике - ulong т.к. гугл говорит, что в Нашей галактике 200 милиардов звезд" +
                "\nОдин байт ОЗУ - byte" +
                "\nСредняя зарплата за год - float достаточно, т.к. зарплата средняя, и хватит 2 разряда точности для копеек." +
                "\nСведения спортсмен или нет - bool" +
                "\nЦвет фигуры - string" +
                "\nлина в мм. - ulong т.к. можно и 1000 км. и большее количество к примеру хранить в милиметрах" +
                "\nДлина в см. - ulong т.к. можно и 1000 км. и большее количество к примеру хранить в милиметрах" +
                "\nФамилия человека - string" +
                "\nВремя года - string" +
                "\nПол человека - string или помечать одним символом char ('m'/ 'f')";
            Write(strOutput);
        }
    }
}
