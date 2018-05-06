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
    public partial class altaAuto : Form
    {
        private List<Persona> personas;
        private List<Corporacion> corporaciones;
        private Auto auto;

        public altaAuto(List<Persona> pers, List<Corporacion> corpos)
        {
            InitializeComponent();
            personas = pers.ToList();
            corporaciones = corpos.ToList();
        }

        private void altaAuto_Load(object sender, EventArgs e)
        {

        }

        private void ComoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            if(ComboUsuario.Text == "Persona")
            {
                listBox1.Visible = true;
                listBox1.DataSource = null;
                listBox1.DataSource = personas;
                
            } else
            {
                if (ComboUsuario.Text == "Corporacion")
                {
                    listBox1.Visible = true;
                    listBox1.DataSource = null;
                    listBox1.DataSource = corporaciones;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(inputDominio.Text) && !string.IsNullOrWhiteSpace(inputMarca.Text) && !string.IsNullOrWhiteSpace(inputModelo.Text) && !string.IsNullOrWhiteSpace(inputAnio.Text))
            {
                string dom = inputDominio.Text;
                string marca = inputMarca.Text;
                string modelo = inputModelo.Text;
                int anio = int.Parse(inputAnio.Text);
                auto = new Auto(dom, modelo, marca, anio);
                Entidad ent;
                ent = listBox1.SelectedItem as Entidad;
                ent.agregarAuto(auto);
                this.Close();
            } else
            {
                MessageBox.Show("Debe cargar todo los campos");
            }
            
            
           


        }

        public Auto darAuto()
        {
            return auto;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
