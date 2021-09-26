using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciber
{
    public class Ciber
    {
        Queue<Cliente> listaClientes;


        public static TipoLlamada ObtenerTipoLlamada(string codigoPais, string prefijo)
        {
            TipoLlamada tipo = TipoLlamada.LargaDistancia;

            if (codigoPais != "54")
            {
                tipo = TipoLlamada.Internacional;
            }
            else if (prefijo == "011" || prefijo == "11")// y 54
            {
                tipo = TipoLlamada.Local;
            }


            return tipo;
        }

        public static double CalcularCosto(Llamada llamada)
        {
            if(llamada.TiempoFinalizacion  != DateTime.MinValue)
            {
                return ((llamada.TiempoInicio - llamada.TiempoFinalizacion).TotalSeconds) * llamada.Costo;
            }
            return 0;
        }
    }
}
