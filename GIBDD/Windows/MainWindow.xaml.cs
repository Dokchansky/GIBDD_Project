using GIBDD.Windows;
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

namespace GIBDD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Окно пользователя";
        }

        private void Button_Personal(object sender, RoutedEventArgs e)
        {
            Hide();
            PersonalWindow personalWindow = new PersonalWindow();
            personalWindow.Show();
        }
        private void Button_Cars(object sender, RoutedEventArgs e)
        {
            Hide();
            CarsWindow carsWindow = new CarsWindow();
            carsWindow.Show();
        }
        private void Button_Fines(object sender, RoutedEventArgs e)
        {
            Hide();
            FineWindow fineWindow = new FineWindow();
            fineWindow.Show();
        }
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Hide();
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }
    }
}
