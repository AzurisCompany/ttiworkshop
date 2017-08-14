using FlightApp.Models;
using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FareChoose : ContentPage
    {
        public static FareChooseModel FareChooseModel { get; set; }

        public FareChoose()
        {
            InitializeComponent();
            BindingContext = new FareChooseViewModel();
        }        
    }
}