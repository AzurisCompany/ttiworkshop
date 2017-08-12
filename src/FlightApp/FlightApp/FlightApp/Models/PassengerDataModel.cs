using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class PassengerDataModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string AreaCode { get; set; }
        public string Phone { get; set; }

        public PassengerDataModel()
        {
            Birthdate = DateTime.Now;
        }
    }
}