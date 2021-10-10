using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public sealed class Ciber
    {
        private List<Cliente> listaClientes;
        private List<Uso> listaDeUsos;
        private List<Servicio> listaServicios;
        private string nombreUsuario;
        private DateTime fechaYHora;
        private List<Cliente> listaClientesAtendidos;

        /// <summary>
        /// constructor que instancia las listas 
        /// </summary>
        private Ciber()
        {
            this.listaClientes = new List<Cliente>();
            this.listaServicios = new List<Servicio>();
            this.listaDeUsos = new List<Uso>();
            this.listaClientesAtendidos = new List<Cliente>();
        }

        /// <summary>
        /// constructor con un solo parametro
        /// </summary>
        /// <param name="usuario"></param>
        public Ciber(string usuario):this()
        {
            this.nombreUsuario = usuario;
            
        }

        /// <summary>
        /// sobrecarga del constructor
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="fecha"></param>
        public Ciber(string usuario, DateTime fecha):this(usuario)
        {
            this.fechaYHora = fecha;
        }

        /// <summary>
        /// propiedad que permite leer el nombre del usuario del ciber 
        /// </summary>
        public string Usuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }

        /// <summary>
        /// propiedad que permite leer la fecha actual
        /// </summary>
        public string Fecha
        {
            get
            {
                return this.fechaYHora.ToShortDateString();
            }
        }

        /// <summary>
        /// propiedead que permite leer la lista de clientes en espera 
        /// </summary>
        public List<Cliente> ListaDeClientes
        {
            get
            {
                return this.listaClientes;
            }
        }

        /// <summary>
        /// propiedead que permite leer la lista de clientes que ya han sido atendidos 
        /// </summary>
        public List<Cliente> ListaDeClientesAtendidos
        {
            get
            {
                return this.listaClientesAtendidos;
            }
        }

        /// <summary>
        /// propiedead que permite leer la lista de servicios que posee el ciber 
        /// </summary>
        public List<Servicio> ListaDeServicios
        {
            get
            {
                return listaServicios;
            }
        }

        /// <summary>
        /// propiedead que permite leer la lista de usos tanto de cabians como computadoras que se han realizado en el ciber
        /// </summary>
        public List<Uso> ListaDeUsos
        {
            get
            {
                return listaDeUsos;
            }
        }

        /// <summary>
        /// indexador para acceder al servicio correspondiente de la lista de servicios. 
        /// permite agregar nuevos servicios a la lista si no estan incluidos
        /// </summary>
        /// <param name="index">string con la inicial del cervicio y el numero</param>
        /// <returns>devuelve el servicio correspondiente al indice</returns>
        public Servicio this[string index]
        { 
            get
            {
                foreach (Servicio item in this.listaServicios)
                {
                    if (item.Id == index)
                    {
                        return item;
                    }

                }
                return null;
            }
            
            set
            {
                foreach (Servicio item in this.listaServicios)
                {
                    if(item.Id == index)
                    {
                        break;
                    }
                }
                listaServicios.Add(value);
            }
        }

        


        /// <summary>
        /// Sobrecarga del operador para agregar clientes a la lista de espera del ciber
        /// </summary>
        /// <param name="ciber"></param>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static Ciber operator +(Ciber ciber, Cliente cliente)
        {
            
            foreach (Cliente item in ciber.listaClientes)
            {
                if (item == cliente)
                {
                    return ciber;
                }

            }
            ciber.listaClientes.Add(cliente);
            return ciber;
        }

        

        /// <summary>
        /// metodo que instancia un nuevo uso de computadora sin tiempo de finalizacion. 
        /// remueve al cliente de la lista de espera y agrega el uso a la lista de usos del ciber 
        /// agrega al cliente a la lista de clientes ya atendidos y le asigna el uso a la computadora correspondiente
        /// </summary>
        /// <param name="computadora">computadora que se pasara por referencia en el uso nuevo</param>
        /// <param name="cliente">cliente que se pasara por referencia en el uso nuevo</param>
        /// <returns>devuelve el uso de computadora que se ha creado</returns>
        public UsoComputadora AsignarComputadoraLibre(Computadora computadora, Cliente cliente)
        {
            if(computadora is not null && computadora.Estado==true)
            {
                computadora.Estado = false;
                UsoComputadora uso = new UsoComputadora(DateTime.Now, cliente, computadora);
                this.listaClientes.Remove(cliente);
                this.listaClientesAtendidos.Add(cliente);
                this.listaDeUsos.Add(uso);
                computadora.UsoActual = uso;
                return uso;
            }
            return null;
        }

        /// <summary>
        /// metodo que instancia un nuevo uso de computadora con tiempo de finalizacion definido
        /// /// remueve al cliente de la lista de espera y agrega el uso a la lista de usos del ciber 
        /// agrega al cliente a la lista de clientes ya atendidos y le asigna el uso a la computadora correspondiente
        /// </summary>
        /// <param name="computadora"></param>
        /// <param name="cliente"></param>
        /// <param name="tiempoSeleccionado">reciba el tiempo seleccionado de uso que viene desde el form de computadoras</param>
        /// <returns>devuelve el uso de computadora que se ha creado</returns>
        public UsoComputadora AsignarComputadoraPorTiempo(Computadora computadora, Cliente cliente, double tiempoSeleccionado)
        {
            DateTime tiempoInicio = DateTime.Now;
            UsoComputadora uso = new UsoComputadora(tiempoInicio, cliente, computadora);
            computadora.UsoActual = uso;
            computadora.UsoActual.TiempoFinalizacion = tiempoInicio.AddSeconds(tiempoSeleccionado);
            computadora.Estado = false;
            this.listaClientes.Remove(cliente);
            this.listaClientesAtendidos.Add(cliente);
            this.listaDeUsos.Add(uso);
            return uso;
        }

        
        
        /// <summary>
        /// metodo que instancia un nuevo uso de cabina sin tiempo de finalizacion. 
        /// remueve al cliente de la lista de espera y agrega el uso a la lista de usos del ciber 
        /// agrega al cliente a la lista de clientes atendidos y asigna el uso a la caiba correspondiente 
        /// </summary>
        /// <param name="computadora">computadora que se pasara por referencia en el uso nuevo</param>
        /// <param name="cliente">cliente que se pasara por referencia en el uso nuevo</param>
        /// <returns></returns>
        public UsoCabina AsignarCabina(Cabina cabina, Cliente cliente, string numero)
        {
            if(cabina is not null && cabina.Estado==true)
            {
                cabina.Estado = false;
                UsoCabina.TipoLlamada tipo = UsoCabina.ObtenerTipoLlamada(numero);
                UsoCabina uso = new UsoCabina(DateTime.Now, numero, tipo, cliente, cabina);
                cabina.UsoActual = uso;
                this.listaClientes.Remove(cliente);
                this.listaClientesAtendidos.Add(cliente);
                this.listaDeUsos.Add(uso);
                return uso;
            }
            return null;

        }

        /// <summary>
        /// Busca entre la lista de Servicios las computadoras utlizadas en el momento que ya tengan un tiempo de finalizacion 
        /// y que sea anterior al tiempo actual
        /// si encuentra una guarda los datos y la desocupa
        /// </summary>
        /// <returns>devuelve los datos del uso que ha finalizado</returns>
        public string BuscarUsosFinalizados()
        {
            string datos = "";
            foreach (Servicio item in this.ListaDeServicios)
            {
                if (item is Computadora)
                {
                    Computadora aux = (Computadora)item;
                    if (aux.UsoActual is not null)
                    {
                        if (aux.UsoActual.TiempoFinalizacion != DateTime.MinValue && aux.UsoActual.TiempoFinalizacion < DateTime.Now)
                        {
                            aux.Estado = true;

                            datos = aux.UsoActual.Mostrar();
                            aux.UsoActual = null;

                        }
                    }
                }
            }

            return datos;
        }

        #region ESTADISTICAS

        

        /// <summary>
        /// metodo que compara dos usos de computadora por su duracion
        /// </summary>
        /// <param name="uso1"></param>
        /// <param name="uso2"></param>
        /// <returns></returns>
        private int CompararTiempoDeUsoComputadora(UsoComputadora uso1, UsoComputadora uso2)
        {
            int minutosUso1 = (int)uso1.UsoEnMinutosTotales;
            int minutosUso2 = (int)uso2.UsoEnMinutosTotales;

            return minutosUso1 - minutosUso2;
        }

        /// <summary>
        /// Metodo que ordena los usos de computadora segun su tiempo de duracion
        /// </summary>
        /// <returns>Devuelve la lista de computadoras ordenadas por minutos de uso de forma descendente.</returns>
        public string OrdenarUsosComputadoraPorTiempoDeUso()
        {
            List<UsoComputadora> listaUsosComputadora = new List<UsoComputadora>();
            StringBuilder sb = new StringBuilder();

            foreach (Uso item in this.listaDeUsos)
            {
                if(item is UsoComputadora)
                {
                    listaUsosComputadora.Add((UsoComputadora)item);
                }
                 
            }

            listaUsosComputadora.Sort(CompararTiempoDeUsoComputadora);
            sb.AppendLine("Lista de computadoras ordenadas por minutos de uso de forma descendente\n");
            foreach (UsoComputadora item in listaUsosComputadora)
            {
                sb.AppendLine(item.ToString());
                sb.AppendLine("-----------------------------");
            }

            return sb.ToString();
        }


        /// <summary>
        /// Metodo que ordena dos usos de cabina segun su tiempo de duracion
        /// </summary>
        /// <param name="uso1"></param>
        /// <param name="uso2"></param>
        /// <returns></returns>
        private int CompararTiempoDeUsoCabina(UsoCabina uso1, UsoCabina uso2)
        {
            int minutosUso1 = (int)uso1.UsoEnMinutosTotales;
            int minutosUso2 = (int)uso2.UsoEnMinutosTotales;

            return minutosUso1 - minutosUso2;
        }

        /// <summary>
        /// Metodo que ordena los usos de cabina segun su tiempo de duracion
        /// </summary>
        /// <returns>devuelve la Lista de cabinas ordenadas por minutos de uso de forma descendente.</returns>
        public string OrdenarUsosCabinaPorTiempoDeUso()
        {
            List<UsoCabina> listaUsosCabina = new List<UsoCabina>();
            StringBuilder sb = new StringBuilder();

            foreach (Uso item in this.listaDeUsos)
            {
                if (item is UsoCabina)
                {
                    listaUsosCabina.Add((UsoCabina)item);
                }

            }

            listaUsosCabina.Sort(CompararTiempoDeUsoCabina);
            sb.AppendLine("Lista de cabinas ordenadas por minutos de uso de forma descendente\n");
            foreach(UsoCabina item in listaUsosCabina)
            {
                sb.AppendLine(item.ToString());
                sb.AppendLine("-----------------------------");
            }

            return sb.ToString();
        }



        /// <summary>
        /// metodo que calcula las ganancias totales del ciber y las ganancias segun el tipo de servicio
        /// </summary>
        /// <returns>Devuelve Ganancias totales y clasificadas por servicio(teléfono/computadora).</returns>
        public string CalcularGananciasTotalesYPorServicio()
        {
            decimal gananciasTotales=0;
            decimal gananciasComputadora = 0;
            decimal gananciasCabina = 0;
            StringBuilder sb = new StringBuilder();

            foreach (Uso item in this.listaDeUsos)
            {
                gananciasTotales += item.CostoNeto;
                if (item is UsoComputadora)
                {
                    gananciasComputadora += item.CostoNeto;
                }
                else if (item is UsoCabina)
                {
                    gananciasCabina += item.CostoNeto;
                }
            }
            sb.AppendLine(" ************************  Ganancias *************************");
            sb.AppendFormat("Ganancias totales: {0:C2}\n", gananciasTotales);
            sb.AppendLine("**************************************************************");
            sb.AppendFormat("Ganancias uso de cabinas: {0:C2}\n", gananciasCabina);
            sb.AppendFormat("Ganancias uso de computadoras: {0:C2}\n", gananciasComputadora);
            sb.AppendLine("**************************************************************");


            return sb.ToString();
        }



        /// <summary>
        /// metodo que clacula las cantidad total de horas de llamadas que se realizaron en el ciber y cuanto recaudo
        /// segun el tipo de llamada
        /// </summary>
        /// <returns>Devuelve las horas totales y la recaudación por tipo de llamada.</returns>
        public string CalcularHorasTotalesLlamadasYRecaudacionPorTipo()
        {
            double minutosLlamadas = 0;
            double horasTotales;
            decimal gananciasLocal = 0;
            decimal gananciasInternacional = 0;
            decimal gananciasLargaDistancia = 0;
            StringBuilder sb = new StringBuilder();

            UsoCabina usoAux;

            foreach (Uso item in this.listaDeUsos)
            {
                if (item is UsoCabina)
                {
                    minutosLlamadas += item.UsoEnMinutosTotales;
                    usoAux = (UsoCabina)item;
                    if(usoAux.TipoDeLlamada == UsoCabina.TipoLlamada.Local)
                    {
                        gananciasLocal += item.CostoNeto;
                    }
                    else if(usoAux.TipoDeLlamada == UsoCabina.TipoLlamada.LargaDistancia)
                    {
                        gananciasLargaDistancia += item.CostoNeto;
                    }
                    else if(usoAux.TipoDeLlamada == UsoCabina.TipoLlamada.Internacional)
                    {
                        gananciasInternacional += item.CostoNeto;
                    }
                }
            }
            horasTotales = minutosLlamadas / 60;
           
            sb.AppendLine("**** Horas totales y la recaudación por tipo de llamada ****\n");
            
            if (horasTotales==1)
            {
                sb.AppendLine($"Tiempo total de llamadas: 1 hora");
            }
            else
            {
                sb.AppendFormat("Tiempo total de llamadas: {0:N2} horas", horasTotales);
            }
            sb.AppendLine("**************************************************************");
            sb.AppendFormat("Ganancias por llamadas locales: {0:C2}\n", gananciasLocal);
            sb.AppendFormat("Ganancias por llamadas de larga distancia: {0:C2}\n", gananciasLargaDistancia);
            sb.AppendFormat("Ganancias por llamadas internacionales: {0:C2}\n", gananciasInternacional);
            sb.AppendLine("**************************************************************");
            

            return sb.ToString();
        }

        //El software más pedido por los clientes.
        //El periférico más pedido por los clientes.
        //El juego más pedido por los clientes.
        /// <summary>
        /// metodo que compara camtidad de repeticiones de un elemento
        /// </summary>
        /// <param name="primerElemento"></param>
        /// <param name="segundoElemento"></param>
        /// <returns>devuelve 1 para ordenar de manera descendente y -1 de manera ascendente </returns>
        private int CompararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            if (primerElemento.Value < segundoElemento.Value)
            {
                return 1;
            }
            if (primerElemento.Value > segundoElemento.Value)
            {
                return -1;
            }
            return 0;
        }
        
        /// <summary>
        /// recorre los clientes atendidos buscando entre lo que utilizaron el elemento mas repetido
        /// </summary>
        /// <param name="inicial">Recibe la inicial del tipo de requerimiento para poder filtrar el tipo de elemento</param>
        /// <returns>Muestra el requerimiento más pedido o los más pedidos si hay empate</returns>
        public string BuscarRequerimientoMasPedido(char inicial)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = false;
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            foreach (Cliente cliente in this.listaClientesAtendidos)
            {
                foreach (KeyValuePair<string,string> item in cliente.Requerimientos)
                {
                    if(item.Key[0] == Char.ToUpper(inicial))
                    {
                        if (diccionario.ContainsKey(item.Value))
                        {
                            diccionario[item.Value]++;
                        }
                        else
                        {
                            diccionario.Add(item.Value, 1);
                        }
                    }
                    
                }
            }

            List<KeyValuePair<string, int>> podio = diccionario.ToList();
            podio.Sort(CompararCantidadRepeticiones);
            if(podio.Count>=1)
            {
                sb.AppendLine(podio[0].Key);
                foreach (KeyValuePair<string, int> item in podio)
                {
                    if(!flag)
                    {
                        flag = true;
                    }
                    else
                    {
                        if (item.Value == podio[0].Value)
                        {
                            sb.AppendLine(item.Key);
                       
                        }
                    }
                    
                }
                return sb.ToString();
            }
            return "";

        }

        

        #endregion

    }
}
