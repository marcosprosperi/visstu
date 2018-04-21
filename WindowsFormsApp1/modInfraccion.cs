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

    public partial class modInfraccion : Form
    {

        protected List<TipoInfraccion> tipoDeinfracciones;
        protected TipoInfraccion tipoInfraccion;
        private void modInfraccion_Load(object sender, EventArgs e)
        {

        }

        public modInfraccion(List<TipoInfraccion> listT)
        {
            if (listT.Count() != 0)
            {
               
                InitializeComponent();
                tipoDeinfracciones = listT.ToList();
                listTipoInfraccion.DataSource = null;
                listTipoInfraccion.DataSource = tipoDeinfracciones;

            }
            else
            {
                MessageBox.Show("No hay tipo de infracciones cargadas");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TipoInfraccion tipoIn = listTipoInfraccion.SelectedItem as TipoInfraccion;
            int cod = tipoIn.Codigo;
            string detalle = tipoIn.Detalle;
            float imp = tipoIn.Importe;

            string tipo = tipoIn.getTipo();

            groupBox1.Enabled = true;

            inputCod.Text = cod.ToString();
            InputDetalle.Text = detalle;
            InputImporte.Text = String.Format("{000,00}", imp); 
            if (tipo == "leve")
                RadioLeve.Checked = true;
            else
                radioGrave.Checked = true;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(inputCod.Text);
            string detalle = InputDetalle.Text;
            float precio = float.Parse(InputImporte.Text);
            if (radioGrave.Checked)
                tipoInfraccion = new InfraccionGrave(cod, detalle, precio);
            else
                tipoInfraccion = new InfraccionLeve(cod, detalle, precio);

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public TipoInfraccion darInfraccion()
        {
            return tipoInfraccion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}