using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Viaje
    {
        public int IdVIajes { get; set; }
        public string CodViaje { get; set; }
        public Terminal TerminalOrigen { get; set; }
        public TerminalDestino TerminalDestino { get; set; }
        public Micro Micro { get; set; }
        public Chofer Chofer { get; set; }
        public DateTime FechaViaje { get; set; }
        public decimal Costo { get; set; }


    }
}
