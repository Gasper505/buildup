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
    public partial class frmGestionarOrdenSalida : Form
    {

        OSalidaWS.OrdenSalidaWSClient daoOrdenSalida;
        OSalidaWS.ordenSalida ordenSalida;

        public frmGestionarOrdenSalida()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoOrdenSalida = new OSalidaWS.OrdenSalidaWSClient();
            ordenSalida = new OSalidaWS.ordenSalida();
            dgvLotes.AutoGenerateColumns = false;
            dgvLotes.DataSource = ordenSalida.lineasOrdenSalida;

            if (frmLogIn.Usuario.rol == "Jefe"
                || frmLogIn.Usuario.rol == "JEFE"
                || frmLogIn.Usuario.rol == "Jefe de Área"
                || frmLogIn.Usuario.rol == "Jefe de Area"
                || frmLogIn.Usuario.rol == "JEFE DE AREA"
                || frmLogIn.Usuario.rol == "JEFE DE ÁREA")
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
                    txtIDOrden.Text = "";
                    if(frmLogIn.Usuario.rol == "Operario")
                    {
                        txtIDOperario.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombres.Text = frmLogIn.Usuario.nombres;
                        txtApellidos.Text = frmLogIn.Usuario.apellidos;
                    }
                    else
                    {
                        txtIDOperario.Text = "";
                        txtNombres.Text = "";
                        txtApellidos.Text = "";
                    }
                        
                    cboNombreTipoLadrillo.Text = "";
                    dgvLotes.RowCount = 0;
                    numNroAproxLadrillos.Value = 0;
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtIDOrden.Enabled = false;
                    dtpFechaRegistro.Enabled = false;
                    txtIDOperario.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    cboNombreTipoLadrillo.Enabled = false;
                    dgvLotes.Enabled = false;
                    numNroAproxLadrillos.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnRemover.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDOrden.Enabled = false;
                    dtpFechaRegistro.Enabled = false;
                    txtIDOperario.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvLotes.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDOrden.Enabled = false;
                    dtpFechaRegistro.Enabled = false;
                    txtIDOperario.Enabled = false;
                    txtNombres.Enabled = false;
                    txtApellidos.Enabled = false;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvLotes.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    break;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ordenSalida = new OSalidaWS.ordenSalida();
            ordenSalida.fecha = dtpFechaRegistro.Value;
            ordenSalida.idOrdenSalida = Int32.Parse(txtIDOrden.Text);
            ordenSalida.operario.apellidos = txtApellidos.Text;
            ordenSalida.operario.nombres = txtNombres.Text;
            ordenSalida.operario.idPersona = Int32.Parse(txtIDOperario.Text);


            daoOrdenSalida.insertar(ordenSalida);
            MessageBox.Show("Orden de Salida registrada con éxito", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstablecerEstadoComponentes(Estado.Inicial);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenSalida formBuscarOrdenSalida = new frmBuscarOrdenSalida();
            if (formBuscarOrdenSalida.ShowDialog() == DialogResult.OK)
            {
                ordenSalida = new OSalidaWS.ordenSalida();
                ordenSalida = formBuscarOrdenSalida.OrdenSeleccionada;
                txtIDOrden.Text = ordenSalida.idOrdenSalida.ToString();
                dtpFechaRegistro.Value = ordenSalida.fecha;
                txtIDOperario.Text = ordenSalida.operario.idPersona.ToString();
                txtNombres.Text = ordenSalida.operario.nombres;
                txtApellidos.Text = ordenSalida.operario.apellidos;

                dgvLotes.DataSource = ordenSalida.lineasOrdenSalida;
                
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void dgvLotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OSalidaWS.ordenSalida data = dgvLotes.Rows[e.RowIndex].DataBoundItem as OSalidaWS.ordenSalida;
            dgvLotes.Rows[e.RowIndex].Cells[1].Value = data.operario.nombres + data.operario.apellidos;
        }
    }
}
