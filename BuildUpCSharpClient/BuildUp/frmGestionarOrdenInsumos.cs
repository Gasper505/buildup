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
    public partial class frmGestionarOrdenInsumos : Form
    {
        public frmGestionarOrdenInsumos()
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
                    txtApellidosOperario.Enabled = false;
                    txtIdOperario.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtIdOrdenInsumos.Enabled = false;
                    txtNombresOperario.Enabled = false;
                    txtNombreInsumo.Enabled = false;
                    txtUnidadMedida.Enabled = false;
                    dtpFechaActual.Enabled = false;
                    btnBuscarInsumo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    txtApellidosOperario.Enabled = true;
                    txtIdOperario.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtIdOrdenInsumos.Enabled = false;
                    txtNombresOperario.Enabled = true;
                    txtNombreInsumo.Enabled = true;
                    txtUnidadMedida.Enabled = false;
                    dtpFechaActual.Enabled = true;
                    btnBuscarInsumo.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    txtApellidosOperario.Enabled = true;
                    txtIdOperario.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtIdOrdenInsumos.Enabled = false;
                    txtNombresOperario.Enabled = true;
                    txtNombreInsumo.Enabled = true;
                    txtUnidadMedida.Enabled = false;
                    dtpFechaActual.Enabled = true;
                    btnBuscarInsumo.Enabled = true;
                    break;

            }
        }

        private void btnNuevaOrdenInsumos_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardarOrdenInsumos_Click(object sender, EventArgs e)
        {
            //validar e insertar en BD
        }


        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmBuscarInsumo formBuscarInsumo = new frmBuscarInsumo();
            if (formBuscarInsumo.ShowDialog() == DialogResult.OK)
            {
                //...
            }
        }

        private void btnBuscarOrdenInsumos_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenInsumos formBuscarOrdenInsumos = new frmBuscarOrdenInsumos();
            if (formBuscarOrdenInsumos.ShowDialog() == DialogResult.OK)
            {
                //...
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtApellidosOperario.Text = "";
            txtIdOperario.Text = "";
            txtIdInsumo.Text = "";
            txtIdOrdenInsumos.Text = "";
            txtNombresOperario.Text = "";
            txtNombreInsumo.Text = "";
            txtUnidadMedida.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
