using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class SaleSummaryModel
    {
        public string DepartureDate { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public string Departure { get; set; }

        public string Arrival { get; set; }

        public string FlightNumber { get; set; }

        public string BookingReference { get; set; }

        public string Ticket { get; set; }

        public PassengerDataModel Passenger { get; set; }

        public string PaymentForm { get; set; }

        public string NumberOfInstallment { get; set; }

        public string InstallmentAmount { get; set; }

        public string SalesAmount { get; set; }
    }
}