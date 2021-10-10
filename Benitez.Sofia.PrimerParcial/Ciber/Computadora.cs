using System;
using System.Collections.Generic;
using System.Text;

namespace CiberCafe
{
    public class Computadora : Servicio
    {
        private Dictionary<string, string> caracteristicas;
        private UsoComputadora usoActual;
        private string memoriaRam;
        private string procesador;
        private bool placaVideo;

        /// <summary>
        /// constructor de una computadora. Instancia un diaccionario para las caracteristicas
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="estado">estado de la computadora (en uso o libre)</param>
        public Computadora(string id, bool estado, string memoria, string procesador, bool placaDeVideo):base(id, estado)
        {
            this.memoriaRam = memoria;
            this.procesador = procesador;
            this.placaVideo = placaDeVideo;
            this.caracteristicas = new Dictionary<string, string>();
             
        }

        /// <summary>
        /// propiedad id, solo lectura
        /// </summary>
        public override string Id
        {
            get
            {
                return this.id;
            }
        }
        
        /// <summary>
        /// propiedad estado. permite leerlo y setearlo
        /// </summary>
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

        /// <summary>
        /// Propiedad Caracteristicas permite acceder al diccionario de caracteristicas del equipo
        /// </summary>
        public Dictionary<string, string> Caracteristicas
        {
            get
            {
                return this.caracteristicas;
            }

        }

        /// <summary>
        /// Propiedad UsoActual permite leer o setear el uso de la computadora en el momento, si no esta siendo utilizada devuelve null
        /// </summary>
        public UsoComputadora UsoActual
        {
            get
            {
                return this.usoActual;
            }

            set
            {
                this.usoActual = value;
            }
        }

        /// <summary>
        /// agrega al diccionary de caracteristicas una clave y un valor que recibe por parametros. 
        /// si la computadora ya tiene esa caracteristica no la agrega
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <return> devuelve true si se agrego la caracteristica y false si no se agrego</return>
        public bool AgregarCaracteristica(string key, string value)
        {
            foreach (KeyValuePair<string, string> caracteristica in this.caracteristicas)
            {
                if(this.caracteristicas.ContainsKey(key))
                {
                    return false;
                }
            }
            this.caracteristicas.Add(key, value);
            return true;
        }




        /// <summary>
        /// muestra los datos de la computadora incluyendo los de la clase base 
        /// </summary>
        /// <returns>devuelve los datos</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Ram: {this.memoriaRam}");
            sb.AppendLine($"Procesador: {this.procesador}");
            if(this.placaVideo)
            {
                sb.AppendLine("Placa de video");
            }
            sb.AppendLine("-------------------");
            if(this.caracteristicas is not null)
            {
                foreach (KeyValuePair<string, string> item in this.caracteristicas)
                {
                    sb.AppendLine($"{item.Value} ");
                }
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


        /// <summary>
        /// libera la computadora y determina el tiempo de finalizacion
        /// </summary>
        /// <returns>devuelve una cadena con los datos del uso</returns>
        public string LiberarComputadora()
        {
            this.Estado = true;
            this.UsoActual.TiempoFinalizacion = DateTime.Now;
            string aux = this.usoActual.Mostrar();
            this.UsoActual = null;

            return aux;
        }




    }
}
