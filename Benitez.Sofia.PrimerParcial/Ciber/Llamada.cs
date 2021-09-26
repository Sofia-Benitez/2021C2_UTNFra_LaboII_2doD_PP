using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public abstract class Llamada : UsoServicio
    {
       
        private string prefijo;
        private string codigoPais;
        private string numero;
        protected TipoLlamada tipoDeLlamada;
        
       

        //constructor 
        public Llamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, TipoLlamada tipoDeLlamada):base(tiempoInicio)
        {
            this.prefijo = prefijo;
            this.codigoPais = codigoPais;
            this.numero = numero;
            this.costo = this.CostoPorTipo();
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
        public Llamada(DateTime tiempoInicio, string prefijo, string codigoPais, string numero, DateTime tiempoFinalizacion, TipoLlamada tipoDeLlamada) : this(tiempoInicio, prefijo, codigoPais, numero, tipoDeLlamada)
        {
            
        }

        public double CostoPorTipo()
        {
            double costo = 0;
            
                if(this.tipoDeLlamada==TipoLlamada.Internacional)
                {
                    costo = 5;
                }
                else if(this.tipoDeLlamada==TipoLlamada.LargaDistancia)
                {
                    costo = 2.5;
                }
                else
                {
                    costo = 1;
                }

            return costo;
        }
       
        public string Prefijo
        {
            get
            {
                return this.prefijo;
            }
        }
        public string CodigoPais
        {
            get
            {
                return this.codigoPais;
            }
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

        
        
        
       

        //mostrar

    }
}
