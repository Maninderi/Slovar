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

namespace работа_с_словарём
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

        var products = new Dictionary<string, int>()
        {
            {"Хлеб", 40},
            {"Молоко", 80},
            {"Яйца", 120},
            {"Сыр", 200},
            {"Вода", 25},
            {"Гречка", 50},
            {"Макароны", 60}
        };
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void DisplayAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
