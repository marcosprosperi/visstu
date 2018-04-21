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
    public partial class modCorporacion : Form
    {
        private List<Corporacion> corporaciones;
        private Corporacion corporacion;

        public modCorporacion(List<Corporacion> corpL)
        {
            if (corpL.Count() != 0)
            {

                InitializeComponent();
                corporaciones = corpL.ToList();
                listBox1.DataSource = corporaciones;
            }
            else
            {
                MessageBox.Show("No hay corpos cargadas");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nom = inputNombre.Text;
            string cuil = InputCuil.Text;
            this.corporacion = new Corporacion(nom, cuil);


            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Corporacion cor = listBox1.SelectedItem as Corporacion;
            string nombre = cor.Nombre;
            string cuil = cor.Cuil;

            inputNombre.Text = nombre.ToString();
            InputCuil.Text = cuil.ToString();
        }

        public Corporacion darCorporacion()
        {
            return corporacion;
        }
    }
}
