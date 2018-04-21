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
    public partial class altaAuto : Form
    {
        public altaAuto()
        {
            InitializeComponent();
        }

        private void altaAuto_Load(object sender, EventArgs e)
        {

        }

        private void ComoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ComboUsuario.Text == "Persona")
            {
                listBox1.Visible = true;
                //aca cargo el list
            } else
            {
                if (ComboUsuario.Text == "Corporacion")
                {
                    listBox1.Visible = true;
                    //cargo list de corpo
                }
            }
        }
    }
}
