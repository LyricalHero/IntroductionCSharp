using System;
using System.Collections.Generic;
using static System.Console;

/*
 Программа игра "Поле  чудес"
  лист
     
     */


namespace FieldOfDreams {
    class FieldOfDreams {
        static void Main(string[] args) {
            LoigcProgram();
            
        }

        //Логика нашей программы 
        //в бесконечном цикле - так надо (если пользователь решит завершить программу, то введет на вопрос "играем еще" - нет)
        private static void LoigcProgram() {
            bool isEnd = false;
            string strUserWord = SetWord();
            
            for (; ; ) {
                char userChar=' ';
                Dictionary<int, string> userTips = selectTips(strUserWord);
                int attemps = userTips.Count; //кол-во попыток
                WriteLine(strUserWord); //удалить потом
                
                UserInput("Введите букву: ", ref userChar);
                WriteLine(userChar);







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

        //метод который выбирает наше слово из 4х
        private static string SetWord() {
            string[] arrWord = new string[4] { "цветок","ручка","школа","доска"};
            string word = arrWord[new Random().Next(0,5)];
            return word;
        }

        
        //метод, в который передаем наше слово, и в зависимости от  слова возвращает нам коллецикцию подсказок
        //кол-во подсказок равно количеству букв в этом слове
        //подсказки хранятся в словарях(они быстрее работают чем Списки)
        static Dictionary<int, string> selectTips(string word) {

            Dictionary<int, string> FlowerDictionaryTips = new Dictionary<int, string>(6);
            //подсказки к слову "цветок"
            FlowerDictionaryTips.Add(2,"В слове 6 букв.");
            FlowerDictionaryTips.Add(3, "В слове нет букв которые повторяются");
            FlowerDictionaryTips.Add(0, "Женщины очень трепетно относятся к нему");
            FlowerDictionaryTips.Add(1, "...... - он мужского рода");
            FlowerDictionaryTips.Add(4, "Любит солнышко и воду");
            FlowerDictionaryTips.Add(5, "Сн тесно связан с 8 Марта");

            Dictionary<int, string> PenDictionaryTips = new Dictionary<int, string>(5);
            PenDictionaryTips.Add(0, "В слове 5 букв.");
            PenDictionaryTips.Add(1, "В слове нет букв, которые повторяются");
            PenDictionaryTips.Add(2, "У тебя есть такая часть тела");
            PenDictionaryTips.Add(3, "В школе нельзя было без нее");
            PenDictionaryTips.Add(4, "Это есть не только у тебя но и у двери");





            return FlowerDictionaryTips;
        }











    }
}
