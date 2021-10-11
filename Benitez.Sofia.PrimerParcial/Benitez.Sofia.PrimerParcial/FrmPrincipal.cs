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
        Cabina t1 = new Cabina("T01", "Siemens", Cabina.Tipo.Disco, true);
        Cabina t2 = new Cabina("T02", "Sony", Cabina.Tipo.Teclado, true);
        Cabina t3 = new Cabina("T03", "Siemens", Cabina.Tipo.Disco, true);
        Cabina t4 = new Cabina("T04", "Panasonic", Cabina.Tipo.Teclado, true);
        Cabina t5 = new Cabina("T05", "Philips", Cabina.Tipo.Teclado, true);

        //Harcodeo computadoras
        Computadora c1 = new Computadora("C01", true, "128", "Pentium 4", false);
        Computadora c2 = new Computadora("C02", true, "256", "Pentium 4", true);
        Computadora c3 = new Computadora("C03", true, "128", "Athlon", false);
        Computadora c4 = new Computadora("C04", true, "256", "Athlon", true);
        Computadora c5 = new Computadora("C05", true, "128", "Athlon", false);
        Computadora c6 = new Computadora("C06", true, "256", "Athlon", true);
        Computadora c7 = new Computadora("C07", true, "128", "Pentium 4", false);
        Computadora c8 = new Computadora("C08", true, "128", "Athlon", false);
        Computadora c9 = new Computadora("C09", true, "128", "Athlon", false);
        Computadora c10 = new Computadora("C10",true, "128", "Pentium 4", false);

        //Harcodeo clientes
        Cliente cliente1 = new Cliente("41565434", "Lisa", "Simpson", 16, Cliente.Necesidad.Computadora, "30 min");
        Cliente cliente2 = new Cliente("24687764", "Michael", "Scott", 40, Cliente.Necesidad.Computadora);
        Cliente cliente3 = new Cliente("23987676", "Joey", "Tribiani", 40, Cliente.Necesidad.Computadora, "60 min");
        Cliente cliente4 = new Cliente("31985664", "Jim", "Halpert", 35, Cliente.Necesidad.Computadora);
        Cliente cliente5 = new Cliente("29876767", "Dwight", "Schrute", 32, Cliente.Necesidad.Computadora, "30 min");
        Cliente cliente6 = new Cliente("32987676", "Pam", "Beesley", 39, Cliente.Necesidad.Computadora);
        Cliente cliente7 = new Cliente("35564456", "Chiqui", "Perez", 25, Cliente.Necesidad.Cabina);
        Cliente cliente8 = new Cliente("33464456", "Ricardo", "Perez", 24, Cliente.Necesidad.Cabina);
        Cliente cliente9 = new Cliente("323564456", "Pollo", "Perez", 27, Cliente.Necesidad.Cabina);
        Cliente cliente10 = new Cliente("31564456", "Walter", "Perez", 24, Cliente.Necesidad.Cabina);
        Cliente cliente11 = new Cliente("28564456", "Rachel", "Green", 29, Cliente.Necesidad.Computadora);
        Cliente cliente12 = new Cliente("23334456", "Chandler", "Bing", 32, Cliente.Necesidad.Computadora);
        Cliente cliente13 = new Cliente("25674456", "Ross", "Geller", 34, Cliente.Necesidad.Computadora);
        Cliente cliente14 = new Cliente("24564456", "Mónica", "Geller", 29, Cliente.Necesidad.Computadora);

 

        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = miCiber.Fecha;
            lblNombre.Text = miCiber.Usuario;


            //agrego elementos a las computadoras
            c1.AgregarCaracteristica("J01", "Counter Strike");
            c1.AgregarCaracteristica("S01", "Ares");
            c1.AgregarCaracteristica("P01", "Auriculares");
            c1.AgregarCaracteristica("P02", "Micrófono");

            c2.AgregarCaracteristica("J01", "Counter Strike");
            c2.AgregarCaracteristica("P01", "Auriculares");
            c2.AgregarCaracteristica("P02", "Micrófono");
            c2.AgregarCaracteristica("J04", "Warcraft III");

            c3.AgregarCaracteristica("J02", "Age of Empires II");
            c3.AgregarCaracteristica("S02", "MSN");
            c3.AgregarCaracteristica("S01", "Ares");
            c3.AgregarCaracteristica("J01", "Counter Strike");

            c4.AgregarCaracteristica("P03", "Cámara");
            c4.AgregarCaracteristica("J04", "Warcraft III");
            c4.AgregarCaracteristica("S03", "Office");
            c4.AgregarCaracteristica("S02", "MSN");

            c5.AgregarCaracteristica("P02", "Micrófono");
            c5.AgregarCaracteristica("P01", "Auriculares");
            c5.AgregarCaracteristica("S03", "Office");
            c5.AgregarCaracteristica("S04", "ICQ");


            c6.AgregarCaracteristica("P03", "Cámara");
            c6.AgregarCaracteristica("S03", "Office");
            c6.AgregarCaracteristica("J01", "Counter Strike");
            c6.AgregarCaracteristica("S01", "Ares");
            c6.AgregarCaracteristica("P01", "Auriculares");

            c7.AgregarCaracteristica("J03", "Diablo II");
            c7.AgregarCaracteristica("J02", "Age of Empires II");
            c7.AgregarCaracteristica("S02", "MSN");
            c7.AgregarCaracteristica("P01", "Auriculares");
            c7.AgregarCaracteristica("P03", "Cámara");

            c8.AgregarCaracteristica("P02", "Micrófono");
            c8.AgregarCaracteristica("P01", "Auriculares");
            c8.AgregarCaracteristica("S03", "Office");
            c8.AgregarCaracteristica("J03", "Diablo II");
            c8.AgregarCaracteristica("J02", "Age of Empires II");

            c9.AgregarCaracteristica("P02", "Micrófono");
            c9.AgregarCaracteristica("P01", "Auriculares");
            c9.AgregarCaracteristica("S02", "MSN");
            c9.AgregarCaracteristica("S01", "Ares");

            c10.AgregarCaracteristica("P01", "Auriculares");
            c10.AgregarCaracteristica("S03", "Office");
            c10.AgregarCaracteristica("P03", "Cámara");
            c10.AgregarCaracteristica("S04", "ICQ");
            c10.AgregarCaracteristica("J05", "Mu Online");

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

            //agrego requerimientos a los clientes de manera random
            Random rndNumber = new Random();
            List<KeyValuePair<string, string>> listaRandom = new List<KeyValuePair<string, string>>();
            int numero;

            listaRandom.Insert(0, new KeyValuePair<string, string>("J01", "Counter Strike"));
            listaRandom.Insert(1, new KeyValuePair<string, string>("J02", "Age of Empires II"));
            listaRandom.Insert(2, new KeyValuePair<string, string>("J03", "Diablo II"));
            listaRandom.Insert(3, new KeyValuePair<string, string>("J04", "Warcraft III"));
            listaRandom.Insert(4, new KeyValuePair<string, string>("J05", "Mu Online"));
            listaRandom.Insert(5, new KeyValuePair<string, string>("P01", "Auriculares"));
            listaRandom.Insert(6, new KeyValuePair<string, string>("P02", "Micrófono"));
            listaRandom.Insert(7, new KeyValuePair<string, string>("P03", "Cámara"));
            listaRandom.Insert(8, new KeyValuePair<string, string>("S01", "Ares"));
            listaRandom.Insert(9, new KeyValuePair<string, string>("S02", "MSN"));
            listaRandom.Insert(10, new KeyValuePair<string, string>("S03", "Office"));
            listaRandom.Insert(11, new KeyValuePair<string, string>("S04", "ICQ"));



            numero = rndNumber.Next(12);
            cliente1.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente1.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente2.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente2.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente2.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);

            numero = rndNumber.Next(12);
            cliente3.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente3.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente4.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente4.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente4.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);

            numero = rndNumber.Next(12);
            cliente5.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente5.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente6.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente6.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente11.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente11.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente12.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente12.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            

            numero = rndNumber.Next(12);
            cliente13.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente13.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
           
            numero = rndNumber.Next(12);
            cliente14.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente14.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);
            numero = rndNumber.Next(12);
            cliente14.AgregarRequerimiento(listaRandom[numero].Key, listaRandom[numero].Value);

            // Agrego clientes a la cola
            miCiber += cliente1;
            miCiber += cliente2;
            miCiber += cliente3;
            miCiber += cliente4;
            miCiber += cliente5;
            miCiber += cliente6;
            miCiber += cliente7;
            miCiber += cliente11;
            miCiber += cliente9;
            miCiber += cliente12;
            miCiber += cliente8;
            miCiber += cliente13;
            miCiber += cliente14;
            miCiber += cliente10;

            //muestro fila de clientes
            Refrescar();

            //harcodeo usos historicos
            DateTime fecha1 = new DateTime(2021, 8, 1, 14, 20, 13);
            DateTime fecha2 = new DateTime(2021, 8, 1, 14, 21, 00);
            DateTime fecha3 = new DateTime(2021, 9, 1, 16, 20, 12);
            DateTime fecha4 = new DateTime(2021, 9, 1, 16, 20, 39);
            DateTime fecha5 = new DateTime(2021, 9, 1, 17, 15, 59);
            

            UsoComputadora uso1 = new UsoComputadora(fecha1, fecha1.AddSeconds(30), cliente1, (Computadora)miCiber["C01"]);
            UsoComputadora uso2 = new UsoComputadora(fecha2, fecha2.AddSeconds(60), cliente3, (Computadora)miCiber["C01"]);
            UsoComputadora uso3 = new UsoComputadora(fecha3, fecha3.AddSeconds(90), cliente4, (Computadora)miCiber["C02"]);
            UsoComputadora uso4 = new UsoComputadora(fecha5, fecha5.AddSeconds(30), cliente2, (Computadora)miCiber["C03"]);
            UsoComputadora uso5 = new UsoComputadora(fecha5, fecha5.AddSeconds(60), cliente11, (Computadora)miCiber["C08"]);
            UsoCabina uso6 = new UsoCabina(fecha4, "541164578787", UsoCabina.TipoLlamada.Local, cliente7, (Cabina)miCiber["T01"]);
            uso6.TiempoFinalizacion = fecha4.AddSeconds(25);
            UsoCabina uso7 = new UsoCabina(fecha5, "54666666667", UsoCabina.TipoLlamada.LargaDistancia, cliente8, (Cabina)miCiber["T03"]);
            uso7.TiempoFinalizacion = fecha5.AddSeconds(55);
            UsoCabina uso8 = new UsoCabina(fecha3, "14565567867", UsoCabina.TipoLlamada.Internacional, cliente9, (Cabina)miCiber["T04"]);
            uso8.TiempoFinalizacion = fecha3.AddSeconds(59);


            miCiber.ListaDeUsos.Add(uso1);
            miCiber.ListaDeUsos.Add(uso2);
            miCiber.ListaDeUsos.Add(uso3);
            miCiber.ListaDeUsos.Add(uso4);
            miCiber.ListaDeUsos.Add(uso5);
            miCiber.ListaDeUsos.Add(uso6);
            miCiber.ListaDeUsos.Add(uso7);
            miCiber.ListaDeUsos.Add(uso8);
            miCiber.ListaDeClientesAtendidos.Add(cliente1);
            miCiber.ListaDeClientesAtendidos.Add(cliente2);
            miCiber.ListaDeClientesAtendidos.Add(cliente3);
            miCiber.ListaDeClientesAtendidos.Add(cliente4);
            miCiber.ListaDeClientesAtendidos.Add(cliente7);
            miCiber.ListaDeClientesAtendidos.Add(cliente8);
            miCiber.ListaDeClientesAtendidos.Add(cliente11);
            miCiber.ListaDeClientesAtendidos.Add(cliente9);


        }

        #region Botones estados computadoras

        // BOTONES COMPUTADORAS
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu1_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C01"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();

        }

        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu2_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C02"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu3_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C03"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu4_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C04"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu5_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C05"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu6_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C06"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu7_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C07"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu8_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C08"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu9_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C09"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }
        /// <summary>
        /// Boton que muestra el estado de la computadora y permite liberarla si esta en uso mostrando un mensaje con los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompu10_Click(object sender, EventArgs e)
        {
            string datosUso = ((Computadora)miCiber["C10"]).LiberarComputadora();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        #endregion

        #region Botones estados Cabinas

        /// <summary>
        /// muestra el estado de la caiba 
        ///  y si esta en uso libera la cabina correspondiente y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina1_Click(object sender, EventArgs e)
        {

            string datosUso = ((Cabina)miCiber["T01"]).LiberarCabina();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// muestra el estado de la caiba 
        ///  y si esta en uso libera la cabina correspondiente y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina2_Click(object sender, EventArgs e)
        {
            string datosUso = ((Cabina)miCiber["T02"]).LiberarCabina();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// muestra el estado de la caiba 
        ///  y si esta en uso libera la cabina correspondiente y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina3_Click(object sender, EventArgs e)
        {
            string datosUso = ((Cabina)miCiber["T03"]).LiberarCabina();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// muestra el estado de la caiba 
        ///  y si esta en uso libera la cabina correspondiente y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina4_Click(object sender, EventArgs e)
        {
            string datosUso = ((Cabina)miCiber["T04"]).LiberarCabina();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
            Refrescar();
        }

        /// <summary>
        /// muestra el estado de la caiba 
        ///  y si esta en uso libera la cabina correspondiente y muestra la informacion del uso (tiempo, cliente, costo)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCabina5_Click(object sender, EventArgs e)
        {
            string datosUso = ((Cabina)miCiber["T05"]).LiberarCabina();
            MessageBox.Show(datosUso, "Finalizar uso", MessageBoxButtons.OK);
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
                    
                    if (frmComputadora.computadora is not null)
                    {
                        if(frmComputadora.tiempo == "tiempo libre")
                        {
                            miCiber.AsignarComputadoraLibre(frmComputadora.computadora, frmComputadora.cliente);
                        }
                        else
                        {
                            miCiber.AsignarComputadoraPorTiempo(frmComputadora.computadora, frmComputadora.cliente, frmComputadora.tiempoSeleccionado);
                        }
                        
                        
                   
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
        /// Abre el formulario que permite ver las estadisticas historicas del ciber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            
            string usosComputadoras = miCiber.OrdenarUsosComputadoraPorTiempoDeUso();
            string usosCabinas = miCiber.OrdenarUsosCabinaPorTiempoDeUso();
            string gananciasTotales = miCiber.CalcularGananciasTotalesYPorServicio();
            string tiempoLlamadasYRecaudacion = miCiber.CalcularHorasTotalesLlamadasYRecaudacionPorTipo();
            string softwareMasPedido=miCiber.BuscarRequerimientoMasPedido('S');
            string juegoMasPedido= miCiber.BuscarRequerimientoMasPedido('J');
            string perifericoMasPedido= miCiber.BuscarRequerimientoMasPedido('P');
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas(usosComputadoras, usosCabinas, gananciasTotales, tiempoLlamadasYRecaudacion, softwareMasPedido, juegoMasPedido, perifericoMasPedido);
            frmEstadisticas.ShowDialog();
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
        /// metodo que se ejecuta cada 5 segundos. 
        /// Busca usos finalizados y si encuentra uno lo muestra y actualiza los estados de los equipos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            string datos = miCiber.BuscarUsosFinalizados();
            if(datos!="")
            {
                MessageBox.Show(datos, "Tiempo de uso del usuario finalizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refrescar();
            }
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

        /// <summary>
        /// Al presionar el boton muestra un mensaje con instruciones para utilizar la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La lista de la izquierda muestra los clientes que aún no han sido atendidos. \n");
            sb.AppendLine("Para asignarle una computadora o cabina al cliente debe seleccionarlo de la lista y presionar el botón Asignar cabina o Asignar computadora, según corresponda. \n");
            sb.AppendLine("Para finalizar el uso de un servicio presionar el boton del equipo correspondiente, esto solo se puede realizar si el equipo esta en uso. \n");
            sb.AppendLine("Los usos de computadora que se alquilan por un tiempo anticipado finalizan automaticamente y se muestran con un mensaje en la pantalla.\n");
            sb.AppendLine("Para ver las estadísticas históricas del ciber presione el botón Estadisticas.");
               

            MessageBox.Show(sb.ToString());
        }

        
    }
}
