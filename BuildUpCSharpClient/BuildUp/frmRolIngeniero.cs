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
    public partial class frmRolIngeniero : Form
    {
        public frmRolIngeniero()
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
                try
                {
                    ms = new MemoryStream(frmLogIn.Usuario.foto);
                    if (ms.Length != 0) pbFoto.Image = new Bitmap(ms);
                }
                catch
                {

                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            frmGestionarIncidencia formGestionarIncidencia = new frmGestionarIncidencia();
            formGestionarIncidencia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGestionarMaquinaria frmMaq = new frmGestionarMaquinaria();
            frmMaq.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGestionarProveedor frmProv = new frmGestionarProveedor();
            frmProv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGestionarProblema frmGesProb = new frmGestionarProblema();
            frmGesProb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarRespuesta frmGesResp = new frmGestionarRespuesta();
            frmGesResp.Show();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            frmGestionarUsuario formGestionarUsuario = new frmGestionarUsuario();
            formGestionarUsuario.Show();
        }
    }
}
