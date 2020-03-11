using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recoleccion_de_datos.Modelo
{
    class Linea
    {
        private int numero;
        private String contenido;

        public Linea()
        {
        }
        public Linea(int numero, string contenido)
        {
            this.numero = numero;
            this.contenido = contenido;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void set(int numero) {
            this.numero = numero;
        }
        public String getContenido()
        {
            return this.contenido;
        }

        public void set(String contenido)
        {
            this.contenido = contenido;
        }
    }
}
