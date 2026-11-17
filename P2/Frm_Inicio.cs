using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2.Models;
using System.IO;
using Newtonsoft.Json;

namespace P2
{
    public partial class Frm_Carregamento : Form
    {
        public Frm_Carregamento()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e) // esse async permite usar "await" dentro do método
        {
            btn_iniciar.Enabled = false;
            string pasta = Application.StartupPath;

            try
            {
                //candidatos
                lbl_etapa.Text = "Carregando Candidatos...";
                AtualizarProgresso(10);
                string caminhoCandidatos = Path.Combine(pasta, "CANDIDATOS.JSON");
                Urna.Candidatos = await Task.Run(() =>
                    JsonConvert.DeserializeObject<List<Candidato>>(File.ReadAllText(caminhoCandidatos)));
                AtualizarProgresso(40);

                //eleitores
                lbl_etapa.Text = "Carregando Eleitores...";
                string caminhoEleitores = Path.Combine(pasta, "ELEITORES.JSON");
                Urna.Eleitores = await Task.Run(() =>
                    JsonConvert.DeserializeObject<List<Eleitor>>(File.ReadAllText(caminhoEleitores)));
                AtualizarProgresso(70);

                //zerésima
                lbl_etapa.Text = "Emitindo Zerésima...";
                string caminhoZeresima = Path.Combine(pasta, "ZEREZIMA.TXT");
                string textoZeresima = MontarZeresima();
                await Task.Run(() => File.WriteAllText(caminhoZeresima, textoZeresima));
                AtualizarProgresso(100);

                lbl_etapa.Text = "Carga concluída.";
                await Task.Delay(1000);
                Frm_Identificacao tela = new Frm_Identificacao();
                this.Hide();
                tela.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na carga: " + ex.Message);
                btn_iniciar.Enabled = true;
            }
        }

        private void AtualizarProgresso(int valor)
        {
            PB_carga.Value = valor;
            lbl_percentual.Text = valor + "%";
        }

        private string MontarZeresima()
        {
            string[] cargos =
            {
        "Deputado Estadual", "Deputado Federal", "Senador (1º voto)",
        "Senador (2º voto)", "Governador", "Presidente"
    };

            string texto = "ZERÉSIMA - SIMULAÇÃO DE URNA ELETRÔNICA" + Environment.NewLine;
            texto += "Emitida em: " + DateTime.Now + Environment.NewLine;
            texto += "Candidatos carregados: " + Urna.Candidatos.Count + Environment.NewLine;
            texto += "Eleitores carregados: " + Urna.Eleitores.Count + Environment.NewLine;
            texto += Environment.NewLine + "Votos registrados por cargo:" + Environment.NewLine;

            foreach (string cargo in cargos)
            {
                texto += cargo + ": 0" + Environment.NewLine;
            }

            texto += Environment.NewLine + "Não há votos registrados na urna.";
            return texto;
        }

        private void Form1_Load(object sender, EventArgs e) { }
    }
}