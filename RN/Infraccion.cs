using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    [Serializable]
    public class Infraccion
    {
        private DateTime fecha;
        private string dominio;
        private TipoInfraccion tipoInfraccion;
        private bool paga;

       /* public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Dominio { get => dominio; set => dominio = value; }

        public TipoInfraccion TipoInfraccion { get => tipoInfraccion; set => tipoInfraccion = value; }
        */
        public Infraccion(DateTime fec, string dom, TipoInfraccion tipI)
        {
            this.fecha = fec;
            this.dominio = dom;
            this.tipoInfraccion = tipI;
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

        public string darDetalle()
        {
            if (this.estaVencida())
                return this.fecha.ToString() + "//" + this.dominio + "//" + this.tipoInfraccion.ToString() + " VENCIDA!";
            else
                return this.fecha.ToString() + "//" + this.dominio + "//" + this.tipoInfraccion.ToString() + " EN FECHA DE PAGO!";
        }

        public override string ToString()
        {
            if (this.estaVencida())
                return this.fecha.ToString() + "//" + this.dominio + "//" + this.tipoInfraccion.ToString() + " VENCIDA!";
            else
                return this.fecha.ToString() + "//" + this.dominio + "//" + this.tipoInfraccion.ToString() + " EN FECHA DE PAGO!";
        }

    }
}
