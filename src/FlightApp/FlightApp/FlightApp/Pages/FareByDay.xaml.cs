using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FareByDay : ContentPage
    {
        public FareByDay()
        {
            InitializeComponent();
            BindingContext = new FareByDayViewModel();
        }
    }
}