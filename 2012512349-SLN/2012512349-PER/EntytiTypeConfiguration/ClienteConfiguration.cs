using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_PER.EntytiTypeConfiguration
{
    class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table Configurations

            ToTable("Clientes");

            // creacion primary key

            HasKey(a => a.ClientesId);
        }
    }
}