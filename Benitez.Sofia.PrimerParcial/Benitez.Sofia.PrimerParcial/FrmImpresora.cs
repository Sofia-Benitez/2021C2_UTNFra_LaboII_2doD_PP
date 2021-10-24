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
    public partial class FrmImpresora : Form
    {
        public Impresora impresora;
        public Ciber miCiber;
        string color = "";
        int cantidad = 0;
        StringBuilder sb = new StringBuilder();
        string mensaje;
        List<Cliente> clientesParaImprimir = new List<Cliente>();


        public FrmImpresora(Ciber ciber, List<Cliente> clientes)
        {
            InitializeComponent();
            miCiber = ciber;
 
        }

        private void FrmImpresora_Load(object sender, EventArgs e)
        {
            lstbImpresoras.Items.Add(miCiber["I01"]);
            lstbImpresoras.Items.Add(miCiber["I02"]);
            lstbImpresoras.Items.Add(miCiber["I03"]);

            foreach (Cliente item in miCiber.ListaDeClientesAtendidos)
            {
                if(item is not null && item.NecesidadCliente == Cliente.Necesidad.Computadora && item.NecesitaImprimir)
                {
                    clientesParaImprimir.Add(item);
                }
                
            }

            RefrescarColaClientes();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbxPropiedades.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    color = item.Text;
                }
            }

            cantidad = (int)numCantCopias.Value;
            Cliente clienteAux = (Cliente)lstbColaImpresiones.SelectedItem;
            impresora=(Impresora)lstbImpresoras.SelectedItem;
            if(clienteAux is not null && impresora is not null && color!="" && clienteAux==impresora)
            {
                sb.AppendLine(clienteAux.ArchivoAImprimir);
                sb.AppendLine($"Cantidad de copias: {cantidad}");
                sb.AppendLine(color);
                sb.AppendLine($"\nImpresora: {impresora}");
                sb.AppendLine($"Pagar en caja: ${Impresora.CalcularCosto(cantidad, color)}");
                
                mensaje = sb.ToString();
                if(MessageBox.Show(mensaje, "Imprimiendo...", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    MessageBox.Show("Impresión cancelada");
                    
                }
                else
                {
                    clientesParaImprimir.Remove((Cliente)lstbColaImpresiones.SelectedItem);
                    RefrescarColaClientes();
                }
                sb.Clear();

            }
            else
            {
                MessageBox.Show("Error. Debe seleccionar una impresora y el archivo a imprimir");
            }
            


        }

        private void lstbColaImpresiones_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstbColaImpresiones.SelectedItem is not null)
            {
                Cliente clienteAux = (Cliente)lstbColaImpresiones.SelectedItem;
                lblArchivo.Text = clienteAux.MostrarDatosImpresion();
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Para imprimir un archivo seleccionar un cliente de la cola y elegir una impresora que cumpla con los requisitos del cliente.");
            sb.AppendLine("Seleccionar el tipo de impresión y la cantidad de copias y presionar el boton Imprimir");
            
            MessageBox.Show(sb.ToString());
        }

        /// <summary>
        /// metodo que actualiza la lista de clientes que esperan para imprimir un archivo
        /// </summary>
        public void RefrescarColaClientes()
        {
            lstbColaImpresiones.Items.Clear();
            foreach (Cliente cliente in clientesParaImprimir)
            {
                lstbColaImpresiones.Items.Add(cliente);
            }
        }
    }
}
