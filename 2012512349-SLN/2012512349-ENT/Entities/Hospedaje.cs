using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class Hospedaje : ServicioTuristico
    {

        public Hospedaje(TipoHospedaje tipohospedaje, CalificacionHospedaje calificacion, CategoriaHospedaje categoria, List<ServicioHospedaje> servicio)
        {
            tipoHospedaje = tipohospedaje;
            calificacionHospedaje = calificacion;
            categoriaHospedaje = categoria;
            _ServicioHospedaje = servicio;
        }

        public int codigo { get; set; }
        public TipoHospedaje tipoHospedaje { get; set; }
        public CalificacionHospedaje calificacionHospedaje { get; set; }
        public CategoriaHospedaje categoriaHospedaje { get; set; }

        // Pueden ofrecerse 1 o más servicios dentro del hospedaje.
        private List<ServicioHospedaje> _ServicioHospedaje;
        public List<ServicioHospedaje> ServicioHospedaje
        {
            get { return _ServicioHospedaje; }
            set { _ServicioHospedaje = ServicioHospedaje; }
        }

        public double precioFinal { get; set; }

        public double PrecioFinal
        {
            set
            {
                double factorPrecioServicios = 1;
                foreach (ServicioHospedaje ser in ServicioHospedaje)
                {
                    factorPrecioServicios *= ser.factorPrecio;
                }
                precioFinal = tipoHospedaje.factorPrecio * calificacionHospedaje.factorPrecio * categoriaHospedaje.factorPrecio * factorPrecioServicios;
            }
        }

        // Función sobreescrita en base a la clase padre 'ServicioTuristico'.
        public override double obtenerPrecio()
        {
            return precioFinal;
        }

    }
}
