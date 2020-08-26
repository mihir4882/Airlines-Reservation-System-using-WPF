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
    /// Interaction logic for PassengerWindow.xaml
    /// </summary>
    public partial class PassengerWindow : Window
    {
        

        private List<passenger> a = new List<passenger>();
        public PassengerWindow()
        {
            InitializeComponent();
            a.Add(new passenger(0, 1, 2));
            a.Add(new passenger(1, 2, 3));
            a.Add(new passenger(2, 3, 4));
            a.Add(new passenger(3, 4, 5));
            a.Add(new passenger(4, 5, 6));

            var pass = from psg in a
                       select psg.CustomerId;
            lpassenger.DataContext = pass;
        }


        private void lpassenger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = lpassenger.SelectedIndex;
            var depart = from flt in a
                         where flt.Id == i
                         select flt;
            foreach (var a in depart)
            {
                custId_tb.Text = a.CustomerId.ToString();
                flightId_tb.Text = a.FlightId.ToString();
            }
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (custId_tb.Text == "" || flightId_tb.Text == "")
            {
                MessageBox.Show("All fields are required to be added", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Add(new passenger(a.Count, int.Parse(custId_tb.Text), int.Parse(flightId_tb.Text)));

                var pass = from pas in a
                           select pas.CustomerId;

                lpassenger.DataContext = pass;
                custId_tb.Clear();
                flightId_tb.Clear();
                MessageBox.Show("Airlines details have been successfully added!!!", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (custId_tb.Text == "" || flightId_tb.Text == "")
            {
                MessageBox.Show("All fields are required to update details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (update == MessageBoxResult.Yes)
                {
                    passenger pas1 = new passenger(a.Count, int.Parse(custId_tb.Text), int.Parse(flightId_tb.Text));
                    a[lpassenger.SelectedIndex] = pas1;

                    var pass = from up in a
                              select up.CustomerId;

                    lpassenger.DataContext = pass;
                    custId_tb.Clear();
                    flightId_tb.Clear();
                    MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Are you sure you want to delete this data?", "Delete Information", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                a.RemoveAt(lpassenger.SelectedIndex);
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Id = i;
                }

                var pass = from del in a
                           select del.CustomerId;

                lpassenger.DataContext = pass;
                custId_tb.Clear();
                flightId_tb.Clear();

                MessageBox.Show("Information is successfully deleted!!!", "Information Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (custId_tb.Text == "" || flightId_tb.Text == "")
            {
                MessageBox.Show("All fields are required to add new customer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Add(new passenger(a.Count, int.Parse(custId_tb.Text), int.Parse(flightId_tb.Text)));
                var pass = from ins in a
                          select ins.CustomerId;

                lpassenger.DataContext = pass;
                custId_tb.Clear();
                flightId_tb.Clear();

                MessageBox.Show("New infromation is successfully added!!!", "New Information Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (update == MessageBoxResult.Yes)
            {
                passenger pas = new passenger(a.Count, int.Parse(custId_tb.Text), int.Parse(flightId_tb.Text));
                a[lpassenger.SelectedIndex] = pas;

                var pass = from upd in a
                         select upd.CustomerId;


                lpassenger.DataContext = pass;

                custId_tb.Clear();
                flightId_tb.Clear();

                MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Would you like to update the data??", "Data Update", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
               
                a.RemoveAt(lpassenger.SelectedIndex);
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Id = i;
                }

                var pass = from del in a
                            select del.CustomerId;
                lpassenger.DataContext = pass;
                custId_tb.Clear();
                flightId_tb.Clear();

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
