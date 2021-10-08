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
        public string numero = "";

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
        private void btn1_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn2.Text);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn3.Text);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn4.Text);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn5.Text);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn6.Text);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn7.Text);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn8.Text);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn9.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnAsterisco.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn0.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumeral.Text);
        }

        /// <summary>
        /// carfa un numero de destino
        /// </summary>
        /// <param name="digitoPresionado"></param>
        private void CargarNumero(string digitoPresionado)
        {
            if (txtNumeroDestino.Text == "Numero destino")
            {
                txtNumeroDestino.Text = string.Empty;
            }
            txtNumeroDestino.Text += digitoPresionado;
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

            numero = txtNumeroDestino.Text;

            if (cabina is not null && cabina.Estado == true && numero!="")
            {
                string mensaje = $"Desea asignarle la cabina {cabina.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"{cabina.ToString()}  \n Asignada.  \n Numero de destino: {numero}");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La cabina esta ocupada o algún campo esta incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCabina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cabina is null)
            {
                if (MessageBox.Show("¿Esta seguro de que desea salir sin asignar una cabina?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        
    }
}
