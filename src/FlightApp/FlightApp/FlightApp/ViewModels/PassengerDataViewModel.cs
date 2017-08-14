using System;

namespace FlightApp.ViewModels
{
    public class PassengerDataViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string AreaCode { get; set; }
        public string Phone { get; set; }

        public PassengerDataViewModel()
        {
        }
    }
}