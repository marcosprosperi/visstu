using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace RN
{
    [Serializable]
    public class Auto
    {
        private string dominio;
        private string modelo;
        private string marca;
        private int anio;

        //agegar set and get

        public Auto(string dom, string mo, string ma, int an)
        {
            this.Dominio = dom;
            this.Modelo = mo;
            this.Marca = ma;
            this.Anio = an;
        }

        public string Dominio { get => dominio; set => dominio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Anio { get => anio; set => anio = value; }


        public override string ToString()
        {
            return "Patente: " + dominio;
        }

        public virtual void armar(ArrayList datos)
        {
            this.dominio = datos[1].ToString();
            this.modelo = datos[2].ToString();
            //this.marca = 
            //this.anio = DateTime.Parse(datos[3].ToString());
        }
    }
}
