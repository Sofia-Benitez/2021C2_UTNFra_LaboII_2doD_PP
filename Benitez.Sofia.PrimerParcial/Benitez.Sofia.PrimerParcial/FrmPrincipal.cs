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

        Ciber miCiber = new Ciber("Sofía Benítez", DateTime.Now);

        //harcodeo cabinas
        Cabina t1 = new Cabina("T01", "Philips", Cabina.Tipo.Disco, false);
        Cabina t2 = new Cabina("T02", "Philips", Cabina.Tipo.Teclado, false);
        Cabina t3 = new Cabina("T03", "Philips", Cabina.Tipo.Disco, false);
        Cabina t4 = new Cabina("T04", "Philips", Cabina.Tipo.Teclado, false);
        Cabina t5 = new Cabina("T05", "Philips", Cabina.Tipo.Teclado, false);

        //Harcodeo computadoras
        Computadora c1 = new Computadora("C01", true);
        Computadora c2 = new Computadora("C02", true);
        Computadora c3 = new Computadora("C03", true);
        Computadora c4 = new Computadora("C04", true);
        Computadora c5 = new Computadora("C05", true);
        Computadora c6 = new Computadora("C06", true);
        Computadora c7 = new Computadora("C07", true);
        Computadora c8 = new Computadora("C08", true);
        Computadora c9 = new Computadora("C09", true);
        Computadora c10 = new Computadora("C10",true);

        //Harcodeo clientes
        Cliente cliente1 = new Cliente("41565434", "Lisa", "Simpson", 16, Cliente.Necesidad.Computadora);
        Cliente cliente2 = new Cliente("24687764", "Michael", "Scott", 40, Cliente.Necesidad.Computadora);
        Cliente cliente3 = new Cliente("23987676", "Ted", "Lasso", 40, Cliente.Necesidad.Computadora);
        Cliente cliente4 = new Cliente("31985664", "Jim", "Halpert", 35, Cliente.Necesidad.Computadora);
        Cliente cliente5 = new Cliente("29876767", "Dwight", "Schrute", 32, Cliente.Necesidad.Computadora);
        Cliente cliente6 = new Cliente("32987676", "Pam", "Beesley", 39, Cliente.Necesidad.Computadora);
        Cliente cliente7 = new Cliente("35564456", "Chiqui", "Perez", 25, Cliente.Necesidad.Cabina);

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = miCiber.Fecha;
            lblNombre.Text = miCiber.Usuario;

            miCiber += c1;
            miCiber += c2;
            miCiber += c3;
            miCiber += c4;
            miCiber += c5;
            miCiber += c6;
            miCiber += c7;
            miCiber += c8;
            miCiber += c9;
            miCiber += c10;
            
            //agregar cabinas


            //agrego elementos a las computadoras
            c1.AgregarCaracteristica("J01", "Counter Strike");
            c1.AgregarCaracteristica("S01", "Ares");
            c1.AgregarCaracteristica("P01", "Auriculares");
            c1.AgregarCaracteristica("P02", "Micrófono");

            c2.AgregarCaracteristica("J01", "Counter Strike");
            c2.AgregarCaracteristica("P01", "Auriculares");
            c2.AgregarCaracteristica("P02", "Micrófono");

            c3.AgregarCaracteristica("J02", "Age of Empires II");
            c3.AgregarCaracteristica("S02", "MSN");

            c4.AgregarCaracteristica("P03", "Cámara");

            c6.AgregarCaracteristica("P03", "Cámara");

            //agrego requerimientos a los clientes 
            cliente1.AgregarRequerimiento("J01", "Counter Strike");
            cliente2.AgregarRequerimiento("P01", "Auriculares");
            cliente3.AgregarRequerimiento("S02", "MSN");
            cliente4.AgregarRequerimiento("J02", "Age of Empires II");
            cliente5.AgregarRequerimiento("P03", "Cámara");
            cliente6.AgregarRequerimiento("P02", "Micrófono");

            // Agrego clientes a la cola
            miCiber += cliente1;
            miCiber += cliente2;
            miCiber += cliente3;
            miCiber += cliente4;
            miCiber += cliente5;
            miCiber += cliente6;
            miCiber += cliente7;

            //muestro fila de clientes
            Refrescar();

           
            

        }

        #region Botones computadoras

        // BOTONES COMPUTADORAS
        /// <summary>
        /// Boton que marca el estado de la computadora 1 y permite liberarla si esta en uso. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu1_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C01");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();

        }

        private void btnCompu2_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C02");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu3_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C03");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu4_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C04");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu5_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C05");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu6_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux= BuscarUsoPorIdComputadora("C06");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu7_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C07");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu8_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C08");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu9_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C09");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu10_Click(object sender, EventArgs e)
        {

            UsoComputadora usoAux = BuscarUsoPorIdComputadora("C10");
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        #endregion
        
        /// <summary>
        /// si se selecciono un cliente de la lista que necesita una computadora abre un nuevo formulario con las computadoras disponibles 
        /// donde se puede seleccionar una y elegir el tiempo de uso. Si el usuario acepta se crea un nuevo uso de esa computadora
        /// luego se actualiza la fila de clientes pendientes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarCompu_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;
            string cliente = "";
            if(lstbClientes.SelectedItem is null)
            {
                MessageBox.Show("Error. Tenés que seleccionar un cliente!");
                
            }
            else
            {
                cliente = lstbClientes.SelectedItem.ToString();
                clienteAux = Cliente.ClienteSeleccionado(cliente, miCiber);
                if(clienteAux.NecesidadCliente is Cliente.Necesidad.Computadora)
                {
                    FrmComputadora frmComputadora = new FrmComputadora(miCiber, clienteAux);


                    frmComputadora.ShowDialog();
                    miCiber.AsignarComputadora(frmComputadora.computadora, frmComputadora.cliente);

                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Error. El cliente necesita una cabina!");
                }
                

            }

           
           
        }

        /// <summary>
        /// actualiza la fila de clientes y los botones con estados de cada servicio
        /// </summary>
        public void Refrescar()
        {
            lstbClientes.Items.Clear();
            foreach (Cliente item in miCiber.ListaDeClientes)
            {
                lstbClientes.Items.Add(item.Mostrar());
            }


            if (miCiber["C01"].Estado == true)
            {
                btnCompu1.BackColor = Color.GreenYellow;
                btnCompu1.Text = "Libre";
                btnCompu1.Enabled = false;
            }
            else
            {
                btnCompu1.BackColor = Color.Red;
                btnCompu1.Text = "En uso";
                btnCompu1.Enabled = true;
            }

            if (miCiber["C02"].Estado == true)
            {
                btnCompu2.BackColor = Color.GreenYellow;
                btnCompu2.Text = "Libre";
                btnCompu2.Enabled = false;
            }
            else
            {
                btnCompu2.BackColor = Color.Red;
                btnCompu2.Text = "En uso";
                btnCompu2.Enabled = true;
            }

            if (miCiber["C03"].Estado == true)
            {
                btnCompu3.BackColor = Color.GreenYellow;
                btnCompu3.Text = "Libre";
                btnCompu3.Enabled = false;
            }
            else
            {
                btnCompu3.BackColor = Color.Red;
                btnCompu3.Text = "En uso";
                btnCompu3.Enabled = true;
            }

            if (miCiber["C04"].Estado == true)
            {
                btnCompu4.BackColor = Color.GreenYellow;
                btnCompu4.Text = "Libre";
                btnCompu4.Enabled = false;
            }
            else
            {
                btnCompu4.BackColor = Color.Red;
                btnCompu4.Text = "En uso";
                btnCompu4.Enabled = true;
            }

            if (miCiber["C05"].Estado == true)
            {
                btnCompu5.BackColor = Color.GreenYellow;
                btnCompu5.Text = "Libre";
                btnCompu5.Enabled = false;
            }
            else
            {
                btnCompu5.BackColor = Color.Red;
                btnCompu5.Text = "En uso";
                btnCompu5.Enabled = true;
            }

            if (miCiber["C06"].Estado == true)
            {
                btnCompu6.BackColor = Color.GreenYellow;
                btnCompu6.Text = "Libre";
                btnCompu6.Enabled = false;
            }
            else
            {
                btnCompu6.BackColor = Color.Red;
                btnCompu6.Text = "En uso";
                btnCompu6.Enabled = true;
            }

            if (miCiber["C07"].Estado == true)
            {
                btnCompu7.BackColor = Color.GreenYellow;
                btnCompu7.Text = "Libre";
                btnCompu7.Enabled = false;
            }
            else
            {
                btnCompu7.BackColor = Color.Red;
                btnCompu7.Text = "En uso";
                btnCompu7.Enabled = true;
            }

            if (miCiber["C08"].Estado == true)
            {
                btnCompu8.BackColor = Color.GreenYellow;
                btnCompu8.Text = "Libre";
                btnCompu8.Enabled = false;
            }
            else
            {
                btnCompu8.BackColor = Color.Red;
                btnCompu8.Text = "En uso";
                btnCompu8.Enabled = true;
            }

            if (miCiber["C09"].Estado == true)
            {
                btnCompu9.BackColor = Color.GreenYellow;
                btnCompu9.Text = "Libre";
                btnCompu9.Enabled = false;
            }
            else
            {
                btnCompu9.BackColor = Color.Red;
                btnCompu9.Text = "En uso";
                btnCompu9.Enabled = true;
            }

            if (miCiber["C10"].Estado == true)
            {
                btnCompu10.BackColor = Color.GreenYellow;
                btnCompu10.Text = "Libre";
                btnCompu10.Enabled = false;
            }
            else
            {
                btnCompu10.BackColor = Color.Red;
                btnCompu10.Text = "En uso";
                btnCompu10.Enabled = true;
            }
        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //EL TICK EJECUTA ESTA FUNCION CADA 100ms

            ///Refrescar();
            /// SI alguno de las compus ocupadas se paso del tiempo de uso.. 
            /// si es mas grande el daytime now que el tiempo de finalizacion
            /// en la lista de usoss
            /// liberar computadora
        }

          /// <summary>
          /// cada vez que cambia el item seleccionado se modifica el label que muestra la informacion ampliada del cliente
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
        private void lstbClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            string clienteSeleccionado = lstbClientes.SelectedItem.ToString();
            Cliente aux = Cliente.ClienteSeleccionado(clienteSeleccionado, miCiber);

            lblDatosCliente.Text = aux.MostrarDatosCliente();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miCiber.MostrarUsos());
        }

        /// <summary>
        /// busca el uso mas reciente de computadora que corresponda a un id y lo devuelve 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private UsoComputadora BuscarUsoPorIdComputadora(string id)
        {
            foreach (UsoComputadora item in miCiber.ListaDeUsos)
            {
                if (item.Computadora.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        
    }
}
