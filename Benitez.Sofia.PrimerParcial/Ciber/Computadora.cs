using System;
using System.Collections.Generic;
using System.Text;

namespace CiberCafe
{
    public class Computadora : Servicios
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
        /// agrega al diccionary de caracteristicas una clave y un valor que recibe por parametros
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool AgregarCaracteristica(string key, string value)
        {
            foreach (KeyValuePair<string, string> item in this.caracteristicas)
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
        /// muestra los datos de la clase llamando a la clase base 
        /// </summary>
        /// <returns></returns>
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

        public static bool operator ==(Computadora computadora1, Computadora computadora2)
        {
            return (computadora1.Id == computadora2.Id);
        }

        public static bool operator !=(Computadora computadora1, Computadora computadora2)
        {
            return !(computadora1.Id == computadora2.Id);
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
