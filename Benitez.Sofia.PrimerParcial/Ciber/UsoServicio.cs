using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public abstract class UsoServicio
    {
        protected DateTime tiempoInicio;//ver si es datetime
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
    }
}
