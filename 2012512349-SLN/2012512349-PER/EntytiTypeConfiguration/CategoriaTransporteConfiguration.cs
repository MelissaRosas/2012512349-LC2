using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class CategoriaTransporteConfiguration : EntityTypeConfiguration<CategoriaTransporte>
    {
        public CategoriaTransporteConfiguration()
        {
            //Table Configurations

            ToTable("CategoriasTransportes");

            // creacion primary key

            HasKey(a => a.CategoriaTransporteId);
        }
    }
}