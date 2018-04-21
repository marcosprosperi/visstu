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
    public partial class altaCorporacion : Form
    {

        private Corporacion corporacion;

        public altaCorporacion()
        {
            InitializeComponent();
        }

        private void altaCorporacion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = inputNombre.Text;
                string cuil = InputCuil.Text;
                corporacion = new Corporacion(nom, cuil);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Corporacion darCorporacion()
        {
            return corporacion;
        }
    }
}
