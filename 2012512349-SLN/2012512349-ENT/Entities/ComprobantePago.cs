﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012512349_ENT.Entities
{
     public class ComprobantePago
    {
        internal double monto;

        public int TipoComprobanteId { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        
        public ComprobantePago()
        {
            TipoComprobante = new TipoComprobante();
        }
    }

 } 