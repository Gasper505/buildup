using BuildUp.ProveedorWS;
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
    public partial class frmGestionarProveedor : Form
    {
        ProveedorWS.ProveedorWSClient daoProveedor;
        ProveedorWS.proveedor prov;

        public frmGestionarProveedor()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoProveedor = new ProveedorWS.ProveedorWSClient();
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
                    txtIDProveedor.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtCorreo.Enabled = false;
                    txtRepresentante.Enabled = false;

                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    txtIDProveedor.Enabled = false;
                    txtRazonSocial.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtRepresentante.Enabled = true;
                    break;

                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    txtIDProveedor.Enabled = false;
                    txtRazonSocial.Enabled = true;
                    txtCorreo.Enabled = true;
                    txtRepresentante.Enabled = true;
                    break;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtRepresentante.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            prov = new ProveedorWS.proveedor();
            prov.razonSocial = txtRazonSocial.Text;
            prov.correo = txtCorreo.Text;
            prov.representante = txtRepresentante.Text;
            daoProveedor.insertarProveedor(prov);
            MessageBox.Show("Se ha registrado correctamente el proveedor", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtIDProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtRepresentante.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscarProveedor formBuscarProveedor = new frmBuscarProveedor();
            if (formBuscarProveedor.ShowDialog() == DialogResult.OK)
            {
                //...
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
