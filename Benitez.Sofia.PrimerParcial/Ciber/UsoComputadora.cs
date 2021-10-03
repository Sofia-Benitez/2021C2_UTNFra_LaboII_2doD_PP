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

        public UsoComputadora(DateTime tiempoInicio, Cliente cliente, Computadora computadora):base(tiempoInicio, cliente)
        {
            
            this.computadora = computadora;
            this.costoFraccion = 0.5F;
        }

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

        public double CostoBruto
        {
            get
            {
                return CalcularCosto();
            }
        }

        public double CostoNeto
        {
            get
            {
                return CalcularCostoNeto();
            }
        }

        public double TiempoDeUso
        {
            get
            {
                if (this.TiempoFinalizacion != DateTime.MinValue)
                {
                    return ((this.tiempoFinalizacion - this.tiempoInicio).Seconds);
                }
                return 0;
                    
            }
        }

        public Computadora Computadora
        {
            get
            {
                return this.computadora;
            }
        }

        public double CalcularCosto()
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

        public double CalcularCostoNeto()
        {
           return  this.CostoBruto * IVA;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Computadora: {this.computadora}");
            
            sb.AppendLine($"Tiempo de uso: {this.TiempoDeUso} minutos");
            sb.AppendLine($"Costo media hora: ${this.costoFraccion}");
            sb.AppendLine($"Costo bruto: ${this.CostoBruto}");
            sb.AppendLine($"Costo neto: ${this.CostoNeto}");

            return sb.ToString();
        }

       
    }
}
