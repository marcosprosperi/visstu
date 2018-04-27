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
    [Serializable]
    public partial class pagoMulta : Form
    {
        List<Infraccion> infracciones;
        Pago pago;

        public pagoMulta(List<Infraccion> infra)
        {
            this.infracciones = infra;
            InitializeComponent();
            listBox1.DataSource = null;
            foreach (Infraccion infrac in infracciones)
            {
                if (!infrac.infraccionPaga() && !infrac.estaVencida())
                    listBox1.Items.Add(infra.ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            Infraccion infraSele =listBox1.SelectedItem as Infraccion;
            Pago pago = new Pago(fechaHoy, infraSele);
            infraSele.pagar();
            
        }

        public Pago darPago()
        {
            return pago;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
