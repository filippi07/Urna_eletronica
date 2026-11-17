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

namespace P2
{
    public partial class Frm_Identificacao : Form
    {
        private Eleitor eleitorAtual;
        private int tentativas = 0;

        public Frm_Identificacao()
        {
            InitializeComponent();
        }

        private void Frm_Identificacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_validar_titulo_Click(object sender, EventArgs e)
        {
            string titulo = txt_titulo.Text.Trim();
            eleitorAtual = Urna.Eleitores.FirstOrDefault(x => x.NumeroDoTitulo == titulo);

            if (eleitorAtual == null)
            {
                lbl_mensagem.Text = "Título inválido.";
                return;
            }

            lbl_mensagem.Text = "";
            lbl_biometria.Visible = true;
            txt_biometria.Visible = true;
            btn_validar_biometria.Visible = true;
            txt_titulo.Enabled = false;
            btn_validar_titulo.Enabled = false;
        }

        private void btn_validar_biometria_Click(object sender, EventArgs e)
        {
            string digitada = txt_biometria.Text.Trim();

            if (digitada == eleitorAtual.Biometria)
            {
                tentativas = 0;
                Frm_Urna urna = new Frm_Urna(eleitorAtual, this); urna.Show();
                this.Hide();
                return;
            }

            tentativas++;

            if (tentativas >= 5)
            {
                ReiniciarIdentificacao();
                lbl_mensagem.Text = "Limite de tentativas atingido. Digite o título novamente.";
            }
            else
            {
                lbl_mensagem.Text = "Biometria incorreta. Tentativa " + tentativas + " de 5.";
                txt_biometria.Clear();
            }
        }

        public void ReiniciarIdentificacao()
        {
            tentativas = 0;
            eleitorAtual = null;

            txt_titulo.Clear();
            txt_biometria.Clear();
            lbl_mensagem.Text = "";

            lbl_biometria.Visible = false;
            txt_biometria.Visible = false;
            btn_validar_biometria.Visible = false;

            txt_titulo.Enabled = true;
            btn_validar_titulo.Enabled = true;
            txt_titulo.Focus();
        }

        private void btn_encerrar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja encerrar a votação?", "Encerrar", MessageBoxButtons.YesNo);
            if (resp != DialogResult.Yes)
            {
                return;
            }
            Urna.ExportarJson();
            Urna.GerarBoletim();
            MessageBox.Show("Boletim de urna gerado. A aplicação será encerrada.");
            Urna.LimparMemoria();
            Application.Exit();
        }

        private void btn_verèleitores_Click(object sender, EventArgs e)
        {
            Frm_ListaEleitores lista = new Frm_ListaEleitores();
            lista.Show();
        }
    }
}
