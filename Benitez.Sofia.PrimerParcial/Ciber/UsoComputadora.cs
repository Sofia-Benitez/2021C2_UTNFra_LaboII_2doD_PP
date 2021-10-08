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
        protected double costoFraccion;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="tiempoInicio"></param>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        public UsoComputadora(DateTime tiempoInicio, Cliente cliente, Computadora computadora):base(tiempoInicio, cliente)
        {
            
            this.computadora = computadora;
            this.costoFraccion = 0.5F;
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

        }

        public double Costo 
        {
            get
            {
                return this.costoFraccion;
            }

            set
            {
                this.costoFraccion = value;
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

        

        public Computadora Computadora
        {
            get
            {
                return this.computadora;
            }
        }

        /// <summary>
        /// calcula el costo total
        /// </summary>
        /// <returns></returns>
        public override double CalcularCosto()
        {
            double costoTotal = 0;

            if (this.TiempoFinalizacion != DateTime.MinValue)
            {
                double segundosUtilizados = ((this.tiempoFinalizacion - this.tiempoInicio).Seconds);
                
                if(segundosUtilizados<30)
                {
                    costoTotal = this.costoFraccion;
                }
                else if(segundosUtilizados>30 && segundosUtilizados<60)
                {
                    costoTotal = this.costoFraccion * 2;
                }
                else
                {
                    //VER math.ceiling y math.floor
                    costoTotal=(segundosUtilizados / 30) * this.costoFraccion;
                }
                
            }
            return costoTotal;
        }

        /// <summary>
        /// agrega el iva al costo total
        /// </summary>
        /// <returns></returns>
        public override double CalcularCostoNeto()
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

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Computadora: {this.computadora}");
            sb.AppendLine($"Costo media hora: ${this.costoFraccion}");
            sb.AppendLine($"Costo bruto: ${this.CostoBruto}");
            sb.AppendLine($"Costo neto: ${this.CostoNeto}");

            return sb.ToString();
        }

       
        //sobrecarga to string
    }
}
