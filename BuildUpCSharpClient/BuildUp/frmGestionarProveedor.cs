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
        ProveedorWS.proveedor proveedor;

        public frmGestionarProveedor()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoProveedor = new ProveedorWS.ProveedorWSClient();
            proveedor = new ProveedorWS.proveedor();
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

        //-----------------------------------------------------------------
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Proveedor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                proveedor.razonSocial = txtRazonSocial.Text;
                proveedor.representante = txtRepresentante.Text;
                proveedor.correo = txtCorreo.Text;

                int result = daoProveedor.insertarProveedor(proveedor);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProveedor.Text = "";
                    txtRazonSocial.Text = "";
                    txtCorreo.Text = "";
                    txtRepresentante.Text = "";
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscarProveedor formBuscarProveedor = new frmBuscarProveedor();
            if (formBuscarProveedor.ShowDialog() == DialogResult.OK)
            {
                proveedor = formBuscarProveedor.ProveedorSeleccionado;
                txtIDProveedor.Text = proveedor.idProveedor.ToString();
                txtRazonSocial.Text = proveedor.razonSocial;
                txtCorreo.Text = proveedor.correo;
                txtRepresentante.Text = proveedor.representante;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar este Proveedor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                proveedor.idProveedor = Int32.Parse(txtIDProveedor.Text);
                proveedor.razonSocial = txtRazonSocial.Text;
                proveedor.representante = txtRepresentante.Text;
                proveedor.correo = txtCorreo.Text;

                int result = daoProveedor.actualizarProveedor(proveedor);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProveedor.Text = "";
                    txtRazonSocial.Text = "";
                    txtCorreo.Text = "";
                    txtRepresentante.Text = "";
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Tipo de Ladrillo del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoProveedor.eliminarProveedor(Int32.Parse(txtIDProveedor.Text));
                txtIDProveedor.Text = "";
                txtRazonSocial.Text = "";
                txtCorreo.Text = "";
                txtRepresentante.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

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
    }
}
