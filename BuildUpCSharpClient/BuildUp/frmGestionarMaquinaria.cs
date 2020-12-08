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

        MaqWS.MaquinariaWSClient daoMaquinaria;
        MaqWS.maquinaria maquinaria;
        LineaProduccionWS.lineaProduccion lineaProduccion;
        ProveedorWS.proveedor proveedor;

        public frmGestionarMaquinaria()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            if (frmLogIn.Usuario.rol == "Ingeniero"
                || frmLogIn.Usuario.rol == "ingeniero"
                || frmLogIn.Usuario.rol == "INGENIERO")
            {
                btnActualizar.Visible = false;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;

            }
            daoMaquinaria = new MaqWS.MaquinariaWSClient();
            maquinaria = new MaqWS.maquinaria();

            maquinaria.proveedor = new MaqWS.proveedor();
            maquinaria.lineaProduccion = new MaqWS.lineaProduccion();

            lineaProduccion = new LineaProduccionWS.lineaProduccion();
            proveedor = new ProveedorWS.proveedor();
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
                    txtIdLinea.Enabled = false;
                    txtIdProveedor.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNombreLinea.Enabled = false;
                    txtRepresentante.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtCorreoRep.Enabled = false;
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
                    txtIdLinea.Enabled = false;
                    txtIdProveedor.Enabled = false;
                    txtNombre.Enabled = true;
                    txtNombreLinea.Enabled = false;
                    txtRepresentante.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtCorreoRep.Enabled = false;
                    btnBuscarLinea.Enabled = true;
                    dtpFechaGarantia.Enabled = true;
                    break;

            }
        }

        //-----------------------------------------------------------------

        private void btnGuardarMaquinaria_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre de la maquinaria", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtIdLinea.Text == "")
            {
                MessageBox.Show("Debe seleccionar una linea de produccion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Maquinaria?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                maquinaria.nombre = txtNombre.Text;
                maquinaria.garantiaFin = dtpFechaGarantia.Value;
                maquinaria.proveedor.idProveedor = Int32.Parse(txtIdProveedor.Text);
                maquinaria.proveedor.razonSocial = txtRazonSocial.Text;
                maquinaria.proveedor.representante = txtRepresentante.Text;
                maquinaria.proveedor.correo = txtCorreoRep.Text;
                maquinaria.lineaProduccion.idLineaProduccion = Int32.Parse(txtIdLinea.Text);
                maquinaria.lineaProduccion.nombre = txtNombreLinea.Text;
                

                int result = daoMaquinaria.insertarMaquinaria(maquinaria);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarMaquinaria_Click(object sender, EventArgs e)
        {
            frmBuscarMaquinaria formBuscarMaquinaria = new frmBuscarMaquinaria();
            if (formBuscarMaquinaria.ShowDialog() == DialogResult.OK)
            {
                maquinaria = formBuscarMaquinaria.MaquinariaSeleccionada;
                txtIdMaquinaria.Text = maquinaria.idMaquinaria.ToString();
                txtNombre.Text = maquinaria.nombre;
                dtpFechaGarantia.Value = maquinaria.garantiaFin;
                txtIdLinea.Text = maquinaria.lineaProduccion.idLineaProduccion.ToString();
                txtNombreLinea.Text = maquinaria.lineaProduccion.nombre;
                txtIdProveedor.Text = maquinaria.proveedor.idProveedor.ToString();
                txtRepresentante.Text = maquinaria.proveedor.representante;
                txtRazonSocial.Text = maquinaria.proveedor.razonSocial;
                txtCorreoRep.Text = maquinaria.proveedor.correo;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }

            if (frmLogIn.Usuario.rol == "Ingeniero"
                || frmLogIn.Usuario.rol == "ingeniero"
                || frmLogIn.Usuario.rol == "INGENIERO")
            {

                EstablecerEstadoComponentes(Estado.Inicial);

            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Maquinaria del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoMaquinaria.eliminarMaquinaria(Int32.Parse(txtIdMaquinaria.Text));
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre de la maquinaria", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtIdLinea.Text == "")
            {
                MessageBox.Show("Debe seleccionar una linea de produccion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Maquinaria?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                maquinaria.idMaquinaria = Int32.Parse(txtIdMaquinaria.Text);
                maquinaria.nombre = txtNombre.Text;
                maquinaria.proveedor.idProveedor = Int32.Parse(txtIdProveedor.Text);
                maquinaria.proveedor.razonSocial = txtRazonSocial.Text;
                maquinaria.proveedor.representante = txtRepresentante.Text;
                maquinaria.proveedor.correo = txtCorreoRep.Text;
                maquinaria.lineaProduccion.idLineaProduccion = Int32.Parse(txtIdLinea.Text);
                maquinaria.lineaProduccion.nombre = txtNombreLinea.Text;
                maquinaria.garantiaFin = dtpFechaGarantia.Value;

                int result = 0;
                result = daoMaquinaria.modificarMaquinaria(maquinaria);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //-----------------------------------------------------------------

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor formBuscarProveedor = new frmBuscarProveedor();
            if (formBuscarProveedor.ShowDialog() == DialogResult.OK)
            {
                proveedor = formBuscarProveedor.ProveedorSeleccionado;
                txtIdProveedor.Text = proveedor.idProveedor.ToString();
                txtRepresentante.Text = proveedor.representante;
                txtRazonSocial.Text = proveedor.razonSocial;
                txtCorreoRep.Text = proveedor.correo;
            }
        }

        private void btnBuscarLinea_Click(object sender, EventArgs e)
        {
            frmBuscarLineaProduccion formBuscarLineaProduccion = new frmBuscarLineaProduccion();
            if (formBuscarLineaProduccion.ShowDialog() == DialogResult.OK)
            {
                lineaProduccion = formBuscarLineaProduccion.LineaProduccionSeleccionada;
                txtIdLinea.Text = lineaProduccion.idLineaProduccion.ToString();
                txtNombreLinea.Text = lineaProduccion.nombre;
            }
            
        }

        //-----------------------------------------------------------------

        private void btnNuevaMaquinaria_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
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
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
