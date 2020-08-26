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
    /// Interaction logic for AirlineWindow.xaml
    /// </summary>
    public partial class AirlineWindow : Window
    {
        private List<airline> a = new List<airline>();
        string rb_Meal;
        string rb_Airline;
        public AirlineWindow()
        {
            InitializeComponent();
            a.Add(new airline(0, "Emirates", "Flight 777", 8, "Veg"));
            a.Add(new airline(1, "Air Canada", "Flight 747", 12, "Non-Veg"));
            a.Add(new airline(2, "Lufthansa", "Flight A380", 25, "Non-Veg"));
            a.Add(new airline(3, "Etihad", "Flight 777", 13, "Mexican"));
            a.Add(new airline(4, "Air India", "Flight 747", 7, "Veg"));

            var air = from ar in a
                      select ar.Name;
            airline_list.DataContext = air;
        }

        private void airline_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = airline_list.SelectedIndex;
            var air = from ar in a
                      where ar.Id == i
                      select ar;
            foreach (var a in air)
            {
                tb_name.Text = a.Name;

                if (a.Airline == "Airbus A380")
                {
                    Airline1.IsChecked = true;
                }
                else if (a.Airline == "Boeing 777")
                {
                    Airline2.IsChecked = true;
                }
                else
                {
                    Airline3.IsChecked = true;
                }

                tb_seat.Text = a.Seat.ToString();
                tb_name.Text = a.Name;
                if (a.Meal == "Veg")
                {
                    Meal1.IsChecked = true;
                }
                else if (a.Meal == "Non-Veg")
                {
                    Meal2.IsChecked = true;
                }
                else
                {
                    Meal3.IsChecked = true;
                }
            }
        }
                public void Addbtn_Click(object sender, RoutedEventArgs e)
                {


                    if (Airline1.IsChecked == true)
                        {
                            rb_Airline = Airline1.IsChecked.ToString();
                        }
                    else if (Airline2.IsChecked == true)
                        {
                            rb_Airline = Airline2.IsChecked.ToString();
                        }
                    else
                        {
                            rb_Airline = Airline3.IsChecked.ToString();
                        }

                    if (Meal1.IsChecked == true)
                        {
                            rb_Meal = Meal1.IsChecked.ToString();
                        }
                    else if (Meal2.IsChecked == true)
                        {
                            rb_Meal = Meal2.IsChecked.ToString();
                        }
                    else
                    {
                            rb_Meal = Meal3.IsChecked.ToString();
                    }


                    if (tb_name.Text == "" || tb_seat.Text == "")
                    {
                        MessageBox.Show("All fields are required to be added", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        a.Add(new airline(a.Count, tb_name.Text, rb_Airline, int.Parse(tb_seat.Text), rb_Meal));
                        var airnames = from air in a
                                       select air.Name;
                        airline_list.DataContext = airnames;
                        tb_name.Clear();
                        tb_seat.Clear();
                        MessageBox.Show("Airlines details have been successfully added!!!", "New Airline Added", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }

        public void Updatebtn_Click(object sender, RoutedEventArgs e)
        {

            if (tb_name.Text == "" || tb_seat.Text == "")
            {
                MessageBox.Show("All fields are required to update details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (update == MessageBoxResult.Yes)
                {
                    if (Airline1.IsChecked == true)
                        {
                            rb_Airline = "Airbus A380";
                        }
                    else if (Airline2.IsChecked == true)
                        {
                            rb_Airline = "Boeing 777";
                        }
                    else
                        {
                            rb_Airline = "Boeing 747-8";
                        }

                    if (Meal1.IsChecked == true)
                    {
                        rb_Meal = "Veg";
                    }
                    else if (Meal2.IsChecked == true)
                    {
                        rb_Meal = "Non-Veg";
                    }
                    else
                    {
                        rb_Meal = "Mexican";
                    }

                    airline air = new airline(airline_list.SelectedIndex, tb_name.Text, rb_Airline, int.Parse(tb_seat.Text), rb_Meal);
                    a[airline_list.SelectedIndex] = air;

                    var upd = from up in a
                              select up.Name;
                    airline_list.DataContext = upd;

                    tb_name.Clear();
                    tb_seat.Clear();
                    MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
                var delete = MessageBox.Show("Are you sure you want to delete this data?", "Delete Information", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (delete == MessageBoxResult.Yes)
                {
                    a.RemoveAt(airline_list.SelectedIndex);
                    for (int i = 0; i < a.Count; i++)
                    {
                        a[i].Id = i;
                    }

                    var names = from del in a
                                select del.Name;
                    airline_list.DataContext = names;
                    tb_name.Clear();
                    tb_seat.Clear();
                 
                    MessageBox.Show("Information is successfully deleted!!!", "Information Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
                }
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text == "" || tb_seat.Text == "")
            {
                MessageBox.Show("All fields are required to add new customer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                a.Add(new airline(a.Count, tb_name.Text, rb_Airline, int.Parse(tb_seat.Text), rb_Meal));
                var air = from ins in a
                             select ins.Name;
                airline_list.DataContext = air;
                tb_name.Clear();
                tb_seat.Clear();
                MessageBox.Show("New infromation is successfully added!!!", "New Information Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (update == MessageBoxResult.Yes)
            {
                airline air = new airline(airline_list.SelectedIndex, tb_name.Text, rb_Airline, int.Parse(tb_seat.Text), rb_Meal);
                a[airline_list.SelectedIndex] = air;

                var up = from upd in a
                             select upd.Name;
                airline_list.DataContext = up;
                tb_name.Clear();
                tb_seat.Clear();
                MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Would you like to update the data??", "Data Update", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                a.RemoveAt(airline_list.SelectedIndex);
                for (int i = 0; i < a.Count; i++)
                {
                    a[i].Id = i;
                }

                var names = from del in a
                            select del.Name;
                airline_list.DataContext = names;
                tb_name.Clear();
                tb_seat.Clear();

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
