using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm_Airlines
{
    class passenger
    {
        private int _id;
        private int _customerId;
        private int _flightId;
        public passenger(int id, int customerId, int flightId)
        {
            Id = id;
            CustomerId = customerId;
            FlightId = flightId;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        public int FlightId
        {
            get { return _flightId; }
            set { _flightId = value; }
        }
    }
}
