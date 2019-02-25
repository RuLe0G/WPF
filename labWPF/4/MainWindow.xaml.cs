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

namespace _4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        int dday;

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 2019; i != 1900; i--)
                years.Items.Add(i);
        }



        private void Years_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            month.IsEnabled = true;
            month.Items.Add("01");
            month.Items.Add("02");
            month.Items.Add("03");
            month.Items.Add("04");
            month.Items.Add("05");
            month.Items.Add("06");
            month.Items.Add("07");
            month.Items.Add("08");
            month.Items.Add("09");
            month.Items.Add("10");
            month.Items.Add("11");
            month.Items.Add("12");
           
        }

        private void Month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((month.SelectedIndex == 0) || (month.SelectedIndex == 2) || (month.SelectedIndex == 4) || (month.SelectedIndex == 6) || (month.SelectedIndex == 8) || (month.SelectedIndex == 10))
                dday = 31;
            else if (month.SelectedIndex == 1)
                dday = 28;
            else
                dday = 30;
            day.IsEnabled = true;
            for (int i = 1; i != dday+1; i++)
                day.Items.Add(i);
        }

        private void Day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int Tyear = DateTime.Now.Year;
            int TMonth = DateTime.Now.Month;
            int Tday = DateTime.Now.Day;
            int t = (Tyear - Convert.ToInt32(years.SelectedItem));

            Lb.Content = ("Разница в годах до нашего времени сотовляет.. " + t) +
                "\n Разница в месяцах до нашего времени сотовляет.. " + ((t * 12) + (TMonth - Convert.ToInt32(month.SelectedItem))); ;


        }
    }
}
