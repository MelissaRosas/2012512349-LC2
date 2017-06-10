using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class Alimentacion : ServicioTuristico
    {

        public Alimentacion(CategoriaAlimentacion categoria, double precio)
        {
            categoriaAlimentacion = categoria;
            this.precio = precio;
        }

        public int codigo { get; set; }
        public CategoriaAlimentacion categoriaAlimentacion { get; set; }
        public double precio { get; set; }

        public override double obtenerPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
