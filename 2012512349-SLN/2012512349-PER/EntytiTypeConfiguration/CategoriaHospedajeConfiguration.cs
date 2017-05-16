using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class CategoriaHospedajeConfiguration : EntityTypeConfiguration<CategoriaHospedaje>
    {
        public CategoriaHospedajeConfiguration()
        {
            //Table Configurations

            ToTable("CategoriasHospedajes");

            // creacion primary key

            HasKey(a => a.CategoriaHospedajeId);
        }
    }
}
