using System.Collections.Generic;

namespace FlightApp.Models
{
    public class FareChooseModel
    {
        public string DepartureDate { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public string Departure { get; set; }

        public string Arrival { get; set; }

        public string FlightNumber { get; set; }

        public List<FareModel> Fares { get; set; }
    }
}