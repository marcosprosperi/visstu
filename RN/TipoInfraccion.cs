using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public abstract class TipoInfraccion
    {
        protected int codigo;
        protected string detalle;
        protected float importe;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public float Importe { get => importe; set => importe = value; }

        public TipoInfraccion(int cod, string det, float imp)
        {
            this.codigo = cod;
            this.detalle = det;
            this.importe = imp;
        }

        public override string ToString()
        {
            return codigo + " - " + detalle + " - " + importe;
        }

        public abstract string getTipo();

    }
}
