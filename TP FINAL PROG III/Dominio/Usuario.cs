using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string CodUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaReg { get; set; }
        public DateTime FechaNac { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }

    }
}
