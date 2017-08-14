using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FlightApp.ViewModels
{
    public class FlightChooseViewModel
    {
        public ObservableCollection<Models.FlightsModel> Flights { get; set; }

        public FlightChooseViewModel()
        {
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
    }
}