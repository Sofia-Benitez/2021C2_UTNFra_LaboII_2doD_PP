using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class Uso
    {
        private Cliente cliente;
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinalizacion;
        protected static double IVA;

        /// <summary>
        /// constructor estatico con el valor del iva
        /// </summary>
        static Uso()
        {
            IVA = 1.21;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="cliente"></param>
        public Uso(DateTime tiempoInicio, Cliente cliente)
        {
            this.tiempoInicio = tiempoInicio;
            this.cliente = cliente;
            this.tiempoFinalizacion = DateTime.MinValue;

        }
        
        public virtual DateTime TiempoInicio
        {
            get
            {
                return this.tiempoInicio;
            }
        }

        public virtual DateTime TiempoFinalizacion
        {
            get
            {
                return this.tiempoFinalizacion;
            }
            set
            {
                this.tiempoFinalizacion = value;
            }
        }

        public virtual string HoraInicio
        {
            get
            {
                return this.tiempoInicio.ToLongTimeString();
            }
        }

        public virtual string HoraFinalizacion
        {
            get
            {
                return this.tiempoFinalizacion.ToLongTimeString();
            }
        }
        /// <summary>
        /// propiedad que devuelve el tiempo de uso en segundos que cuentan como minutos para la aplicacion
        /// </summary>
        public double TiempoDeUsoMinutos
        {
            get
            {
                if (this.TiempoFinalizacion != DateTime.MinValue)
                {
                    return ((this.tiempoFinalizacion - this.tiempoInicio).Seconds);
                }
                return 0;

            }
        }

        /// <summary>
        /// propiedad que devuelve el tiempo de uso en minutos que cuentan como horas para la aplicacion
        /// </summary>
        public double TiempoDeUsoHoras
        {
            get
            {
                if (this.TiempoFinalizacion != DateTime.MinValue)
                {
                    return ((this.tiempoFinalizacion - this.tiempoInicio).Minutes);
                }
                return 0;

            }
        }

        public double UsoEnMinutosTotales
        {
            get
            {
                if (this.TiempoFinalizacion != DateTime.MinValue)
                {
                    return ((this.TiempoDeUsoHoras * 60) + this.TiempoDeUsoMinutos);
                }
                return 0;

            }
        }

        public abstract double CalcularCosto();

        public abstract double CalcularCostoNeto();

        public abstract double CostoNeto { get; }



        /// <summary>
        /// muestra los datos de la clase
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {this.cliente.Nombre}");
            sb.AppendLine($"Inicio del servicio: {this.HoraInicio}");
            sb.AppendLine($"Finalizacion del servicio: {this.HoraFinalizacion}");
            sb.AppendLine($"Tiempo de uso: {this.TiempoDeUsoHoras} horas {this.TiempoDeUsoMinutos} minutos");

            return sb.ToString();
        }
    }
}
