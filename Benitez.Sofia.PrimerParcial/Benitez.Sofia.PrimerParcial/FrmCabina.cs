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
        #region botonera telefono

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn1_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn1.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn2_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn2.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn3_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn3.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn4_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn4.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn5_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn5.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn6_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn6.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn7_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn7.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn8_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn8.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn9_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn9.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnAsterisco.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn0_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btn0.Text);
        }

        /// <summary>
        /// al presionar el boton cara el numero correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumeral.Text);
        }
#endregion

        /// <summary>
        /// carga un numero de destino en el textbox
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


        /// <summary>
        /// Al cliquear el boton se asignara la cabina y saldra del formulario. 
        /// Si no se selecciona una cabina o no se ingresa un numero correcto no es posible asignarle una cabina al cliente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if(int.TryParse(numero, out int n)==false)
            {
                MessageBox.Show("Falta ingresar el numero o el número es incorrecto");
            }
            else if (cabina is not null && cabina.Estado == true)
            {
                string mensaje = $"Desea asignarle la cabina {cabina.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show($"{cabina.Id.ToString()}  \n Asignada.  \n Numero de destino: {numero}");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("La cabina esta ocupada o algún campo esta incompleto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// muestra un mensaje si se quiere cerrar el formulario sin asignar una cabina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Muestra un mensaje que explica como se utiliza el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Seleccione la cabina que quiere asignarle al cliente. Solo se puede seleccionar una cabina desocupada. \n");
            sb.AppendLine("Ingrese el número al que el cliente quiere llamar \n");
            sb.AppendLine("Presione el botón Asignar para asignarle la cabina al cliente. \n");
            
            MessageBox.Show(sb.ToString());
        }
    }
}
