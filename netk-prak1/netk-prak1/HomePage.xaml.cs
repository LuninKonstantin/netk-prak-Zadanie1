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

namespace netk_prak1
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void StudentListButton_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new StudentListPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new NewStudentPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Mark());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new SpisokPrepod());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new NewPrepod());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Propuski());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new SpisokPredmetov());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new NewPredmet());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).mainFrame.Navigate(new Meropr());
        }
    }
}
       