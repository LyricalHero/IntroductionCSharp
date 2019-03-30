﻿ using System;
using System.Linq;  // в нее помещен метод Sum() у массивов и т.д.
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
          //  //заполняем его случайными значениями[10 - 99] и выводим на экран
          //  mySet_Array(arr, index1, index2);
          //  myPrintArray(arr, index1, index2);
          //  /*Task1. Дан двумерный массив. а) Вывести на экран элемент, расположенный в правом верхнем углу массива. 
          //б) Вывести на экран элемент, расположенный в левом нижнем углу массива.*/
          //  //а)выводим на экран элемент, расположенный в правом верхнем углу массива.
          //  //т.е это элемент 1й строки последнего столбца
          //  WriteLine("Элемент, расположенный в правом верхнем углу массива: {0}", arr[0, index2 - 1]);
          //  // б) Вывести на экран элемент, расположенный в левом нижнем углу массива.
          //  // т.е. это элемент 1й столбца последней строки
          //  WriteLine("Элемент, расположенный в левом нижнем углу массива: {0}", arr[index1 - 1, 0]);
          //  //очищаем консоль и еще раз выводим наш массив:
          //  myEnd_Task();
          //  myPrintArray(arr, index1, index2);

          //  //Task2 -a заменяем значение любого элемента пятой строки двумерного массива числом 1949
          //  //и выводим на экран новый массив
          //  myTask_2(arr, index1, index2, false);
          //  WriteLine("Мы заменили значение любого элемента пятой строки двумерного массива числом 1949");
          //  myPrintArray(arr, index1, index2);

          //  //Task 2 - b заменяющую значение любого элемента двумерного массива числом a
          //  myTask_2(arr, index1, index2, true);
          //  WriteLine("Мы заменили значение любого элемента  двумерного массива Вашим числом ");
          //  myPrintArray(arr, index1, index2);

          //  myEnd_Task();
          //  //создаем новый массив 8х8 для таска 3
          //  index1 = 9;
          //  index2 = 9;
          //  int[,] arrTask3 = new int[index1, index2];
          //  //заполняем массив значениями
          //  myTask_3(arrTask3, index1, index2);
          //  WriteLine("Заполнили двумерный массив результатом таблицы умножения от 1 до 9");
          //  myPrintArray(arrTask3, index1, index2);
          //  myEnd_Task();
          //  //Task 4
          //  myPrintArray(arrTask3, index1, index2);
          //  myTask_4(arrTask3, index1, index2);
          //  myEnd_Task();
          //  //Task 5
          //  myPrintArray(arrTask3, index1, index2);
          //  myTask_5(arrTask3, index1, index2);
          //  // Task 6 выводим на примере того-же массива
          //  myTask_6(arrTask3, index1, index2);
          //  myEnd_Task();
            //создам новый массив 4х4 , и на его примере буду выводить результаты следующих тасков
            index1 = 4;
            index2 = 4;
            int[,] myNewArr = new int[index1,index2];
            mySet_Array(myNewArr, index1, index2);
            myPrintArray(myNewArr, index1,index2);
            //Task 7
            myTask_7(myNewArr,index1,index2);
            //Task 8
            myTask_8_9(myNewArr, index1, index2);



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
            //a) Выводим на экран все элементы третьей строки массива, начиная с последнего элемента этой строки
            Write("Выводим на экран все элементы третьей строки массива, начиная с последнего элемента этой строки:");
            for (int i = index2-1; i>=0;i--) {
                Write(myArr[2,i]+" ");
            }
            //пользователь выбирает столбец который будет выводить и важно что бы было корректное значение       
            int k = UserSelectIndex("столбец",index2) ;            
            //б) все элементы k-го столбца массива, начиная с нижнего элемента этого столбца.
            Write($"\nВыводим на экран все элементы {k}-го столбца массива, начиная с нижнего элемента этого столбца.");
            for (int i =index1-1; i>=0;i--) {
                Write(myArr[i,k-1]+" ");
            }

        }


        /*5. Дан двумерный массив. Определить: 
         * а) сумму всех элементов третьей строки массива;
         * б) сумму всех элементов s-го столбца массива.
         * нахождение суммы прописывал "ручками"
         */
         static void myTask_5(int[,] myArr, int index1, int index2) {
            int sum = 0;
            //а) сумму всех элементов третьей строки массива
            for (int i =0; i< index2;i++) {
                sum += myArr[2,i];
            }
            Write("\nСумма всех элементов 3-й строки массива: {0}", sum);

            sum = 0;    //обнуляем переменную суммы
            //б) сумму всех элементов s-го столбца массива.
            int s = UserSelectIndex("столбец", index2);
            for (int i = 0; i< index1;i++) {
                sum += myArr[i,s-1];
            }
            Write("\nСумма всех элементов {0}-го столбца массива: {1}", s, sum);
         }

        /*6. Дан двумерный массив.
         * Определить: а) сумму всех элементов второго столбца массива;
         * б) сумму всех элементов k-й строки массива.
         Окей, такое уже было, что бы ручками не прописывать все
         я брал нужную строку(столбец) и записывал в новый массив
         потом вычислял сумму через стандартный метод массивов Sum() */
         static void myTask_6(int[,] myArr,int index1,int index2) {
            //а) сумму всех элементов второго столбца массива
            int sum = 0;
            int[] buffArr1 = new int[index1];  ////массив кол-во элементов которого равно кол-ву строк
            //заполняю новый одномерный массив значениями второго столбца массива
            for (int i = 0;i < index1;i++) {
                buffArr1[i] = myArr[i,1];
            }
            sum = buffArr1.Sum();
            WriteLine($"\nСумма всех элементов 2-го столбца массива: {sum}");

            //б) сумму всех элементов k-й строки массива.
            int[] buffArr2 = new int[index2];   //массив кол-во элементов которого равно кол-ву столбцов
            int k = UserSelectIndex("строку", index1);
            //заполняю новый одномерный массив значениями k-й строки массива
            for (int i = 0; i < index2; i++) {
                buffArr2[i] = myArr[k-1, i];
            }
            sum = buffArr2.Sum();
            WriteLine($"\nСумма всех элементов {k}-й строки массива: {sum}");

        }

        /*7. Дан двумерный массив. Определить: 
         * а) сумму квадратов элементов второй строки массива; 
         * б) сумму квадратов элементов c-го столбца массива
         Единственное что - массив целочисленное*/
        static void myTask_7(int[,] myArr,int index1,int index2) {
            int sumPow = 0;
            //а) сумму квадратов элементов второй строки массива
            for (int i=0; i< index2; i++) {
                sumPow += myArr[1,i]*myArr[1,i];
            }
            Write($"\nСумма квадратов элементов 2-й строки массива: {sumPow}");
            //б) сумму квадратов элементов c-го столбца массива
            sumPow = 0;         // обнуляем сумму
            int c = UserSelectIndex("столбец",index2);
            for (int i=0;i<index1;i++) {
                sumPow += myArr[i,c-1] * myArr[i,c-1];
            }
            Write($"\nСумма квадратов элементов {c}-го столбца массива: {sumPow}");
        }

        /*8. Дан двумерный массив. Определить:
         * а) максимальный элемент массива; 
         * б) минимальный элемент массива; 
         * в) координаты минимального элемента массива.*/
        /*9. Найдите индексы первого вхождения максимального элемента. Выведите два числа: номер строки и номер столбца,
        * в которых стоит наибольший элемент в двумерном массиве. 
        * Если таких элементов несколько, то выводится тот, у которого меньше номер строки, 
        * а если номера строк равны то тот, у которого меньше номер столбца.
        Сделал оба таска в одном методе что бы не писать лишний код*/

        static void myTask_8_9(int[,] myArr,int index1, int index2) {
            int max = myArr[0, 0];
            int min = myArr[0,0];
            int mini = 0, minj = 0;
            int maxi = 0, maxj = 0;
            bool flag = false;
            //циклы перебора каждого элемента массива
            for (int i=0;i<index1;i++) {
                for (int j=0; j<index2;j++) {
                    if(max < myArr[i, j]) {        //максимальный элемент
                        max = myArr[i, j];
                        maxi = i;
                        maxj = j;
                    }
                    
                    //минимальный элемент + координаты. 
                    //P.S. если миинимальный элемент массива встречается несколько раз, 
                    //то выведет координаты последнего элемента(правого нижнего)
                    if (min >= myArr[i, j]) {        
                        min = myArr[i, j];
                        mini = i+1;
                        minj = j+1;
                    }
                }
            }
            
            WriteLine($"\nМаксимальный элемент массива = {max}, минимальный элемент массива = {min} " +
                $"\nКоординаты минимального элемента: [{mini},{minj}] ");
            //Task 9
            //зная значение и координаты максимального элемента массива пройдемся еще раз по массиву
            //на проверку нескольких максимальных эдементов                   
            for (int i = 0; i< index1;i++) {
                for (int j=0;j<index2;j++) {
                    if (myArr[i,j] == max) {
                        //Если таких элементов несколько, то выводится тот, у которого меньше номер строки, 
                        if (i < maxi) {
                            maxi = i+1;
                            maxj = j+1;
                        }
                        //а если номера строк равны то тот, у которого меньше номер столбца.
                        else if (i == maxi) {
                            maxi = i+1;
                            maxj = j+1;
                            break;      //выходим из внутренего цикла for,дальше строку не перебираем
                        }
                    }
                }
            }
            WriteLine($"Координаты максимального элемента: [{maxi},{maxj}] ");

        }

        



        //метод, который вызываю по окончанию таска
        //он ждет пока пользователь не введет Enter и после этого очищает консоль
        static void myEnd_Task() {
            WriteLine("\nДля продолжения нажмите <Enter>");
            ReadLine();
            Clear();
        }


        /* Метод для пользователя - запрос на введение значений 
            и проверка к
            орректности ввода значения для  целочисленых чисел
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

        /*проверка корректного выбора столбца/строки массива(что бы пользователь не ввел 
            слишком большое значение и мы не вышли за пределы массива иначе будет жопа(словим ексепшн))
            strIndex - для вывода сообщения пользователю что он выберает строку или столбец
         */
         static int UserSelectIndex(string strIndex,int index) {
            int value = 0;
            for (; ; ) {
                UserInput($"\nВыберите {strIndex} массива (число меньше {index}): ", ref value);
                if (value > index | value <= 0) {
                    WriteLine("Вы ввели некорректное значение!");
                    continue;
                }
                else { break; }

            }
            return value;
        }













    }

}