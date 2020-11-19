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
    public partial class frmGestionarMerma : Form
    {
        MermaWS.MermaWSClient daoMerma;
        MermaWS.merma merma;

        public frmGestionarMerma()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoMerma = new MermaWS.MermaWSClient();
            merma = new MermaWS.merma();
        }

        public void EstablecerEstadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtIDMerma.Enabled = false;
                    txtTipo.Enabled = false;
                    cboUnidadMedida.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtIDMerma.Enabled = false;
                    txtTipo.Enabled = true;
                    cboUnidadMedida.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtIDMerma.Enabled = false;
                    txtTipo.Enabled = true;
                    cboUnidadMedida.Enabled = true;
                    break;

            }
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Merma?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                merma.tipo = txtTipo.Text;
                merma.descripcion = txtDescripcion.Text;
                merma.unidad = cboUnidadMedida.Text;

                int result = daoMerma.insertarMerma(merma);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDMerma.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
                    cboUnidadMedida.Text = "";
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
            frmBuscarMerma formBuscarMerma = new frmBuscarMerma();
            if (formBuscarMerma.ShowDialog() == DialogResult.OK)
            {
                this.merma = formBuscarMerma.MermaSeleccionada;
                txtIDMerma.Text = merma.idMerma.ToString();
                txtTipo.Text = merma.tipo;
                txtDescripcion.Text = merma.descripcion;
                cboUnidadMedida.Text = merma.unidad;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Merma?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                merma.idMerma = Int32.Parse(txtIDMerma.Text);
                merma.tipo = txtTipo.Text;
                merma.descripcion = txtDescripcion.Text;
                merma.unidad = cboUnidadMedida.Text;

                int result = daoMerma.actualizarMerma(merma);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDMerma.Text = "";
                    txtTipo.Text = "";
                    txtDescripcion.Text = "";
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Merma del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoMerma.eliminarMerma(Int32.Parse(txtIDMerma.Text));
                txtIDMerma.Text = "";
                txtTipo.Text = "";
                txtDescripcion.Text = "";
                cboUnidadMedida.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDMerma.Text = "";
            txtTipo.Text = "";
            txtDescripcion.Text = "";
            cboUnidadMedida.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
