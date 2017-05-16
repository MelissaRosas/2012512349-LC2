using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            //Table Configurations

            ToTable("ComprobantesPagos");

            // creacion primary key

            HasKey(a => a.ComprobantePagoId);
        }
    }
}