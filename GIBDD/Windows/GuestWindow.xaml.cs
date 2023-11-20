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
    /// Логика взаимодействия для GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        public GuestWindow()
        {
            InitializeComponent();
            Title = "Окно гостя";
        }
        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            Hide();
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }
    }
}
