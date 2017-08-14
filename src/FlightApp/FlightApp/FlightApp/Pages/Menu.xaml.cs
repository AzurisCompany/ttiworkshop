using FlightApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var menu = (Models.Menu)e.Item;

            switch (menu.Description)
            {
                case "Reservar voos":
                    await Navigation.PushAsync(new Pages.FlightChoose());
                    break;
                case "Meus voos":
                    throw new NotImplementedException();
                    break;
                case "Checkin":
                    throw new NotImplementedException();
                    break;
                case "Contato":
                    throw new NotImplementedException();
                    break;

            }
        }
    }
}