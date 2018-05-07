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

        public string Dominio { get => dominio; set => dominio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool Paga { get => paga; set => paga = value; }
        public TipoInfraccion TipoInfraccion { get => tipoInfraccion; set => tipoInfraccion = value; }

        /* public DateTime Fecha { get => fecha; set => fecha = value; }
         public string Dominio { get => dominio; set => dominio = value; }

         public TipoInfraccion TipoInfraccion { get => tipoInfraccion; set => tipoInfraccion = value; }
         */
        public Infraccion(DateTime fec, string dom, TipoInfraccion tipI)
        {
            this.Fecha = fec;
            this.Dominio = dom;
            this.TipoInfraccion = tipI;
            this.Paga = false;
        }

       public bool infraccionPaga()
        {
            return this.Paga;
        }

        public bool estaVencida()
        {
            TimeSpan diff = (DateTime.Today - this.Fecha);
            if (diff.Days > 30)
                return true;
            else
                return false;
        }

        public void pagar()
        {
            Paga = true;
        }

        public string darDetalle()
        {
            if (this.estaVencida())
                return this.Fecha.ToString() + "//" + this.Dominio + "//" + this.TipoInfraccion.ToString() + " VENCIDA!";
            else
                return this.Fecha.ToString() + "//" + this.Dominio + "//" + this.TipoInfraccion.ToString() + " EN FECHA DE PAGO!";
        }

        public override string ToString()
        {
            if (this.estaVencida())
                return this.Fecha.ToString() + "//" + this.Dominio + "//" + this.TipoInfraccion.ToString() + " VENCIDA!";
            else
                return this.Fecha.ToString() + "//" + this.Dominio + "//" + this.TipoInfraccion.ToString() + " EN FECHA DE PAGO!";
        }

        

    }
}
