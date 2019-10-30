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
using System.IO.Ports;

namespace TabletVzhled
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort;
        public MainWindow()
        {
            InitializeComponent();
            init();
        }

        private void Pozice1_Click(object sender, RoutedEventArgs e)
        {
            Pozice1.Background = Brushes.Red;
           
            _serialPort.WriteLine("A");

        }

        private void Pozice2_Click(object sender, RoutedEventArgs e)
        {
            Pozice2.Background = Brushes.Red;
            _serialPort.WriteLine("B");
        }

        private void Pozice3_Click(object sender, RoutedEventArgs e)
        {
            Pozice3.Background = Brushes.Red;
            _serialPort.WriteLine("C");
        }

        private void Pozice4_Click(object sender, RoutedEventArgs e)
        {
            Pozice4.Background = Brushes.Red;
            _serialPort.WriteLine("D");
        }

        private void Pozice5_Click(object sender, RoutedEventArgs e)
        {
            Pozice5.Background = Brushes.Red;
            _serialPort.WriteLine("E");
        }

        private void Pozice6_Click(object sender, RoutedEventArgs e)
        {
            Pozice6.Background = Brushes.Red;
            _serialPort.WriteLine("F");
        }

        private void Pozice7_Click(object sender, RoutedEventArgs e)
        {
            Pozice7.Background = Brushes.Red;
            _serialPort.WriteLine("G");
        }

        private void Pozice8_Click(object sender, RoutedEventArgs e)
        {
            Pozice8.Background = Brushes.Red;
            _serialPort.WriteLine("H");
        }

        private void Pozice9_Click(object sender, RoutedEventArgs e)
        {
            Pozice9.Background = Brushes.Red;
            _serialPort.WriteLine("I");
        }

        
        private void init()
        {
            try
            {

                _serialPort = new SerialPort();
                _serialPort.BaudRate = 9600;
                _serialPort.PortName = "COM3";
                _serialPort.Open();
            }

            catch(Exception)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Reset_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
