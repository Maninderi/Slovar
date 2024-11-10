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
            l1.ItemsSource = products.Keys;
            products1 = new Dictionary<string, int>(products);
        }

        void UpdateL1()
        {
            l1.ItemsSource = null;
            l1.ItemsSource = products.Keys;
        }

        Dictionary <string, int> products = new Dictionary<string, int>()
        {
            {"Хлеб", 40},
            {"Молоко", 80},
            {"Яйца", 120},
            {"Сыр", 200},
            {"Вода", 25},
            {"Гречка", 50},
            {"Макароны", 60}
        };

        Dictionary<string, int> products1;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (l1.SelectedItem != null)
            {
                input.Text = l1.SelectedItem.ToString();
            }
        }
        private void Restore_Click(object sender, RoutedEventArgs e)
        {
            products = new Dictionary<string, int>(products1);
            UpdateL1();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var key = Convert.ToString(input.Text);
            if(products.TryGetValue(key, out int value) == true)
            {
                output.Text = value.ToString() + " рублей";
            }
            else
            {
                output.Text = "Ошибка";
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var key = Convert.ToString(input.Text);
            if (products.Remove(key))
            {
                output.Text = key.ToString() + " удалён";
            }
            else
            {
                output.Text = "Ошибка";
            }
            UpdateL1();
        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            products.Clear();
            UpdateL1();
        }
    }
}
