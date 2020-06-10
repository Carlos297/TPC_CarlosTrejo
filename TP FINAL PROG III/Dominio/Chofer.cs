using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Chofer
    {
        public int IdChofer { get; set; }
        public int Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Estado { get; set; }  //si esta de licencia o no
    }
}
