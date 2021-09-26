using System;
using System.Collections.Generic;
using System.Text;

namespace Ciber
{
    public class Computadora : Servicios
    {
        private List<string> software;
        private List<string> juegos;
        private List<string> hardware;
        private List<string> perifericos;
        
        /// <summary>
        /// constructor de una computadora con costo fijo de 0.5 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="estado">estado de la computadora (en uso o libre)</param>
        public Computadora(int id, bool estado):base(id, estado)
        {

            this.software = new List<string>();
            this.juegos = new List<string>();
            this.hardware = new List<string>();
            this.perifericos = new List<string>();
             
        }

        public override int Id
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



        public void AgregarSoftware(string programa)
        {
            ///ver que no este repetido
            this.software.Add(programa);
        }

        public void AgregarJuego(string juego)
        {
            ///ver que no este repetido
            this.juegos.Add(juego);
        }

        public void AgregarHardware(string especificacion)
        {
            ///ver que no este repetido
            this.hardware.Add(especificacion);
        }

        public void AgregarPeriferico(string periferico)
        {
            ///ver que no este repetido
            this.perifericos.Add(periferico);
        }




        //mostrar
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("************ Software **************");
            foreach (string item in this.software)
            {
                sb.AppendLine(item);
            }
            sb.AppendLine("*************************************");
            sb.AppendLine("************ Hardware **************");
            foreach (string item in this.hardware)
            {
                sb.AppendLine(item);
            }
            sb.AppendLine("*************************************");
            sb.AppendLine("************ Perifericos **************");
            foreach (string item in this.perifericos)
            {
                sb.AppendLine(item);
            }
            sb.AppendLine("*************************************");
            sb.AppendLine("************ Juegos **************");
            foreach (string item in this.juegos)
            {
                sb.AppendLine(item);
            }
            sb.AppendLine("*************************************");

            return ToString();
        }




    }
}
