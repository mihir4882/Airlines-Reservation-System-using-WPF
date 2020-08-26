using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public LoginWindow()
        {
            InitializeComponent();
            dictionary.Add("mihir", "12345");
            dictionary.Add("jay", "12345");
            dictionary.Add("parth", "12345");
            dictionary.Add("andy", "12345");
            dictionary.Add("john", "12345");

        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {

            bool Userkey = dictionary.ContainsKey(Username_Textbox.Text);
            bool Passkey = dictionary.ContainsValue(Password_Tb.Password);
                if(Userkey && Passkey )
                    {
                        MainWindow mw = new MainWindow();
                        mw.Background = Brushes.LightBlue;
                        mw.Title = "Welcome";
                        mw.ShowDialog(); 
                    }
                else
                {
                    MessageBox.Show("Your Username or Password is Incoreect", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                   
                }
            Username_Textbox.Clear();
            Password_Tb.Clear();
        }
        
        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
