using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class Cabina : Servicios
    {
        
        private string marca;
        private Tipo tipo;
        public enum Tipo { Disco, Teclado};

        public Cabina(int id, string marca, Tipo tipo)
        {
            
            this.marca = marca;
            this.tipo = tipo;
        }

       

    }
}
