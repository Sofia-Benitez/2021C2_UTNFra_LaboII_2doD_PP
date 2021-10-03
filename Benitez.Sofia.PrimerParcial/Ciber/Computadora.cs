using System;
using System.Collections.Generic;
using System.Text;

namespace CiberCafe
{
    public class Computadora : Servicios
    {
        private Dictionary<string, string> caracteristicas;
        
        
        /// <summary>
        /// constructor de una computadora
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="estado">estado de la computadora (en uso o libre)</param>
        public Computadora(string id, bool estado):base(id, estado)
        {

            this.caracteristicas = new Dictionary<string, string>();
             
        }

        
        public override string Id
        {
            get
            {
                return this.id;
            }
        }
        

        public override bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public Dictionary<string, string> Caracteristicas
        {
            get
            {
                return this.caracteristicas;
            }

        }

        public void AgregarCaracteristica(string key, string value)
        {
            this.caracteristicas.Add(key, value);
        }




        //mostrar
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            foreach(KeyValuePair <string, string> item in this.Caracteristicas)
            {
                sb.AppendLine($"{item.Value} ");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static Computadora ComputadoraSeleccionada(string computadoraSeleccionada, Ciber miCiber)
        {
            foreach (Computadora item in miCiber.ListaDeServicios)
            {
                if (item.Mostrar() == computadoraSeleccionada)
                {
                    return item;
                }
            }
            return null;
        }



    }
}
