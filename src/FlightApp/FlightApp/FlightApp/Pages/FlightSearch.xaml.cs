using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightSearch : ContentPage
    {
        public FlightSearch()
        {
            InitializeComponent();
            BindingContext = new FlightSearchViewModel();
            stpInfant.ValueChanged += StpInfant_ValueChanged;
            stpChild.ValueChanged += StpChild_ValueChanged;
            stpAdults.ValueChanged += StpAdults_ValueChanged;
        }

        private void StpAdults_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtNumberOfAdults.Text = e.NewValue.ToString();
        }

        private void StpChild_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtChild.Text = e.NewValue.ToString();
        }

        private void StpInfant_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            txtInfant.Text = e.NewValue.ToString();
        }
    }
}