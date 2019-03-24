using System;
using System.Collections.Generic;
using static System.Console;

/*
 Программа игра "Поле  чудес"
  массивы
     
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
            string strUserWord = "";
            for (; ; ) {
                strUserWord = SetWord();
                WriteLine(strUserWord);






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
        private static void UserInput(string userMessage, ref char Symvol) {
            for (; ; ) {
                Write(userMessage);
                try {
                    Symvol = Convert.ToChar(ReadLine());
                    if (Char.IsLetter(Symvol)) {
                        Symvol = Char.ToLower(Symvol);
                        break;
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
        

            

       









    }
}
