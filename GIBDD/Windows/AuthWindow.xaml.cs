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
using GIBDD.Infrastructure.Database;
using GIBDD.Infrastructure.ViewModels;
using GIBDD.Infrastructure.Mappers;
using GIBDD.Infrastructure;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Contexts;
using System.Data;

namespace GIBDD.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private UserRepository _userRepository;
        private UserViewModel _userViewModel;
        public AuthWindow()
        {
            InitializeComponent();
            Title = "Окно авторизации";
            _userRepository = new UserRepository();
            _userViewModel = new UserViewModel();
        }


        private void Button_Login(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Password;


            _userRepository.Login(login, password);
            if (login == "" && password == "")
            {
                MessageBox.Show("Логин и пароль не могут быть пустыми строками!");
                return;
            }
            if (login == "")
            {
                MessageBox.Show("Логин не может быть пустой строкой!");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Пароль не может быть пустой строкой!");
                return;
            }

            
            using (Infrastructure.Context context = new Infrastructure.Context())
            {
                var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                if (user != null)
                {
                    Hide();
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show(); ;
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                    return;
                }
            }
            
            
            
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
