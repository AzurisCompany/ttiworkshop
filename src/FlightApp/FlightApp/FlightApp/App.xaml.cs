using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FlightApp
{
    public partial class App : Application
    {
        public static IList<Models.FlightsModel> FlightsResults { get; set; }
        public static IList<Models.Menu> Menu { get; set; }
        public static IList<Models.FlightDayFare> FlightsDayFare { get; set; }

        public App()
        {
            InitializeComponent();

            FlightsResults = new List<Models.FlightsModel>
            {
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                }
            };

            FlightsDayFare = new List<Models.FlightDayFare>
            {
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "28 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "29 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                },
                new Models.FlightDayFare
                {
                    Date = "27 Jul quinta-Feira",
                    Price = "112,49 BRL"
                }
            };

            MainPage = new FlightApp.FareChoose();
            MainPage = new FlightApp.Pages.PassengerData();
            Menu = new List<Models.Menu>
            {
                new Models.Menu(){Description = "Reservar voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem1.png") },
                new Models.Menu(){Description = "Meus voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem2.png")},
                new Models.Menu(){Description = "Checkin", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem3.png")},
                new Models.Menu(){Description = "Contato", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem6.png")}
            };

            MainPage = new FlightApp.Menu();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
