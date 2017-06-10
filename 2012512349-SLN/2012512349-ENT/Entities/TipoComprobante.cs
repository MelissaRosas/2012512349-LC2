﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class TipoComprobante
    {
        public TipoComprobante()
        {
        }

        public TipoComprobante(String nom, char abrev)
        {
            nombre = nom;
            abreviatura = abrev;
        }

        public int codigo { get; set; }
        public String nombre { get; set; }
        // Factura -> F / Boleta -> B
        public char abreviatura { get; set; }

    }
}
