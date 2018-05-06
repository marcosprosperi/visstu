using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using CapaDatos;

namespace RN
{
    [Serializable]
    public class Empresa
    {
        private string empresa;
        private int cuil;
        private List<Persona> personas;
        private List<Corporacion> corporaciones;
        private List<TipoInfraccion> tipoInfracciones;
        private List<Auto> autos;
        private List<Pago> pagos;
        private List<Infraccion> infracciones;

        public Empresa(string emp, int cuil)
        {
            this.empresa = emp;
            this.cuil = cuil;
            this.personas = new List<Persona>();
            this.corporaciones = new List<Corporacion>();
            this.tipoInfracciones = new List<TipoInfraccion>();
            this.autos = new List<Auto>();
            this.pagos = new List<Pago>();
            this.infracciones = new List<Infraccion>();

        }


        public void agregarTipoInfraccion(TipoInfraccion ti)
        {
            tipoInfracciones.Add(ti);
        }

        public void agregarPersona(Persona Per)
        {
            personas.Add(Per);
        }

        public void agregarCorporacion(Corporacion Cor)
        {
            corporaciones.Add(Cor);
        }


        public bool yaExistePersona(Persona per)
        {
            return personas.Contains(per);
        }

        public bool yaExisteCorpo(Corporacion corp)
        {
            return corporaciones.Contains(corp);
        }

        public List<TipoInfraccion> darListadoDeInfracciones()
        {
            return tipoInfracciones;
        }

        public bool yaExisteInfraccion(TipoInfraccion ti)
        {
            return tipoInfracciones.Contains(ti);
        }

        public void modificarInfraccion(TipoInfraccion ti)
        {
            try
            {
                TipoInfraccion tipoInf = tipoInfracciones.Find(x => x.Codigo == ti.Codigo);
                tipoInfracciones.Remove(tipoInf);
                tipoInfracciones.Add(ti);
            }
            catch(Exception e)
            {
                
            }
            /*
            tipoInf.Detalle = ti.Detalle;
            tipoInf.Importe = ti.Importe;
            if (ti.getTipo() == "leve")
                tipoInf = (InfraccionLeve)tipoInf;
            else
                tipoInf = (InfraccionLeve)tipoInf;
                */
        }

        public List<Persona> getTodasLasPersonas()
        {
            return personas;
        }

        public List<Corporacion> getCorpos()
        {
            return corporaciones;
        }

        public void modificarPersona(Persona pe)
        {
            Persona persona = personas.Find(x => x.Dni == pe.Dni);
            persona.Nombre = pe.Nombre;
            persona.Dni = pe.Dni;
            persona.Telefono = pe.Telefono;
            persona.Apellido = pe.Apellido;


        }

        public void modificarCorporacion(Corporacion corpo)
        {
            Corporacion corporacion = corporaciones.Find(x => x.Cuil == corpo.Cuil);
            corporacion.Nombre = corpo.Nombre;
            corporacion.Cuil = corpo.Cuil;
        }

        public void agregarAuto(Auto auto)
        {
            autos.Add(auto);
        }

        public List<Auto> getAutos()
        {
            return this.autos;
        }

        public void agregarInfracciones(Infraccion inf)
        {
            infracciones.Add(inf);
        }

        public List<Infraccion> getMultasNoPagas()
        {
            List<Infraccion> infraNoPagas = new List<Infraccion>();
            foreach (Infraccion inf in infracciones)
            {
                if (!inf.infraccionPaga())
                    infraNoPagas.Add(inf);
            }
            return infraNoPagas;
        }

        public void agregarPago(Pago pago)
        {
            pagos.Add(pago);
        }


        public bool guardar()
        {
            return Datos.Guardar(this);
        }


        public static Empresa Recuperar()
        {
            Empresa c = (Empresa)Datos.Recuperar();
            if (c == null)
                c = new Empresa("Empresa Curro", 303143396);
            return c;
        }

    }
}
