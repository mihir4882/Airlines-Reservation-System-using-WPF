using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Text;

namespace Midterm_Airlines
{
    class Flight
    {
        private int _id;
        private int _airId;
        private string _departCity;
        private string _destCity;
        private string _departDate;
        private double _flTime;

        public Flight(int id, int airId, string departCity, string destCity, string departDate, double flTime)
        {
            Id = id;
            AirlineId = airId;
            DepartureCity = departCity;
            DestinationCity = destCity;
            DepartureDate = departDate;
            FlightTime = flTime;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int AirlineId
        {
            get { return _airId; }
            set { _airId = value; }
        }
        public string DepartureCity
        {
            get { return _departCity; }
            set { _departCity = value; }
        }
        public string DestinationCity
        {
            get { return _destCity; }
            set { _destCity = value; }
        }
        public string DepartureDate
        {
            get { return _departDate; }
            set { _departDate = value; }
        }
        public double FlightTime
        {
            get { return _flTime; }
            set { _flTime = value; }
        }

    }
}
