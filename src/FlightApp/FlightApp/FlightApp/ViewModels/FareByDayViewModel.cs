using FlightApp.Pages;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class FareByDayViewModel
    {
        public ObservableCollection<Models.FlightsModel> Flights { get; set; }

        public Command NextButtonCommand { get; set; }

        public FareByDayViewModel()
        {
            NextButtonCommand = new Command(NextButtonCommandExecute);

            Flights = new ObservableCollection<Models.FlightsModel>
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
        }

        private async void NextButtonCommandExecute()
        {
            await App.Current.MainPage.Navigation.PushAsync(new FlightChoose());
        }
    }
}