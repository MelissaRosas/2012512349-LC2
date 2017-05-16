using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class PaqueteConfiguration : EntityTypeConfiguration<Paquete>
    {
        public PaqueteConfiguration()
        {
            //Table Configurations

            ToTable("Paquetes");

            // creacion primary key

            HasKey(a => a.PaqueteId);
        }
    }
}