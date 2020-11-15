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
    public partial class frmGestionarPlanProduccion : Form
    {

        public frmGestionarPlanProduccion()
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
                    btnAgregar.Enabled = false;
                    btnRemover.Enabled = false;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = false;
                    cboNombreTipoLadrillo.Enabled = false;
                    dgvAsignacion.Enabled = false;
                    numNroAproxLadrillos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = true;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvAsignacion.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = true;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvAsignacion.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    break;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstablecerEstadoComponentes(Estado.Inicial);
        }


        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmBuscarPlanProduccion formBuscarPlanProduccion = new frmBuscarPlanProduccion();
            if (formBuscarPlanProduccion.ShowDialog() == DialogResult.OK)
            {
                //...
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
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
            txtIDPlan.Text = "";
            txtAnho.Text = "";
            cboNombreTipoLadrillo.Text = "";
            numNroAproxLadrillos.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }
    }
}
