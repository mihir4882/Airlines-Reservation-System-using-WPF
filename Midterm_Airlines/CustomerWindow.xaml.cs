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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private Queue<customer> cq = new Queue<customer>();
        public CustomerWindow()
        {
            InitializeComponent();
            cq.Enqueue(new customer(0, "Mihir", "Brampton", "mihir@gmail.com", "6478091234"));
            cq.Enqueue(new customer(1, "Jay", "Ajax", "jay@gmail.com", "6478094321"));
            cq.Enqueue(new customer(2, "Parth", "Toronto", "parth@gmail.com", "6478095454"));
            cq.Enqueue(new customer(3, "John", "Mississauga", "john123@gmail.com", "6478096789"));
            cq.Enqueue(new customer(4, "Andy", "London", "andy456@gmail.com", "6478094567"));

            var na = from cus in cq
                     select cus.Name;
            CustList.DataContext = na;
        }

        private void CustList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = CustList.SelectedIndex;
            var SelectIndex = from cust in cq
                              where cust.Id == i
                              select cust;
            foreach (var k in SelectIndex)
            {
                Name_tb.Text = k.Name;
                Address_tb.Text = k.Address;
                Email_tb.Text = k.Email;
                Phone_tb.Text = k.Phone;
            }
        }
            private void Addbtn_Click(object sender, RoutedEventArgs e)
            {
                if(Name_tb.Text == "" || Address_tb.Text == "" || Email_tb.Text == "" || Phone_tb.Text == "")
                {
                    MessageBox.Show("All fields are required to add new customer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    cq.Enqueue(new customer(cq.Count, Name_tb.Text, Address_tb.Text, Email_tb.Text, Phone_tb.Text));
                    var ins = from cu in cq
                              select cu.Name;
                    CustList.DataContext = ins;
                    Name_tb.Clear();
                    Address_tb.Clear();
                    Email_tb.Clear();
                    Phone_tb.Clear();
                    MessageBox.Show("New infromation is successfully added!!!", "New Information Added", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        private void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            var update = MessageBox.Show("Would you like to update the data??", "Data Update", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(update == MessageBoxResult.Yes)
            {
                customer cus = new customer(CustList.SelectedIndex, Name_tb.Text, Address_tb.Text, Email_tb.Text, Phone_tb.Text);
                foreach (customer csitem in cq)
                {
                    if (cus.Id == csitem.Id)
                    {
                        csitem.Name = Name_tb.Text;
                        csitem.Address = Address_tb.Text;
                        csitem.Email = Email_tb.Text;
                        csitem.Phone = Phone_tb.Text;
                    }
                }

                var upd = from up in cq
                          select up.Name;
                CustList.DataContext = upd;
                Name_tb.Clear();
                Address_tb.Clear();
                Email_tb.Clear();
                Phone_tb.Clear();
                MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Are you sure you want to delete this data?", "Information Delete", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                
                while (true)
                {
                    customer delc = cq.Dequeue();
                    if (delc.Id == CustList.SelectedIndex)
                    {
                        break;
                    }
                    cq.Enqueue(delc);
                }
                int i = 0;
                foreach(customer item in cq)
                {
                    item.Id = i;
                    i++;
                }

                var del = from cust in cq
                            select cust.Name;
                CustList.DataContext = del;
                Name_tb.Clear();
                Address_tb.Clear();
                Email_tb.Clear();
                Phone_tb.Clear();
                MessageBox.Show("Information is successfully deleted!!!", "Information Deleted", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (Name_tb.Text == "" || Address_tb.Text == "" || Email_tb.Text == "" || Phone_tb.Text == "")
            {
                MessageBox.Show("All fields are required to add new customer", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                cq.Enqueue(new customer(cq.Count, Name_tb.Text, Address_tb.Text, Email_tb.Text, Phone_tb.Text));
                var insert = from cust in cq
                            select cust.Name;
                CustList.DataContext = insert;
                Name_tb.Clear();
                Address_tb.Clear();
                Email_tb.Clear();
                Phone_tb.Clear();
                MessageBox.Show("New infromation is successfully added!!!", "New Information Added", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            var update = MessageBox.Show("Would you like to update the data??", "Update Data", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (update == MessageBoxResult.Yes)
            {
                customer cus = new customer(CustList.SelectedIndex, Name_tb.Text, Address_tb.Text, Email_tb.Text, Phone_tb.Text);
                foreach (customer csitem in cq)
                {
                    if (cus.Id == csitem.Id)
                    {
                        csitem.Name = Name_tb.Text;
                        csitem.Address = Address_tb.Text;
                        csitem.Email = Email_tb.Text;
                        csitem.Phone = Phone_tb.Text;
                    }
                }

                var upd = from cust in cq
                             select cust.Name;
                CustList.DataContext = upd;
                Name_tb.Clear();
                Address_tb.Clear();
                Email_tb.Clear();
                Phone_tb.Clear();
                MessageBox.Show("Details have been successfully Updated!!!", "Data Updated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var delete = MessageBox.Show("Would you like to update the data??", "Data Update", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (delete == MessageBoxResult.Yes)
            {
                while (true)
                {
                    customer tempc = cq.Dequeue();
                    if (tempc.Id == CustList.SelectedIndex)
                    {
                        break;
                    }
                    cq.Enqueue(tempc);
                }
                int i = 0;
                foreach (customer item in cq)
                {
                    item.Id = i;
                    i++;
                }

                var del = from cust in cq
                          select cust.Name;
                CustList.DataContext = del;
                Name_tb.Clear();
                Address_tb.Clear();
                Email_tb.Clear();
                Phone_tb.Clear();
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
