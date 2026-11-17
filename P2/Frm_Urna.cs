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

namespace P2
{
    public partial class Frm_Urna : Form
    {
        private Eleitor eleitor;
        private Frm_Identificacao identificacao;
        private string[] cargos = { "Deputado Estadual", "Deputado Federal", "Senador - 1º voto", "Senador - 2º voto", "Governador", "Presidente" };
        private int[] digitos = { 5, 4, 3, 3, 2, 2 };
        private int cargoAtual = 0;
        private string[] cargosJson = { "Deputado Estadual", "Deputado Federal", "Senador", "Senador", "Governador", "Presidente" };

        private bool votoBranco = false;
        public Frm_Urna()
        {
            InitializeComponent();
            MostrarCargo();
        }
        private void MostrarCargo()
        {
            lbl_cargo.Text = cargos[cargoAtual];
            lbl_numero.Text = "";

            pb_candidato.Visible = false;
            pb_vice.Visible = false;
            pb_suplente2.Visible = false;
            lbl_nome.Visible = false;
            lbl_partido.Visible = false;
            lbl_vice.Visible = false;
            lbl_aviso_2.Visible = false;

            votoBranco = false;
        }
        private void BtnDigito_Click(object sender, EventArgs e)
        {
            if (votoBranco) {
                return;
            }

            //ainda bem que existe iss, se nao eu ia fazer varis funçoes uma pra cada botao
            Button btn = (Button)sender;
            string digito = btn.Text;

            if (lbl_numero.Text.Length < digitos[cargoAtual]) //agora que percebi, deixei cargo com letra minuscula
            {
                lbl_numero.Text += digito;
                AtualizarTela();
                if (lbl_numero.Text.Length == digitos[cargoAtual])
                {
                    MostrarCandidato();
                }
            }
        }
        private void btn_corrige_Click(object sender, EventArgs e)
        {
            MostrarCargo();
        }
        private void AtualizarTela()
        {
            if (cargoAtual > 1)
            {
                return;
            }
            if (lbl_numero.Text.Length < 2)
            {
                lbl_partido.Visible = false;
                return;
            }

            string prefixo = lbl_numero.Text.Substring(0, 2);
            Candidato achado = Urna.Candidatos.FirstOrDefault(x => x.Numero.StartsWith(prefixo));
            if (achado != null)
            {
                lbl_partido.Text = achado.SiglaPartido + " - " + achado.NomePartido;
                lbl_partido.Visible = true;
            }
            else
            {
                lbl_partido.Visible = false;
            }
        }
        private Image ConverterImagem(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            using (MemoryStream ms = new MemoryStream(bytes))
            using (Image img = Image.FromStream(ms))
            {
                return new Bitmap(img);
            }
        }
        private void MostrarCandidato()
        {
            Candidato c = Urna.Candidatos.FirstOrDefault(x => x.Numero == lbl_numero.Text && x.Cargo == cargosJson[cargoAtual]);

            if (c == null)
            {
                lbl_partido.Visible = false;
                lbl_aviso_2.Text = "VOTO NULO";
                lbl_aviso_2.Visible = true;
                return;
            }

            lbl_nome.Text = c.NomeCandidato;
            lbl_partido.Text = c.SiglaPartido + " - " + c.NomePartido;
            pb_candidato.Image = ConverterImagem(c.FotoBase64);
            lbl_nome.Visible = true;
            lbl_partido.Visible = true;
            pb_candidato.Visible = true;

            if (c.Vice != null)
            {
                lbl_vice.Text = "Vice: " + c.Vice.Nome;
                pb_vice.Image = ConverterImagem(c.Vice.FotoBase64);
                lbl_vice.Visible = true;
                pb_vice.Visible = true;
            }
            if (c.Suplentes != null && c.Suplentes.Count >= 2)
            {
                lbl_vice.Text = "Suplentes: " + c.Suplentes[0].Nome + " / " + c.Suplentes[1].Nome;
                pb_vice.Image = ConverterImagem(c.Suplentes[0].FotoBase64);
                pb_suplente2.Image = ConverterImagem(c.Suplentes[1].FotoBase64);
                lbl_vice.Visible = true;
                pb_vice.Visible = true;
                pb_suplente2.Visible = true;
            }
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {
            {
                if (lbl_numero.Text.Length == 0)
                {
                    votoBranco = true;
                    lbl_aviso_2.Text = "VOTO EM BRANCO";
                    lbl_aviso_2.Visible = true;
                }
            }
        }

        private void btn_confirma_Click(object sender, EventArgs e)
        {
            string voto;

            if (votoBranco)
            {
                voto = "BRANCO";
            }
            else if (lbl_numero.Text.Length == digitos[cargoAtual])
            {
                bool existe = Urna.Candidatos.Any(x => x.Numero == lbl_numero.Text && x.Cargo == cargosJson[cargoAtual]);

                if (existe)
                {
                    voto = lbl_numero.Text;
                }
                else
                {
                    voto = "NULO";
                }
            }
            else if (cargoAtual <= 1 && lbl_numero.Text.Length == 2 && Urna.Candidatos.Any(x => x.Numero.StartsWith(lbl_numero.Text)))
            {
                voto = lbl_numero.Text;
            }
            else
            {
                return;
            }

            Urna.Votos[cargoAtual].Add(voto);
            System.Media.SystemSounds.Asterisk.Play(); //a ideia era usar o som da urna, mas vamos deixar quieto essa ideia
            cargoAtual++;

            if (cargoAtual < cargos.Length)
            {
                MostrarCargo();
            }
            else
            {
                FinalizarVotacao();
            }
        }
        private async void FinalizarVotacao()
        {
            pb_candidato.Visible = false;
            pb_vice.Visible = false;
            pb_suplente2.Visible = false;
            lbl_nome.Visible = false;
            lbl_partido.Visible = false;
            lbl_vice.Visible = false;
            lbl_cargo.Text = "";
            lbl_numero.Text = "";

            lbl_aviso_2.Text = "FIM";
            lbl_aviso_2.Visible = true;

            await Task.Delay(3000);

            Urna.EleitoresQueVotaram.Add(eleitor);

            for (int i = 0; i < Urna.Votos.Length; i++)
            {
                Urna.Embaralhar(Urna.Votos[i]);
            }
            Urna.Embaralhar(Urna.EleitoresQueVotaram);

            identificacao.ReiniciarIdentificacao();
            identificacao.Show();
            this.Close();
        }

        public Frm_Urna(Eleitor eleitor, Frm_Identificacao identificacao) : this()
        {
            this.eleitor = eleitor;
            this.identificacao = identificacao;
        }

        private void btn_ver_candidatos_Click(object sender, EventArgs e)
        {
            Frm_ListaCandidatos lista = new Frm_ListaCandidatos();
            lista.Show();
        }
    } 
}