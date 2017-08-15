using FlightApp.Models;
using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class SaleSummaryViewModel
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

        public Command MenuButtonCommand { get; set; }

        public SaleSummaryViewModel()
        {
            MenuButtonCommand = new Command(MenuButtonCommandExecute);
            FillSaleSummury();
        }

        private void FillSaleSummury()
        {
            BookingReference = "0ESYD7";
            DepartureDate = "28 julSexta-Feira";
            DepartureTime = "11:00";
            ArrivalTime = "12:00";
            Departure = "Ribeirão Preto (RAO)";
            Arrival = "SP - Guarulhos(GRU)";
            FlightNumber = "2267";
            Ticket = "6781008420659";
            Passenger = new PassengerDataModel
            {
                Name = "Will",
                Surname = "Test Longo"
            };
            PaymentForm = "Cartão crédito Visa Tef";
            NumberOfInstallment = "1 parcela(s)";
            InstallmentAmount = "112,49 BRL";
            SalesAmount = "112,49 BRL";
        }

        private async void MenuButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.Menu());
        }
    }
}