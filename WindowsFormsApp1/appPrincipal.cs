using RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class appPrincipal : Form
    {
        private Empresa empresa;
        
        public appPrincipal()
        {
            empresa = new Empresa("ESTa empresa", 231223123);
            if (empresa.recuperarAutos())
                MessageBox.Show("AUTOS RECUPERADOS");


            InitializeComponent();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void appPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            
            formTipoInfraccion formTI = new formTipoInfraccion();
            formTI.ShowDialog();
            
            
            if(formTI.darInfraccion() != null)
                empresa.agregarTipoInfraccion(formTI.darInfraccion());
            

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(empresa.darListadoDeInfracciones().Count != 0) { 
                modInfraccion formModTI = new modInfraccion(empresa.darListadoDeInfracciones());
                formModTI.ShowDialog();
                empresa.modificarInfraccion(formModTI.darInfraccion());
            } else
            {
                MessageBox.Show("No hay tipo de infracciones cargadas");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void altaPersonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            altaPersona formAP = new altaPersona();
            formAP.ShowDialog();
            if (formAP.darPersona() != null)
                empresa.agregarPersona(formAP.darPersona());
        
        }

        private void modificarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empresa.getTodasLasPersonas().Count != 0)
            {
                modPersona formModPe = new modPersona(empresa.getTodasLasPersonas());
                formModPe.ShowDialog();
                if (formModPe.darPersona() != null)
                    empresa.modificarPersona(formModPe.darPersona());
            } else
            {
                MessageBox.Show("No hay personas cargadas");
            }
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaCorporacion altaCorpo = new altaCorporacion();
            altaCorpo.ShowDialog();
            if (altaCorpo.darCorporacion() != null)
                empresa.agregarCorporacion(altaCorpo.darCorporacion());
            
        }

        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empresa.getCorpos().Count != 0)
            {
                modCorporacion formModCo = new modCorporacion(empresa.getCorpos());
                formModCo.ShowDialog();
                if (formModCo.darCorporacion() != null)
                    empresa.modificarCorporacion(formModCo.darCorporacion());
            } else
            {
                MessageBox.Show("No hay corpos cargadas!");
            }
        }

        private void altaAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaAuto altaAuto = new altaAuto(empresa.getTodasLasPersonas(), empresa.getCorpos());
            altaAuto.ShowDialog();
            if (altaAuto.darAuto() != null)
                empresa.agregarAuto(altaAuto.darAuto());
        }

        private void altaMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            altaInfraccion altaInf = new altaInfraccion(empresa.darListadoDeInfracciones(), empresa.getAutos());
            altaInf.ShowDialog();
            if(altaInf.darInfraccion() != null)
                empresa.agregarInfracciones(altaInf.darInfraccion());
        }

        private void pagarMiultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (empresa.getMultasNoPagas().Count != 0)
            {
                pagoMulta pagoMulta = new pagoMulta(empresa.getMultasNoPagas());
                pagoMulta.ShowDialog();
                empresa.agregarPago(pagoMulta.darPago());
            } else
            {
                MessageBox.Show("No hay empresa cargadas");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (empresa.guardar())
                MessageBox.Show("GUARDADO OK");
            else
                MessageBox.Show("ERROR AL GAURDAR");

            this.Close();
        }

        private void modificarAutoToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void listadoDeVencidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informe informe = new Informe(empresa.getTodasLasPersonas(), empresa.getCorpos(), empresa.getMultasNoPagas());
            informe.ShowDialog();
           // if (altaAuto.darAuto() != null)
             //   empresa.agregarAuto(altaAuto.darAuto());
        }
    }
}
