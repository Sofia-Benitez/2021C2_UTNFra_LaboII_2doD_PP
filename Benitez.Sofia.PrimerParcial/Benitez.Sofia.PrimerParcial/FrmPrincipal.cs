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
    public partial class FrmPrincipal : Form
    {

        //harcodeo cabinas
        Cabina t1 = new Cabina("T01", "Philips", Cabina.Tipo.Disco, false);
        Cabina t2 = new Cabina("T02", "Philips", Cabina.Tipo.Teclado, false);
        Cabina t3 = new Cabina("T03", "Philips", Cabina.Tipo.Disco, false);
        Cabina t4 = new Cabina("T04", "Philips", Cabina.Tipo.Teclado, false);
        Cabina t5 = new Cabina("T05", "Philips", Cabina.Tipo.Teclado, false);

        //Harcodeo computadoras
        Computadora c1 = new Computadora("C01", false);
        Computadora c2 = new Computadora("C02", true);
        Computadora c3 = new Computadora("C03", true);
        Computadora c4 = new Computadora("C04", true);
        Computadora c5 = new Computadora("C05", false);
        Computadora c6 = new Computadora("C06", false);
        Computadora c7 = new Computadora("C07", false);
        Computadora c8 = new Computadora("C08", false);
        Computadora c9 = new Computadora("C09", false);
        Computadora c10 = new Computadora("C10", false);

        //Harcodeo clientes
        Cliente cliente1 = new Cliente("34565434", "Lisa", "Simpson", 16, Cliente.Necesidad.Computadora);
        Cliente cliente2 = new Cliente("35687764", "Eva", "Eisberg", 30, Cliente.Necesidad.Cabina);

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            Ciber ciberElVicio = new Ciber("Sofía Benítez", fecha);
            lblFecha.Text = fecha.ToShortDateString();
            lblNombre.Text = ciberElVicio.Usuario;

            //agrego elementos a las computadoras
            c1.AgregarCaracteristica("J01", "Counter Strike");
            c1.AgregarCaracteristica("S01", "Ares");
            c1.AgregarCaracteristica("P01", "Auriculares");
            c1.AgregarCaracteristica("P02", "Micrófono");

            //agrego requerimientos a los clientes 
            cliente1.AgregarRequerimiento("J01", "Counter Strike");
            cliente2.AgregarRequerimiento("P01", "Auriculares");

            //muestro fila de clientes
            lstbClientes.Items.Add(cliente1.Mostrar());
            lstbClientes.Items.Add(cliente2.Mostrar());


        }

        // BOTONES COMPUTADORAS

        private void btnCompu10_Click(object sender, EventArgs e)
        {
           
           
        }

        private void btnAsignarCompu_Click(object sender, EventArgs e)
        {
            FrmComputadora frmComputadora = new FrmComputadora(c1, c2, c3, c4);

            frmComputadora.ShowDialog();
        }

        
    }
}
