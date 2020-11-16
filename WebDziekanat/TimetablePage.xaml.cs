using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Threading;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace WebDziekanat
{
    /// <summary>
    /// Interaction logic for TimetablePage.xaml
    /// </summary>
    public partial class TimetablePage : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        public TimetablePage()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            double timetableStart = 8 * 60 + 15;
            double timetableEnd = 20 * 60;
            double currentTime = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
            double position = pointerCanvas.ActualWidth * ( (currentTime-timetableStart) / (timetableEnd-timetableStart))  - timePointer.ActualWidth; ;

            currentTimeTxtb.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            Canvas.SetLeft(timePointer, position);
            Canvas.SetLeft(currentTimeTxtb, position);
        }

    }
}
