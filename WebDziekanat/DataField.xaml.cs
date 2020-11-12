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
    /// <summary>
    /// Interaction logic for DataField.xaml
    /// </summary>
    public partial class DataField : UserControl
    {
        public DataField()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public static readonly 
        DependencyProperty 
        BadgeProperty = DependencyProperty.Register("Badge", typeof(string), typeof(DataField)),
        ContentProperty = DependencyProperty.Register("Content", typeof(string), typeof(DataField));


        public string Badge{
            get{
                return GetValue(BadgeProperty) as string;
            }
            set{
                SetValue(BadgeProperty, value);
            }
        }

        public string Content{
            get{
                return GetValue(ContentProperty) as string;
            }
            set{
                SetValue(ContentProperty, value);
            }
        }


    }
}
