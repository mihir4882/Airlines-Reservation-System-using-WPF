using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Airlines
{
    class airline
    {
        private int _id;
        private string _name;
        private string _airline;
        private int _seat;
        private string _meal;

        public airline(int id, string name, string airline, int seat, string meal)
        {
            Id = id;
            Name = name;
            Airline = airline;
            Seat = seat;
            Meal = meal;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Airline
        {
            get { return _airline; }
            set { _airline = value; }
        }
        public int Seat
        {
            get { return _seat; }
            set { _seat = value; }
        }
        public string Meal
        {
            get { return _meal; }
            set { _meal = value; }
        }
    }
}
