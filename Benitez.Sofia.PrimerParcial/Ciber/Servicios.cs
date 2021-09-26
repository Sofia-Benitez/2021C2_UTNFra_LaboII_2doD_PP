using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public abstract class Servicios
    {
        
        protected int id;
        protected bool estado;
        public enum TipoServicio { Cabina, Computadora }

        public Servicios(int id, bool estado)
        {
            
            this.id = id;
            this.estado = estado;
        }
        
        public abstract int Id
        {
            get;
        }
        public abstract  bool Estado
        {
            get; set;
        }

        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            

            return sb.ToString();
        }
    }
}
