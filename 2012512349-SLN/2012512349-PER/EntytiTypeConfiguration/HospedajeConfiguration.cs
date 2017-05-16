using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class HospedajeConfiguration : EntityTypeConfiguration<Hospedaje>
    {
        public HospedajeConfiguration()
        {
            //Table Configurations

            ToTable("Hospedajes")

            // creacion primary key

            .HasKey(a => a.HospedajeId)
             .HasMany(c => c.Hospedaje)
                .WithMany(t => t.ServicioTuristico)
                .Map(m => m.ToTable("ServicioTuristicoHopedaje"));
        }
    }
}

