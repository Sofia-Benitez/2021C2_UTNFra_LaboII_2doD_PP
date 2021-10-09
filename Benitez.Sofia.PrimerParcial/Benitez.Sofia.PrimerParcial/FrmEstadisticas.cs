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
        string ganancias;
        string tiempoLlamadasYRecaudacion;
        string software;
        string juego;
        string periferico;

        public FrmEstadisticas(string usosComputadoras, string usosCabinas, string gananciasTotales, string tiempoLlamadas, string softwareMasPedido, string juegoMasPedido, string perifericoMasPedido )
        {
            InitializeComponent();
            ordenUsosComputadoras = usosComputadoras;
            ordenUsosCabinas = usosCabinas;
            ganancias = gananciasTotales;
            tiempoLlamadasYRecaudacion = tiempoLlamadas;
            software = softwareMasPedido;
            juego = juegoMasPedido;
            periferico = perifericoMasPedido;
        }

        private void btnEstadistica1_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = ordenUsosComputadoras;
        }

        private void btnEstadistica2_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = ordenUsosCabinas;
        }

        private void btnEstadistica3_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = ganancias;
        }

        private void btnEstadistica4_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = tiempoLlamadasYRecaudacion;
        }

        private void btnEstadistica5_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = software;
        }

        private void btnEstadistica6_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = juego;
        }

        private void btnEstadistica7_Click(object sender, EventArgs e)
        {
            rtbxEstadisticas.Text = periferico;
        }
    }
}
