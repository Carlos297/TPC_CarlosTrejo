using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TerminalDestino
    {
        public int IdTerminal { get; set; }
        public string CodTerminal { get; set; }
        public string NombreTerminal { get; set; }
        public string Estado { get; set; }  //si esta disponible como terminal o no
    }
}
