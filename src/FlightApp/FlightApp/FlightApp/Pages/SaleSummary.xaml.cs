using FlightApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SaleSummary : ContentPage
	{
		public SaleSummary ()
		{
			InitializeComponent ();

            BindingContext = new SaleSummaryModel
            {
                BookingReference = "0ESYD7",
                DepartureDate = "28 julSexta-Feira",
                DepartureTime = "11:00",
                ArrivalTime = "12:00",
                Departure = "Ribeirão Preto (RAO)",
                Arrival = "SP - Guarulhos(GRU)",
                FlightNumber = "2267",
                Ticket = "6781008420659",
                Passenger = new PassengerDataModel
                {
                    Name = "Will",
                    Surname="Test Longo"
                },
                PaymentForm = "Cartão crédito Visa Tef",
                NumberOfInstallment = "1 parcela(s)",
                InstallmentAmount = "112,49 BRL",
                SalesAmount = "112,49 BRL"
            };
        }
	}
}