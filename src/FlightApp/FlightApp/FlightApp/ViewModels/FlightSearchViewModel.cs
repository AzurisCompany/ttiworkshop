using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class FlightSearchViewModel
    {
        public Command FlightSearchButtonCommand { get; set; }

        public Command MenuButtonCommand { get; set; }

        public FlightSearchViewModel()
        {
            FlightSearchButtonCommand = new Command(FlightSearchButtonCommandExecute);
            MenuButtonCommand = new Command(MenuButtonCommandExecute);
        }

        private async void MenuButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.Menu());
        }

        private async void FlightSearchButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.DayFare());
        }
    }
}