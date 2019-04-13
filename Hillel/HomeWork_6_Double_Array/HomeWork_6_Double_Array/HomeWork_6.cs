 using System;
using System.Linq;  // в нее помещен метод Sum() у массивов и т.д.
using static System.Console;




namespace HomeWork_6_Double_Array {
    class HomeWork_6 {
        static void Main(string[] args) {
            //LogicProgramm();

            //task 13
            myLogicTask13();

            ReadLine();
        }
        //метод в которм вля логика программы что бы не засорять Main
        private static void LogicProgramm() {
            //создаем массив для наглядности из 5х5
            int index1 = 5, index2 = 5;
            int[,] arr = new int[index1,index2];
            //заполняем его случайными значениями[10 - 99] и выводим на экран
            mySet_Array(arr, index1, index2);
            myPrintArray(arr, index1, index2);
            /*Task1. Дан двумерный массив. а) Вывести на экран элемент, расположенный в правом верхнем углу массива. 
          б) Вывести на экран элемент, расположенный в левом нижнем углу массива.*/
            //а)выводим на экран элемент, расположенный в правом верхнем углу массива.
            //т.е это элемент 1й строки последнего столбца
            WriteLine("Элемент, расположенный в правом верхнем углу массива: {0}", arr[0, index2 - 1]);
            // б) Вывести на экран элемент, расположенный в левом нижнем углу массива.
            // т.е. это элемент 1й столбца последней строки
            WriteLine("Элемент, расположенный в левом нижнем углу массива: {0}", arr[index1 - 1, 0]);
            //очищаем консоль и еще раз выводим наш массив:
            myEnd_Task();
            myPrintArray(arr, index1, index2);

            //Task2 -a заменяем значение любого элемента пятой строки двумерного массива числом 1949
            //и выводим на экран новый массив
            myTask_2(arr, index1, index2, false);
            WriteLine("Мы заменили значение любого элемента пятой строки двумерного массива числом 1949");
            myPrintArray(arr, index1, index2);

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
            //Task 4
            myPrintArray(arrTask3, index1, index2);
            myTask_4(arrTask3, index1, index2);
            myEnd_Task();
            //Task 5
            myPrintArray(arrTask3, index1, index2);
            myTask_5(arrTask3, index1, index2);
            // Task 6 выводим на примере того-же массива
            myTask_6(arrTask3, index1, index2);
            myEnd_Task();
            //создам новый массив 4х4 , и на его примере буду выводить результаты следующих тасков
            index1 = 4;
            index2 = 4;
            int[,] myNewArr = new int[index1, index2];
            mySet_Array(myNewArr, index1, index2);
            myPrintArray(myNewArr, index1, index2);
            //Task 7
            myTask_7(myNewArr, index1, index2);
            //Task 8 and 9
            myTask_8_9(myNewArr, index1, index2);
            myEnd_Task();
            //Task 10
            int index = 0;
            for (; ; ) {    //цикл проверки ввода  нечетного числа
                UserInput("Введите целое нечетное число n для размерности масивва n x n: ", ref index);
                if (index % 2 == 0) {
                    WriteLine("Вы ввели четное число, попробуйте еще раз!");
                } else {
                    break;
                }
            }
            char[,] arrTask10 = new char[index, index];
            myTask_10(arrTask10, index);
            myEnd_Task();

            //Task 11
            //создаем двумерный квадратный массив 7x7 и заполняем его случайными элементами
            //алгоритм корректно работает с нечетным кол-вом элементов
            int[,] myArrTask11 = new int[7, 7];
            mySet_Array(myArrTask11, 7, 7);
            //выводми массив на экран
            myPrintArray(myArrTask11, 7, 7);
            myTask_11(myArrTask11, 7);
            WriteLine("Наш массив после того, как поменяли элементы на главной и побочной диагонали:\n ");
            myPrintArray(myArrTask11, 7, 7);
            myEnd_Task();
            //task 12
            int index_1_task12 = 0, index_2_task12 = 0;
            UserInput("введите индекс для двумерного массива i: ", ref index_1_task12);
            UserInput("введите индекс для двумерного массива j: ", ref index_2_task12);
            //создаем массив и заполняем случайными значениями
            int[,] myarrtask12 = new int[index_1_task12, index_2_task12];
            mySet_Array(myarrtask12, index_1_task12, index_2_task12);
            myPrintArray(myarrtask12, index_1_task12, index_2_task12);
            int[,] myNewArrTask12 = myTask_12(myarrtask12, index_1_task12, index_2_task12);
            WriteLine("наш массив после того, как мы повернули его на 90 градусов по часовой стрелке: \n");
            myPrintArray(myNewArrTask12, index_2_task12, index_1_task12);






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

        /*10. Дано нечетное число n. Создайте двумерный массив из n x n элементов, заполнив его символами "." 
         * (каждый элемент массива является строкой из одного символа). 
         * Затем заполните символами "*" среднюю строку массива, средний столбец массива, 
         * главную диагональ и побочную диагональ.
         * В результате единицы в массиве должны образовывать изображение звездочки.*/
        static void myTask_10(char[,] myArr, int index) {
            //Заполняем массив "."
            for(int i=0; i< index; i++) {
                for (int j = 0; j< index; j++) {
                    myArr[i, j] = '.';                    
                }
            }
            //заполняем массив "*"
            for (int i = 0; i < index; i++) {
                for (int j = 0; j < index; j++) {
                    //средняя строчка массива
                    if (i==(index/2)) {
                        myArr[i, j] = '*';
                    }
                    //средний столюец массива
                    if (j == index / 2 ) {
                        myArr[i, j] = '*';
                    }
                    //главная диагональ
                    if (i==j) {
                        myArr[i, j] = '*';
                    }
                    //побочная диагональ
                    if (j == index-1-i) {
                        myArr[i, j] = '*';
                    }
                }
            }
            //выводим заполненый массив
            for (int i =0; i< index; i++) {
                for (int j = 0; j< index; j++) {
                    Write(myArr[i,j]+" ");
                }
                WriteLine();
            }
        }

        /*11. Дан квадратный массив. Поменяйте местами элементы,
         * стоящие на главной и побочной диагонали, при этом каждый элемент должен остаться в том же столбце
         * (то есть в каждом столбце нужно поменять местами элемент на главной диагонали и на побочной диагонали).
         Метод корректно работает только если массив квадратный с нечетным количеством строк и столбцов, например 7х7 */
         static void myTask_11(int[,] myArr, int index) {
            int temp = 0;
            //цикл прохода по всем элементам массива...
            for(int i = 0; i < index; i++) {
                for (int j = 0; j<index; j++) {
                    //проходим по шлавной диагонали 
                    //и меняем местами элементы с элементами побочной диагонали
                    //index - 1 - i, j   - элементы побочной диагонали
                    if (i == j) {
                        temp = myArr[i, j];
                        myArr[i, j] = myArr[index - 1 - i, j];
                        myArr[index - 1 - i, j ] = temp;
                    }
                }
            }

        }

        /*12. Дан прямоугольный массив размером n x m. 
         * Поверните его на 90 градусов по часовой стрелке,
         * записав результат в новый массив размером m x n.*/
        static int[,] myTask_12(int[,] myArr,int index1,int index2) {
            //новая размерность нового массива 
            int newIndex1 = index2, newIndex2 = index1;
            //создаем новый массив
            int[,] myNewArr = new int[newIndex1, newIndex2];
            //поворачиваем его на 90 градусов  по часовой стрелке :)
            //выходит что теперь строки нового массива - это столбцы предыдущего
            // а столбцы нового массива - строки предыдущего В ОБРАТНОМ ПОРЯДКЕ(т.е. снизу вверх)
            for(int i = 0; i< newIndex1; i++) {
                for(int j = 0; j< newIndex2; j++) {
                    myNewArr[i, j] = myArr[index1-1-j,i];
                }
            }
            return myNewArr;
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












        /*13. Риализовать диагностическую программу, которая протестирует различне алгоритмы сортировки 
         * (реализовать самостоятельно - сортировка пузырьком, сортировка вставками, сортировка выборкой;
         * использовать готовую сортировку, встроенную в стандартный функционал) на скорость работы с 
         * 1000, 100000, 1000000, 1000000000 элементов случайных чисел. 
         * Использовать Stopwatch из пространства имен -> System.Diagnostice;*/

        //метод заполнения массива случайными числами от 10 до 255 включительно - перегруженный метод как и для заполнения двумерного массива
        static void mySet_Array(byte[] myArr, long index) {
            for(int i =0; i< index; i++) {
                myArr[i] =Convert.ToByte( new Random().Next(1, 255));
              
            }
        }

        //сортировка пузырьком
        //
        static void myBubbleSort(byte[] myArr) {
           byte temp = 0;
            //засекаю время непосредственно перед самим алгоритмом 
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            //внешний цикл по общему проду по элементов
            //кол-во проходов = кол-во элементов - 1
            //по завершению каждого внешнего прохода на последней и т.д. позиции будет максимальный элемент            
            for (int i = 0; i < myArr.Length-1; i++) {  
                for(int j =0; j < myArr.Length - i - 1; j++)
                if (myArr[j]>myArr[j+1]) {
                        temp = myArr[j];
                        myArr[j] = myArr[j + 1];
                        myArr[j + 1] = temp;
                }
            }
            time.Stop();
            long milisec = time.ElapsedMilliseconds;
            string strOutput = $"Сортировка методом пузырька на {myArr.Length} элементов длится {milisec} милисекунд или" +
                $" {milisec/1000} секунд.";            
            WriteLine(strOutput);

        }

        //Сортировка вставками
        //
        static void myInsertSort(byte[] myArr) {
            byte temp = 0;  //для хранения значения 
            //засекаю время непосредственно перед самим алгоритмом 
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            //Алгоритм сортировки вставками
            for(int i = 1; i<myArr.Length; i++) {   //начинаем со 2го элемент
                for(int j =i; j > 0; j--) {      //проходим по предыдущим элементам массива, и вставляем наш элемент на нужную позицию
                    //ecли предыдущий элемент больше текущего то меняем их местами
                    if (myArr[j-1] > myArr[j]) {
                        temp = myArr[j];
                        myArr[j] = myArr[j - 1];
                        myArr[j - 1] = temp;
                        
                    }
                }
            }
            time.Stop();
            long milisec = time.ElapsedMilliseconds;
            string strOutput = $"Сортировка вставками на {myArr.Length} элементов длится {milisec} милисекунд или" +
                $" {milisec / 1000} секунд.";
            WriteLine(strOutput);                       
        }

        //сортировка выборкой
        //
        static void mySampleSort(byte[] myArr) {
            int indexmin =0;   //для хранения индекса минимального элемента
            byte temp = 0;
            //засекаю время непосредственно перед самим алгоритмом 
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            //Алгоритм сортировки выборкой
            for (int i=0;i<myArr.Length-1;i++) {
                indexmin = i;  //минимальный элемент
                //поиск минимального элемента в массиве
                for(int j = i + 1;j< myArr.Length;j++) {
                    if (myArr[j] < myArr[indexmin]) {
                        indexmin = j;
                    }
                }
                //меняем элементы местами(мин. элемент ставим на нужную позицию)
                temp = myArr[i];
                myArr[i] = myArr[indexmin];
                myArr[indexmin] = temp;
            }

            time.Stop();
            long milisec = time.ElapsedMilliseconds;
            string strOutput = $"Сортировка выборкой на {myArr.Length} элементов длится {milisec} милисекунд или" +
                $" {milisec / 1000} секунд.";
            WriteLine(strOutput);


        }

        //готовая сортировка 
        //
        static void myReadySort(byte[] myArr) {
            //засекаю время непосредственно перед самим алгоритмом 
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            //Стандартная сортировка
            Array.Sort(myArr);

            time.Stop();
            long milisec = time.ElapsedMilliseconds;
            string strOutput = $"Стандартная Сортировка на {myArr.Length} элементов длится {milisec} милисекунд или" +
                $" {milisec / 1000} секунд.";
            WriteLine(strOutput);
        }

        //метод в котором вся логика 13 таска с сортировками
        static void myLogicTask13() {

        }



        //метод для вывода одномерного массива(для проверки отработки сортировки)
        //он же перегруженный метод вывода двумерного массива
        static void myPrintArray(byte[] myArr) {
            for (int i = 0; i < myArr.Length; i++) {
                Write(myArr[i] + " ");
            }
            WriteLine();
        }
    }

}
 