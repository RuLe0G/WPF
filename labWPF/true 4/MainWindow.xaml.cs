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
        public MainWindow()
        {
            InitializeComponent();
            
            Timer = new System.Windows.Threading.DispatcherTimer();
            Timer.Tick += new EventHandler(dispatcherTimer_Tick); 
            Timer.Interval = new TimeSpan(0, 0, 1);
        
            Timer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            l1.Content = "";
       
            if (hou.IsChecked == true) l1.Content += DateTime.Now.Hour + " : ";

            if (min.IsChecked == true) l1.Content += DateTime.Now.Minute + " : ";

            if (sec.IsChecked == true) l1.Content += DateTime.Now.Second + "";

        }

    }
} 