using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Home_Work_2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
// строки для работы + инициализация их для первого запуска приложения
        public string UserInputStr = "Введи тут какой-то текст", SystemOutputStr = "\tТут будет информация о системе:";

       
        //так понимаю это конструктор при инициализации 
        //тут заполняем текст боксы по умолчанию
        public MainWindow()
        {
            InitializeComponent();
            UserInputTextBox.Text = UserInputStr;
            UserOutputTextBox.Text = "Тут будет твой текст"; 
            SystemOutputTextBox.Text = SystemOutputStr;
        }

      

        //событие при наведении пользователем мышкой на текстбокс очищает его
        private void UserInputTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            UserInputTextBox.Clear();
        }
  //если пользовел отвел указатель мышки с текст бокса
        private void UserInputTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            //и если он не ввел что то, то мы возвращаем туда начальный текст
            if (UserInputTextBox.Text == string.Empty)
                UserInputTextBox.Text = UserInputStr;
        }
  // при нажатии на кнопку выведем справа то, что ввел пользователь и внизу информацию о системе
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserInputStr = UserInputTextBox.Text;
            UserOutputTextBox.Text = UserInputStr;
            //вывод информации о системе:
            SystemOutputStr = "Путь к приложению: " + Environment.CurrentDirectory;
            SystemOutputStr += "\nИмя компьютера: " + Environment.MachineName;
            SystemOutputStr += "\nИмя пользователя: " + Environment.UserName;
            SystemOutputStr += "\nВерсия ОС: " + Environment.OSVersion;
            SystemOutputStr += "\nКоличество процессоров: " + Environment.ProcessorCount;
            SystemOutputStr += "\nПуть к системному каталогу: " + Environment.SystemDirectory;

            SystemOutputTextBox.Text = SystemOutputStr;
        }



    }
}
