using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class CategoriaHospedaje
    {

        public CategoriaHospedaje(String nombre, double factorPrecio)
        {
            this.nombre = nombre;
            this.factorPrecio = factorPrecio;
        }

        public int codigo { get; set; }

        public String nombre { get; set; }
        // Factor que influirá en el precio final del hospedaje.
        public double factorPrecio { get; set; }

    }
}
