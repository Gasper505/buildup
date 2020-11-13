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
    public partial class frmRolSupervisor : Form
    {
        public frmRolSupervisor()
        {
            InitializeComponent();
            lblNombres.Text = frmLogIn.Usuario.nombres + ' ' + frmLogIn.Usuario.apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            this.Hide();
            frmLog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarIncidencia f = new frmGestionarIncidencia();
            f.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
