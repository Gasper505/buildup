using System;
using System.Collections;
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
        BindingList<OSalidaWS.lineaOrdenSalida> lineasOs;
        TipoLadrilloWS.TipoLadrilloWSClient daoTipoLadrillo;

        public frmGestionarOrdenSalida()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoOrdenSalida = new OSalidaWS.OrdenSalidaWSClient();
            ordenSalida = new OSalidaWS.ordenSalida();
            //lineasOs = new BindingList<OSalidaWS.lineaOrdenSalida>();


            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();

            dgvLotes.AutoGenerateColumns = false;
            dgvLotes.DataSource = ordenSalida.lineasOrdenSalida;

            cboNombreTipoLadrillo.DataSource = new BindingList<TipoLadrilloWS.tipoLadrillo>(daoTipoLadrillo.listarTiposLadrillo().ToArray());
            cboNombreTipoLadrillo.ValueMember = "idTipoLadrillo";
            cboNombreTipoLadrillo.DisplayMember = "nombre";

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
                    //dgvLotes.RowCount = 0;
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
        

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lineasOs==null || lineasOs.Count==0)
            {
                MessageBox.Show("Debe agregar lineas para orden de salida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Orden de Salida?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ordenSalida.fecha = dtpFechaRegistro.Value;
                ordenSalida.operario = new OSalidaWS.operario();
                ordenSalida.operario.apellidos = txtApellidos.Text;
                ordenSalida.operario.nombres = txtNombres.Text;
                ordenSalida.operario.idPersona = Int32.Parse(txtIDOperario.Text);
                ordenSalida.lineasOrdenSalida = lineasOs.ToArray();


                int result = daoOrdenSalida.insertarOrdenSalida(ordenSalida);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDOrden.Text = "";
                    dtpFechaRegistro.Value = DateTime.Now;
                    txtIDOperario.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    cboNombreTipoLadrillo.Text = "";
                    dgvLotes.DataSource = null;
                    numNroAproxLadrillos.Value = 0;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lineasOs = new BindingList<OSalidaWS.lineaOrdenSalida>();
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

                if (ordenSalida.lineasOrdenSalida != null)
                {
                    foreach (OSalidaWS.lineaOrdenSalida linea in ordenSalida.lineasOrdenSalida)
                    {
                        lineasOs.Add(linea);
                    }
                }

                //dgvLotes.DataSource = ordenSalida.lineasOrdenSalida; //<---
                dgvLotes.DataSource = lineasOs.ToArray();

                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            if (frmLogIn.Usuario.rol == "Jefe"
                || frmLogIn.Usuario.rol == "JEFE"
                || frmLogIn.Usuario.rol == "Jefe de Área"
                || frmLogIn.Usuario.rol == "Jefe de Area"
                || frmLogIn.Usuario.rol == "JEFE DE AREA"
                || frmLogIn.Usuario.rol == "JEFE DE ÁREA")
            {
                EstablecerEstadoComponentes(Estado.Inicial);
            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Orden de Salida?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ordenSalida.idOrdenSalida = Int32.Parse(txtIDOrden.Text);
                ordenSalida.operario = new OSalidaWS.operario();
                ordenSalida.fecha = dtpFechaRegistro.Value;
                ordenSalida.operario.apellidos = txtApellidos.Text;
                ordenSalida.operario.nombres = txtNombres.Text;
                ordenSalida.operario.idPersona = Int32.Parse(txtIDOperario.Text);
                //ordenSalida.lineasOrdenSalida = lineasOs.ToArray();

                int result = 0;
                result = daoOrdenSalida.actualizarOrdenSalida(ordenSalida);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDOrden.Text = "";
                    dtpFechaRegistro.Value = DateTime.Now;
                    txtIDOperario.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    cboNombreTipoLadrillo.Text = "";
                    dgvLotes.DataSource =null;
                    numNroAproxLadrillos.Value = 0;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //lineasOs = null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Orden de Salida del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoOrdenSalida.eliminarOrdenSalida(Int32.Parse(txtIDOrden.Text));
                txtIDOrden.Text = "";
                dtpFechaRegistro.Value = DateTime.Now;
                txtIDOperario.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                cboNombreTipoLadrillo.Text = "";
                dgvLotes.DataSource = null;
                numNroAproxLadrillos.Value = 0;
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtIDOrden.Text = "";
                dtpFechaRegistro.Value = DateTime.Now;
                txtIDOperario.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                cboNombreTipoLadrillo.Text = "";
                dgvLotes.DataSource = null;
                numNroAproxLadrillos.Value = 0;
                lineasOs = new BindingList<OSalidaWS.lineaOrdenSalida>();
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (ActiveForm != null) ActiveForm.Show();
        }

        private void dgvLotes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 
            OSalidaWS.lineaOrdenSalida data = dgvLotes.Rows[e.RowIndex].DataBoundItem as OSalidaWS.lineaOrdenSalida;
            dgvLotes.Rows[e.RowIndex].Cells[0].Value = data.tipoLadrillo.nombre;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lineasOs == null)
            {
                lineasOs = new BindingList<OSalidaWS.lineaOrdenSalida>();
            }

            if (cboNombreTipoLadrillo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numNroAproxLadrillos.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(numNroAproxLadrillos.Text) == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (ordenSalida.lineasOrdenSalida != null) {
                foreach (OSalidaWS.lineaOrdenSalida linea in ordenSalida.lineasOrdenSalida)
                {
                    if (linea.tipoLadrillo.nombre.Equals(cboNombreTipoLadrillo.Text))
                    {
                        linea.cantidad = linea.cantidad + Int32.Parse(numNroAproxLadrillos.Text);
                        dgvLotes.DataSource = ordenSalida.lineasOrdenSalida;
                        dgvLotes.Refresh();
                        return;
                    }
                }         
            }

            OSalidaWS.lineaOrdenSalida los = new OSalidaWS.lineaOrdenSalida();

            los.tipoLadrillo = new OSalidaWS.tipoLadrillo();
            TipoLadrilloWS.tipoLadrillo tipLad = (TipoLadrilloWS.tipoLadrillo)cboNombreTipoLadrillo.SelectedItem;
            los.tipoLadrillo.idTipoLadrillo = tipLad.idTipoLadrillo;
            los.tipoLadrillo.nombre = tipLad.nombre;
            los.cantidad = Int32.Parse(numNroAproxLadrillos.Text);

 
            lineasOs.Add(los);
            ordenSalida.lineasOrdenSalida =lineasOs.ToArray();

            dgvLotes.DataSource = lineasOs.ToArray();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvLotes.CurrentRow != null)
            {
                OSalidaWS.lineaOrdenSalida l = (OSalidaWS.lineaOrdenSalida)dgvLotes.CurrentRow.DataBoundItem;
                lineasOs.Remove(l);
                ordenSalida.lineasOrdenSalida = lineasOs.ToArray();
                dgvLotes.DataSource = lineasOs.ToArray();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de orden de salida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                frmReportesProduccionJA f = new frmReportesProduccionJA();
                f.ShowDialog();
        }
    }
}
