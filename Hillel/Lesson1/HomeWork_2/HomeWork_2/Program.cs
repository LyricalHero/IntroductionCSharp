using System;
using System.IO;
using static System.Console;
//using static System.Environment;
/*С помощью класса System.Environment вывести на консоль сведенья о компьютере*/

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // string system;
            
            WriteLine("Имя и Аргументы коммандной строки когда Ваше приложение было запущенно: " + Environment.CommandLine);
            
            WriteLine("Путь к приложению: " + Environment.CurrentDirectory);
           // system = Environment.MachineName;
            WriteLine("\nИмя компьютера: " + Environment.MachineName);
            WriteLine("Версия ОС: " + Environment.OSVersion);
            WriteLine("Колличество процессоров: " + Environment.ProcessorCount);
            WriteLine("Путь к системному каталогу: " + Environment.SystemDirectory);
            WriteLine("Время с последнего запуска \a системы: " + (Environment.TickCount)/1000/60 + " минут");
            WriteLine("Имя пользователя: {0}", Environment.UserName );

           // WriteLine(String.Join( ',', Environment.GetLogicalDrives) );




            ReadLine();
        }
    }
}
