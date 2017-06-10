using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
  {
    public class CategoriaAlimentacion
    {

        public CategoriaAlimentacion(String nombre)
        {
            this.nombre = nombre;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }

    }
}
