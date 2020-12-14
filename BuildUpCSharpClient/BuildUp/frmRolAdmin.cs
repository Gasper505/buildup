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
    public partial class frmRolAdmin : Form
    {
        public frmRolAdmin()
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

        private void button2_Click(object sender, EventArgs e) //Gestionar usuario
        {
            frmGestionarUsuario formGestionarUsuario = new frmGestionarUsuario();
            formGestionarUsuario.Show();
            
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

    }
}
