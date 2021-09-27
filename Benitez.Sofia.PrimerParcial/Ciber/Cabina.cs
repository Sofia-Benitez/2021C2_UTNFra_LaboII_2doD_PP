using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiberCafe
{
    public class Cabina : Servicios
    {
        
        private string marca;
        private Tipo tipo;
        public enum Tipo { Disco, Teclado};

        public Cabina(string id, string marca, Tipo tipo, bool estado):base(id, estado)
        {
            
            this.marca = marca;
            this.tipo = tipo;
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

        //mostrar
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("************ Caracteristicas **************");

            sb.AppendLine("*************************************");

            return ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
