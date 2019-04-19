using System;
using static System.Console;

namespace Home_Work_7_Strings {
    class Home_Work_7_Strings {
        static void Main(string[] args) {
            myLogicProgramm();

            ReadLine();
        }

        static void myLogicProgramm() {
            string myString1 = "Аквалланг";
            WriteLine($"Наше слово: {myString1}");

            /*1) Дано слово. Вывести на экран его третий символ.*/
            WriteLine($"Его третий символ: {myString1[2]}");

            /*2) Дано слово. Определить, одинаковы ли второй и четвертый символы в нем.*/
            if (myString1[1] == myString1[3]) { WriteLine("Второй и четвертый символы в нем одинаковы."); }
            else { WriteLine("Второй и четвертые символы в нем разные."); }
            WriteLine();

            /*3)Дано название футбольного клуба. Напечатать его на экране "столбиком".*/
            string myString2 = "Ювентус";
            for (int i = 0; i < myString2.Length; i++) {
                WriteLine(myString2[i]);
            }
            WriteLine();

            /*4) Дано слово s1. Получить слово s2, образованное нечетными буквами слова s1*/
            string s1 = "Паралеллизм", s2 = "";
            for (int i = 0; i < s1.Length; i += 2) {
                s2 += s1[i];
            }
            WriteLine($"Дано слово \"{s1}\" \nСлово образованное нечетными буквами слова выше: \"{s2}\" \n");

            /*5) Дан текст. Сколько раз в нем встречается символ "+" и сколько раз символ "*"?*/
            Write("Введите текст: ");
            string myString3 = ReadLine();
            int nump = 0, numz = 0; //счетчик сколько раз встречается "+" и "*" соответственно
            foreach (char ch in myString3) {
                if (ch == '+') { nump++; }
                else if (ch == '*') { numz++; }
            }
            WriteLine($"Ваша строка: {myString3}\nИ в ней {nump} раз встречается символ \"+\" и {numz} раз встречается символ \"*\". \n");

            /*6) Дано предложение. Все буквы е в нем заменить буквой и.*/
            //у нас уже есть заполненая строка myString3 но нужно еще привести к нижнему регистру
            string myNewString1 = myString3.ToLower().Replace('е', 'и');
            WriteLine(myNewString1);
            /*7) Дано предложение. Все пробелы в нем заменить символом "_". */
            string myNewString2 = myString3.Replace(' ', '_');
            WriteLine(myNewString2);

            /*8) Дан текст. Напечатать все имеющиеся в нем цифры.*/
            WriteLine("Введите какой-то текст с цифрами: ");
            string myString4 = ReadLine();
            Write("Все цифры в вашем тексте: ");
            foreach (char ch in myString4) {
                if (char.IsDigit(ch)) {
                    Write(ch + " ");
                }
            }

            /*9) Дан текст, в котором имеются цифры. а) Найти их сумму. б) Найти максимальную цифру */
            // в myString4 уже есть текст с цифрами
            int summNumber = 0, maxNumber = 0, number = 0;
            foreach (char ch in myString4) {
                if (char.IsDigit(ch)) {
                    number = (int)Char.GetNumericValue(ch);
                    summNumber += number;
                    if (number > maxNumber) { maxNumber = number; }
                }
            }
            WriteLine($"Сумма всех цифр = {summNumber} и максимальное из них - {maxNumber}");

            /*10) Составить программу, которая запрашивает название государства и его столицы,
             * а затем выводит сообщение: 
             * "Столица государства ... — город ..." 
             * (на месте многоточий должны быть выведены соответствующие значения)*/

            Write("Введите государство: ");
            string strCountry = ReadLine();
            Write("Введите столицу: ");
            string strCapital = ReadLine();
            WriteLine($"Столица государства {strCountry} — город {strCapital}");

            //11)             
            WriteLine(myTask11());

            /*12) Дано предложение из 10 слов. Заполнить ими массив из 10 элементов.*/
            string myStringTask12 = "Предложение из 10 нэлементов для пример вот оно так выглядит";
            WriteLine("Наше исходное предложение: {0}", myStringTask12);
            string[] myArrTask12 = myStringTask12.Split(" ");
            //для проверки вывел массив из 10 элементов
            foreach (string item in myArrTask12) {
                WriteLine(item);
            }

            /*13) Дано предложение. Напечатать его в обратном порядке слов, например, предложение мама мыла раму должно быть напечатано в виде раму мыла мама.
             предложение у нас уже есть  - myStringTask12 + есть массив строк в котором хранятся все слова предложения по отдельности*/
            string myStringTask13 = "";
            for (int  i = myArrTask12.Length-1;  i >= 0;  i--) {
                myStringTask13 += myArrTask12[i];
                myStringTask13 += " ";
            }
            WriteLine(myStringTask13);


            /*14) Дано предложение. Определить: а) количество слов, начинающихся с буквы н; б) количество слов, оканчивающихся буквой р.
             так же само - предложение уже есть (myStringTask12)
             разбиваем его в массив на количество слов(тоже уже готово - myArrTask12 )
             P.S. без учета локали и без учета регистра!*/
            int numStart = 0, numEnd = 0;
            foreach (string item in myArrTask12) {
                //проверяем первые и последние символы строки
                if (item[0] == 'н') { numStart++; }
                if(item[item.Length-1] == 'р') { numEnd++; }
            }
            WriteLine("В нашем предложении количество слов, начинающихся с буквы \"н\" равно {0}", numStart);
            WriteLine("В нашем предложении количество слов, оканчивающихся буквой \"р\"  равно {0}", numEnd);




        }

        /*11) Даны три слова. Напечатать их общие буквы. Повторяющиеся буквы каждого слова не рассматривать.
         * закинул логику в отдельный метод*/
        static string myTask11() {
            //strbuff - для хранения символов которые уже рассматривались
            string strOutput = "", strWord1, strWord2,strWord3,strBuff = "";
            Write("Введите первое слово: ");
            strWord1 = ReadLine();
            Write("Введите второе слово: ");
            strWord2 = ReadLine();
            Write("Введите третье слово: ");
            strWord3 = ReadLine();

            //цикл прохода по символам в первом слове
            foreach (char item in strWord1) {
                //если рассматриваемый символ уже рассматривали то переходим к следующему символу(новая итерация цикла)
                if(strBuff.IndexOf(item) != -1) { continue;    }
                //если есть хоть одно вхождения символа во втором и третьем слове то выводим этот символ
                if( (strWord2.IndexOf(item) != -1) && (strWord3.IndexOf(item) != -1)) {
                    strOutput += item;                    
                }
                //присваиваем к строке символ который уже рассматривали
                strBuff += item;
                
            }
            if (String.IsNullOrEmpty(strOutput)) {
                return "В ваших словах нет одинаковых символов";
            }
            else {
                return "Буквы, которые повторяются во всех Ваших словах: " + strOutput;
            }

            
        }










    }
}

