using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Midterm_Airlines
{
    /// <summary>
    /// Interaction logic for FlightWindow.xaml
    /// </summary>
    public partial class FlightWindow : Window
    {
        private List<Flight> a = new List<Flight>();
        public FlightWindow()
        {
            InitializeComponent();
            a.Add(new Flight(0, 8, "Toronto", "Ahmedabad", "2020-06-22", 5.45));
            a.Add(new Flight(1, 18, "Ahmedabad", "Chicago", "2020-06-28", 22.50));
            a.Add(new Flight(2, 25, "Switzerland", "Bali", "2020-07-13", 17.30));
            a.Add(new Flight(3, 42, "New-York", "Montreal", "2020-07-18", 8.45));
            a.Add(new Flight(4, 58, "Boston", "Ottawa", "2020-07-25", 11.35));

            var depart = from flt in a
                         select flt.DepartureCity;
            flight_list.DataContext = depart;
        }

        private void flight_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = flight_list.SelectedIndex;
            var depart = from flt in a
                         where flt.Id == i
                         select flt;
            foreach (var a in depart)
            {
                airline_tb.Text = a.AirlineId.ToString();
                depart_tb.Text = a.DepartureCity;
                dest_tb.Text = a.DestinationCity;
                date_tb.Text = a.DepartureDate;
                flight_tb.Text = a.FlightTime.ToString();
            }
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (airline_tb.Text == "" || depart_tb.Text == "" || dest_tb.Text == "" || date_tb.Text == "" || flight_tb.Text == "")
            {
                MessageBox.Show("All fields are required to be added", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Add(new Flight(a.Count, int.Parse(airline_tb.Text), depart_tb.Text, dest_tb.Text, date_tb.Text, double.Parse(flight_tb.Text)));
                var depart = from val in a
                             select val.DepartureCity;
                flight_list.DataContext = depart;
                airline_tb.Clear();
                depart_tb.Clear();
                dest_tb.Clear();
                date_tb.Clear();
                flight_tb.Clear();
                MessageBox.Show("Airlines details have been successfully added!!!", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (airline_tb.Text == "" || depart_tb.Text == "" || dest_tb.Text == "" || date_tb.Text == "" || flight_tb.Text == "")
            {
                MessageBox.Show("All fields are required to update details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (update == MessageBoxResult.Yes)
                {
                    Flight flt = new Flight(a.Count, int.Parse(airline_tb.Text), depart_tb.Text, dest_tb.Text, date_tb.Text, double.Parse(flight_tb.Text));
                    a[flight_list.SelectedIndex] = flt;

                    var upd = from up in a
                              select up.DepartureCity;
                    flight_list.DataContext = upd;
                    airline_tb.Clear();
                    depart_tb.Clear();
                    dest_tb.Clear();
                    date_tb.Clear();
                    flight_tb.Clear();
                    MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Are you sure you want to delete this data?", "Delete Information", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                a.RemoveAt(flight_list.SelectedIndex);
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Id = i;
                }

                var names = from del in a
                            select del.DepartureCity;
                flight_list.DataContext = names;
                airline_tb.Clear();
                depart_tb.Clear();
                dest_tb.Clear();
                date_tb.Clear();
                flight_tb.Clear();

                MessageBox.Show("Information is successfully deleted!!!", "Information Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (airline_tb.Text == "" || depart_tb.Text == "" || dest_tb.Text == "" || date_tb.Text == "" || flight_tb.Text == "")
            {
                MessageBox.Show("All fields are required to add new customer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Add(new Flight(a.Count, int.Parse(airline_tb.Text), depart_tb.Text, dest_tb.Text, date_tb.Text, double.Parse(flight_tb.Text)));
                var flt = from ins in a
                          select ins.DepartureCity;
                flight_list.DataContext = flt;
                
                MessageBox.Show("New infromation is successfully added!!!", "New Information Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (update == MessageBoxResult.Yes)
            {
                Flight flt = new Flight(a.Count, int.Parse(airline_tb.Text), depart_tb.Text, dest_tb.Text, date_tb.Text, double.Parse(flight_tb.Text));
                a[flight_list.SelectedIndex] = flt;

                var up = from upd in a
                         select upd.DepartureCity;
                flight_list.DataContext = up;
                airline_tb.Clear();
                depart_tb.Clear();
                dest_tb.Clear();
                date_tb.Clear();
                flight_tb.Clear();

                MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Would you like to update the data??", "Data Update", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                a.RemoveAt(flight_list.SelectedIndex);
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Id = i;
                }

                var names = from del in a
                            select del.DepartureCity;
                flight_list.DataContext = names;
                airline_tb.Clear();
                depart_tb.Clear();
                dest_tb.Clear();
                date_tb.Clear();
                flight_tb.Clear();

                MessageBox.Show("Information is successfully deleted!!!", "Information Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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
            var result = MessageBox.Show("Are you sure you want to exit", "Exiting...", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
