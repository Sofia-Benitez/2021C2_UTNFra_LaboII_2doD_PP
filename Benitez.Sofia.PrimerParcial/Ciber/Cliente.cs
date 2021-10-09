using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private int edad;
        private Necesidad necesidad;
        private  Dictionary<string, string> requerimientos;


        public enum Necesidad
        {
            Cabina,Computadora
        }
        
        /// <summary>
        /// constructor cliente 
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="necesidad"></param>
        public Cliente(string dni, string nombre, string apellido, int edad, Necesidad necesidad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.necesidad = necesidad;
            this.requerimientos = new Dictionary<string, string>();
        }

       
        
        public string Nombre { get { return nombre; } }

        public string Dni
        {
            get
            {
                return this.dni;
            }
        }
       
        public Necesidad NecesidadCliente
        {
            get
            {
                return necesidad;
            }
        }
        public Dictionary<string, string> Requerimientos
        {
            get
            {
                return this.requerimientos;
            }
            
        }

        

        /// <summary>
        /// muestra el nombre del cliente, el servicio que necesita y los requerimientos
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} | {this.necesidad} | ");
            if(requerimientos is not null)
            {
                foreach (KeyValuePair<string, string> item in requerimientos)
                {
                    sb.Append(item.Value);
                }
            }
           
            return sb.ToString();
        }

        /// <summary>
        /// muestra los datos personales del cliente
        /// </summary>
        /// <returns></returns>
        public string MostrarDatosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// agrega requerimientos al diccionario 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool AgregarRequerimiento(string key, string value)
        {
            if(this.necesidad == Necesidad.Computadora)
            {
                foreach (KeyValuePair<string, string> item in this.requerimientos)
                {
                    if (this.requerimientos.ContainsKey(key))
                    {
                        return false;
                    }
                }
                this.requerimientos.Add(key, value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// sobrecarga == para comprobar si lo que necesita el cliente esta en la computadora
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente, Computadora computadora)
        {
           
                foreach (KeyValuePair<string, string> item in cliente.Requerimientos)
                {
                    if (!(computadora.Caracteristicas.ContainsKey(item.Key)))
                    {
                        return false;
                    }

                }
                return true;
            
            
        }

        /// <summary>
        /// sobrecarga del operador 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente, Computadora computadora)
        {
            return (!(cliente == computadora));
        }



        //sobrecargar equals y hash


        /// <summary>
        /// sobrecarga del operador == para ocmparar clientes por su numero de DNI
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            return (cliente1.Dni == cliente2.Dni);
        }

        /// <summary>
        /// sobrecarga del operador != para ocmparar clientes por su numero de DNI
        /// </summary>
        /// <param name="cliente1"></param>
        /// <param name="cliente2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            return (!(cliente1 == cliente2));
        }
    }
}
