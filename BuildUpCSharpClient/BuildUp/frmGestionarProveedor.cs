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

            if (frmLogIn.Usuario.rol == "Ingeniero")
            {
                btnActualizar.Visible = false;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;

            }
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
                    txtRuc.Enabled = false;
                    txtDireccion.Enabled = false;

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
                    txtRuc.Enabled = true;
                    txtDireccion.Enabled = true;
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
                    txtRuc.Enabled = true;
                    txtDireccion.Enabled = true;
                    break;
            }
        }

        //-----------------------------------------------------------------
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtRuc.Text == "")
            {
                MessageBox.Show("Debe ingresar el RUC del proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("Debe escribir la razon social", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar la dirección del proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar el correo electronico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRepresentante.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del representante", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Proveedor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                proveedor.razonSocial = txtRazonSocial.Text;
                proveedor.representante = txtRepresentante.Text;
                proveedor.correo = txtCorreo.Text;
                proveedor.ruc = txtRuc.Text;
                proveedor.direccion = txtDireccion.Text;

                int result = daoProveedor.insertarProveedor(proveedor);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProveedor.Text = "";
                    txtRazonSocial.Text = "";
                    txtCorreo.Text = "";
                    txtRepresentante.Text = "";
                    txtRuc.Text = "";
                    txtDireccion.Text = "";
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
                txtRuc.Text = proveedor.ruc;
                txtDireccion.Text = proveedor.direccion;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }

            if (frmLogIn.Usuario.rol == "Ingeniero")
            {
                EstablecerEstadoComponentes(Estado.Inicial);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtRuc.Text == "")
            {
                MessageBox.Show("Debe ingresar el RUC del proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("Debe escribir la razon social", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe ingresar la dirección del proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar el correo electronico", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRepresentante.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del representante", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
           

            DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar los datos de este Proveedor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                proveedor.idProveedor = Int32.Parse(txtIDProveedor.Text);
                proveedor.razonSocial = txtRazonSocial.Text;
                proveedor.representante = txtRepresentante.Text;
                proveedor.correo = txtCorreo.Text;
                proveedor.ruc = txtRuc.Text;
                proveedor.direccion = txtDireccion.Text;

                int result = daoProveedor.actualizarProveedor(proveedor);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDProveedor.Text = "";
                    txtRazonSocial.Text = "";
                    txtCorreo.Text = "";
                    txtRepresentante.Text = "";
                    txtRuc.Text = "";
                    txtDireccion.Text = "";
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
                txtRuc.Text = "";
                txtDireccion.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (ActiveForm != null) ActiveForm.Show();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtIDProveedor.Text = "";
                txtRazonSocial.Text = "";
                txtCorreo.Text = "";
                txtRepresentante.Text = "";
                txtRuc.Text = "";
                txtDireccion.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbDatosProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtRepresentante_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
