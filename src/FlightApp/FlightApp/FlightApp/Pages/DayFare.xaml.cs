using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayFare : ContentPage
    {
        public DayFare()
        {
            InitializeComponent();
            BindingContext = new DayFareViewModel();
        }
    }
}