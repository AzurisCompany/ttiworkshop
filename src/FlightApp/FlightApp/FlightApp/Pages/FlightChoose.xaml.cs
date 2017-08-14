using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightChoose : ContentPage
    {
        public FlightChoose()
        {
            InitializeComponent();
            BindingContext = new FlightChooseViewModel();
        }
    }
}