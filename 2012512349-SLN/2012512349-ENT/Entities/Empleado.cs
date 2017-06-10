using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    
    public class Empleado
    {

        public Empleado(Persona persona, double sueldo)
        {
            this.persona = persona;
            this.sueldo = sueldo;
        }

        public int codigo { get; set; }
        // Referencia a la clase persona. Evita redundancia de atributos.
        public Persona persona { get; set; }
        public double sueldo { get; set; }

    }
}
