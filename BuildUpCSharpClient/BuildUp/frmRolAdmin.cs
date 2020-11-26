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

            //MemoryStream ms = new MemoryStream(frmLogIn.Usuario.foto);
            //pbFoto.Image = new Bitmap(ms);
        }

        private void button2_Click(object sender, EventArgs e) //Gestionar usuario
        {
            frmGestionarUsuario formGestionarUsuario = new frmGestionarUsuario();
            formGestionarUsuario.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            this.Hide();
            frmLog.ShowDialog();
        }
    }
}
