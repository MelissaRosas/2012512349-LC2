using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class CategoriaAlimentacionConfiguration : EntityTypeConfiguration<CategoriaAlimentacion>
    {
        public CategoriaAlimentacionConfiguration()
        {
            //Table Configurations

            ToTable("CategoriasAlimentaciones");

            // creacion primary key

            HasKey(a => a.CategoriaAlimentacionId);
        }

private void ToTable(string p)
{
 	throw new NotImplementedException();
}
    }
}}