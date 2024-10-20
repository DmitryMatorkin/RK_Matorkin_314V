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
using System.Windows.Shapes;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Log_In.xaml
    /// </summary>
    public partial class Log_In : Window
    {
        public Log_In()
        {
            InitializeComponent();
        }
        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем текст placeholder при фокусе
            if (EmailTextBox.Text == "Введите почту")
            {
                EmailTextBox.Text = "";
            }

            // Делаем вводимый текст черным
            EmailTextBox.Foreground = Brushes.Black;
            EmailTextBox.Opacity = 1.0;
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращаем текст placeholder при потере фокуса, если поле пустое
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "Введите почту";
                EmailTextBox.Foreground = Brushes.Gray;

            }
        }
        private void TextBoxWithPlaceholder_GotFocus(object sender, RoutedEventArgs e)
        {

            // Убираем текст placeholder при фокусе
            if (TextBoxWithPlaceholder.Text == "Введите пароль")
            {
                TextBoxWithPlaceholder.Text = "";
            }

            // Делаем вводимый текст черным
            TextBoxWithPlaceholder.Foreground = Brushes.Black;
            TextBoxWithPlaceholder.Opacity = 1.0;
        }

        private void TextBoxWithPlaceholder_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращаем текст placeholder при потере фокуса, если поле пустое
            if (string.IsNullOrWhiteSpace(TextBoxWithPlaceholder.Text))
            {
                TextBoxWithPlaceholder.Text = "Введите пароль";
                TextBoxWithPlaceholder.Foreground = Brushes.Gray;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        public static class WindowManager
        {

            public static void SwitchWindow(Window currentWindow, Window newWindow)
            {
                newWindow.Show();
                currentWindow.Hide();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Reg reg = new Reg();
            WindowManager.SwitchWindow(this, reg);
        }
    }
}
