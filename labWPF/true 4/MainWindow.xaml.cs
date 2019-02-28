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

namespace true_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     //создание переменной Таймер     
        System.Windows.Threading.DispatcherTimer Timer;
        DateTime time = new DateTime();

        public MainWindow()
        {
            InitializeComponent();

           

            time = DateTime.MinValue;

            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick); 
            Timer.Interval = new TimeSpan(0, 0, 1);

            if (hou.IsChecked == true) l1.Content += time.Hour.ToString() + " : ";

            if (min.IsChecked == true) l1.Content += time.Minute.ToString() + " : ";

            if (sec.IsChecked == true) l1.Content += time.Second.ToString() + "";

        }

        bool ToF = true;

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);

            if (time.Second == 60) time = time.AddMinutes(1);

            if (time.Minute == 60) time = time.AddHours(1);

            //l1.Content = time.ToShortTimeString();

            //l1.Content = time.Hour.ToString();

            if (ToF == true)
            {

                l1.Content = "";

                if (hou.IsChecked == true) l1.Content += time.Hour.ToString() + " : ";

                if (min.IsChecked == true) l1.Content += time.Minute.ToString() + " : ";

                if (sec.IsChecked == true) l1.Content += time.Second.ToString() + "";
            }
        }

        private void Star_Click(object sender, RoutedEventArgs e)
        {
            Timer.Start();
            ToF = true;
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            time = DateTime.MinValue;
          
            l1.Content = "";

            if (hou.IsChecked == true) l1.Content += time.Hour.ToString() + " : ";

            if (min.IsChecked == true) l1.Content += time.Minute.ToString() + " : ";

            if (sec.IsChecked == true) l1.Content += time.Second.ToString() + "";
        }

        private void Sto_Click(object sender, RoutedEventArgs e)
        {

            ToF = false;
        }
    }
} 