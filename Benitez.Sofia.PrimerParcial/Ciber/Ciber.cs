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
        private List<Servicios> listaServicios;
        private string nombreUsuario;
        private DateTime fechaYHora;
        /// <summary>
        /// constructor que instancia las listas 
        /// </summary>
        private Ciber()
        {
            this.listaClientes = new List<Cliente>();
            this.listaServicios = new List<Servicios>();
            this.listaDeUsos = new List<Uso>();
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

        public string Usuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }

        public string Fecha
        {
            get
            {
                return this.fechaYHora.ToShortDateString();
            }
        }

        public List<Cliente> ListaDeClientes
        {
            get
            {
                return listaClientes;
            }
        }

        public List<Servicios> ListaDeServicios
        {
            get
            {
                return listaServicios;
            }
        }
        public List<Uso> ListaDeUsos
        {
            get
            {
                return listaDeUsos;
            }
        }

        /// <summary>
        /// indexador para acceder al servicio correspondiente de la lista de servicios
        /// </summary>
        /// <param name="index">string con la inicial del cervicio y el numero</param>
        /// <returns></returns>
        public Servicios this[string index]
        { 
            get
            {

                foreach (Servicios item in this.listaServicios)
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
                foreach (Servicios item in this.listaServicios)
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
        /// metodo estatico que devuelve el tipo de llamada segun el prefijo y el codigo que recibe
        /// </summary>
        /// <param name="codigoPais"></param>
        /// <param name="prefijo"></param>
        /// <returns></returns>
        public static UsoLlamada.TipoLlamada ObtenerTipoLlamada(string numero)
        {
            UsoLlamada.TipoLlamada tipo = UsoLlamada.TipoLlamada.LargaDistancia;

            if ((numero[0]=='5' && numero[1] == '4' && numero[2] == '0' && numero[3] == '1' && numero[4] == '1')
                || (numero[0] == '5' && numero[1] == '4' && numero[2] == '1' && numero[3] == '1' ))
            {
                tipo = UsoLlamada.TipoLlamada.Local;
            }
            else if (numero[0] != '5' && numero[1] != '4')
            {
                tipo = UsoLlamada.TipoLlamada.Internacional;
            }


            return tipo;
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
        /// metodo que instancia un nuevo uso de computadora sin tiempo de finalizacion. remueve al cliente de la lista de espera y agrega el uso a la lista de usos del ciber 
        /// </summary>
        /// <param name="computadora">computadora que se pasara por referencia en el uso nuevo</param>
        /// <param name="cliente">cliente que se pasara por referencia en el uso nuevo</param>
        /// <returns></returns>
        public UsoComputadora AsignarComputadoraLibre(Computadora computadora, Cliente cliente)
        {
            if(computadora is not null && computadora.Estado==true)
            {
                computadora.Estado = false;
                UsoComputadora uso = new UsoComputadora(DateTime.Now, cliente, computadora);
                this.listaClientes.Remove(cliente);
                this.listaDeUsos.Add(uso);
                computadora.UsoActual = uso;
                return uso;
            }
            return null;
        }

        /// <summary>
        /// sobrecarga de AsignarComputadora para que reciba el tiempo seleccionado de uso que viene desde el form de computadoras
        /// </summary>
        /// <param name="computadora"></param>
        /// <param name="cliente"></param>
        /// <param name="tiempoSeleccionado"></param>
        /// <returns></returns>
        public UsoComputadora AsignarComputadoraPorTiempo(Computadora computadora, Cliente cliente, double tiempoSeleccionado)
        {
            DateTime tiempoInicio = DateTime.Now;
            UsoComputadora uso = new UsoComputadora(tiempoInicio, cliente, computadora);
            computadora.UsoActual = uso;
            computadora.UsoActual.TiempoFinalizacion = tiempoInicio.AddSeconds(tiempoSeleccionado);
            computadora.Estado = false;
            
            
            this.listaClientes.Remove(cliente);
            this.listaDeUsos.Add(uso);
            return uso;
        }

        
        

        /// <summary>
        /// muestra los datos de los usos de la lista
        /// </summary>
        /// <returns></returns>
        public string MostrarUsos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Uso item in this.listaDeUsos)
            {
                sb.AppendLine(item.Mostrar());
                sb.AppendLine("--------------------------");
            }
            return sb.ToString();
        }

     

        /// <summary>
        /// metodo que instancia un nuevo uso de computadora sin tiempo de finalizacion. remueve al cliente de la lista de espera y agrega el uso a la lista de usos del ciber 
        /// </summary>
        /// <param name="computadora">computadora que se pasara por referencia en el uso nuevo</param>
        /// <param name="cliente">cliente que se pasara por referencia en el uso nuevo</param>
        /// <returns></returns>
        public UsoLlamada AsignarCabina(Cabina cabina, Cliente cliente, string numero)
        {
            if(cabina is not null && cabina.Estado==true)
            {
                cabina.Estado = false;
                UsoLlamada.TipoLlamada tipo = ObtenerTipoLlamada(numero);
                UsoLlamada uso = new UsoLlamada(DateTime.Now, numero, tipo, cliente, cabina);
                cabina.UsoActual = uso;
                this.listaClientes.Remove(cliente);
                this.listaDeUsos.Add(uso);
                return uso;
            }
            return null;
            
        }

    }
}
