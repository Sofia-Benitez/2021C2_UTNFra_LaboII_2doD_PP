﻿using System;
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
        public Necesidad necesidad;
        private  Dictionary<string, string> requerimientos;
        private string tiempoSolicitado;


        /// <summary>
        /// enumerado con la necesidad que puede tener el cliente al ingresar al ciber
        /// </summary>
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
            this.Dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.necesidad = necesidad;
            this.requerimientos = new Dictionary<string, string>();
        }

        /// <summary>
        /// sobrecarga del cosntructor cliente para que incluya el tiempo solicitado de uso del serivcio
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="necesidad"></param>
        /// <param name="tiempoSolicitado"></param>
        public Cliente(string dni, string nombre, string apellido, int edad, Necesidad necesidad, string tiempoSolicitado):this(dni, nombre, apellido, edad, necesidad)
        {
            this.tiempoSolicitado = tiempoSolicitado;
        }
        
        /// <summary>
        /// pripiedad que permite leer el nombre del cliente
        /// </summary>
        public string Nombre 
        {
            get
            {
                return nombre; 
            } 
        }

        /// <summary>
        /// propiedad que permite leer el DNI del cliente y setearlo si el numero es correcto 
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if(value.Length>7 && value.Length<10)
                {
                    this.dni = value;
                }
                else
                {
                    this.dni = "";
                }
            }
        }
       
        /// <summary>
        /// propiedad que permite leer la necesidad del cliente
        /// </summary>
        public Necesidad NecesidadCliente
        {
            get
            {
                return necesidad;
             
            }
        }

        /// <summary>
        /// propiedad que permite acceder a la lista de requerimientos del cliente
        /// </summary>
        public Dictionary<string, string> Requerimientos
        {
            get
            {
                return this.requerimientos;
            }
            
        }

        

        /// <summary>
        /// muestra el nombre del cliente, el servicio que necesita, el tiempo que solicita si no es tiempo libre y los requerimientos
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.nombre} | {this.necesidad} | {this.tiempoSolicitado} ");
            
            if(requerimientos is not null)
            {
                foreach (KeyValuePair<string, string> item in requerimientos)
                {
                    sb.Append(item.Value + " ");
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

        /// <summary>
        /// Sobrecarga del metodo ToString() para mostrar los datos escenciales del cliente dentro del contexto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// agrega requerimientos al diccionario mientras no se encuentren ya en el diccionario
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
        /// <returns>devuelve true si lo que necesita el cliente esta en la computadora</returns>
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
        /// sobrecarga del operador !=
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="computadora"></param>
        /// <returns>devuelve true si lo que necesita el cliente no esta en la computadora </returns>
        public static bool operator !=(Cliente cliente, Computadora computadora)
        {
            return (!(cliente == computadora));
        }

        

        /// <summary>
        /// sobrecarga del operador == para comparar clientes por su numero de DNI
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

        /// <summary>
        /// sobrecarga del metodo Equals para comprobar si un objeto es del tipo cliente
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && this == cliente;
        }

        /// <summary>
        /// sobrecarga del metdo GetHashCode() para obtener el mismo hash code si dos clientes tienen el mismo dni 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return dni.GetHashCode();
        }
    }
}
