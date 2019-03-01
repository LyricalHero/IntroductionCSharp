using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


/*1. Ввести три числа и выведите на экран значение суммы и произведения этих чисел.*/

namespace Task1 {
    class Task_1 {
        static void Main(string[] args) {
//пременная test - это значение которое (в теории) вряд-ли когда нибудь введет пользователь 
//мы присвоим ее значение для всех переменных по умолчанию для проверки ввел ли корректное значение пользователь

            double test = -345.00001, oneNumber = test , twoNumber = test, threeNumber = test;

            
//тут лгика следующая: 
//у нас есть цикл, который постоянно будет предлагать ввести пользователью значение до тех пор, пока он не введет корректное значение 
//выйдет из цикла только при условии что пользователь реально ввел значение всех 3х переменных (если значения всех трех переменных отличное от значения по умолчанию тогда выходит из цикла)
            while ( !((oneNumber != test) & (twoNumber != test) & (threeNumber != test)) )
            {
 //проверка, если пользователь еще не менял значения текущей переменной, то просим ввести значение
                if (oneNumber == test) {
                    try {
                        Write("Введите значение первой переменной: ");
                        oneNumber = Convert.ToDouble(ReadLine());

                    }
                    catch {
                        WriteLine("Вы ввели не число!");
 //если пользователь ввел некорректное значение, то перейдет к началу цикла и предложит ввести ему то значение, на котором он остановился а не следующее
                        continue;
                    }
                }
                if (twoNumber == test) {
                    try {
                        Write("Введите значение второй переменной: ");
                        twoNumber = Convert.ToDouble(ReadLine());

                    }
                    catch {
                        WriteLine("Вы ввели не число!");
                        continue;
                    }
                }
                if (threeNumber == test) {
                    try {
                        Write("Введите значение третьей переменной: ");
                        threeNumber = Convert.ToDouble(ReadLine());

                    }
                    catch {
                        WriteLine("Вы ввели не число!");
                        continue;
                    }
                }
            }
//ввывод на консль суммы и произведения введеных пользователем значений
            WriteLine("Сумма этих чисел равна  {0}", oneNumber + twoNumber + threeNumber);
            WriteLine("Произведение этих чисел равно  {0}", oneNumber*twoNumber*threeNumber);

            WriteLine("Нажмите 'Enter' для выхода из программы. ");
            ReadLine();
        }
    }
}
