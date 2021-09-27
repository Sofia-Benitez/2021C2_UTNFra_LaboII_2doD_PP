using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public sealed class Ciber
    {
        private Queue<Cliente> listaClientes;
        private List<UsoServicio> listaDeUsos;
        private List<Servicios> listaServicios;
        private string nombreUsuario;
        private DateTime fechaActual;

        public Ciber(string usuario, DateTime fecha)
        {
            Queue<Cliente> listaClientes = new Queue<Cliente>();
            this.nombreUsuario = usuario;
            this.fechaActual = fecha;
        }

        public string Usuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }

        public static TipoLlamada ObtenerTipoLlamada(string codigoPais, string prefijo)
        {
            TipoLlamada tipo = TipoLlamada.LargaDistancia;

            if (codigoPais != "54")
            {
                tipo = TipoLlamada.Internacional;
            }
            else if (prefijo == "011" || prefijo == "11")// y 54
            {
                tipo = TipoLlamada.Local;
            }


            return tipo;
        }

        public static double CalcularCosto(UsoServicio servicio)
        {
            
            if(servicio.TiempoFinalizacion  != DateTime.MinValue)
            {
                return ((servicio.TiempoInicio - servicio.TiempoFinalizacion).TotalSeconds) * servicio.Costo;
            }
            return 0;
        }

       
    }
}
