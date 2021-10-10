using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoCabina : Uso
    {

        private string numero;
        protected TipoLlamada tipoDeLlamada;
        private Cabina cabina;
        public enum TipoLlamada { Local, LargaDistancia, Internacional };

        //constructor 
        public UsoCabina(DateTime tiempoInicio, string numero, TipoLlamada tipoDeLlamada, Cliente cliente, Cabina cabina) : base(tiempoInicio, cliente)
        {
            
            this.Numero = numero;
            this.tipoDeLlamada = tipoDeLlamada;
            this.cabina = cabina;
        }

        /// <summary>
        /// porpiedad Numero permite leer el numero de telefono al que se llama y asignarlo si es un numero valido
        /// </summary>
        public string Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                if((value.Length > 7 && value.Length <= 15))
                {
                    this.numero = value;
                }
                else
                {
                    this.numero = "";
                }
            }
        }

        /// <summary>
        /// propiedad que permite leer el tipo de llamada realizada
        /// </summary>
        public TipoLlamada TipoDeLlamada
        {
            get
            {
                return this.tipoDeLlamada;
            }
        }

        /// <summary>
        /// propiedad que devuelve lo que retorna el metodo CalcularCosto
        /// </summary>
        public override decimal CostoBruto
        {
            get
            {
                return CalcularCosto();
            }
        }

        /// <summary>
        /// propiedad que devuelve lo que retorna CalcularCostoNeto
        /// </summary>

        public override decimal CostoNeto
        {
            get
            {
                return CalcularCostoNeto();
            }
        }

        /// <summary>
        /// devuelve el costo correspondiente al tipo de llamada
        /// </summary>
        /// <returns></returns>
        public decimal CostoPorTipo()
        {
            decimal costo = 0;

            if (this.tipoDeLlamada == TipoLlamada.Internacional)
            {
                costo = 5M;
            }
            else if (this.tipoDeLlamada == TipoLlamada.LargaDistancia)
            {
                costo = 2.5M;
            }
            else
            {
                costo = 1M;
            }

            return costo;
        }

  
        /// <summary>
        /// Calcula el costo  de la llamada
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularCosto()
        {
            return (decimal)this.UsoEnMinutosTotales * this.CostoPorTipo();
        }

        /// <summary>
        /// agrega el IVA al costo total de la llamada
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularCostoNeto()
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
            
            sb.AppendLine($"Cabina: {this.cabina.Id}");
            sb.AppendLine($"Numero: {this.Numero}");
            sb.AppendLine($"Tipo de llamada: {this.tipoDeLlamada}");
            sb.AppendLine($"Costo minuto: ${this.CostoPorTipo()}");
            sb.AppendLine(base.Mostrar());


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
        /// metodo estatico que devuelve el tipo de llamada segun el prefijo y el codigo del numero que recibe
        /// </summary>
        /// <param name="numero">numero de telefono a evaluar</param>
        /// <returns>Devuelve el enumerado correspondiente al tipo de llamada </returns>
        public static UsoCabina.TipoLlamada ObtenerTipoLlamada(string numero)
        {
            UsoCabina.TipoLlamada tipo = UsoCabina.TipoLlamada.LargaDistancia;

            if ((numero[0] == '5' && numero[1] == '4' && numero[2] == '0' && numero[3] == '1' && numero[4] == '1')
                || (numero[0] == '5' && numero[1] == '4' && numero[2] == '1' && numero[3] == '1'))
            {
                tipo = UsoCabina.TipoLlamada.Local;
            }
            else if (numero[0] != '5' && numero[1] != '4')
            {
                tipo = UsoCabina.TipoLlamada.Internacional;
            }


            return tipo;
        }
    }


}
