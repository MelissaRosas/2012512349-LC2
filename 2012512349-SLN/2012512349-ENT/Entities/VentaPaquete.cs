using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class VentaPaquete
    {

        public VentaPaquete(Cliente clie, Paquete paq, ComprobantePago comp, MedioPago med, Empleado emp, DateTime fec)
        {
            cliente = clie;
            paquete = paq;
            comprobantePago = comp;
            medioPago = med;
            empleado = emp;
            fecha = fec;
        }

        public int codigo { get; set; }
        public Cliente cliente { get; set; }
        // Se vende 1 paquete a la vez.
        public Paquete paquete { get; set; }
        public ComprobantePago comprobantePago { get; set; }
        public MedioPago medioPago { get; set; }
        // Empleado que realiza la venta.
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public double montoTotal
        {
            get
            {
                return paquete.calcularPrecioTotal(); ;
            }
            set
            {
                // Asignamos el mismo monto al comprobante de la venta actual.
                montoTotal = paquete.calcularPrecioTotal();
                comprobantePago.monto = paquete.calcularPrecioTotal();
            }
        }

        public String reporte()
        {
            String reporte = "";
            reporte += "Cliente: " + cliente.persona.nombreCompleto() + "\n";
            reporte += "Empleado responsable: " + empleado.persona.nombreCompleto() + "\n";
            reporte += "Fecha: " + fecha + "\n";
            reporte += "Monto Total del Paquete: S/. " + montoTotal + "\n";
            return reporte;
        }

    }
}
