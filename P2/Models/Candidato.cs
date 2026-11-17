using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Models
{
    public class Candidato
    {
        public string NomeCandidato { get; set; }
        public string NomePartido { get; set; }
        public string SiglaPartido { get; set; }
        public string Numero { get; set; }
        public string FotoBase64 { get; set; }
        public string Cargo { get; set; }
        public Pessoa Vice { get; set; }
        public List<Pessoa> Suplentes { get; set; }
    }
}
