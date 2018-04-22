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
            empresa = new Empresa("empresa", 123);
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
            if (!empresa.yaExisteInfraccion(formTI.darInfraccion()))
                empresa.agregarTipoInfraccion(formTI.darInfraccion());
            else
                MessageBox.Show("Ya existe una infraccion");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modInfraccion formModTI = new modInfraccion(empresa.darListadoDeInfracciones());
            formModTI.ShowDialog();
            empresa.modificarInfraccion(formModTI.darInfraccion());

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
            if (!empresa.yaExistePersona(formAP.darPersona()))
                empresa.agregarPersona(formAP.darPersona());
            else
                MessageBox.Show("Ya existe una infraccion");
        }

        private void modificarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modPersona formModPe = new modPersona(empresa.getTodasLasPersonas());
            formModPe.ShowDialog();
            empresa.modificarPersona(formModPe.darPersona());
        }

        private void altaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaCorporacion altaCorpo = new altaCorporacion();
            altaCorpo.ShowDialog();
            if (!empresa.yaExisteCorpo(altaCorpo.darCorporacion()))
                empresa.agregarCorporacion(altaCorpo.darCorporacion());
            else
                MessageBox.Show("Ya existe una ...");
        }

        private void modificarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCorporacion formModCo = new modCorporacion(empresa.getCorpos());
            formModCo.ShowDialog();
            empresa.modificarCorporacion(formModCo.darCorporacion());
        }

        private void altaAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaAuto altaAuto = new altaAuto(empresa.getTodasLasPersonas(), empresa.getCorpos());
            altaAuto.ShowDialog();
            empresa.agregarAuto(altaAuto.darAuto());
        }

        private void altaMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaInfraccion altaInf = new altaInfraccion(empresa.darListadoDeInfracciones(), empresa.getAutos());
            altaInf.ShowDialog();
            empresa.agregarInfracciones(altaInf.darInfraccion());
        }


    }
}
