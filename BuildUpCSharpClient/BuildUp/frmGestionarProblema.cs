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
    public partial class frmGestionarProblema : Form
    {
        public frmGestionarProblema()
        {
            InitializeComponent();
            establecerEstadoComponentes(Estado.Inicial);

        }
        public void establecerEstadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = false;
                    txtNivelImportancia.Enabled = false;
                    txtActivo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = true;
                    txtNivelImportancia.Enabled = true;
                    txtActivo.Enabled = false;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = true;
                    txtNivelImportancia.Enabled = true;
                    txtActivo.Enabled = true;
                    break;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            establecerEstadoComponentes(Estado.Nuevo);
            txtActivo.Text = "1";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //CODIGO QUE REGISTRARA LA INFORMACION EN LA BD


            //FIN
            txtIdProblema.Text = "";
            txtTipo.Text = "";
            txtNivelImportancia.Text = "";
            txtActivo.Text = "";
            establecerEstadoComponentes(Estado.Inicial);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro de eliminar el Problema?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdProblema.Text = "";
            txtTipo.Text = "";
            txtNivelImportancia.Text = "";        
            txtActivo.Text = "";
            establecerEstadoComponentes(Estado.Inicial);
        }

        private void frmGestionarProblema_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProblema formBuscarProblema = new frmBuscarProblema();
            if (formBuscarProblema.ShowDialog() == DialogResult.OK)
            {
                //PASO DE INFORMACION
            }
            establecerEstadoComponentes(Estado.Modificacion);
        }
    }
}
