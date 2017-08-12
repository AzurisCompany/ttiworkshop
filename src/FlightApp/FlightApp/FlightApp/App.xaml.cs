using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FlightApp
{
    public partial class App : Application
    {
        public static IList<Models.FlightsModel> FlightsResults { get; set; }

        public App()
        {
            InitializeComponent();

            FlightsResults = new List<Models.FlightsModel>
            {
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                },
                new Models.FlightsModel(){
                    OrigemDestino = "Riberirao preto (RAO) - Guarulhos (GRU)",
                    PartidaChegada = "09:21 - 10:25 (01:04)",
                    TipoVoo = "Voo Direto",
                    Observacao = "Nao existem conexoes neste voo....",
                    Valor = "BRL 112.49"
                }
            };

            MainPage = new FlightApp.FlightChoose();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
