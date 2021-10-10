using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class Uso
    {
        protected Cliente cliente;
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinalizacion;
        protected static decimal IVA = 1.21M;

        
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
        
       /// <summary>
       /// Propiedad tiempo de finalización. permite leer y setear el valor en el momento que finaliza un servicio.
       /// </summary>
        public virtual DateTime TiempoFinalizacion
        {
            get
            {
                return this.tiempoFinalizacion;
            }
            set
            {
                if(value>this.tiempoInicio)
                {
                    this.tiempoFinalizacion = value;
                }
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

        /// <summary>
        /// Propiedad que permite ver cuantos tiempo se utilizó un servicio en minutos
        /// </summary>
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

        public abstract decimal CostoNeto { get; }
        public abstract decimal CostoBruto { get; }

        public abstract decimal CalcularCosto();

        public abstract decimal CalcularCostoNeto();

        



        /// <summary>
        /// muestra los datos de la clase
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {this.cliente.Nombre}");
            sb.AppendLine($"Inicio del servicio: {this.tiempoInicio.ToLongTimeString()}");
            sb.AppendLine($"Finalizacion del servicio: {this.tiempoFinalizacion.ToLongTimeString()}");
            sb.AppendLine($"Tiempo de uso: {this.TiempoDeUsoHoras} horas {this.TiempoDeUsoMinutos} minutos");
            sb.AppendFormat("Costo bruto: {0:C2}\n", this.CostoBruto);
            sb.AppendFormat("Costo neto: {0:C2}", this.CostoNeto);

            return sb.ToString();
        }
    }
}
