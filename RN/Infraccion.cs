using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    public class Infraccion
    {
        private DateTime fecha;
        private string dominio;
        private TipoInfraccion tipoInfraccion;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Dominio { get => dominio; set => dominio = value; }
        public TipoInfraccion TipoInfraccion { get => tipoInfraccion; set => tipoInfraccion = value; }

        public Infraccion(DateTime fec, string dom, TipoInfraccion tipI)
        {
            this.Fecha = fec;
            this.Dominio = dom;
            this.TipoInfraccion = tipI;
        }

       
    }
}
