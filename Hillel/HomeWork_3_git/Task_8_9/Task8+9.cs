using System;
using static System.Console;


namespace Task_8_9 {
    class Program {
        static void Main(string[] args) {

            Task_8();
            Task_9();

            ReadLine();
        }


/*
 * 8. Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z:
 * X = Ложь, Y = Истина, Z = Ложь:
 * а) X или Z;
 * б) X и Y; 
 * в) X и Z.*/
        static void Task_8() {
            bool X = false, Y = true, Z = false, result = true;
            WriteLine("******** Task 8 ********");
            result = X | Z;
            WriteLine("a): {0} OR {1} = {2}", X, Z, result);
            result = X & Y;
            WriteLine("b): {0} AND {1} = {2}",X, Y, result);
            result = X & Z;
            WriteLine("c): {0} AND {1} = {2}",X, Z, result); 
        }

/*9.Вычислить значение логического выражения при следующих значениях логических величин X, Y и Z: 
X = Ложь, Y = Ложь, Z = Истина: 
а) X или Y и не Z; 
г) X и не Y или Z; 
б) не X и не Y; д) X и (не Y или Z); 
в) не (X и Z) или Y; е) X или (не (Y или Z)).*/
        static void Task_9() {
            bool X = false , Y = false,  Z = false, result = true;
            WriteLine("******** Task 9 ********");
            //а) X или Y и не Z
            result = (X | Y) & !Z ;
            WriteLine($"{X} OR {Y} AND not {Z} = {result}");
            //б) не X и не Y
            result = !X & !Y;
            WriteLine($"not {X} AND not {Y} = {result}");
            //в) не(X и Z) или Y
            result = !(X & Z) | Y;
            WriteLine($"not ({X} AND {Z}) OR {Y} = {result}");
            //г) X и не Y или Z
            result = X & !Y | Z;
            WriteLine($"{X} AND not {Y} OR {Z} = {result}");
            //д) X и (не Y или Z);
            result = X & (!Y | Z);
            WriteLine($"{X} AND (not {Y} OR {Z} = {result}");
            //е) X или (не (Y или Z)).
            result = X | (!(Y | Z)) ;
            WriteLine($"{X} OR ( not ({Y} OR {Z}) ) = {result}");
        }

    }
}
