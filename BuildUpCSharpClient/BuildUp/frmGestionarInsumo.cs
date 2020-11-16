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
    public partial class frmGestionarInsumo : Form
    {
        public frmGestionarInsumo()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void EstablecerEstadoComponentes(Estado estado)
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
                    txtIdInsumo.Enabled = false;
                    txtNombreInsumo.Enabled = false;
                    cboUnidadMedida.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtNombreInsumo.Enabled = true;
                    cboUnidadMedida.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    txtIdInsumo.Enabled = false;
                    txtNombreInsumo.Enabled = true;
                    cboUnidadMedida.Enabled = true;
                    break;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarInsumo formBuscarInsumo = new frmBuscarInsumo();
            if (formBuscarInsumo.ShowDialog() == DialogResult.OK)
            {
                //...
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdInsumo.Text = "";
            txtNombreInsumo.Text = "";
            cboUnidadMedida.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
