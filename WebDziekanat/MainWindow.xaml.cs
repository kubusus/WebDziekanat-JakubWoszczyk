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

namespace WebDziekanat
{
    
    public partial class MainWindow : Window
    {

        HomePage homePage = new HomePage();
        Grades gradesPage = new Grades();
        TimetablePage timetablePage = new TimetablePage();
        ContactsPage contactsPage = new ContactsPage();

        public MainWindow()
        {
            InitializeComponent();

            
            NavigationFrame.Navigate(homePage);
            this.WindowState = WindowState.Maximized;
        }

        private void gradesBtn_Click(object sender, RoutedEventArgs e)
        {

            NavigationFrame.Navigate(gradesPage);
        }

        private void generalBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(homePage);
        }

        private void timetableBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(timetablePage);
        }

        private void ContactsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Navigate(contactsPage);
        }
    }
}
