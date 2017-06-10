using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class Persona
    {
        public Persona(String apePat, String apeMat, String nom, char sex)
        {
            apellidoPaterno = apePat;
            apellidoMaterno = apeMat;
            nombre = nom;
            sexo = sex;
        }

        public int codigo { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String dni { get; set; }
        public char sexo { get; set; }

        public String nombreCompleto()
        {
            return apellidoPaterno + " " + apellidoMaterno + ", " + nombre;
        }

    }
}
