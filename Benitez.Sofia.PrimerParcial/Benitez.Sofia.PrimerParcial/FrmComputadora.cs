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
    public partial class FrmComputadora : Form
    {
        public Computadora computadora = null;
        public Ciber miCiber;
        public Cliente cliente;
        public double tiempoSeleccionado=double.MinValue;
        public string tiempo = "";


        public FrmComputadora(Ciber ciber, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            miCiber = ciber;
            cliente = clienteSeleccionado;
            lblCliente.Text = clienteSeleccionado.ToString();

            rbtnC1.Text = ciber["C01"].ToString();
            rbtnC1.Tag = ciber["C01"];

            rbtnC2.Text = ciber["C02"].ToString();
            rbtnC2.Tag= ciber["C02"];

            rbtnC3.Text = ciber["C03"].ToString();
            rbtnC3.Tag = ciber["C03"];

            rbtnC4.Text = ciber["C04"].ToString();
            rbtnC4.Tag = ciber["C04"];

            rbtnC5.Text = ciber["C05"].ToString();
            rbtnC5.Tag = ciber["C05"];

            rbtnC6.Text = ciber["C06"].ToString();
            rbtnC6.Tag = ciber["C06"];

            rbtnC7.Text = ciber["C07"].ToString();
            rbtnC7.Tag = ciber["C07"];

            rbtnC8.Text = ciber["C08"].ToString();
            rbtnC8.Tag = ciber["C08"];

            rbtnC9.Text = ciber["C09"].ToString();
            rbtnC9.Tag = ciber["C09"];

            rbtnC10.Text = ciber["C10"].ToString();
            rbtnC10.Tag = ciber["C10"];

        }


        /// <summary>
        /// al presional el boton de asignar controla que la computadora seleccionada tenga los elementos que el cliente necesita, sino no permite la asignacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarComputadora_Click(object sender, EventArgs e)
        {
           
            
           
            foreach (Control item in gbxCompus.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    computadora = (Computadora)item.Tag;
                }
            }

            if (chbTiempoLibre.Checked)
            {
                tiempo= "tiempo libre";
            }
            else
            {
                tiempo = " por " + numMinutos.Value.ToString() + " minutos";
                tiempoSeleccionado= (double)numMinutos.Value;
            }

            
            if(computadora is not null && computadora.Estado==true && (cliente == computadora))
            {
                string mensaje = $"Desea asignarle la computadora {computadora.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(computadora.Id.ToString() + "\n Asignada " + tiempo);
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("La computadora esta ocupada o no cumple con los requisitos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// maneja el bloqueo de la asignacion de minutos. Solo se puede elegir tiempo libre o la cantidad de minutos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbTiempoLibre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTiempoLibre.Checked)
            {
                numMinutos.Enabled = false;
            }
            else
            {
                numMinutos.Enabled = true;
            }
        }

        private void FrmComputadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(computadora is null)
            {
                if (MessageBox.Show("¿Desea salir sin asignar una computadora?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
