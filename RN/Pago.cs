﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public class Pago
    {
        private DateTime fecha;
        private Infraccion infraccion;

        public Pago(DateTime fec, Infraccion infra)
        {
            this.fecha = fec;
            this.infraccion = infra;
        }


    }
}
