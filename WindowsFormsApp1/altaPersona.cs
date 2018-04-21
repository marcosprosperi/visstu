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
    public partial class altaPersona : Form
    {
        protected Persona persona;

        public altaPersona()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                string nom = inputNombre.Text;
                string ape = inputApellido.Text;
                int dni = int.Parse(InputDni.Text);
                string telefono = inputTelefono.Text;
                persona = new Persona(nom, ape, dni, telefono);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Persona darPersona()
        {
            return persona;
        }

        private void altaPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
