using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoComputadora : Uso
    {
        private Cliente cliente;
        private Computadora computadora;
        protected double costoFraccion;

        public UsoComputadora(DateTime tiempoInicio, Cliente cliente, Computadora computadora):base(tiempoInicio)
        {
            this.cliente = cliente;
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

        public double CostoTotal
        {
            get
            {
                return CalcularCosto();
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

            if (this.TiempoFinalizacion != DateTime.MinValue)
            {
                return ((this.tiempoFinalizacion-this.tiempoInicio).Seconds) * this.costoFraccion;
            }
            return 0;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Computadora: {this.computadora}");
            sb.AppendLine($"Cliente: {this.cliente.Nombre}");
            sb.AppendLine($"Costo media hora: ${this.costoFraccion}");
            sb.AppendLine($"Costo total: ${this.CostoTotal}");

            return sb.ToString();
        }


    }
}
