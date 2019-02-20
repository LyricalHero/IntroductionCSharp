//DRY  - не повторяй сам себя    
/*    HotKey:
     
 
  
  
 */






using System;
//using static System.Console;

class Program
{
    public static void Main()
    {
        string str = "Hello new App";
        string console= "Hi";
        string answer = str + " " + console;  // Контактенация

        int i = 9;      // целосисленное
        int y = i + 789 * (123 / 456);  // откинет дробную часть y = 

        double d = 1231.0 / 456;        //вещественное обязат. указывать через точку '.'

        bool b = true;             //логический


        Console.WriteLine(str);
        Console.WriteLine(console);
        Console.WriteLine(answer);
        Console.WriteLine(i);

        Console.WriteLine(d);
        Console.WriteLine(b);

        Console.ReadLine();
    }


}