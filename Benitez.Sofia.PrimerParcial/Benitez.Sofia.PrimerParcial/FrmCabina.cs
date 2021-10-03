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
        public Cabina cabina;
        public string codigoPais;
        public string prefijo;
        public string numero;

        public FrmCabina(Ciber ciber, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            miCiber = ciber;
            cliente = clienteSeleccionado;
            lblCliente.Text = clienteSeleccionado.Mostrar();

            rbtnCabina1.Text = ciber["T01"].ToString();
            rbtnCabina2.Text = ciber["T02"].ToString();
            rbtnCabina3.Text = ciber["T03"].ToString();
            rbtnCabina4.Text = ciber["T04"].ToString();
            rbtnCabina5.Text = ciber["T05"].ToString();
        }

        

        private void btnAsignarCabina_Click(object sender, EventArgs e)
        {
            string cabinaSeleccionada = "";


            foreach (Control item in gbxCabinas.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    cabinaSeleccionada = item.Text;
                }
            }

            codigoPais = txtCodigo.Text;
            prefijo = txtPrefijo.Text;
            numero = txtNumero.Text;

            cabina = Cabina.BuscarCabinaSeleccionada(cabinaSeleccionada, miCiber);
            if (cabina.Estado == true)
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
