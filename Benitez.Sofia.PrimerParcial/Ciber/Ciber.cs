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

        private Ciber()
        {
            this.listaClientes = new List<Cliente>();
            this.listaServicios = new List<Servicios>();
            this.listaDeUsos = new List<Uso>();
        }
        public Ciber(string usuario):this()
        {
            this.nombreUsuario = usuario;
            
        }

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

            //set
            //{

            //    listaServicios[index] = value;
            //}
        }

        public static TipoLlamada ObtenerTipoLlamada(string codigoPais, string prefijo)
        {
            TipoLlamada tipo = TipoLlamada.LargaDistancia;

            if (codigoPais != "54")
            {
                tipo = TipoLlamada.Internacional;
            }
            else if (codigoPais=="54" && (prefijo == "011" || prefijo == "11"))
            {
                tipo = TipoLlamada.Local;
            }


            return tipo;
        }

        

        public static bool operator ==(Ciber ciber, Servicios servicio)
        {
            foreach (Servicios item in ciber.listaServicios)
            {
                if(servicio.Id == item.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Ciber ciber, Servicios servicio)
        {
            return !(ciber == servicio);
        }

        public static Ciber operator +(Ciber ciber, Servicios servicio)
        {
            //if (ciber.listaServicios is not null)
            //{
                foreach (Servicios item in ciber.listaServicios)
                {
                    if (item.Id == servicio.Id)
                    {
                        return ciber;
                    }

                }
            //}


            ciber.listaServicios.Add(servicio);
                return ciber;
        }

        public static Ciber operator +(Ciber ciber, Cliente cliente)
        {
            //if (ciber.listaServicios is not null)
            //{
            foreach (Cliente item in ciber.listaClientes)
            {
                if (item.Dni == cliente.Dni)
                {
                    return ciber;
                }

            }
            //}


            ciber.listaClientes.Add(cliente);
            return ciber;
        }

        public static Ciber operator -(Ciber ciber, Cliente cliente)
        {
            //if (ciber.listaServicios is not null)
            //{
            foreach (Cliente item in ciber.listaClientes)
            {
                if (item.Dni == cliente.Dni)
                {
                    ciber.listaClientes.Remove(item);
                }

            }
            //}


            
            return ciber;
        }

        public UsoComputadora AsignarComputadora(Computadora computadora, Cliente cliente)
        {
            computadora.Estado = false;//VER ACA EL ERROR EN EJECUCION  
            UsoComputadora uso = new UsoComputadora(DateTime.Now, cliente, computadora);
            this.listaClientes.Remove(cliente);
            this.listaDeUsos.Add(uso);
            return uso;
        }

        public void LiberarComputadora(UsoComputadora uso)
        {
            uso.Computadora.Estado = true;
            uso.TiempoFinalizacion = DateTime.Now;
        }

        public string MostrarUsos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (UsoComputadora item in this.listaDeUsos)
            {
                sb.AppendLine(item.Mostrar());
                sb.AppendLine("--------------------------");
            }
            return sb.ToString();
        }

    }
}
