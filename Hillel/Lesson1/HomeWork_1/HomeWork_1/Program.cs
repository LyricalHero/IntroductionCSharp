using System;
using static System.Console;

/*Написать программу для отображения Ваших данных – ФИО, сколько лет и т.д. ​(Обязательно каждые данные отображать через переменные)*/

namespace Task0
{
    class Program
    {
        static void Main(string[] args)
        {
//Инициализация переменных, возраст решил через 'byte' для экономии памяти 
            string FirstName = "Роман", LastName = "Жолоб", MiddleName = "Владимирович";
            string DateOfBirth = "25 января 1994";
            byte Age = 25;
// вывод инфы
            WriteLine("Коротко о себе:\nФИО:\t" + LastName + " " + FirstName + " " + MiddleName);
            WriteLine("Дата рождения:\t" + DateOfBirth + "\nМне " + Age + " лет.\nПриятно познакомится :)");

            ReadLine();
        }
    }
}
