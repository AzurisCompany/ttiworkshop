using System.Collections.Generic;

using Xamarin.Forms;

namespace FlightApp
{
    public partial class App : Application
    {
        public static IList<Models.Menu> Menu { get; set; }
        public static IList<Models.FlightDayFare> FlightsDayFare { get; set; }

        public App()
        {
            InitializeComponent();
           
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
                      

         
            Menu = new List<Models.Menu>
            {
                new Models.Menu(){Description = "Reservar voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem1.png") },
                new Models.Menu(){Description = "Meus voos", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem2.png")},
                new Models.Menu(){Description = "Checkin", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem3.png")},
                new Models.Menu(){Description = "Contato", ImageName = ImageSource.FromResource("FlightApp.Resources.menuItem6.png")}
            };

            MainPage = new NavigationPage(new FlightApp.Menu()) { BarBackgroundColor = Color.FromHex("#e9c813") };
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
