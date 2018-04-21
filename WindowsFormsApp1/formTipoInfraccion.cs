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
    public partial class formTipoInfraccion : Form
    {
        protected TipoInfraccion tipoInfraccion;

        public formTipoInfraccion()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(inputCod.Text);
                string detalle = InputDetalle.Text;
                float impo = float.Parse(InputImporte.Text);
                if (radioGrave.Checked)
                    tipoInfraccion = new InfraccionGrave(cod, detalle, impo);
                else
                    tipoInfraccion = new InfraccionLeve(cod, detalle, impo);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public TipoInfraccion darInfraccion() {
            return tipoInfraccion;
        }

        private void formTipoInfraccion_Load(object sender, EventArgs e)
        {
                
        }
    }
}