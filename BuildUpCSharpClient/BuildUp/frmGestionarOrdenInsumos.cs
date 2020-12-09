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

        OrdenInsumosWS.OrdenInsumosWSClient daoOrdenInsumos;
        OrdenInsumosWS.ordenInsumos ordenInsumos;
        bool estado;

        public frmGestionarOrdenInsumos()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

            daoOrdenInsumos = new OrdenInsumosWS.OrdenInsumosWSClient();
            

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
                
                pnlAceptacionOrden.Visible = true;
            }
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
                    //txtApellidosOperario.Enabled = false;
                    txtIdOperario.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtIdOrdenInsumos.Enabled = false;
                    txtNombresOperario.Enabled = false;
                    txtNombreInsumo.Enabled = false;
                    //txtUnidadMedida.Enabled = false;
                    dtpFechaActual.Enabled = false;
                    btnBuscarInsumo.Enabled = false;
                    numericUpDown1.Enabled = false;
                    btnAceptarOrden.Enabled = false;
                    //btnRechazarOrden.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    //txtApellidosOperario.Enabled = true;
                    txtIdOperario.Enabled = false;
                    txtIdInsumo.Enabled = false;
                    txtIdOrdenInsumos.Enabled = false;
                    txtNombresOperario.Enabled = false;
                    //txtApellidosOperario.Enabled = false;
                    txtNombreInsumo.Enabled = false;
                    //txtUnidadMedida.Enabled = false;
                    dtpFechaActual.Enabled = false;
                    btnBuscarInsumo.Enabled = true;
                    numericUpDown1.Enabled = true;
                    btnAceptarOrden.Enabled = true;
                    //btnRechazarOrden.Enabled = true;

                    break;
                case Estado.Modificacion:
                    if (frmLogIn.Usuario.rol == "Jefe"
                || frmLogIn.Usuario.rol == "JEFE"
                || frmLogIn.Usuario.rol == "Jefe de Área"
                || frmLogIn.Usuario.rol == "Jefe de Area"
                || frmLogIn.Usuario.rol == "JEFE DE AREA"
                || frmLogIn.Usuario.rol == "JEFE DE ÁREA")
                    {
                        btnNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnBuscar.Enabled = true;
                        btnEliminar.Enabled = false;
                        btnActualizar.Enabled = false;
                        //txtApellidosOperario.Enabled = false;
                        txtIdOperario.Enabled = false;
                        txtIdInsumo.Enabled = false;
                        txtIdOrdenInsumos.Enabled = false;
                        txtNombresOperario.Enabled = false;
                        txtNombreInsumo.Enabled = false;
                        dtpFechaActual.Enabled = false;
                        btnBuscarInsumo.Enabled = false;
                        numericUpDown1.Enabled = false;
                        btnAceptarOrden.Enabled = true;
                        //btnRechazarOrden.Enabled = true;
                    }
                    else
                    {
                        
                        btnNuevo.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = true;
                        btnBuscar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnActualizar.Enabled = true;
                        //txtApellidosOperario.Enabled = true;
                        txtIdOperario.Enabled = false;
                        txtIdInsumo.Enabled = false;
                        txtIdOrdenInsumos.Enabled = false;
                        txtNombresOperario.Enabled = false;
                        txtNombreInsumo.Enabled = false;
                        //txtUnidadMedida.Enabled = true;
                        dtpFechaActual.Enabled = false;
                        btnBuscarInsumo.Enabled = true;
                        numericUpDown1.Enabled = true;
                        btnAceptarOrden.Enabled = true;
                        //btnRechazarOrden.Enabled = true;
                        if (this.estado)
                        {
                            btnEliminar.Enabled = false;
                            btnActualizar.Enabled = false;
                            btnBuscarInsumo.Enabled = false;
                            numericUpDown1.Enabled = false;
                        }
                    }
                    break;

            }
        }

        private void btnNuevaOrdenInsumos_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
            txtIdOperario.Text = frmLogIn.Usuario.idPersona.ToString();
            txtNombresOperario.Text = frmLogIn.Usuario.nombres.ToString();
            //txtApellidosOperario.Text = frmLogIn.Usuario.apellidos.ToString();


        }

        private void btnGuardarOrdenInsumos_Click(object sender, EventArgs e)
        {
            if (txtIdInsumo.Text == "")
            {
                MessageBox.Show("No ha ingresado el insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(numericUpDown1.Text)==0)
            {
                MessageBox.Show("No ha ingresado la cantidad del insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Orden de Insumos?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //validar e insertar en BD
                ordenInsumos = new OrdenInsumosWS.ordenInsumos();
                ordenInsumos.insumo = new OrdenInsumosWS.insumo();
                ordenInsumos.operario = new OrdenInsumosWS.operario();
                ordenInsumos.operario.nombres = txtNombresOperario.Text;
                ordenInsumos.insumo.nombre = txtNombreInsumo.Text;
                ordenInsumos.operario.idPersona = Int32.Parse(txtIdOperario.Text);
                ordenInsumos.insumo.idInsumo = Int32.Parse(txtIdInsumo.Text);
                ordenInsumos.cantidad = Int32.Parse(numericUpDown1.Text);

                int resultado = 0;
                resultado = daoOrdenInsumos.insertarOrdenInsumos(ordenInsumos);
                txtIdOrdenInsumos.Text = resultado.ToString();
                if (resultado != 0)
                {
                    txtIdOrdenInsumos.Text = "";
                    dtpFechaActual.Value = DateTime.Now;
                    txtIdInsumo.Text = "";
                    txtNombreInsumo.Text = "";
                    numericUpDown1.Text = "";

                    EstablecerEstadoComponentes(Estado.Inicial);
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmBuscarInsumo formBuscarInsumo = new frmBuscarInsumo();
            if (formBuscarInsumo.ShowDialog() == DialogResult.OK)
            {
                txtIdInsumo.Text = formBuscarInsumo.InsumoSeleccionado.idInsumo.ToString();
                txtNombreInsumo.Text= formBuscarInsumo.InsumoSeleccionado.nombre.ToString();
                //txtUnidadMedida.Text= formBuscarInsumo.InsumoSeleccionado.unidadMedida.ToString();
            }
        }

        private void btnBuscarOrdenInsumos_Click(object sender, EventArgs e)
        {
            frmBuscarOrdenInsumos formBuscarOrdenInsumos = new frmBuscarOrdenInsumos();
            if (formBuscarOrdenInsumos.ShowDialog() == DialogResult.OK)
            {
                txtIdOperario.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.operario.idPersona.ToString();
                txtNombresOperario.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.operario.nombres.ToString();
                //txtApellidosOperario.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.operario.apellidos.ToString();
                txtIdOperario.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.operario.idPersona.ToString();
                txtIdOrdenInsumos.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.idOrdenInsumos.ToString();
                dtpFechaActual.Value = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.fecha;
                txtIdInsumo.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.insumo.idInsumo.ToString();
                txtNombreInsumo.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.insumo.nombre.ToString();
                //txtUnidadMedida.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.insumo.unidadMedida.ToString();
                numericUpDown1.Text = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.cantidad.ToString();
                estado = formBuscarOrdenInsumos.OrdenInsumoSeleccionado.estado;

                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                //txtApellidosOperario.Text = "";
                txtIdOperario.Text = "";
                txtIdInsumo.Text = "";
                txtIdOrdenInsumos.Text = "";
                txtNombresOperario.Text = "";
                txtNombreInsumo.Text = "";
                dtpFechaActual.Value = DateTime.Now;
                numericUpDown1.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveForm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            ordenInsumos = new OrdenInsumosWS.ordenInsumos();
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Orden de Insumo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ordenInsumos.idOrdenInsumos = Int32.Parse(txtIdOrdenInsumos.Text);
                ordenInsumos.insumo = new OrdenInsumosWS.insumo();
                ordenInsumos.insumo.idInsumo = Int32.Parse(txtIdInsumo.Text);
                ordenInsumos.operario = new OrdenInsumosWS.operario();
                ordenInsumos.operario.idPersona = frmLogIn.Usuario.idPersona;
                ordenInsumos.cantidad = Int32.Parse(numericUpDown1.Text);
                //...

                int result = 0;
                result = daoOrdenInsumos.modificarOrdenInsumos(ordenInsumos);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdOrdenInsumos.Text = "";
                    dtpFechaActual.Value = DateTime.Now;
                    txtIdInsumo.Text = "";
                    txtNombreInsumo.Text = "";
                    numericUpDown1.Text = "";


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
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta Orden de Insumo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int result = 0;
                result = daoOrdenInsumos.eliminarOrdenInsumos(Int32.Parse(txtIdOrdenInsumos.Text));
                if (result != 0)
                {
                    MessageBox.Show("La eliminacion ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdOrdenInsumos.Text = "";
                    dtpFechaActual.Value = DateTime.Now;
                    txtIdInsumo.Text = "";
                    txtNombreInsumo.Text = "";
                    numericUpDown1.Text = "";


                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnRechazarOrden_Click(object sender, EventArgs e)
        {
            if (!(txtIdOrdenInsumos.Text == ""))
            {
                if (estado)
                {
                    MessageBox.Show("La Orden de Insumos ya ha sido aceptada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Está seguro que desea aceptar esta Orden de Insumos?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int result = 0;
                        result = daoOrdenInsumos.aceptarOrdenInsumos(Int32.Parse(txtIdOrdenInsumos.Text));
                        if (result != 0)
                        {
                            MessageBox.Show("La operacion ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdOperario.Text = "";
                            txtNombresOperario.Text = "";
                            txtIdOrdenInsumos.Text = "";
                            dtpFechaActual.Value = DateTime.Now;
                            txtIdInsumo.Text = "";
                            txtNombreInsumo.Text = "";
                            numericUpDown1.Text = "";
                            EstablecerEstadoComponentes(Estado.Inicial);
                        }
                        else
                        {
                            MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una Orden de Insumos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptarOrden_Click(object sender, EventArgs e)
        {
            if (!(txtIdOrdenInsumos.Text == ""))
            {
                if (estado)
                {
                    MessageBox.Show("La Orden de Insumos ya ha sido aceptada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("¿Esta seguro que desea aceptar esta Orden de Insumo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        int result = 0;
                        result = daoOrdenInsumos.aceptarOrdenInsumos(Int32.Parse(txtIdOrdenInsumos.Text));
                        if (result != 0)
                        {
                            MessageBox.Show("La operacion ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdOperario.Text = "";
                            txtNombresOperario.Text = "";
                            txtIdOrdenInsumos.Text = "";
                            dtpFechaActual.Value = DateTime.Now;
                            txtIdInsumo.Text = "";
                            txtNombreInsumo.Text = "";
                            numericUpDown1.Text = "";
                            EstablecerEstadoComponentes(Estado.Inicial);
                        }
                        else
                        {
                            MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una Orden de Insumos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
