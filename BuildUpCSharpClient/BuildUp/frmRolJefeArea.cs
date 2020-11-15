using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp
{
    public partial class frmRolJefeArea : Form
    {
        public frmRolJefeArea()
        {
            InitializeComponent();
            lblNombres.Text = frmLogIn.Usuario.nombres + ' ' + frmLogIn.Usuario.apellidos;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            this.Hide();
            frmLog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarPlanProduccion frmPlan = new frmGestionarPlanProduccion();
            frmPlan.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarOrdenInsumos frmOrdIns = new frmGestionarOrdenInsumos();
            frmOrdIns.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGestionarOrdenSalida f = new frmGestionarOrdenSalida();
            f.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGestionarMaquinaria f= new frmGestionarMaquinaria();
            f.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGestionarProveedor f = new frmGestionarProveedor();
            f.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmGestionarIncidencia f = new frmGestionarIncidencia();
            f.Show(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmGestionarInsumo f = new frmGestionarInsumo();
            f.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmGestionarTipoLadrillo f = new frmGestionarTipoLadrillo();
            f.Show(this);
        }

        private void btnLineaProduccion_Click(object sender, EventArgs e)
        {
            frmGestionarLineaProduccion f = new frmGestionarLineaProduccion();
            f.Show(this);
        }
    }
}
