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
            InitializeComponent();
            this.infracciones = infra;
            listBox1.DataSource = null;
            listBox1.DataSource = infra;
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Infraccion selectedItem = listBox1.SelectedItem as Infraccion;
            if(selectedItem.estaVencida())
            {
                MessageBox.Show("Esta vencida no se puede abonar!");
                button1.Enabled = false;
            } else
            {
                button1.Enabled = true;
            }
            
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            Infraccion infraSele = listBox1.SelectedItem as Infraccion;
            Pago pago = new Pago(fechaHoy, infraSele);
            infraSele.pagar();
            this.Close();
            
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
