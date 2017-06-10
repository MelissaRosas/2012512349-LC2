using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class Cliente
    {

        public Cliente (Persona persona)
        {
            this.persona = persona;
        }

        public int codigo { get; set; }
        // Referencia a la clase persona. Evita redundancia de atributos.
        public Persona persona { get; set; }

    }
}