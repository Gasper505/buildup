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

        InsumoWS.insumo insumo;
        InsumoWS.InsumoWSClient daoInsumo;

        public frmGestionarInsumo()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            insumo = new InsumoWS.insumo();
            daoInsumo = new InsumoWS.InsumoWSClient();
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

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Insumo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                insumo.nombre = txtNombreInsumo.Text;
                insumo.unidadMedida= cboUnidadMedida.Text;

                int result = daoInsumo.insertarInsumo(insumo);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdInsumo.Text = "";
                    txtNombreInsumo.Text = "";
                    cboUnidadMedida.Text = "";
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Merma?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                insumo.idInsumo = Int32.Parse(txtIdInsumo.Text);
                insumo.nombre = txtNombreInsumo.Text;
                insumo.unidadMedida = cboUnidadMedida.Text;

                int result = daoInsumo.modificarInsumo(insumo);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdInsumo.Text = "";
                    txtNombreInsumo.Text = "";
                    cboUnidadMedida.Text = "";
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Insumo del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoInsumo.eliminarInsumo(Int32.Parse(txtIdInsumo.Text));
                txtIdInsumo.Text = "";
                txtNombreInsumo.Text = "";
                cboUnidadMedida.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarInsumo formBuscarInsumo = new frmBuscarInsumo();
            if (formBuscarInsumo.ShowDialog() == DialogResult.OK)
            {
                this.insumo = formBuscarInsumo.InsumoSeleccionado;
                txtIdInsumo.Text = insumo.idInsumo.ToString();
                txtNombreInsumo.Text = insumo.nombre;
                cboUnidadMedida.Text = insumo.unidadMedida;
                EstablecerEstadoComponentes(Estado.Modificacion);
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
                txtIdInsumo.Text = "";
                txtNombreInsumo.Text = "";
                cboUnidadMedida.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
