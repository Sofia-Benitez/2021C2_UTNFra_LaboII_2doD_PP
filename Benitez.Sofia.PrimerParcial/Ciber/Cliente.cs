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
        public Necesidad NecesidadCliente { get => necesidad; set => necesidad = value; }
        public Dictionary<string, string> Requerimientos { get => requerimientos; set => requerimientos = value; }


        

        //mostrar
        public string Mostrar()
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

        public string MostrarDatosCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"DNI: {this.dni}");
            return sb.ToString();
        }

        public void AgregarRequerimiento(string key, string value)
        {
            if(requerimientos is not null)
            {
                this.requerimientos.Add(key, value);
            }
           
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

        public static bool operator !=(Cliente cliente, Computadora computadora)
        {
            return (!(cliente == computadora));
        }


        
        //sobrecargar equals y hash

        public static Cliente ClienteSeleccionado(string clienteSeleccionado, Ciber miCiber)
        {
            foreach (Cliente item in miCiber.ListaDeClientes)
            {
                if (item.Mostrar() == clienteSeleccionado)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
