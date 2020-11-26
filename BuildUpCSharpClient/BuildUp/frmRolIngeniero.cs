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
    public partial class frmRolIngeniero : Form
    {
        public frmRolIngeniero()
        {
            InitializeComponent();
            lblNombres.Text = frmLogIn.Usuario.nombres + ' ' + frmLogIn.Usuario.apellidos;
            //MemoryStream ms = new MemoryStream(frmLogIn.Usuario.foto);
            //pbFoto.Image = new Bitmap(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            this.Hide();
            frmLog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGestionarIncidencia formGestionarIncidencia = new frmGestionarIncidencia();
            formGestionarIncidencia.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmGestionarMaquinaria frmMaq = new frmGestionarMaquinaria();
            frmMaq.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGestionarProveedor frmProv = new frmGestionarProveedor();
            frmProv.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGestionarProblema frmGesProb = new frmGestionarProblema();
            frmGesProb.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmGestionarRespuesta frmGesResp = new frmGestionarRespuesta();
            frmGesResp.Show(this);
        }
    }
}
