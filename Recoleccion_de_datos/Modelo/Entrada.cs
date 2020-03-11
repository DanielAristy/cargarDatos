using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recoleccion_de_datos.Modelo
{
    class Entrada
    {
        
        private List<Linea> lienas;
        private static Entrada entrada;

        public static Entrada getInstancia()
        {
            if(entrada == null)
            {
                entrada = new Entrada();
            }

            entrada = null;
            return null;
        }
        private void obtenerInstancia() { 

        }
        private void agregarLinea(Linea linea) {
            
        }

        private Linea obtenerLinea(int numero)
        {
            return;
        }

        private void reiniciarEntrada()
        {

        }

        private List<Linea> obtenerLineas() {


            return;
        }
    }
}
