using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public FareChooseModel()
        {
            Fares = new List<FareModel>();
        }
    }
}