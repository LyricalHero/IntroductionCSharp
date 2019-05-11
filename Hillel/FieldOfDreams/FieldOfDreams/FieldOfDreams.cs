using System;
using System.Collections.Generic;
using static System.Console;

/*
 Программа игра "Поле  чудес"  */


namespace FieldOfDreams {
    class FieldOfDreams {
        static void Main(string[] args) {
            LoigcProgram();
            
        }

        //Логика нашей программы 
        //в бесконечном цикле - так надо (если пользователь решит завершить программу, то введет на вопрос "играем еще" - нет)
        private static void LoigcProgram() {
                        
            for (; ; ) {
                char userChar=' ';
                bool isEnd = false;
                string strUserWord = SetWord(); // выбор случайного слова
                Dictionary<int, string> userTips = selectTips(strUserWord); //подсказки для слова
                int attemps = userTips.Count; //кол-во попыток
                char[] userOutput = new char [strUserWord.Length]; //массив который будет выводится пользователю
                //инициализация строки по умолчанию в формате "------"
                for (int i = 0; i <= userTips.Count; i++) {
                    userOutput[i] = '-';
                }
                
                //цикл одной игры 
                while (attemps >= 0) {
                    Write("Слово: ");
                    Write(userOutput );
                    WriteLine();
                    UserInput("Введите букву: ", ref userChar);
                    WriteLine(userChar); // удалить потом    
                    if(FindChar(userChar, strUserWord, userOutput)) {
                        WriteLine("Вы угадали букву!");
                        continue;
                    } else {
                        WriteLine("Вы не угадали букву!" +
                            "\nОсталось попыток: {0}", attemps);
                        WriteLine("Подсказка: " + userTips[attemps-1]);
                    }  
                                                                                                         
                    attemps--;
                }

                isEnd = EndGame();
                if (isEnd) { continue; }
                else { break; }
            }
        }


        //запрос пользователю о окончании программы
        private static bool EndGame() {
            string isEnd = "да";
            for (; ; ) {
                WriteLine("\nИграем еще? <да / нет>: ");
                isEnd = ReadLine();
                isEnd = isEnd.ToLower();    //если пользователь ввел Большие буквы - так же отработает
                if (isEnd == "да") { return true; }
                else if (isEnd == "нет") { return false; }
                else {
                    WriteLine("Введите 'да' или 'нет'!");
                    continue;
                }
            }
        }

        //метод проверяющий корректность ввода значений символа а именно буквы
        //нужно еще проверить что-бы буква была русской расскладки
        private static void UserInput(string userMessage, ref char Symvol) {
            for (; ; ) {
                Write(userMessage);
                try {
                    Symvol = Convert.ToChar(ReadLine());
                    if (Char.IsLetter(Symvol)) {
                        Symvol = Char.ToLower(Symvol);
                        if((Symvol>='а') && (Symvol <= 'я')) { break; }
                        else {
                            WriteLine("Введите букву русского алфавита!");
                            continue;
                        }
                        
                    }
                    else { continue; }
                }
                catch {
                    WriteLine("Вы ввели не букву, поробуйте еще раз!");
                    continue;
                }
            }
        }

        //метод который выбирает наше слово из 2х
        private static string SetWord() {
            string[] arrWord = new string[4] { "цветок","ручка","школа","доска"};
            string word = arrWord[new Random().Next(0,3)];
            return word;
        }

        
        //метод, в который передаем наше слово, и в зависимости от  слова возвращает нам коллецикцию подсказок
        //кол-во подсказок равно количеству букв в этом слове -1
        //подсказки хранятся в словарях(они быстрее работают чем Списки)
        static Dictionary<int, string> selectTips(string word) {

            Dictionary<int, string> FlowerDictionaryTips = new Dictionary<int, string>(6);
            //подсказки к слову "цветок"
            FlowerDictionaryTips.Add(2,"В слове 6 букв.");
            FlowerDictionaryTips.Add(3, "В слове нет букв которые повторяются");
            FlowerDictionaryTips.Add(0, "Женщины очень трепетно относятся к нему");
            FlowerDictionaryTips.Add(1, "...... - он мужского рода");
            FlowerDictionaryTips.Add(4, "Любит солнышко и воду");
            //FlowerDictionaryTips.Add(5, "Сн тесно связан с 8 Марта");
            //подсказки к слову ручка
            Dictionary<int, string> PenDictionaryTips = new Dictionary<int, string>(5);
            PenDictionaryTips.Add(0, "В слове 5 букв.");
            PenDictionaryTips.Add(1, "В слове нет букв, которые повторяются");
            PenDictionaryTips.Add(2, "У тебя есть такая часть тела");
            PenDictionaryTips.Add(3, "В школе нельзя было без нее");
            //PenDictionaryTips.Add(4, "Это есть не только у тебя но и у двери");

            if (word == "цветок") { return FlowerDictionaryTips; } 
                else { return PenDictionaryTips; }
        }

        //метод который ищет букву в слове и если нашло, то подставляет эту букву на нужную позицию и возвращает true
        // в случае если буквы в слове нет, то возвращает false
        static bool FindChar(char ch, string userWord, char[] userOutput) {
            //т.к. одинаковых букв может быть несколько нам нужна промежуточная переменная,
            //что бы понимать были ли подставлены буквы 
            byte temp = 0;
            for (int i = 0; i < userWord.Length-1; i++) {
                if (ch == userWord[i]) {
                    userOutput[i] = ch;
                    temp++;
                }         
            }
            //если буквы есть в слове
            if (temp > 0) { return true; }
                else { return false; }
        }











    }
}
