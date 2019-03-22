using System;
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
                UserInput("Введите номер Задания от 1 до 25. Для выхода нажмите 0.\n", ref userSelectTask);
                if (userSelectTask == 0) { break; }
                switch (userSelectTask) {
                    case 1:
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
                        Write("\nКоличество положительных цифр в вашем наборе ({0}, {1}, {2}) = {3}", a, b, c, Task_6(ref a, ref b, ref c));
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
                        if (Task_14(ref a, ref b, ref c, ref result))
                            WriteLine($"Среди Вашего набора чисел {a}, {b}, {c}  - среднее равно {result}");
                        break;
                    case 15:
                        if (Task_15(ref a, ref b)) { WriteLine("Число {0} является делителем числа {1}", a, b); }
                        else { WriteLine("Число {0} не является делителем числа {1}", a, b); }
                        break;
                    case 16:
                        UserInput("Введите любое число: ", ref a);
                        if (Task_16(a)) { WriteLine("Ваше число пренадлежит интервалу [ -5, 3 ]"); }
                        else { WriteLine("Ваше число  не пренадлежит интервалу [ -5, 3 ]"); }
                        break;
                    case 17:
                        Task_17();
                        break;
                    case 18:
                        WriteLine("Сумма всех нечетных чисел от 0 до 50 равна {0}", Task_18());
                        break;
                    case 19:
                        UserInput("Введите а: ", ref a);
                        UserInput("Введите b: ", ref b);
                        WriteLine("Сумма всех положительных чисел кратных 4 в промежутке [{0} , {1}] = {2}",a,b,Task_19(a,b));
                        break;
                    case 20:
                        WriteLine(Task_20());
                        break;
                    case 21:
                        UserInput("Введите колличество чисел, которое будет: ", ref a);
                        WriteLine(Task_21(a));
                        
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
                    WriteLine("Вы ввели не целочиcленное значение, попробуйте еще раз: ");
                    continue;
                }
            }
        }

        /// <summary>
        /// перегруженный метод который дополнительно проверяет является ли значение в нужном нам промежутке
        /// </summary>
        /// <param name="inputMessage"> сообщение которое выведется пользователю</param>
        /// <param name="variable">переменная</param>
        /// <param name="lowBorder">диапазон "от"</param>
        /// <param name="hightBorder">диапазон "до"</param>
        static void UserInput(string inputMessage, ref int variable, int lowBorder, int hightBorder) {
            //цикл заппроса введения числа до тех пор, пока пользователь не введет в нужном нам значении
            for (; ; ) {
                UserInput(inputMessage, ref variable);
                if ((variable >= lowBorder) & (variable <= hightBorder)) { break; }
                else {
                    WriteLine($"Введите значение в диапазоне [{lowBorder} , {hightBorder}] :  ");
                    continue; }
            }
        } 

        
        /*Еще один перегруженный метод запроса ввода для пользователя( 3х значений)  */
        static void UserInput(ref int A, ref int B, ref int C) {
            UserInput("Введите значение переменной A: ", ref A);
            UserInput("Введите значение переменной B:", ref B);
            UserInput("Введите значение переменной C:", ref C);
        }

        /*Task 1: Даны переменные A, B, C.
         * Изменить их значения, переместив содержимое A в B, B — в C, C — в A,
         * и вывести новые значения переменных A, B, C.
         * передаю параметры по ссылку что бы внутри менялись значеня
         поставил пользователю ограничение на то, что он может вводить только int*/
        static void Task_1(ref int A, ref int B, ref int C) {
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
            UserInput("Введите целое двузначное число: ",ref number, 10, 99);
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
                sOutput += "- положительное, мы прибавили к нему 1 и оно равно ";
            }
            else if (number < 0) {
                number -= 2;
                sOutput += "- отрицательное, мы вычли из него 2 и оно равно ";
            }
            else {
                number = 10;
                sOutput += "равно нулю, мы заменили его на 10";
            }
            Write(sOutput);
            return number;
        }

        /*6. Даны три целых числа. Найти количество положительных чисел в исходном наборе */
        static byte Task_6(ref int A, ref int B, ref int C) {
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
        static void Task_7(ref int A, ref int B, ref int C, out int positiveNumber, out int negativeNumber) {
            positiveNumber = Task_6(ref A, ref B, ref C);
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
            UserInput("Выберите единицу длины: ", ref userChoice, 1, 5);
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
                    result = userLenght / 100.0;
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
            UserInput("Подайте комманду роботу: ",ref command, -1, 2);
                switch (command) {
                    //прямо
                    case 0:
                        break;
                    /*
                    логика алгоритма следующая :
                    в string прописаны направления
                    про повороте направо мы проходим по строке справа-налево и указаталь текущего направления(flagActiveDirection
                    Который указывает на текущий символ смещается в минус. Если он достигнет начала строки (0й символ)
                    мы переносим указатель на последний символ строки
                    При повороте налево все наоборот
                     */
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
            UserInput("Введите целое число в диапазоне 20-69, определяющее возвраст(в годах): ", ref age, 20, 69);
            yearSwich = age % 10;
            if (yearSwich == 1) {
                strAnswer = "год.";
            }
            else if (yearSwich >= 2 & yearSwich <= 4) {
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
            if (number == 1) {
                WriteLine(strOut);
                return;
            }
            else {
                UserInput("Вы загадали 1 ? Если Да - нажмите 1 , если нет - любую цифру: ", ref number);
                if (number == 1) {
                    WriteLine(strOut);
                    return;
                }
                else {
                    UserInput("Тогда Вы точно загадали число 3, если да - нажмите 1 , если нет - любую цифру: ", ref number);
                    if (number == 1) {
                        WriteLine(strOut);
                        return;
                    }
                    else {
                        WriteLine("Так не честно, ты мухлюешь, надо было загадать число от 1 до 3");
                    }
                }
            }
        }

        /*14. Среди трех чисел найти среднее. Если среди чисел есть равные, вывести сообщение "Ошибка"
         считаем что при успешном завершении метода возвращает True и при этом резульат будет в переменной result*/
        static bool Task_14(ref int A, ref int B, ref int C, ref int result) {

            UserInput(ref A, ref B, ref C);
            //если есть равные числа выведет на консоль "Ошибка!"
            if (A == B | B == C | C == A) {
                WriteLine("Ошибка!");
                return false;
            }
            if (((A > B) & (B > C)) | ((B < C) & (B > A))) { result = B; }
            else if (((C > B) & (C < A)) | ((C > A) & (C < B))) { result = C; }
            else { result = A; }

            return true;
        }

        /*15. Определить, является ли число а делителем числа b  
         * если является - вернет true
         а делитель b только когда b делится на а без остатка*/
        static bool Task_15(ref int A, ref int B) {
            UserInput("Введите число 'a': ", ref A);
            UserInput("Введите число 'b' :", ref B);
            if (B % A == 0) { return true; }
            else { return false; }
        }

        /*  16. Проверить, принадлежит ли число введенное с клавиатуры, интервалу (-5;3). 
         если число принадлежит вернет true если нет - false
         число передаем извне*/
        static bool Task_16(int number) {
            if (number >= -5 & number <= 3) { return true; }
            else { return false; }
        }

        /*17. Дано двузначное число. Определить: входит ли в него цифра 3 входит ли в него цифра а.
         возвращаем ответ в виде строки*/
        static string Task_17 (){
            string strOutput = "";
            int number = 0, numeral = 0, leftNumeral = 0, righrtNumeral = 0;
            //ввод пользователем двухзначного числа и цифры
            UserInput("Введите двухзначное число: ", ref number, 10, 99);
            UserInput("Введите цифру в диапазоне [0 - 9]: ", ref numeral, 0, 9);
            leftNumeral = number / 10;
            righrtNumeral = number % 10;

            if(leftNumeral % 3 == 0 | righrtNumeral % 3 == 0) {
                strOutput += "\nВ ваше число входит цифра '3'";
            }
            else if (leftNumeral % numeral == 0 | righrtNumeral % numeral == 0) {
                strOutput += "\nВ ваше число входит цифра {" + numeral+ "}";
                }


            return strOutput;
        }

        /* 18. Найти сумму положительных нечетных чисел, меньших 50.
         * что бы не добавлять условие на проверку четности или нечетности инкрементировал в цикле i на*/
        static int Task_18() {
            int result = 0;             
            for (int i = 1; i <= 50; i+=2) {
                result += i;
            }
            return result;
        }

        /*19. Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем. */
        static int Task_19(int a, int b) {
            int result = 0;
            for (int i = a; i<=b; i++ ) {
                if((i > 0) && (i % 4 == 0)) { //если число отрицательное то даже не будет проверять второе условие
                    result += i;
                }
            }
            return result;
        }

        /*20. Найти: а) все двузначные числа, сумма квадратов цифр которых делится на 13;
         * б) все двузначные числа, обладающие следующим свойством: 
         * если к сумме цифр числа прибавить квадрат этой суммы, то получится снова искомое число */
         static string Task_20() {
            string strResultA = "a)Все двузначные числа, сумма квадратов цифр которых делится на 13: \n";
            string StrResultB = "b)все двузначные числа, обладающие следующим свойством: " +
                "если к сумме цифр числа прибавить квадрат этой суммы, то получится снова искомое число: \n";
            int leftNumber = 0, rightNumber = 0, summNumber = 0;
            for (int i =10; i<=99; i++) {
                leftNumber = i / 10;
                rightNumber = i % 10;
                //a
                if((Math.Pow(rightNumber,2 ) + Math.Pow(leftNumber, 2) ) % 13 == 0) {  
                    strResultA += i + " ";
                }
                //b
                summNumber = leftNumber + rightNumber;
                if((summNumber + Math.Pow(summNumber, 2)) == i) {
                    StrResultB += i + " ";
                }
            }

            return strResultA + "\n"+ StrResultB;
        }

        /*21. Даны натуральное число n и вещественные числа Найти: а) максимальное из вещественных чисел;
         * б) минимальное из вещественных чисел; 
         * в) максимальное и минимальное из вещественных чисел. 
         * Примечание В задаче (в) использовать только один оператор цикла
         * cделал 1 таск - 1 метод, и да, без массивов
         и да, с одним оператором цикла
         все числа записываются в строку, и разделителем чисел является символ | */
         static string Task_21(int n) {
            string strOutput = "", strUserNumbers = "", strTemp;
            int startNumber = 0, endNumber = 0;
            double number = 0.0, minValue = 0.0, maxValue = 0.0;

            //цикл запроса ввода значений пользователя - количество значений - n
            for (int i = 0; i< n; i++) {
                Write("\nВведите вещественное число : ");
                try {
                    number = Convert.ToDouble(ReadLine());
                    strUserNumbers += number;
                    strUserNumbers+= '|';
                    //по окончанию цикла минимальному и макс. значению будет присвоено последнее введенное пользователем значение(так надо)
                    minValue = maxValue = number;    
                }
                catch {
                    WriteLine("не-не, это не вещественное число)");
                    i--;
                }
            }
            //проход по каждому символу строки
            for(int i =0; i < strUserNumbers.Length;i++) {
                //если текущий символ - является разделителем чисел(т.е. == '|')
                //то нам нужно извлечь подстроку в которой нужное вещественное число
                //сконвертировать е в переменную double
                //и сравнивать с минимальным и максимальным значением (записанным по умолчанию - последний пользовательский ввод)
                if(strUserNumbers[i] == '|') {
                    endNumber = i - startNumber;
                    strTemp = strUserNumbers.Substring(startNumber, endNumber);
                    number = Convert.ToDouble(strTemp);
                    //если значение минимальное записанное в переменную больше текущего числа, 
                    //то перезаписываем новое минимальное значение
                    if ( minValue > number) { 
                        minValue = number;
                    }
                    //так же и с максимальным поступаем
                    if (maxValue < number) {
                        maxValue = number;
                    }
                    startNumber = i + 1;
                }
            }

            strOutput += "Ваше мнинимальное значение: " + minValue + "\n";
            strOutput += "Ваше минимальное значение: " + maxValue;

            return strOutput;
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
