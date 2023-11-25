using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GIBDD.Windows
{
    /// <summary>
    /// Логика взаимодействия для FineWindow.xaml
    /// </summary>
    public partial class FineWindow : Window
    {
        private FineRepository _repository;
        private TransportRepository _transportRepository;
        public FineWindow()
        {
            InitializeComponent();
            Title = "Список штрафов";
            _repository = new FineRepository();
            FineGrid.ItemsSource = _repository.GetList();
            _transportRepository = new TransportRepository();
            state_number.ItemsSource = _transportRepository.GetList();


        }
        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void state_number_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //TransportRepository chosenumber = state_number.SelectedItem as TransportRepository;
            //FineGrid.ItemsSource = chosenumber.GetList();
            
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
