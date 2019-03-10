using System;
using System.Collections.Generic;
using System.Text;

namespace App7.Model
{
    public class Flight
    {
        public int Term { get; set; }
        public string Gate { get; set; }
        public string Seat { get; set; }
        public DateTime Departure { get; set; }
        public string FlightNumber { get; set; }
        public string STA { get; set; }
        public string ETA { get; set; }
        public string Terminal { get; set; }
        public string Status { get; set; }
        public string DepartureAirport { get; set; }
    }
}
