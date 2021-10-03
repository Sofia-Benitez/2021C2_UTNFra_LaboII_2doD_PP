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
        public Computadora computadora;
        public Ciber miCiber;
        public Cliente cliente;


        public FrmComputadora(Ciber ciber, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            miCiber = ciber;
            cliente = clienteSeleccionado;
            lblCliente.Text = clienteSeleccionado.Mostrar();

            rbtnC1.Text = ciber["C01"].ToString();
            rbtnC2.Text = ciber["C02"].ToString();
            rbtnC3.Text = ciber["C03"].ToString();
            rbtnC4.Text = ciber["C04"].ToString();
            rbtnC5.Text = ciber["C05"].ToString();
            rbtnC6.Text = ciber["C06"].ToString();


        }
        private void FrmComputadora_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string computadoraSeleccionada = "";
            
           
            foreach (Control item in gbxCompus.Controls)
            {

                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    computadoraSeleccionada = item.Text;
                }
            }

            computadora = Computadora.ComputadoraSeleccionada(computadoraSeleccionada, miCiber);
            if(computadora.Estado==true && (cliente == computadora))
            {
                string mensaje = $"Desea asignarle la computadora {computadora.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(computadora.ToString() + "\n Asignada");
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("La computadora esta ocupada o no cumple con los requisitos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
    }
}
