using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public class InfraccionGrave : TipoInfraccion
    {
        public InfraccionGrave(int cod, string det, float imp) : base(cod, det, imp)
        {

        }


        public override string getTipo()
        {
            return "grave";
        }

        public override string ToString()
        {
            return codigo + " - " + detalle + " - " + importe;
        }

    }
}
