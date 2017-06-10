using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class Transporte : ServicioTuristico
    {

        public Transporte(TipoTransporte tip, CategoriaTransporte cat, double pre)
        {
            tipoTransporte = tip;
            categoriaTransporte = cat;
            precio = pre;
        }

        public int codigo { get; set; }
        public TipoTransporte tipoTransporte { get; set; }
        public CategoriaTransporte categoriaTransporte { get; set; }
        public double precio { get; set; }
        public override double obtenerPrecio()
        {
            return precio;
        }

    }
}
