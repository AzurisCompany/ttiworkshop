using System;
using Xamarin.Forms;

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

        public Command MenuButtonCommand { get; set; }

        public PassengerDataViewModel()
        {
            MenuButtonCommand = new Command(MenuButtonCommandExecute);
        }

        private async void MenuButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Pages.Menu());
        }
    }
}