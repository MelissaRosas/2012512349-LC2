using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class MedioPago
    {

        public MedioPago(String nombre, Boolean ofreceDescuento)
        {
            this.nombre = nombre;
            this.ofreceDescuento = ofreceDescuento;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        // Dependiendo si es crédito o al contado, puede ofrecer un descuento.
        public Boolean ofreceDescuento { get; set; }

    }
}
