using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class Cabina : Servicios
    {
        
        private string marca;
        private Tipo tipo;
        public enum Tipo { Disco, Teclado};
        private UsoLlamada usoActual;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="estado"></param>
        public Cabina(string id, string marca, Tipo tipo, bool estado):base(id, estado)
        {
            this.marca = marca;
            this.tipo = tipo;
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
        public UsoLlamada UsoActual
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
        /// muestra los datos de la clase llamando a la clase base 
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Tipo: {this.tipo}");
            sb.AppendLine($"Marca: {this.marca}");
            

            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo ToString() para mostrar los datos de la clase 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// libera el uso de una cabina, setea su tiempo de finalizacion
        /// </summary>
        /// <returns>devuelve </returns>
        public string LiberarCabina()
        {
            this.Estado = true;
            this.UsoActual.TiempoFinalizacion = DateTime.Now;
            string aux = this.usoActual.Mostrar();
            this.UsoActual = null;

            return aux;
        }

        
    }
}
