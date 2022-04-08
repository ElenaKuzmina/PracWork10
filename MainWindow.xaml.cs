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
using System.IO;

namespace PracWork10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                       
        }
        /// <summary>
        /// выполнение основного алгоритма
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {
            try // обработка исключения
            {
                // Получаем номер выделенной строки
                int index = lstInput.SelectedIndex;
            // Считываем строку в перменную str
            string str = (string)lstInput.Items[index];
            // Узнаем количество символов в строке
            int len = str.Length;
            // Считаем, что количество пробелов равно 0
            int count = 0;
            // Устанавливаем счетчик символов в 0
            int i = 0;
            //Организуем цикл перебора всех символов в строке
            while (i < len - 1)
            {
                // Если нашли пробел, то увеличиваем
                // счетчик пробелов на 1
                if (str[i] == ' ')
                    count++;
                i++;
            }
            txbRezult.Text = "Количество пробелов = " + count.ToString();

            }
            catch (Exception ex) // "поймать" ошибку
            {
                MessageBox.Show(ex.Message); // вывести сообщение об ошибке
            }

        }
        /// <summary>
        /// считывание строк текста их файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListFromFile_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"Строки.txt", Encoding.UTF8);

            while (!sr.EndOfStream) //пока не конец файла(потока)
            {
                lstInput.Items.Add(sr.ReadLine());
            }
        }
    }
}
