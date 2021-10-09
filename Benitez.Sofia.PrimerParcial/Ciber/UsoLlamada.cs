using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoLlamada : Uso
    {

        private string numero;
        protected TipoLlamada tipoDeLlamada;
        private Cabina cabina;
        public enum TipoLlamada { Local, LargaDistancia, Internacional };

        //constructor 
        public UsoLlamada(DateTime tiempoInicio, string numero, TipoLlamada tipoDeLlamada, Cliente cliente, Cabina cabina) : base(tiempoInicio, cliente)
        {
            
            this.numero = numero;
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
        public UsoLlamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, DateTime tiempoFinalizacion, TipoLlamada tipoDeLlamada, Cliente cliente, Cabina cabina) : this(tiempoInicio, numero, tipoDeLlamada, cliente, cabina)
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
                return this.numero;
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
        /// propiedad que devuelve lo que retorna el metodo CalcularCosto
        /// </summary>
        public double CostoBruto
        {
            get
            {
                return CalcularCosto();
            }
        }

        /// <summary>
        /// propiedad que devuelve lo que retorna CalcularCostoNeto
        /// </summary>
        public double CostoNeto
        {
            get
            {
                return CalcularCostoNeto();
            }
        }

        public override double CalcularCosto()
        {
            double horasAminutos = this.TiempoDeUsoHoras * 60;
            return (this.TiempoDeUsoMinutos + horasAminutos) * this.CostoPorTipo();
        }

        public override double CalcularCostoNeto()
        {
            return this.CostoBruto * IVA;
        }

        /// <summary>
        /// muestra los datos de la llamada
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Cabina: {this.cabina}");
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Tipo de llamada: {this.tipoDeLlamada}");
            sb.AppendLine($"Costo minuto: ${this.CostoPorTipo()}");
            sb.AppendLine($"Costo bruto: ${this.CostoBruto}");
            sb.AppendLine($"Costo neto: ${this.CostoNeto}");

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

        /// <summary>
        /// metodo estatico que devuelve el tipo de llamada segun el prefijo y el codigo que recibe
        /// </summary>
        /// <param name="codigoPais"></param>
        /// <param name="prefijo"></param>
        /// <returns></returns>
        public static UsoLlamada.TipoLlamada ObtenerTipoLlamada(string numero)
        {
            UsoLlamada.TipoLlamada tipo = UsoLlamada.TipoLlamada.LargaDistancia;

            if ((numero[0] == '5' && numero[1] == '4' && numero[2] == '0' && numero[3] == '1' && numero[4] == '1')
                || (numero[0] == '5' && numero[1] == '4' && numero[2] == '1' && numero[3] == '1'))
            {
                tipo = UsoLlamada.TipoLlamada.Local;
            }
            else if (numero[0] != '5' && numero[1] != '4')
            {
                tipo = UsoLlamada.TipoLlamada.Internacional;
            }


            return tipo;
        }
    }


}
