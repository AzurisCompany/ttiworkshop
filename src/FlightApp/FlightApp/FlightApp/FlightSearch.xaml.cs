using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlightApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlightSearch : ContentPage
    {
        public FlightSearch()
        {
            InitializeComponent();
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