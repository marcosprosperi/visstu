using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RN;

namespace WindowsFormsApp1
{
    public partial class modPersona : Form
    {
        protected Persona persona;
        protected List<Persona> personas;
        
        public modPersona(List<Persona> ListP)
        {
            if (ListP.Count() != 0)
            {

                InitializeComponent();
                personas = ListP.ToList();
                listBox1.DataSource = personas;
                
            }
            else
            {
                MessageBox.Show("No hay tipo de infracciones cargadas");
                this.Close();
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

   
        }

        private void modPersona_Load(object sender, EventArgs e)
        {

        }

        public Persona darPersona()
        {
            return persona;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nom = inputNombre.Text;
            string ape = inputApellido.Text;
            int dni = int.Parse(InputDni.Text);
            string telefono = inputTelefono.Text;
            this.persona = new Persona(nom, ape, dni, telefono);


            this.Close();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Persona per = listBox1.SelectedItem as Persona;
            string nombre = per.Nombre;
            string apellido = per.Apellido;
            int dni = per.Dni;
            string telefono = per.Telefono;

            inputNombre.Text = nombre.ToString();
            inputApellido.Text = apellido.ToString();
            InputDni.Text = dni.ToString();
            inputTelefono.Text = telefono.ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
           
            this.Close();
        }
    }
}
