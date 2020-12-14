using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            lblUsername.Text = frmLogIn.Usuario.username;

            if (pbFoto.Image != null)
            {
                pbFoto.Image.Dispose();
                pbFoto.Image = null;
            }
            MemoryStream ms;
            if (frmLogIn.Usuario.foto != null)
            {
                ms = new MemoryStream(frmLogIn.Usuario.foto);
                if (ms.Length != 0) pbFoto.Image = new Bitmap(ms);
            }
        }


        private void button1_Click(object sender, EventArgs e) //logout
        {
            
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cerrar su sesión?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                frmLogIn frmLog = new frmLogIn();
                this.Hide();
                frmLog.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarPlanProduccion frmPlan = new frmGestionarPlanProduccion();
            frmPlan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarOrdenInsumos frmOrdIns = new frmGestionarOrdenInsumos();
            frmOrdIns.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGestionarOrdenSalida f = new frmGestionarOrdenSalida();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGestionarMaquinaria f= new frmGestionarMaquinaria();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGestionarProveedor f = new frmGestionarProveedor();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmGestionarIncidencia f = new frmGestionarIncidencia();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmGestionarInsumo f = new frmGestionarInsumo();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmGestionarTipoLadrillo f = new frmGestionarTipoLadrillo();
            f.Show();
        }

        private void btnLineaProduccion_Click(object sender, EventArgs e)
        {
            frmGestionarLineaProduccion f = new frmGestionarLineaProduccion();
            f.Show();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            frmGestionarUsuario formGestionarUsuario = new frmGestionarUsuario();
            formGestionarUsuario.Show();
        }
    }
}
