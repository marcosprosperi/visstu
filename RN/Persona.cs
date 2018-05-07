﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
namespace RN
{
    [Serializable]
    public class Persona : Entidad
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string telefono;
        
        public Persona(string nom, string ape, int dni, string tel)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Dni = dni;
            this.Telefono = tel;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return nombre + " " + apellido + " - " + telefono + " - " + dni;
        }

        public override string getTipo()
        {
            return "Persona";
        }
    }
}
