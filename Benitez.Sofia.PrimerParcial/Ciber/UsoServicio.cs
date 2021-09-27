using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class UsoServicio
    {
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinalizacion;
        protected double costo;
        
        

        public abstract DateTime TiempoInicio { get; }
        public abstract DateTime TiempoFinalizacion { get; }

        public abstract double Costo { get; set; }

        public UsoServicio(DateTime tiempoInicio)
        {
            this.tiempoInicio = tiempoInicio;
            
        }
        public UsoServicio(DateTime tiempoInicio, DateTime tiempoFinalizacion):this(tiempoInicio)
        {
            this.tiempoFinalizacion = tiempoFinalizacion;
        }

        //mostrar

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Inicio del servicio: {this.TiempoInicio}");
            sb.AppendLine($"Finalizacion del servicio: {this.TiempoFinalizacion}");
            sb.AppendLine($"Costo por minuto: ${this.Costo}");

            return sb.ToString();
        }
    }
}
