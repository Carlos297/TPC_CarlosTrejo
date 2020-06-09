using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pasaje
    {
        public string CodBoleto { get; set; }
        public Viaje Viaje { get; set; }
        public int CantBoletos { get; set; }
        public decimal PrecioTotal { get; set; }

    }
}
