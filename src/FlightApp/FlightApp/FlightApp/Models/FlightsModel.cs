using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class FlightsModel
    {
        public string OrigemDestino { get; set; }

        public string PartidaChegada { get; set; }

        public string TipoVoo { get; set; }

        public string Observacao { get;  set; }

        public string Valor { get; set; }
    }
}