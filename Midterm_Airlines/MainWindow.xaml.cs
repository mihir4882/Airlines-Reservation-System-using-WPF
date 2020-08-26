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

namespace Midterm_Airlines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Custbtn_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cuwin = new CustomerWindow();
            cuwin.Title = "Customer Window";
            cuwin.Background = Brushes.LightBlue;
            cuwin.ShowDialog();
        }

        private void Airbtn_Click(object sender, RoutedEventArgs e)
        {
            AirlineWindow awin = new AirlineWindow();
            awin.Title = "Airline Window";
            awin.Background = Brushes.LightBlue;
            awin.ShowDialog();
        }

        private void Flightbtn_Click(object sender, RoutedEventArgs e)
        {
            FlightWindow fwin = new FlightWindow();
            fwin.Title = "Flight Window";
            fwin.Background = Brushes.LightBlue;
            fwin.ShowDialog();
        }

        private void Passengerbtn_Click(object sender, RoutedEventArgs e)
        {
            PassengerWindow pwin = new PassengerWindow();
            pwin.Title = "Passenger Window";
            pwin.Background = Brushes.LightBlue;
            pwin.ShowDialog();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cuwin = new CustomerWindow();
            cuwin.Title = "Customer Window";
            cuwin.Background = Brushes.LightBlue;
            cuwin.ShowDialog();
        }

        private void Airlines_Click(object sender, RoutedEventArgs e)
        {
            AirlineWindow awin = new AirlineWindow();
            awin.Title = "Airline Window";
            awin.Background = Brushes.LightBlue;
            awin.ShowDialog();
        }

        private void Flights_Click(object sender, RoutedEventArgs e)
        {
            FlightWindow fwin = new FlightWindow();
            fwin.Title = "Flight Window";
            fwin.Background = Brushes.LightBlue;
            fwin.ShowDialog();
        }

        private void Passengers_Click(object sender, RoutedEventArgs e)
        {
            PassengerWindow pwin = new PassengerWindow();
            pwin.Title = "Passenger Window";
            pwin.Background = Brushes.LightBlue;
            pwin.ShowDialog();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Help hwin = new Help();
            hwin.Title = "Help";
            hwin.Background = Brushes.LightBlue;
            hwin.ShowDialog();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Close_Window(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit", "Existing...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
