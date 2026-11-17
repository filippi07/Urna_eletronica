using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Frm_ListaCandidatos : Form
    {
        public Frm_ListaCandidatos()
        {
            InitializeComponent();
            dgv_candidatos.DataSource = Urna.Candidatos
    .Select(x => new { x.NomeCandidato, x.NomePartido, x.SiglaPartido, x.Numero, x.Cargo, x.Vice, x.Suplentes })
    .ToList();
        }
    }
}
