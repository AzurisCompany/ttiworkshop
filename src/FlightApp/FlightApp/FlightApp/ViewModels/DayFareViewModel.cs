using FlightApp.Models;
using FlightApp.Pages;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class DayFareViewModel
    {
        public ObservableCollection<FlightDayFare> FlightsDayFare { get; set; }

        public Command NextButtonCommand { get; set; }

        public Command MenuButtonCommand { get; set; }

        public DayFareViewModel()
        {
            NextButtonCommand = new Command(NextButtonCommandExecute);

            MenuButtonCommand = new Command(MenuButtonCommandExecute);

            FlightsDayFare = new ObservableCollection<FlightDayFare>
            {
                new FlightDayFare
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
        }

        private async void NextButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new FlightChoose());
        }

        private async void MenuButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.Menu());
        }
    }
}