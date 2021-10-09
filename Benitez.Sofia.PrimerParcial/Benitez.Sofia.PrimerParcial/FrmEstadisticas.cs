using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benitez.Sofia.PrimerParcial
{
    public partial class FrmEstadisticas : Form
    {
        string ordenUsosComputadoras;
        string ordenUsosCabinas;
        public FrmEstadisticas(string usosComputadoras, string usosCabinas)
        {
            InitializeComponent();
            ordenUsosComputadoras = usosComputadoras;
            ordenUsosCabinas = usosCabinas;
        }

        private void btnEstadistica1_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = ordenUsosComputadoras;
        }

        private void btnEstadistica2_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = ordenUsosCabinas;
        }
    }
}
