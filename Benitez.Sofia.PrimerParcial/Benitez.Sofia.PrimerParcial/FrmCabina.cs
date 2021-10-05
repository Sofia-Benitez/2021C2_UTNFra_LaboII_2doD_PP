using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiberCafe;

namespace Benitez.Sofia.PrimerParcial
{
    public partial class FrmCabina : Form
    {
        public Ciber miCiber;
        public Cliente cliente;
        public Cabina cabina = null;
        public string codigoPais;
        public string prefijo;
        public string numero;

        public FrmCabina(Ciber ciber, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            miCiber = ciber;
            cliente = clienteSeleccionado;
            lblCliente.Text = clienteSeleccionado.ToString();

            rbtnCabina1.Text = ciber["T01"].ToString();
            rbtnCabina1.Tag = ciber["T01"];
            rbtnCabina2.Text = ciber["T02"].ToString();
            rbtnCabina2.Tag = ciber["T02"];
            rbtnCabina3.Text = ciber["T03"].ToString();
            rbtnCabina3.Tag = ciber["T03"];
            rbtnCabina4.Text = ciber["T04"].ToString();
            rbtnCabina4.Tag= ciber["T04"];
            rbtnCabina5.Text = ciber["T05"].ToString();
            rbtnCabina5.Tag = ciber["T05"];
        }

        

        private void btnAsignarCabina_Click(object sender, EventArgs e)
        {
            
            foreach (Control item in gbxCabinas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    cabina = (Cabina)item.Tag;
                }
            }

            codigoPais = txtCodigo.Text;
            prefijo = txtPrefijo.Text;
            numero = txtNumero.Text;

            if (cabina is not null && cabina.Estado == true)
            {
                string mensaje = $"Desea asignarle la cabina {cabina.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(cabina.ToString() + "\n Asignada ");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La cabina esta ocupada o algún campo esta incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
