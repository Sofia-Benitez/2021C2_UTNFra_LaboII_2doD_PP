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
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.necesidad = necesidad;
            this.requerimientos = new Dictionary<string, string>();
        }

       
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public Necesidad Necesidad1 { get => necesidad; set => necesidad = value; }
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
            if (computadora.Estado == false)
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
            return false;
        }

        public static bool operator !=(Cliente cliente, Computadora computadora)
        {
            return (!(cliente == computadora));
        }


        public void AsignarComputadora()
        {

        }
        //sobrecargar equals y hash
    }
}
