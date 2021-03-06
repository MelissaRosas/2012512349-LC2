﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
    public class TipoHospedaje
    {

        public TipoHospedaje(String nom, double facPrecio)
        {
            nombre = nom;
            factorPrecio = facPrecio;
        }

        public int codigo { get; set; }
        // Hotel, Hostal, Backpacker, etc.
        public String nombre { get; set; }
        // Factor que influirá en el precio final del hospedaje.
        public double factorPrecio { get; set; }
    }
}
