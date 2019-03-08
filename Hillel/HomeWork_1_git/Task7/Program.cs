using System;

using static System.Console;

/*Дан прямоугольник с размерами 543 x 130 мм.Сколько квадратов со стороной 130 мм можно отрезать от него?
 
    Логика в том, что сторона квадрата равна высоте прямоугольника(130 мм), поэтому надо посчитать сколько
    равных квадратов мы можем отрезать. 
     */

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            uint rectangle = 543, square = 130, result=0;
            result = rectangle / square; 
            WriteLine($"C прямоугольника размером {rectangle} х {square} мм можно нарезать " + result + $" ровных квадрата c высотой {square}мм.");
        
            ReadLine();
        }
    }
}
