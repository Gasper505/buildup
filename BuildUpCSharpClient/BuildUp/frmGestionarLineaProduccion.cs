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
    public partial class frmGestionarLineaProduccion : Form
    {

        LineaProduccionWS.LineaProduccionWSClient daoLineaProduccion;
        LineaProduccionWS.lineaProduccion lineaProduccion;
        TipoLadrilloWS.TipoLadrilloWSClient daoTipoLadrillo;

        public frmGestionarLineaProduccion()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

            daoLineaProduccion = new LineaProduccionWS.LineaProduccionWSClient();
            lineaProduccion = new LineaProduccionWS.lineaProduccion();
            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();

            cboTipoLadrillo.DataSource = new BindingList<TipoLadrilloWS.tipoLadrillo>(daoTipoLadrillo.listarTiposLadrillo().ToArray());
            cboTipoLadrillo.ValueMember = "idTipoLadrillo";
            cboTipoLadrillo.DisplayMember = "nombre";

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

                    txtIDLinea.Enabled = false;
                    txtNombre.Enabled = false;
                    cboTipoLadrillo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;

                    txtIDLinea.Enabled = false;
                    txtNombre.Enabled = true;
                    cboTipoLadrillo.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;

                    txtIDLinea.Enabled = false;
                    txtNombre.Enabled = true;
                    cboTipoLadrillo.Enabled = true;
                    break;

            }
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre de la linea de produccion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTipoLadrillo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Línea de Producción?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                lineaProduccion.nombre = txtNombre.Text;
                lineaProduccion.tipoLadrillo = new LineaProduccionWS.tipoLadrillo();
                TipoLadrilloWS.tipoLadrillo tipLad=(TipoLadrilloWS.tipoLadrillo)cboTipoLadrillo.SelectedItem;
                lineaProduccion.tipoLadrillo.idTipoLadrillo = tipLad.idTipoLadrillo;


                int result = daoLineaProduccion.insertarLineaProduccion(lineaProduccion);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDLinea.Text = "";
                    txtNombre.Text = "";
                    cboTipoLadrillo.Text = "";
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
            frmBuscarLineaProduccion formBuscarLineaProduccion = new frmBuscarLineaProduccion();
            if (formBuscarLineaProduccion.ShowDialog() == DialogResult.OK)
            {
                lineaProduccion = formBuscarLineaProduccion.LineaProduccionSeleccionada;
                txtIDLinea.Text = lineaProduccion.idLineaProduccion.ToString();
                txtNombre.Text = lineaProduccion.nombre;
                cboTipoLadrillo.Text = lineaProduccion.tipoLadrillo.nombre;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre de la linea de produccion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboTipoLadrillo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Línea de Producción?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                lineaProduccion.idLineaProduccion = Int32.Parse(txtIDLinea.Text);
                lineaProduccion.nombre = txtNombre.Text;

                TipoLadrilloWS.tipoLadrillo t = (TipoLadrilloWS.tipoLadrillo)cboTipoLadrillo.SelectedItem;
                lineaProduccion.tipoLadrillo.idTipoLadrillo = t.idTipoLadrillo;
                lineaProduccion.tipoLadrillo.nombre = t.nombre;
                lineaProduccion.tipoLadrillo.largo = t.largo;
                lineaProduccion.tipoLadrillo.ancho = t.ancho;
                lineaProduccion.tipoLadrillo.altura = t.altura;

                int result = 0;
                result = daoLineaProduccion.modificarLineaProduccion(lineaProduccion);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDLinea.Text = "";
                    txtNombre.Text = "";
                    cboTipoLadrillo.Text = "";
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar esta Línea de Producción del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoLineaProduccion.eliminarLineaProduccion(Int32.Parse(txtIDLinea.Text));
                txtIDLinea.Text = "";
                txtNombre.Text = "";
                cboTipoLadrillo.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDLinea.Text = "";
            txtNombre.Text = "";
            cboTipoLadrillo.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }
    }
}
