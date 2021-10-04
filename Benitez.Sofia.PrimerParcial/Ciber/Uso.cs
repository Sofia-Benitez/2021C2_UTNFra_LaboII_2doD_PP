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

        }
        /// <summary>
        /// sobrecarga de constructor con tiempo de finalizacion
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="tiempoFinalizacion"></param>
        /// <param name="cliente"></param>
        public Uso(DateTime tiempoInicio, DateTime tiempoFinalizacion, Cliente cliente) : this(tiempoInicio, cliente)
        {
            this.tiempoFinalizacion = tiempoFinalizacion;
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
        /// muestra los datos de la clase
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {this.cliente.Nombre}");
            sb.AppendLine($"Inicio del servicio: {this.HoraInicio}");
            sb.AppendLine($"Finalizacion del servicio: {this.HoraFinalizacion}");
            
            return sb.ToString();
        }
    }
}
