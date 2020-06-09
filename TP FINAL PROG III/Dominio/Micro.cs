using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Micro
    {
        public string Patente { get; set; } //Ejemplo AAA99989
        public int Modelo { get; set; }  //Ejemplo 1990
        public DateTime FechaFabricacion { get; set; }
        public int CantAsientos { get; set; }
        public bool Estado { get; set; }  //si esta en reaparacion o no
    }
}
