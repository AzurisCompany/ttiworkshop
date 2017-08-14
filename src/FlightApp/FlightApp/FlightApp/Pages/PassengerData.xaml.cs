using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassengerData : ContentPage
    {
        public PassengerData()
        {
            InitializeComponent();

            BindingContext = new PassengerDataViewModel();
        }
    }
}