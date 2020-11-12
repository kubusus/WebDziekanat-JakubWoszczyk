using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    

    public partial class Grades : Page
    {

        ObservableCollection<Subject> semester1;
        ObservableCollection<Subject> semester2;
        ObservableCollection<Subject> semester3;

        void fill_data()
        {
            semester1 = new ObservableCollection<Subject>();
            semester2 = new ObservableCollection<Subject>();
            semester3 = new ObservableCollection<Subject>();

            semester1.Add(new Subject("Programming and data structures", 6, 5, "dr inż. Grzegorz Jabłoński"));
            semester1.Add(new Subject("Databases", 3, 4.5, "prof. dr hab. inż. Adam Pelikant"));
            semester1.Add(new Subject("Academic English", 2, 4.5, "mgr Elżbieta Krawczyk"));
            semester1.Add(new Subject("Mathematics I", 6, 4, "dr inż. Sławomir Jagodziński	"));

            semester2.Add(new Subject("Algorithms and Data Structures", 6, 5, "dr hab. Szymon Grabowski"));
            semester2.Add(new Subject("Physics", 6, 5, "dr inż. Bogdan Żółtowski"));
            semester2.Add(new Subject("Scripting Languages", 5, 5, "dr inż. Witold Marańda"));

            semester3.Add(new Subject("Computer Graphics", 3, 4, ""));
            semester3.Add(new Subject("Mathematics", 6, 4, "dr inż. Sławomir Jagodziński"));
            semester3.Add(new Subject("Electronics ", 3, 4.5, "dr hab. inż. Marcin Janicki"));

            semester1_DataGrid.ItemsSource = semester1;
            semester2_DataGrid.ItemsSource = semester2;
            semester3_DataGrid.ItemsSource = semester3;
        }


        public Grades()
        {
            InitializeComponent();
            fill_data();
        }
    }
}
