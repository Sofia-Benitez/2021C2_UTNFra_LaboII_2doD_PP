using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;
        private int edad;
        private Necesidad necesidad;
        private string numero;
        public enum Necesidad
        {
            Cabina,Computadora
        }
        

        //constructor para compu
        public Cliente(string dni, string nombre, string apellido, int edad, Necesidad necesidad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.necesidad = necesidad;
        }
        //constructor para cabina

        public Cliente(string dni, string nombre, string apellido, int edad, Necesidad necesidad, string numero)
            :this(dni, nombre, apellido, edad, necesidad)
        {
            this.numero = numero;
        }

        //calcular costo

        //mostrar

    }
}
