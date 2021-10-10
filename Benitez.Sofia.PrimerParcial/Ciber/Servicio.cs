using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public abstract class Servicio
    {
        
        protected string id;
        protected bool estado;
        

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado">true libre / false en uso</param>
        public Servicio(string id, bool estado)
        {
            
            this.id = id;
            this.estado = estado;
        }
        
        /// <summary>
        /// Propiedad abstracta ID
        /// </summary>
        public abstract string Id
        {
            get;
        }

        /// <summary>
        /// Propiedad abstracta Estado: true: libre   false: en uso
        /// </summary>
        public abstract  bool Estado
        {
            get; set;
        }

        /// <summary>
        /// muestra los datos de la clase base, el id y el estado que corresponda
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
