using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2.Models;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace P2
{
    public static class Urna
    {
        public static List<Candidato> Candidatos { get; set; } = new List<Candidato>();
        public static List<Eleitor> Eleitores { get; set; } = new List<Eleitor>();
        public static List<string>[] Votos = new List<string>[6];
        public static List<Eleitor> EleitoresQueVotaram = new List<Eleitor>();

        static Urna()
        {
            for (int i = 0; i < 6; i++)
            {
                Votos[i] = new List<string>();
            }
        }
        private static Random rnd = new Random();

        public static void Embaralhar<T>(List<T> lista)
        {
            for (int i = lista.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                T temp = lista[i];
                lista[i] = lista[j];
                lista[j] = temp;
            }
        }
        public static void ExportarJson()
        {
            string pasta = Application.StartupPath;

            string jsonVotos = JsonConvert.SerializeObject(Votos, Formatting.Indented);
            File.WriteAllText(Path.Combine(pasta, "VOTOS.JSON"), jsonVotos);

            string jsonEleitores = JsonConvert.SerializeObject(EleitoresQueVotaram, Formatting.Indented);
            File.WriteAllText(Path.Combine(pasta, "ELEITORES_QUE_VOTARAM.JSON"), jsonEleitores);
        }
        public static void GerarBoletim()
        {
            string[] nomesCargos = { "Deputado Estadual", "Deputado Federal", "Senador - 1º voto", "Senador - 2º voto", "Governador", "Presidente" };
            string[] cargosJson = { "Deputado Estadual", "Deputado Federal", "Senador", "Senador", "Governador", "Presidente" };

            string texto = "BOLETIM DE URNA" + Environment.NewLine;
            texto += "Emitido em: " + DateTime.Now + Environment.NewLine + Environment.NewLine;

            for (int i = 0; i < 6; i++)
            {
                int brancos = Votos[i].Count(v => v == "BRANCO");
                int nulos = Votos[i].Count(v => v == "NULO");

                texto += nomesCargos[i] + Environment.NewLine;
                var validos = Votos[i].Where(v => v != "BRANCO" && v != "NULO");
                var porNumero = validos.GroupBy(v => v).OrderByDescending(g => g.Count());

                texto += "  Votos por candidato:" + Environment.NewLine;
                foreach (var grupo in porNumero)
                {
                    string numero = grupo.Key;
                    if (i <= 1 && numero.Length == 2)
                    {
                        texto += "    Legenda " + numero + ": " + grupo.Count() + Environment.NewLine;
                    }
                    else
                    {
                        Candidato c = Candidatos.FirstOrDefault(x => x.Numero == numero && x.Cargo == cargosJson[i]);
                        string nome = c != null ? c.NomeCandidato : "?";
                        texto += "    " + numero + " - " + nome + ": " + grupo.Count() + Environment.NewLine;
                    }
                }
                texto += "  Votos brancos: " + brancos + Environment.NewLine;
                texto += "  Votos nulos: " + nulos + Environment.NewLine + Environment.NewLine;
            }

            texto += "BALANÇO" + Environment.NewLine;
            texto += "Eleitores que votaram: " + EleitoresQueVotaram.Count + Environment.NewLine;

            bool inconsistente = false;
            for (int i = 0; i < 6; i++)
            {
                texto += "  " + nomesCargos[i] + ": " + Votos[i].Count + " votos registrados" + Environment.NewLine;

                if (Votos[i].Count != EleitoresQueVotaram.Count)
                {
                    texto += "  ALERTA: inconsistência em " + nomesCargos[i] + " (" + EleitoresQueVotaram.Count + " eleitores x " + Votos[i].Count + " votos)" + Environment.NewLine;
                    inconsistente = true;
                }
            }

            if (!inconsistente)
            {
                texto += "Nenhuma inconsistência encontrada." + Environment.NewLine;
            }

            File.WriteAllText(Path.Combine(Application.StartupPath, "BOLETIM_DE_URNA.TXT"), texto);
        }

        public static void LimparMemoria()
        {
            Candidatos.Clear();
            Eleitores.Clear();
            EleitoresQueVotaram.Clear();

            for (int i = 0; i < Votos.Length; i++)
            {
                Votos[i].Clear();
            }
        }
    }  
}
