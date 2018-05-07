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
    public partial class Informe : Form
    {

        protected List<Persona> personas;
        protected List<Corporacion> corporaciones;
        protected List<Infraccion> infracciones;

        public Informe(List<Persona> pers, List<Corporacion> corpos, List<Infraccion> infras)
        {

            InitializeComponent();
            this.personas = pers;
            this.corporaciones = corpos;
            this.infracciones = infras;
            
        }

        private void Informe_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = null;
            if(comboBox1.SelectedItem == "Personas")
                comboBox2.DataSource = this.personas;
            else
                comboBox2.DataSource = this.corporaciones;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = null;
            Entidad selectedItem2 = comboBox2.SelectedItem as Entidad;
            if(selectedItem2 != null)
                comboBox3.DataSource = selectedItem2.getAutos();
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto selectedItem3 = comboBox3.SelectedItem as Auto;
            Infraccion infraSelected = listBox1.SelectedItem as Infraccion;
            Entidad selectedItem2 = comboBox2.SelectedItem as Entidad;
            if(selectedItem3 != null && infraSelected != null && selectedItem2 != null) { 
                label25.Text = DateTime.Today.ToShortDateString();
                label22.Text = infraSelected.Dominio;
                label17.Text = infraSelected.TipoInfraccion.Codigo.ToString();
                label19.Text = infraSelected.TipoInfraccion.Detalle;
                label16.Text = "$" + infraSelected.TipoInfraccion.Importe.ToString() + ".-";
                label18.Text = infraSelected.TipoInfraccion.getTipo();
                label20.Text = selectedItem3.Marca;
                label21.Text = selectedItem3.Anio.ToString();
                label23.Text = selectedItem3.Modelo;
                var MesesAdeudados = Math.Abs((DateTime.Today.Month - infraSelected.Fecha.Month) + 12 * (DateTime.Today.Year - infraSelected.Fecha.Year));
                label29.Text = MesesAdeudados.ToString();
                label27.Text = infraSelected.Fecha.ToShortDateString();
                var totalAPagar = 0f;
                if (selectedItem2.getTipo() == "Persona")
                {
                    totalAPagar = infraSelected.TipoInfraccion.Importe;
                    label15.Text = "2%";
                    for(var i = 0;i<MesesAdeudados;i++)
                    {
                        totalAPagar = totalAPagar * 1.02f;
                    }
                    label14.Text = "$" + totalAPagar.ToString() + ".-";
                } else
                {
                    totalAPagar = infraSelected.TipoInfraccion.Importe;
                    label15.Text = "3%";
                    for (var i = 0; i < MesesAdeudados; i++)
                    {
                        totalAPagar = totalAPagar * 1.03f;
                    }
                    label14.Text = "$" + totalAPagar.ToString() + ".-";
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            Auto selectedItem3 = comboBox3.SelectedItem as Auto;
            if(selectedItem3 != null) { 
                List<Infraccion> infracionDelAuto = new List<Infraccion>();
                foreach (Infraccion infr in infracciones)
                {
                    if (infr.Dominio == selectedItem3.Dominio && infr.estaVencida())
                        infracionDelAuto.Add(infr);
                }
                listBox1.DataSource = infracionDelAuto;
            }
        }
    }
}
