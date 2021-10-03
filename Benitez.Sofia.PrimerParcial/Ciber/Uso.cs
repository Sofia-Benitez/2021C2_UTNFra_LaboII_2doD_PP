using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class Uso
    {
        protected DateTime tiempoInicio;
        protected DateTime tiempoFinalizacion;
        

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

        public Uso(DateTime tiempoInicio)
        {
            this.tiempoInicio = tiempoInicio;
            
        }
        public Uso(DateTime tiempoInicio, DateTime tiempoFinalizacion):this(tiempoInicio)
        {
            this.tiempoFinalizacion = tiempoFinalizacion;
        }

        

        //mostrar

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Inicio del servicio: {this.HoraInicio}");
            sb.AppendLine($"Finalizacion del servicio: {this.HoraFinalizacion}");
            


            return sb.ToString();
        }
    }
}
