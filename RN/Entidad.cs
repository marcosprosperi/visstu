using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RN
{
    [Serializable]
    public abstract class Entidad
    {
        protected List<Auto> autos;

        public Entidad()
        {
            this.autos = new List<Auto>();
        }

        public void agregarAuto(Auto auto)
        {
            autos.Add(auto);
        }


    }
}
