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
    public partial class frmGestionarRegistroMerma : Form
    {
        public frmGestionarRegistroMerma()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
        }
        public void EstablecerEstadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                    txtIDmerma.Enabled = false;
                    cboTipoMerma.Enabled = false;
                    txtCantidad.Enabled = false;
                    dtpFechaMerma.Enabled = false;
                    txtSupervisor.Enabled = false;
                    txtLineaProduccion.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                    txtIDmerma.Enabled = false;
                    cboTipoMerma.Enabled = true;
                    txtCantidad.Enabled = true;
                    dtpFechaMerma.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;

                    txtIDmerma.Enabled = false;
                    cboTipoMerma.Enabled = true;
                    txtCantidad.Enabled = true;
                    dtpFechaMerma.Enabled = true;
                    break;
            }
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente","Mensaje Informativo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmBuscarRegistroMerma formBuscarMerma = new frmBuscarRegistroMerma();
            formBuscarMerma.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtSupervisor.Text = frmLogIn.Usuario.nombres + frmLogIn.Usuario.apellidos;
  
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDmerma.Text = "";
            cboTipoMerma.Text = "";
            txtCantidad.Text = "";
            dtpFechaMerma.Value = DateTime.Now;
            txtSupervisor.Text = "";
            txtLineaProduccion.Text = "";
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
