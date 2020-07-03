using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Viaje
    {
        public int CodVIajes { get; set; }
        public Terminal Destino { get; set; }
        public Micro Micro { get; set; }
        public Chofer Chofer { get; set; }
        public DateTime FechaViaje { get; set; }
        public decimal Costo { get; set; }

    }
}
