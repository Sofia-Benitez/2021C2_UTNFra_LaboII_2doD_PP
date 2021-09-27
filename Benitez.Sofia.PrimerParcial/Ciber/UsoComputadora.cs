using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class UsoComputadora : UsoServicio
    {
        private Cliente cliente;
        private Computadora computadora;

        public UsoComputadora(DateTime tiempoInicio, Cliente cliente, Computadora computadora):base(tiempoInicio)
        {
            this.cliente = cliente;
            this.computadora = computadora;
            this.costo = 0.5F;
        }

        public UsoComputadora(DateTime tiempoInicio, DateTime tiempoFinalizacion, Cliente cliente, Computadora computadora) : this(tiempoInicio, cliente, computadora)
        {
            
        }

        public override DateTime TiempoInicio
        {
            get
            {
                return this.tiempoInicio;
            }
        }

        public override DateTime TiempoFinalizacion
        {
            get
            {
                return this.tiempoFinalizacion;
            }
        }

        public override double Costo 
        {
            get
            {
                return this.costo;
            }

            set
            {
                this.costo = value;
            }
        }

        
    }
}
