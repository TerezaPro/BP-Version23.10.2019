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

namespace TabletVzhled
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pozice1_Click(object sender, RoutedEventArgs e)
        {
            Pozice1.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice2_Click(object sender, RoutedEventArgs e)
        {
            Pozice2.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice3_Click(object sender, RoutedEventArgs e)
        {
            Pozice3.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice4_Click(object sender, RoutedEventArgs e)
        {
            Pozice4.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice5_Click(object sender, RoutedEventArgs e)
        {
            Pozice5.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice6_Click(object sender, RoutedEventArgs e)
        {
            Pozice6.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice7_Click(object sender, RoutedEventArgs e)
        {
            Pozice7.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Pozice8_Click(object sender, RoutedEventArgs e)
        {
            Pozice8.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme"); 
        }

        private void Pozice9_Click(object sender, RoutedEventArgs e)
        {
            Pozice9.Background = Brushes.Red;
            MessageBox.Show($"Děkujeme");
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            for (int index = 1; index <= 9; index++)
            {
                string wpfComponent = "Pozice"+index.ToString();
                Pozice9.Background = Brushes.LawnGreen;
            }
           
        }
    }
}
