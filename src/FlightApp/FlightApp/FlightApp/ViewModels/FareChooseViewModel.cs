using FlightApp.Models;
using System.Collections.Generic;

namespace FlightApp.ViewModels
{
    public class FareChooseViewModel
    {
        public string DepartureDate { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public string Departure { get; set; }

        public string Arrival { get; set; }

        public string FlightNumber { get; set; }

        public List<FareModel> Fares { get; set; }

        public FareChooseViewModel()
        {           
            var fareList = new List<FareModel>();
            fareList.Add(new FareModel()
            {
                Name = "PROMO",
                Detail = "PROMO DETAILS",
                Price = "Indisponível"
            });
            fareList.Add(new FareModel()
            {
                Name = "LEVISSIMA",
                Detail = "LEVISSIMA DETAILS",
                Price = "112,49 BRL"
            });
            fareList.Add(new FareModel()
            {
                Name = "BASICA",
                Detail = "BASICA DETAILS",
                Price = "232,49 BRL"
            });
            fareList.Add(new FareModel()
            {
                Name = "CLASSICA",
                Detail = "CLASSICA DETAILS",
                Price = "312,39 BRL"
            });

            Arrival = "SP - GUARULHOS(GRU)";
            ArrivalTime = "12:00";
            Departure = "RIBEIRÃO PRETO(RAO)";
            DepartureDate = "28 JUL SEXTA-FEIRA";
            DepartureTime = "11:00";
            FlightNumber = "2267";
            Fares = fareList;
        }
    }
}