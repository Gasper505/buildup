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
    public partial class frmGestionarMaquinaria : Form
    {

        public frmGestionarMaquinaria()
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
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscarProveedor.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtIdMaquinaria.Enabled = false;
                    txtIdLinea.Enabled = false;
                    txtIdProveedor.Enabled = false;
                    txtNombre.Enabled = false;
                    txtNombreLinea.Enabled = false;
                    txtRepresentante.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtCorreoRep.Enabled = false;
                    btnBuscarLinea.Enabled = false;
                    dtpFechaGarantia.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscarProveedor.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                    txtIdMaquinaria.Enabled = false;
                    txtIdLinea.Enabled = true;
                    txtIdProveedor.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNombreLinea.Enabled = true;
                    txtRepresentante.Enabled = true;
                    txtRazonSocial.Enabled = true;
                    txtCorreoRep.Enabled = true;
                    btnBuscarLinea.Enabled = true;
                    dtpFechaGarantia.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscarProveedor.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnEliminar.Enabled = true;
                    txtIdMaquinaria.Enabled = false;
                    txtIdLinea.Enabled = true;
                    txtIdProveedor.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNombreLinea.Enabled = true;
                    txtRepresentante.Enabled = true;
                    txtRazonSocial.Enabled = true;
                    txtCorreoRep.Enabled = true;
                    btnBuscarLinea.Enabled = true;
                    dtpFechaGarantia.Enabled = true;
                    break;

            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor formBuscarProveedor = new frmBuscarProveedor();
            if (formBuscarProveedor.ShowDialog() == DialogResult.OK)
            {
                //Recibir proveedor seleccionado de frmBuscarMaquinaria
            }
        }

        private void btnNuevaMaquinaria_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardarMaquinaria_Click(object sender, EventArgs e)
        {
            //Insercion en BD.
        }

        private void btnBuscarMaquinaria_Click(object sender, EventArgs e)
        {
            frmBuscarMaquinaria formBuscarMaquinaria = new frmBuscarMaquinaria();
            if (formBuscarMaquinaria.ShowDialog() == DialogResult.OK)
            {
                //Recibir maquinaria seleccionada de frmBuscarMaquinaria
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdMaquinaria.Text = "";
            txtIdLinea.Text = "";
            txtIdProveedor.Text = "";
            txtNombre.Text = "";
            txtNombreLinea.Text = "";
            txtRepresentante.Text = "";
            txtRazonSocial.Text = "";
            txtCorreoRep.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminacion logica de BD.
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Modificacion en BD.
        }

        private void btnBuscarLinea_Click(object sender, EventArgs e)
        {
            frmBuscarLineaProduccion formBuscarLineaProduccion = new frmBuscarLineaProduccion();
            if (formBuscarLineaProduccion.ShowDialog() == DialogResult.OK)
            {
                //Recibir linea seleccionada de frmBuscarLineaProduccion
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }
    }
}
