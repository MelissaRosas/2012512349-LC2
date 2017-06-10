using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class ServicioHospedaje
    {

        public ServicioHospedaje(String nom, double facPrecio)
        {
            nombre = nom;
            factorPrecio = facPrecio;
        }

        public int codigo { get; set; }

        public String nombre { get; set; }

        public double factorPrecio { get; set; }

    }
}
