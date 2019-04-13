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
            for(int i = 0; i<myString2.Length;i++) {
                WriteLine(myString2[i]);
            }
            WriteLine();

            /*4) Дано слово s1. Получить слово s2, образованное нечетными буквами слова s1*/
            string s1 = "Паралеллизм", s2 = "";
            for (int i = 0; i<s1.Length; i+=2) {
                s2 += s1[i];
            }
            WriteLine($"Дано слово \"{s1}\" \nСлово образованное нечетными буквами слова выше: \"{s2}\" \n");

            /*5) Дан текст. Сколько раз в нем встречается символ "+" и сколько раз символ "*"?*/
            Write("Введите текст: ");
            string myString3 = ReadLine();
            int nump = 0, numz = 0; //счетчик сколько раз встречается "+" и "*" соответственно
            foreach (char ch in myString3) {
                if(ch == '+') { nump++; }
                else if(ch == '*') { numz++; }
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
                    Write(ch+" ");
                }
            }

            /*9) Дан текст, в котором имеются цифры. а) Найти их сумму. б) Найти максимальную цифру */
            // в myString4 уже есть текст с цифрами
            int summNumber = 0, maxNumber = 0, number = 0;
            foreach(char ch in myString4) {
                if(char.IsDigit(ch)) {
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

            /*11) Даны три слова. Напечатать их общие буквы. Повторяющиеся буквы каждого слова не рассматривать.*/




        }













    }
}

