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

        //constructor 
        public UsoLlamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, TipoLlamada tipoDeLlamada) : base(tiempoInicio)
        {
            this.prefijo = prefijo;
            this.codigoPais = codigoPais;
            this.numero = numero;
            this.costoMinuto = this.CostoPorTipo();
            this.tipoDeLlamada = tipoDeLlamada;
        }
        /// <summary>
        /// sobrecarga del cosntructor con tiempo de finalizacion de la llamada
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="prefijo"></param>
        /// <param name="codigoPais"></param>
        /// <param name="numero"></param>
        /// <param name="tiempoFinalizacion"></param>
        public UsoLlamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, DateTime tiempoFinalizacion, TipoLlamada tipoDeLlamada) : this(tiempoInicio, prefijo, codigoPais, numero, tipoDeLlamada)
        {

        }

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

        //public override double Costo
        //{
        //    get 
        //    {
        //        return this.costoMinuto;
        //    }

        //    set
        //    {
        //        this.costoMinuto = value;
        //    }
        //}

        public string Numero
        {
            get
            {
                return this.codigoPais + this.prefijo + this.numero;
            }
        }
      
        

        
        //mostrar
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Tipo de llamada: {this.tipoDeLlamada}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
