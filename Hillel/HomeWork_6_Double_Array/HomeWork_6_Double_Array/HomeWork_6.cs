 using System;
using static System.Console;




namespace HomeWork_6_Double_Array {
    class HomeWork_6 {
        static void Main(string[] args) {
            LogicProgramm();

            ReadLine();
        }
        //метод в которм вля логика программы что бы не засорять Main
        private static void LogicProgramm() {
            //создаем массив для наглядности из 5х5
            int index1 = 5, index2 = 5;
            int[,] arr = new int[index1,index2];
            //заполняем его случайными значениями[10 - 99] и выводим на экран
            mySet_Array(arr, index1, index2);
            myPrintArray(arr,index1,index2);
            /*Task1. Дан двумерный массив. а) Вывести на экран элемент, расположенный в правом верхнем углу массива. 
          б) Вывести на экран элемент, расположенный в левом нижнем углу массива.*/
            //а)выводим на экран элемент, расположенный в правом верхнем углу массива.
            //т.е это элемент 1й строки последнего столбца
            WriteLine("Элемент, расположенный в правом верхнем углу массива: {0}", arr[0,index2-1]);
            // б) Вывести на экран элемент, расположенный в левом нижнем углу массива.
            // т.е. это элемент 1й столбца последней строки
            WriteLine("Элемент, расположенный в левом нижнем углу массива: {0}", arr[index1-1, 0]);
            //очищаем консоль и еще раз выводим наш массив:
            myEnd_Task();
            myPrintArray(arr, index1, index2);

            //Task2 -a заменяем значение любого элемента пятой строки двумерного массива числом 1949
            //и выводим на экран новый массив
            myTask_2(arr,index1,index2,false);
            WriteLine("Мы заменили значение любого элемента пятой строки двумерного массива числом 1949");
            myPrintArray(arr, index1,index2);

            //Task 2 - b заменяющую значение любого элемента двумерного массива числом a
            myTask_2(arr, index1, index2, true);
            WriteLine("Мы заменили значение любого элемента  двумерного массива Вашим числом ");
            myPrintArray(arr, index1, index2);

            myEnd_Task();
            //создаем новый массив 8х8 для таска 3
            index1 = 9;
            index2 = 9;
            int[,] arrTask3 = new int[index1, index2];
            //заполняем массив значениями
            myTask_3(arrTask3, index1, index2);
            WriteLine("Заполнили двумерный массив результатом таблицы умножения от 1 до 9");
            myPrintArray(arrTask3, index1, index2);
            myEnd_Task();



        }

        //метод заполнения двухмерного массивa случайными числами от 10 до 99
        static void mySet_Array(int[,] myArr,int index1, int index2) {
            for (int i = 0; i< index1; i++) {
                for(int j = 0; j < index2; j++) {
                    myArr[i,j] = new Random().Next(10,100);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        //метод вывода двумерного массива на экран
        static void myPrintArray(int[,] myArr,int index1, int index2) {
            WriteLine($"Наш Массив {index1}x{index2}: \n");
            for(int  i =0; i< index1; i++) {
                for (int j =0; j< index2; j++) {
                    Write(myArr[i,j] + "\t");
                }
                WriteLine();
            }
            WriteLine();
        }

        /*2. Составить программу:
         * а) заменяющую значение любого элемента пятой строки двумерного массива числом 1949; 
         * б) заменяющую значение любого элемента двумерного массива числом a.
         метод заменяющий любой элемент массива числом a(передается через аргументы) если флаг whatMetod = true
         если whatMetod = false - то выполняется задание а*/
         static void myTask_2(int[,] myArr,int index1,int index2,bool whatMetod) {
            int i = new Random().Next(0, index1);
            int j = new Random().Next(0, index2);
            int a = 0;
            if (whatMetod) {
                //заменяем рандомный элемент массива a
                UserInput("Введите значение которым мы заменим случайный элемент массива: ", ref a);
                myArr[i, j] = a;
            }
            else {
                // заменяем рангдомный элемент пятой строки значением 1949
                myArr[4, j] = 1949;
            }
        }

        /*3. Заполнить двумерный массив результатами таблицы умножения 
         * (в первой строке должны быть записаны произведения каждого из чисел от 1 до 9 на 1,
         * во второй — на 2, ..., в последней — на 9).
         метод заполняет мвассив результатами таблицы умножения чисел от 1 до размерности массива*/
        static void myTask_3(int[,] myArr,int index1, int index2) {
            for(int i =0; i < index1; i++) {
                for(int j =0; j < index2; j++) {
                    myArr[i, j] = (i + 1) * (j+1);
                }
            }
        }

        /*4. Дан двумерный массив. Вывести на экран: 
         * а) все элементы третьей строки массива, начиная с последнего элемента этой строки; 
         * б) все элементы k-го столбца массива, начиная с нижнего элемента этого столбца.*/
         static void myTask_4(int[,] myArr, int index1, int index2) {
            //a)
            
        }












        //метод, который вызываю по окончанию таска
        //он ждет пока пользователь не введет Enter и после этого очищает консоль
        static void myEnd_Task() {
            WriteLine("\nДля продолжения нажмите <Enter>");
            ReadLine();
            Clear();
        }


        /* Метод для пользователя - запрос на введение значений 
            и проверка корректности ввода значения для  целочисленых чисел
            и будет запрос до тех пор , пока не введет целочисленное значение*/
        static void UserInput(string message, ref int variable) {
            Write(message);
            for (; ; ) {
                try {
                    variable = Convert.ToInt32(ReadLine());
                    break;
                }
                catch {
                    WriteLine("Вы ввели не целочиcленное значение, попробуйте еще раз: ");
                    continue;
                }
            }
        }















    }

}