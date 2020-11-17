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
                    txtIDmerma.Enabled = false;
                    cboTipoMerma.Enabled = false;
                    txtCantidad.Enabled = false;
                    cboSupervisor.Enabled = false;
                    cboLineaProduccion.Enabled = false;
                    dtpFechaMerma.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    txtIDmerma.Enabled = false;
                    cboTipoMerma.Enabled = true;
                    txtCantidad.Enabled = true;
                    cboSupervisor.Enabled = true;
                    cboLineaProduccion.Enabled = true;
                    dtpFechaMerma.Enabled = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            establecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente",
               "Mensaje Informativo", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            establecerEstadoComponentes(Estado.Inicial);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmBuscarRegistroMerma formBuscarMerma = new frmBuscarRegistroMerma();
            formBuscarMerma.ShowDialog();
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
