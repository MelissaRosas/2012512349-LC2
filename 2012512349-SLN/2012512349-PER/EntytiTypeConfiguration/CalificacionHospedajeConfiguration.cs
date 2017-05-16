using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class CalificacionHospedajeConfiguration : EntityTypeConfiguration<CalificacionHospedaje>
    {
        public CalificacionHospedajeConfiguration()
        {
            //Table Configurations

            ToTable("CalificacionesHospedajes");

            // creacion primary key

            .HasKey(a => a.CalificacionHospedajeId);
        }

        private void ToTable(string p)
        {
            throw new NotImplementedException();
        }
    }
}
