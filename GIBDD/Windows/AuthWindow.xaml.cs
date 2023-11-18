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

namespace GIBDD.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            Title = "Окно авторизации";
        }


        private void Button_Login(object sender, RoutedEventArgs e)
        {
            Hide();
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
        }

        private void Button_Guest(object sender, RoutedEventArgs e)
        {
            Hide();
            GuestWindow guestWindow = new GuestWindow();
            guestWindow.Show();
        }

        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
