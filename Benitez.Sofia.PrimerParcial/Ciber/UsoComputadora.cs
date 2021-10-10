using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoComputadora : Uso
    {
        
        private Computadora computadora;
        private static double costoFraccion = 0.5;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        public UsoComputadora(DateTime tiempoInicio, Cliente cliente, Computadora computadora):base(tiempoInicio, cliente)
        {
            
            this.computadora = computadora;
        }

        /// <summary>
        /// sobrecarga del constructor con tiempo de finalizacion
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="tiempoFinalizacion"></param>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        public UsoComputadora(DateTime tiempoInicio, DateTime tiempoFinalizacion, Cliente cliente, Computadora computadora) : this(tiempoInicio, cliente, computadora)
        {
            this.tiempoFinalizacion = tiempoFinalizacion;
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
        /// calcula el costo total del uso del servicio
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularCosto()
        {
            decimal costoTotal = 0;

            if (this.TiempoFinalizacion != DateTime.MinValue)
            {

                costoTotal= (decimal)(Math.Ceiling(this.UsoEnMinutosTotales / 30) * costoFraccion);
                
                
            }
            return costoTotal;
        }

        /// <summary>
        /// agrega el iva al costo total
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularCostoNeto()
        {
           return  this.CostoBruto * IVA;
        }

        /// <summary>
        /// muestra los datos
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Computadora: {this.computadora.Id}");
            sb.AppendLine($"Costo media hora: ${costoFraccion}");
            sb.AppendLine(base.Mostrar());


            return sb.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo ToString() para devolver los datos del uso
        /// </summary>
        /// <returns>devuelve los datos del uso del Metodo mstrar()</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
