using FlightApp.Models;
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
    public partial class FareChoose : ContentPage
    {
        public static FareChooseModel FareChooseModel { get; set; }

        public FareChoose()
        {

            InitializeComponent();
            fillFare();
        }

        public void fillFare()
        {
            var FareList = new List<FareModel>();
            FareList.Add(new FareModel()
            {
                Name = "PROMO",
                Detail = "PROMO DETAILS",
                Price = "Indisponível"
            });
            FareList.Add(new FareModel()
            {
                Name = "LEVISSIMA",
                Detail = "LEVISSIMA DETAILS",
                Price = "112,49 BRL"
            });
            FareList.Add(new FareModel()
            {
                Name = "BASICA",
                Detail = "BASICA DETAILS",
                Price = "232,49 BRL"
            });
            FareList.Add(new FareModel()
            {
                Name = "CLASSICA",
                Detail = "CLASSICA DETAILS",
                Price = "312,39 BRL"
            });

            FareChooseModel = new FareChooseModel()
            {
                Arrival = "SP - GUARULHOS(GRU)",
                ArrivalTime = "12:00",
                Departure = "RIBEIRÃO PRETO(RAO)",
                DepartureDate = "28 JUL SEXTA-FEIRA",
                DepartureTime = "11:00",
                FlightNumber = "2267",
                Fares = FareList
            };

            BindingContext = FareChooseModel;
        }
    }
}