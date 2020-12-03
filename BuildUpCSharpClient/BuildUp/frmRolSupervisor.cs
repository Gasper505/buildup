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
    public partial class frmRolSupervisor : Form
    {
        public frmRolSupervisor()
        {
            InitializeComponent();
            lblNombres.Text = frmLogIn.Usuario.nombres + ' ' + frmLogIn.Usuario.apellidos;

            //MemoryStream ms = new MemoryStream(frmLogIn.Usuario.foto);
            //pbFoto.Image = new Bitmap(ms);
        }

        private void btnIncidencia_Click(object sender, EventArgs e)
        {
            frmGestionarIncidencia formGestionarIncidencia = new frmGestionarIncidencia();
            formGestionarIncidencia.Show(this);
        }

        private void btnMerma_Click(object sender, EventArgs e)
        {
            frmGestionarMerma formGestionarMerma = new frmGestionarMerma();
            formGestionarMerma.Show(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            this.Hide();
            frmLog.ShowDialog();
        }

        private void btnAcontecimientoMerma_Click(object sender, EventArgs e)
        {
            frmGestionarRegistroMerma formGestionarRegistroMerma = new frmGestionarRegistroMerma();
            formGestionarRegistroMerma.Show(this);
        }
    }
}
