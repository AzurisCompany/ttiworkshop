using FlightApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SaleSummary : ContentPage
	{
		public SaleSummary ()
		{
			InitializeComponent ();
            BindingContext = new SaleSummaryViewModel();
        }
	}
}