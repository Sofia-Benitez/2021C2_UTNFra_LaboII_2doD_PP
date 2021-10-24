using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class Impresora : Servicio
    {
        private string marca;
        private bool imprimeColor;
        private static double precioCopiaByN = 0.5;
        private static double precioCopiaColor = 1;

           
        
        /// <summary>
        /// constructor de impresora
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estado"></param>
        /// <param name="marca"></param>
        /// <param name="imprimeColor"></param>
        public Impresora(string id, bool estado, string marca, bool imprimeColor):base(id, estado)
        {
            this.marca = marca;
            this.imprimeColor = imprimeColor;
         
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

        /// <summary>
        /// metodo que devuelve un string con los datos de la impresora
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append($" Marca: {this.marca}  ");
            if(imprimeColor)
            {
                sb.Append("Imprime color");
            }
            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo ToString() para mostrar los datos de la impresora
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// sobrecarga del operador == para comparar una impresora con un cliente y ver si lo que necesita el cliente se puede realizar en la impresora
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="impresora"></param>
        /// <returns>devuelve true si el cliente quiere imprimir a color y la imrpesora lo permite y si el cliente quiere imprimir en blanco y negro</returns>
        public static bool operator ==(Cliente cliente, Impresora impresora)
        {
            if(cliente.NecesitaImprimirAColor)
            {
                if(impresora.imprimeColor)
                {
                    return true;
                }
                return false;
            }
            return true;
            
        }

        /// <summary>
        /// sobrecarga del operador !=
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="impresora"></param>
        /// <returns>devuelve true si la impresora no cumple ocn el requsito del cliente de imprimir a color</returns>
        public static bool operator !=(Cliente cliente, Impresora impresora)
        {
            return !(cliente == impresora);
        }

        public override bool Equals(object obj)
        {
            Impresora impresora = obj as Impresora;

            return impresora is not null && this == impresora;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public static double CalcularCosto(int cantidadCopias, string tipo)
        {
            double costo;
            if(tipo == "Color")
            {
                costo= cantidadCopias * precioCopiaColor;
            }
            else
            {
                costo = cantidadCopias * precioCopiaByN;
            }

            return costo;
        }
    }
}
