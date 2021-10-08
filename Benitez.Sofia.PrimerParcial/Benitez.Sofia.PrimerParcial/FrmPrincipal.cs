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
        Cabina t1 = new Cabina("T01", "Philips", Cabina.Tipo.Disco, true);
        Cabina t2 = new Cabina("T02", "Philips", Cabina.Tipo.Teclado, true);
        Cabina t3 = new Cabina("T03", "Philips", Cabina.Tipo.Disco, true);
        Cabina t4 = new Cabina("T04", "Philips", Cabina.Tipo.Teclado, true);
        Cabina t5 = new Cabina("T05", "Philips", Cabina.Tipo.Teclado, true);

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
        Cliente cliente8 = new Cliente("33464456", "Ricardo", "Perez", 24, Cliente.Necesidad.Cabina);
        Cliente cliente9 = new Cliente("323564456", "Pollo", "Perez", 27, Cliente.Necesidad.Cabina);
        Cliente cliente10 = new Cliente("31564456", "Walter", "Perez", 24, Cliente.Necesidad.Cabina);

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = miCiber.Fecha;
            lblNombre.Text = miCiber.Usuario;

            //agregar computadoras al ciber
            miCiber["C01"] = c1;
            miCiber["C02"] = c2;
            miCiber["C03"] = c3;
            miCiber["C04"] = c4;
            miCiber["C05"] = c5;
            miCiber["C06"] = c6;
            miCiber["C07"] = c7;
            miCiber["C08"] = c8;
            miCiber["C09"] = c9;
            miCiber["C10"] = c10;

            //agregar cabinas al ciber
            miCiber["T01"] = t1;
            miCiber["T02"] = t2;
            miCiber["T03"] = t3;
            miCiber["T04"] = t4;
            miCiber["T05"] = t5;

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

            c7.AgregarCaracteristica("J03", "Diablo II");

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
            miCiber += cliente8;
            miCiber += cliente9;
            miCiber += cliente10;

            //muestro fila de clientes
            Refrescar();

           
            

        }

        #region Botones estados computadoras

        // BOTONES COMPUTADORAS
        /// <summary>
        /// Boton que marca el estado de la computadora 1 y permite liberarla si esta en uso. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu1_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C01"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();

        }

        private void btnCompu2_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C02"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu3_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C03"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu4_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C04"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu5_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C05"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu6_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux= miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C06"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu7_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C07"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu8_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C08"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu9_Click(object sender, EventArgs e)
        {
            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C09"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCompu10_Click(object sender, EventArgs e)
        {

            UsoComputadora usoAux = miCiber.BuscarUsoPorComputadora((Computadora)miCiber["C10"]);
            miCiber.LiberarComputadora(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        #endregion

        #region Botones estados Cabinas

        /// <summary>
        /// busca el uso  relacionado con la cabina la libera y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina1_Click(object sender, EventArgs e)
        {
            UsoLlamada usoAux = miCiber.BuscarUsoPorCabina((Cabina)miCiber["T01"]);
            miCiber.LiberarCabina(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCabina2_Click(object sender, EventArgs e)
        {
            UsoLlamada usoAux = miCiber.BuscarUsoPorCabina((Cabina)miCiber["T02"]);
            miCiber.LiberarCabina(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCabina3_Click(object sender, EventArgs e)
        {
            UsoLlamada usoAux = miCiber.BuscarUsoPorCabina((Cabina)miCiber["T03"]);
            miCiber.LiberarCabina(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCabina4_Click(object sender, EventArgs e)
        {
            UsoLlamada usoAux = miCiber.BuscarUsoPorCabina((Cabina)miCiber["T04"]);
            miCiber.LiberarCabina(usoAux);
            MessageBox.Show(usoAux.Mostrar());
            Refrescar();
        }

        private void btnCabina5_Click(object sender, EventArgs e)
        {
            UsoLlamada usoAux = miCiber.BuscarUsoPorCabina((Cabina)miCiber["T05"]);
            miCiber.LiberarCabina(usoAux);
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
            if(lstbClientes.SelectedItem is null)
            {
                MessageBox.Show("Error. Tenés que seleccionar un cliente!");
                
            }
            else
            {
                clienteAux = (Cliente)lstbClientes.SelectedItem;
                if(clienteAux.NecesidadCliente is Cliente.Necesidad.Computadora)
                {
                    FrmComputadora frmComputadora = new FrmComputadora(miCiber, clienteAux);


                    frmComputadora.ShowDialog();
                    if (frmComputadora.tiempoSeleccionado != double.MinValue)
                    {
                        miCiber.AsignarComputadora(frmComputadora.computadora, frmComputadora.cliente, frmComputadora.tiempoSeleccionado);
                    }
                    if (frmComputadora.computadora is not null)
                    {
                        miCiber.AsignarComputadora(frmComputadora.computadora, frmComputadora.cliente);
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ninguna computadora");
                    }
                    

                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Error. El cliente necesita una cabina");
                }
            }

        }

        /// <summary>
        /// si hay un cliente seleccionado y su necesidad es una cabina abre un nuevo formulario, sino muestra mensajes de errror
        /// recibe los datos del formulario de cabina y asigna la cabina con los datos recibidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsignarCabina_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;

            if (lstbClientes.SelectedItem is null)
            {
                MessageBox.Show("Error. Tenés que seleccionar un cliente!");

            }
            else
            {
                clienteAux = (Cliente)lstbClientes.SelectedItem;
                if (clienteAux.NecesidadCliente is Cliente.Necesidad.Cabina)
                {
                    FrmCabina frmCabina = new FrmCabina(miCiber, clienteAux);


                    frmCabina.ShowDialog();
                    if(frmCabina.cabina is not null)
                    {
                        if(miCiber.AsignarCabina(frmCabina.cabina, frmCabina.cliente, frmCabina.numero) is null)
                        {
                            MessageBox.Show("No se asigno la cabina", "Error", MessageBoxButtons.OK);
                        }
                    }

                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Error. El cliente necesita una computadora.");
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
                lstbClientes.Items.Add(item);
            }

            ManejarEstadosServicios();
            
        }

        

        /// <summary>
        /// funcion que se llama cada 10 segundos. servira para el corte automatico de usos pero todavia no funciona 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            int flag = 0;
            //EL TICK EJECUTA ESTA FUNCION CADA 100ms
            UsoComputadora usoAux = miCiber.BuscarUsoFinalizado();
            if(flag ==0)
            {
                if (usoAux is not null)
                {
                    miCiber.LiberarComputadora(usoAux);
                    MessageBox.Show(usoAux.Mostrar());
                    Refrescar();
                    flag = 1;
                }
            }
            
            
            /// SI alguno de las compus ocupadas se paso del tiempo de uso.. 
            /// si es mas grande el daTEtime now que el tiempo de finalizacion
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
            if(lstbClientes.SelectedItem is not null)
            {
              
                Cliente clienteAux = (Cliente)lstbClientes.SelectedItem;

                lblDatosCliente.Text = clienteAux.MostrarDatosCliente();
            }
            
        }

        /// <summary>
        /// muestra la estadistica del ciber, por el momento muestra usos historicos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miCiber.MostrarUsos());
        }

        
        
        /// <summary>
        /// maneja la apariencia de los botones asociados a los servicios segun su estado
        /// </summary>
        private void ManejarEstadosServicios()
        {
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

            if (miCiber["T01"].Estado == true)
            {
                btnCabina1.BackColor = Color.GreenYellow;
                btnCabina1.Text = "Libre";
                btnCabina1.Enabled = false;
            }
            else
            {
                btnCabina1.BackColor = Color.Red;
                btnCabina1.Text = "En uso";
                btnCabina1.Enabled = true;
            }

            if (miCiber["T02"].Estado == true)
            {
                btnCabina2.BackColor = Color.GreenYellow;
                btnCabina2.Text = "Libre";
                btnCabina2.Enabled = false;
            }
            else
            {
                btnCabina2.BackColor = Color.Red;
                btnCabina2.Text = "En uso";
                btnCabina2.Enabled = true;
            }

            if (miCiber["T03"].Estado == true)
            {
                btnCabina3.BackColor = Color.GreenYellow;
                btnCabina3.Text = "Libre";
                btnCabina3.Enabled = false;
            }
            else
            {
                btnCabina3.BackColor = Color.Red;
                btnCabina3.Text = "En uso";
                btnCabina3.Enabled = true;
            }

            if (miCiber["T04"].Estado == true)
            {
                btnCabina4.BackColor = Color.GreenYellow;
                btnCabina4.Text = "Libre";
                btnCabina4.Enabled = false;
            }
            else
            {
                btnCabina4.BackColor = Color.Red;
                btnCabina4.Text = "En uso";
                btnCabina4.Enabled = true;
            }

            if (miCiber["T05"].Estado == true)
            {
                btnCabina5.BackColor = Color.GreenYellow;
                btnCabina5.Text = "Libre";
                btnCabina5.Enabled = false;
            }
            else
            {
                btnCabina5.BackColor = Color.Red;
                btnCabina5.Text = "En uso";
                btnCabina5.Enabled = true;
            }
        }

        

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
