using System;
using static System.Console;

namespace Home_Work_5_Aray {
    class HW5Array {
        static void Main(string[] args) {
            MyProgramm_Part_One();
            WriteLine("\n\nДля завершения программы нажмите Enter: ");
            ReadLine();
        }



        //отдельный метод в котором вся логика 5 задания вариант 1 (с одномерными массивами)
        static void MyProgramm_Part_One() {
            //Task 1: создаем новый массив, заполняем его согластно 1му заданию и выводим:
            int[] myArrTask1 = Task_1_1();
            Print_Arr("Ваш массив: ", myArrTask1);
            //Task 2: 
            //Массив предназначен для хранения значений ростов двенадцати человек. 
            //С помощью случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
            int[] myArrTask2 = setArr(12, 163, 190, true);
            //выведем массив с таска 2: 
            Print_Arr("Массив предназначен для хранения значений ростов двенадцати человек: ", myArrTask2);
            //Task 3:
            Task_1_3();
            //Task 4:
            Task_1_4();
            WriteLine();
            //Task 5
            //      int[] myArrTask5 = new int[12];
            //      int sumTask5 = Task_1_5(myArrTask5);
            //      Print_Arr("Наш массив: ", myArrTask5);
            //      WriteLine($"Сумма всех элементов массива = {sumTask5}");

            //Task 6 
            int[] myArrTask6 = new int[20];
            double sum = Task_1_6(myArrTask6);
            //ввыведем заполненый массив и потом общее сопротивление цепи
            Print_Arr("Массив из 20 элементов, которые хранят информацию о сопротивлении каждого элимента цепи R:", myArrTask6);
            WriteLine("Общее сопротивление цепи (1 / R(1) + 1 / R(2)… 1 / R(n)): {0}", sum);

            //Task 7 
            //сначала просим у пользоваателя какой дли массив он хочет
            int indexArr;
            Write("\nВведите размерность массива: ");
            for (; ; ) {  //цикл будет до тех пор пока пользователь не введет целочисленное значение
                try {
                    indexArr = Convert.ToInt32(ReadLine());
                    break;
                }
                catch {
                    WriteLine("Вы ввели не целочисленное значение попробуйте еще раз!");
                    continue;
                }
            }
            //потом инициализируем этот массив случайными числами от -999 до 999
            int[] arrTask7 = setArr(indexArr, -999, 999, true);
            //выведем этот массив
            Print_Arr("Ваш массив заполненый случайными числами от -999 до 999: ", arrTask7);
            // и выведем результат - сумма всех элементов больше 0 или меньше
            int summ = 0;
            if(Task_1_7(arrTask7,ref summ)) {
                WriteLine("Сумма всех элементов массива:{0} и она больше 0 ", summ);
            }
            else {
                WriteLine("Сумма всех элементов массива:{0} и она меньше 0 ", summ);
            }
        }

        //отдельный метод в котором вся логика 5 задания вариант 2 (с двухмерными массивами)
        static void MyProgramm_Part_Two() {



        }

        //метод, который выводит наш массив на экран
        static void Print_Arr(string srtUserMessage, int[] arr) {
            WriteLine(srtUserMessage);
            string strOutputArr = "[ ";
            for (int i = 0; i < arr.Length; i++) {
                strOutputArr += arr[i];
                if (i != arr.Length - 1) {
                    strOutputArr += ", ";   // когда будет последний елемент массива, то не добавит запятую
                }
            }
            strOutputArr += "]";
            WriteLine(strOutputArr);
        }

        //универсальный метод который возвращает заполненый массив размерностью index
        // в диапазоне от lowBorder до hightBorder включительно
        // если флаг flag  -> true, то заполняет случайными элементами
        //flag -> false заполняет значениями от lowBorder до конца размерности с шагом в 1
        static int[] setArr(int index, int lowBorder, int hightBorder, bool flag) {
            int[] myArr = new int[index];
            if (flag) {
                for (int i = 0; i < index; i++) {
                    myArr[i] = new Random().Next(lowBorder, hightBorder);
                    System.Threading.Thread.Sleep(10);
                }
            }
            else {
                for (int i = 0; i < index; i++) {
                    myArr[i] = lowBorder + 1 + i;

                }
            }

            return myArr;
        }

        //1_1 Заполнить массив из восьми элементов следующими значениями:
        //первый элемент массива равен 37, второй — 0, 
        //третий — 50, четвертый — 46, пятый — 34, шестой — 46, 
        //седьмой — 0, восьмой —13. Вывести на экран
        static int[] Task_1_1() {
            int[] myArr = new int[8] { 37, 0, 50, 46, 34, 46, 0, -13 };
            return myArr;
        }


        /*1_3 Присвоить начальные целые значения 1, 2, 3,… , 10 элементам массива из десяти элементов 
         * и выводит на экран элементы массива с четным индексом.*/
        static void Task_1_3() {
            int[] myArr = setArr(10, 0, 0, false); //заполняем наш массив значениями от 0 до 10 
            //выводим элементы массива с четным индексом(т.е. индексы от 0 и возврастают на 2) 
            WriteLine("Выведем элементы массива с четными индексами:");
            for (int i = 0; i < 10; i += 2) {
                Write($"{myArr[i]} ");
            }
            WriteLine();
        }

        /*1_4. Создать массив размерностью в 10 элементов, вывести на экран все элементы массива в обратном порядке.*/
        static void Task_1_4() {
            //сначала создадим массив из 10 элементов и заполним случайными двухзначными значениями
            int[] myArr = setArr(10, 10, 100, true);
            //теперь выведем наш массив на экран
            Print_Arr("Наш массив из 10 элементов: ", myArr);
            //и выведем наш массив в обратном порядке:
            WriteLine("Наш массив в обратном порядке: ");
            for (int i = 9; i >= 0; i--) {
                Write($"{myArr[i]} ");
            }

        }

        /*1_5Создать массив размерностью в 12 элементов, суммировать значения. Суммирование осуществляется в теле цикла for.
         * Значения, используемые в качестве начальных для массива A, вводятся в программу пользователем с клавиатуры.*/
        static int Task_1_5(int[] myArr) {
            int sum = 0;
            //заполняем массив
            for (int i = 0; i < myArr.Length; i++) {
                Write($"Введите целочисленное значение элемена {i + 1} массива: ");
                try {
                    myArr[i] = Convert.ToInt32(ReadLine());
                }
                catch {
                    WriteLine("Вы ввели не целочисленное значение попробуйте еще раз!");
                    i--;
                }
            }

            //цикл суммирования значения массива как указано в задании ,
            //хотя это можно было сделать во время считывания значений что бы лишний цикл не писать :)
            for (int i = 0; i < myArr.Length; i++) {
                sum += myArr[i];
            }

            return sum;
        }

        /*1_6. В массиве хранится информация о сопротивлении каждого из 20 элементов электрической цепи. 
         * Все элементы соединены параллельно. Определить общее сопротивление цепи.
         * (1 / R(1) + 1 / R(2)… 1 / R(n))*/
        static double Task_1_6(int[] myArr) {
            double totalResistance = 0;
            //заполним  массив который хранит все 20 значений сопротивления элементов  R(n)
            for (int i = 0; i < myArr.Length; i++) {
                myArr[i] = new Random().Next(1, 100);
                System.Threading.Thread.Sleep(5);
                totalResistance += 1.0 / myArr[i];            //сразу добавляем это значение 
            }
            return totalResistance;
        }

        /*Выяснить, верно ли, что сумма элементов массива есть неотрицательное число.*/
        static bool Task_1_7(int[] myArr, ref int summ) {
            
            for (int i = 0; i < myArr.Length; i++) {
                summ += myArr[i];
            }

            if (summ > 0) { return true; }
            else { return false; }






        }
    }





}



