using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//essa parte eu fiz so paar nao tem o trabalho de abrir os arquivos so para ver os eleitores

namespace P2
{
    public partial class Frm_ListaEleitores : Form
    {
        public Frm_ListaEleitores()
        {
            InitializeComponent();
            dgv_eleitores.DataSource = Urna.Eleitores
    .Select(x => new { x.Nome, x.NomeDaMae, x.NumeroDoTitulo, x.Biometria })
    .ToList();
        }
    }
}
