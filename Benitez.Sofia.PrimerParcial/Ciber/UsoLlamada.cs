using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoLlamada : Uso
    {

        private string prefijo;
        private string codigoPais;
        private string numero;
        protected TipoLlamada tipoDeLlamada;
        private double costoMinuto;
        private Cabina cabina;

        //constructor 
        public UsoLlamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, TipoLlamada tipoDeLlamada, Cliente cliente, Cabina cabina) : base(tiempoInicio, cliente)
        {
            this.prefijo = prefijo;
            this.codigoPais = codigoPais;
            this.numero = numero;
            this.costoMinuto = this.CostoPorTipo();
            this.tipoDeLlamada = tipoDeLlamada;
            this.cabina = cabina;
        }
        /// <summary>
        /// sobrecarga del cosntructor con tiempo de finalizacion de la llamada
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="prefijo"></param>
        /// <param name="codigoPais"></param>
        /// <param name="numero"></param>
        /// <param name="tiempoFinalizacion"></param>
        public UsoLlamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, DateTime tiempoFinalizacion, TipoLlamada tipoDeLlamada, Cliente cliente, Cabina cabina) : this(tiempoInicio, prefijo, codigoPais, numero, tipoDeLlamada, cliente, cabina)
        {

        }

        /// <summary>
        /// devuelve el costo correspondiente al tipo de llamada
        /// </summary>
        /// <returns></returns>
        public double CostoPorTipo()
        {
            double costo = 0;

            if (this.tipoDeLlamada == TipoLlamada.Internacional)
            {
                costo = 5;
            }
            else if (this.tipoDeLlamada == TipoLlamada.LargaDistancia)
            {
                costo = 2.5;
            }
            else
            {
                costo = 1;
            }

            return costo;
        }

   

        public string Numero
        {
            get
            {
                return this.codigoPais + this.prefijo + this.numero;
            }
        }


        public Cabina Cabina
        {
            get
            {
                return this.cabina;
            }
        }

        /// <summary>
        /// muestra los datos de la llamada
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Tipo de llamada: {this.tipoDeLlamada}");

            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo ToString para mostrar los datos de la llamada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        ///costo
        ///((this.tiempoFinalizacion-this.tiempoInicio).Seconds) * this.costoFraccion
    }
}
