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

        public DateTime TiempoAhora
        {
            get
            {
                return this.fechaYHora;
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
        /// <param name="index"></param>
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

        

        //public static bool operator ==(Ciber ciber, Servicios servicio)
        //{
        //    foreach (Servicios item in ciber.listaServicios)
        //    {
        //        if(servicio.Id == item.Id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public static bool operator !=(Ciber ciber, Servicios servicio)
        //{
        //    return !(ciber == servicio);
        //}

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
        public UsoComputadora AsignarComputadora(Computadora computadora, Cliente cliente)
        {
            if(computadora is not null && computadora.Estado==true)
            {
                computadora.Estado = false;
                UsoComputadora uso = new UsoComputadora(DateTime.Now, cliente, computadora);
                this.listaClientes.Remove(cliente);
                this.listaDeUsos.Add(uso);
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
        public UsoComputadora AsignarComputadora(Computadora computadora, Cliente cliente, double tiempoSeleccionado)
        {
            DateTime tiempoFinalizacion = DateTime.Now.AddSeconds(tiempoSeleccionado);
            computadora.Estado = false;//VER ACA EL ERROR EN EJECUCION  
            UsoComputadora uso = new UsoComputadora(DateTime.Now, tiempoFinalizacion, cliente, computadora);
            this.listaClientes.Remove(cliente);
            this.listaDeUsos.Add(uso);
            return uso;
        }

        //unificar las funciones de liberar
        /// <summary>
        /// libera la computadora y determina el tiempo de finalizacion
        /// </summary>
        /// <param name="uso"></param>
        public void LiberarComputadora(UsoComputadora uso)
        {
            uso.Computadora.Estado = true;
            uso.TiempoFinalizacion = DateTime.Now;
        }

        public void LiberarCabina(UsoLlamada uso)
        {
            uso.Cabina.Estado = true;
            uso.TiempoFinalizacion = DateTime.Now;
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
        /// busca entre los usos de la lista al que involucre la computadora que recibe. si hay alguno lo devuelve \
        /// AGREGAR SI EL ESTADO ES OCUPADO PARA CUANDO HAYA MAS DE DOS USOS 
        /// </summary>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public UsoComputadora BuscarUsoPorComputadora(Computadora computadora)
        {

            UsoComputadora usoAux = null;
            foreach (Uso item in this.ListaDeUsos)
            {
                if(item is UsoComputadora)
                {
                    usoAux = (UsoComputadora)item;
                    if (usoAux.Computadora == computadora)
                    {
                        usoAux = (UsoComputadora)item;
                    }
                    else
                    {
                        usoAux = null;
                    }
                }
                
            }
            return usoAux;
        }

        /// <summary>
        ///busca entre los usos de la lista al que involucre la cabina que recibe. 
        ///si hay alguno lo devuelve 
        /// </summary>
        /// <param name="cabina"></param>
        /// <returns></returns>
        public UsoLlamada BuscarUsoPorCabina(Cabina cabina)
        {
            UsoLlamada usoAux = null;
            foreach (Uso item in this.ListaDeUsos)
            {
                if(item is UsoLlamada)
                {
                    usoAux = (UsoLlamada)item;
                    if (usoAux.Cabina == cabina)
                    {
                         usoAux = (UsoLlamada)item;
                    }
                    else
                    {
                        usoAux = null;
                    }
                   
                }
                
            }
            return usoAux;
        }

        /// <summary>
        /// busca entre los usos alguno cuyo tiempo de finalizacion sea anterior al tiempo actual   TODAVIA NO FUNCIONA
        /// </summary>
        /// <returns></returns>
        public UsoComputadora BuscarUsoFinalizado()
        {
            foreach (Uso item in this.listaDeUsos)
            {
                if(item.TiempoFinalizacion<DateTime.Now)
                {
                    return (UsoComputadora)item;
                }
            }
            return null;
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
                this.listaClientes.Remove(cliente);
                this.listaDeUsos.Add(uso);
                return uso;
            }
            return null;
            
        }

    }
}
