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

namespace labWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            A.Text = "A";
            B.Text = "B";

        
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            int Ra = Int32.Parse(A.Text);
            int Rb = Int32.Parse(B.Text);
            string rs = Convert.ToString(Ra + Rb);
                 inp.Content = rs;
            character.Content = plus.Content;
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            int Ra = Int32.Parse(A.Text);
            int Rb = Int32.Parse(B.Text);
            string rs = Convert.ToString(Ra - Rb);
            inp.Content = rs;
            character.Content = minus.Content;
        }

        private void Ad_Click(object sender, RoutedEventArgs e)
        {
            int Ra = Int32.Parse(A.Text);
            int Rb = Int32.Parse(B.Text);
            string rs = Convert.ToString(Ra * Rb);
            inp.Content = rs;
            character.Content = ad.Content;
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            double Ra = Double.Parse(A.Text);
            double Rb = Double.Parse(B.Text);
            string rs = Convert.ToString(Ra / Rb);
            inp.Content = rs;
            character.Content = div.Content;
        }
    }
}
