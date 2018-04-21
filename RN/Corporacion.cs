using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public class Corporacion
    {
        private string nombre;
        private string cuil;
        private List<Auto> autos;

        public Corporacion(string nombre, string cuil)
        {
            this.nombre = nombre;
            this.cuil = cuil;
            this.autos = new List<Auto>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cuil { get => cuil; set => cuil = value; }


        public override string ToString()
        {
            return nombre + " " + cuil;
        }
    }
}
