using System;
using System.Collections.Generic;
using System.Text;

namespace CiberCafe
{
    public class Computadora : Servicios
    {
        private Dictionary<string, string> caracteristicas;
        
        
        /// <summary>
        /// constructor de una computadora. Instancia un diaccionario para las caracteristicas
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="estado">estado de la computadora (en uso o libre)</param>
        public Computadora(string id, bool estado):base(id, estado)
        {

            this.caracteristicas = new Dictionary<string, string>();
             
        }

        
        public override string Id
        {
            get
            {
                return this.id;
            }
        }
        

        public override bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }


        public Dictionary<string, string> Caracteristicas
        {
            get
            {
                return this.caracteristicas;
            }

        }

        /// <summary>
        /// agrega al diccionary de caracteristicas una clave y un valor que recibe por parametros
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AgregarCaracteristica(string key, string value)
        {
            this.caracteristicas.Add(key, value);
        }




        /// <summary>
        /// muestra los datos de la clase llamando a la clase base 
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            foreach(KeyValuePair <string, string> item in this.Caracteristicas)
            {
                sb.AppendLine($"{item.Value} ");
            }

            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo ToString(). devuelve los datos de la clase 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        

       



    }
}
