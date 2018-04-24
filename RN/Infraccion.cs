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
        private bool paga;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Dominio { get => dominio; set => dominio = value; }
        public TipoInfraccion TipoInfraccion { get => tipoInfraccion; set => tipoInfraccion = value; }

        public Infraccion(DateTime fec, string dom, TipoInfraccion tipI)
        {
            this.Fecha = fec;
            this.Dominio = dom;
            this.TipoInfraccion = tipI;
            this.paga = false;
        }

       public bool infraccionPaga()
        {
            return this.paga;
        }

        public bool estaVencida()
        {
            TimeSpan diff = (DateTime.Today - this.fecha);
            if (diff.Days > 30)
                return true;
            else
                return false;
        }

        public void pagar()
        {
            paga = true;
        }
    }
}
