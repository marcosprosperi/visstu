using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    public class Infraccion
    {
        protected DateTime fecha;
        protected string dominio;
        protected TipoInfraccion tipoInfraccion;


        public Infraccion(DateTime fec, string dom, TipoInfraccion tipI)
        {
            this.fecha = fec;
            this.dominio = dom;
            this.tipoInfraccion = tipI;
        }

       
    }
}
