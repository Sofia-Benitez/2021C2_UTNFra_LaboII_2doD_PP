using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class Servicios
    {
        
        protected string id;
        protected bool estado;
        public enum TipoServicio { Cabina, Computadora }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado">true libre / false en uso</param>
        public Servicios(string id, bool estado)
        {
            
            this.id = id;
            this.estado = estado;
        }
        
        public abstract string Id
        {
            get;
        }

        /// <summary>
        /// true: libre   false: en uso
        /// </summary>
        public abstract  bool Estado
        {
            get; set;
        }

        /// <summary>
        /// muestra los datos de la clase base
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            if(this.estado)
            {
                sb.AppendLine($"Estado: disponible");
            }
            else
            {
                sb.AppendLine($"Estado: en uso");
            }
            

            return sb.ToString();
        }

    }
}
