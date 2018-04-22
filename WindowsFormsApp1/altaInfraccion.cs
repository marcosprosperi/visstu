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
    public partial class altaInfraccion : Form
    {
        protected List<TipoInfraccion> listInfracciones;
        protected List<Auto> autos;
        protected Infraccion infraccion;

        public altaInfraccion(List<TipoInfraccion> listTI, List<Auto> aut)
        {
            this.listInfracciones = listTI;
            this.autos = aut;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string domBuscar = this.textBox1.Text;
            Auto autC = this.autos.Find(x => x.Dominio == domBuscar);
            if(autC != null)
            {
                labelError.Visible = false;
                this.Height = 314;
                labelAnio.Text = autC.Anio.ToString();
                labelModelo.Text = autC.Modelo.ToString();
                labelMarca.Text = autC.Marca.ToString();
            } else
            {
                this.Height = 140;
                labelError.Visible = true;
                labelError.Text = "No se encontro ese dominio";

            }

        }

        private void altaInfraccion_Load(object sender, EventArgs e)
        {

        }

        public Infraccion darInfraccion()
        {
            return darInfraccion();
        }
    }
}
