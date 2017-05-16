using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2012512349_PER.EntytiTypeConfiguration
{
    class AlimentacionConfiguration : EntityTypeConfiguration<Alimentacion>
    {
        public AlimentacionConfiguration()
        {
            //Table Configurations

            ToTable("Alimentaciones")

            // creacion primary key

            .HasKey(a => a.AlimentacionId)
             .HasMany(c => c.Alimentacion)
            .WithMany(t => t.ServicioTuristico)
            .Map(m => m.ToTable("ServicioTuristicoAlimentacion"));
        }

        private object ToTable(string p)
        {
            throw new NotImplementedException();
        }
    }
}
