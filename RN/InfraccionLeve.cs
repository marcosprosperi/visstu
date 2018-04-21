using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public class InfraccionLeve : TipoInfraccion
    {
        public InfraccionLeve(int cod, string det, float imp) : base(cod, det, imp)
        {

        }

        public override string getTipo()
        {
            return "leve";
        }
    }
}
