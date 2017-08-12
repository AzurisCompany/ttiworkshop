﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            BindingContext = new Models.PassengerDataModel();
        }
    }
}