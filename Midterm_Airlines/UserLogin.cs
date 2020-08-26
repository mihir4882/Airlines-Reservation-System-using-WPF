using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Midterm_Airlines
{
    class UserLogin
    {
        private int _id;
        private string _user;
        private string _password;

        public UserLogin(int id, string user, string password)
        {
            Id = id;
            User = user;
            Password = password;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
       
    }
}
