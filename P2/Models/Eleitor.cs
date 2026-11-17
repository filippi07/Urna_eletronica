using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Models
{
    public class Eleitor
    {
        public string Nome { get; set; }
        public string NomeDaMae { get; set; }
        public string NumeroDoTitulo { get; set; }
        public string FotoBase64 { get; set; }
        public string Biometria { get; set; }
    }
}
