using BuildUp.TipoLadrilloWS;
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
    public partial class frmGestionarTipoLadrillo : Form
    {
        TipoLadrilloWS.TipoLadrilloWSClient daoTipoLadrillo;
        TipoLadrilloWS.tipoLadrillo tipoLadrillo;

        public frmGestionarTipoLadrillo()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();
            tipoLadrillo = new TipoLadrilloWS.tipoLadrillo();
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
                    txtIDTipo.Enabled = false;
                    txtNombre.Enabled = false;
                    numAltura.Enabled = false;
                    numAncho.Enabled = false;
                    numLargo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDTipo.Enabled = false;
                    txtNombre.Enabled = true;
                    numAltura.Enabled = true;
                    numAncho.Enabled = true;
                    numLargo.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDTipo.Enabled = false;
                    txtNombre.Enabled = true;
                    numAltura.Enabled = true;
                    numAncho.Enabled = true;
                    numLargo.Enabled = true;
                    break;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }


        //-----------------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre del tipo de ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Int32.Parse(numLargo.Text)==0 || numLargo.Text=="")
            {
                MessageBox.Show("Debe insertar el largo del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(numAncho.Text) == 0 || numAncho.Text == "")
            {
                MessageBox.Show("Debe insertar el ancho del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Int32.Parse(numAltura.Text) == 0 || numAltura.Text == "")
            {
                MessageBox.Show("Debe insertar la altura del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Tipo de Ladrillo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                tipoLadrillo = new TipoLadrilloWS.tipoLadrillo();
                tipoLadrillo.nombre = txtNombre.Text;
                tipoLadrillo.altura = (int)numAltura.Value;
                tipoLadrillo.ancho = (int)numAncho.Value;
                tipoLadrillo.largo = (int)numLargo.Value;

                int result = daoTipoLadrillo.insertarTipoLadrillo(tipoLadrillo);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDTipo.Text = "";
                    txtNombre.Text = "";
                    numAltura.Value = 0;
                    numAncho.Value = 0;
                    numLargo.Value = 0;
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
            frmBuscarTipoLadrillo formBuscarTipoLad = new frmBuscarTipoLadrillo();
            if (formBuscarTipoLad.ShowDialog() == DialogResult.OK)
            {
                tipoLadrillo = formBuscarTipoLad.TipoLadrilloSeleccionado;
                txtIDTipo.Text = tipoLadrillo.idTipoLadrillo.ToString();
                txtNombre.Text = tipoLadrillo.nombre;
                numAltura.Value = (decimal)tipoLadrillo.altura;
                numAncho.Value = (decimal)tipoLadrillo.ancho;
                numLargo.Value = (decimal)tipoLadrillo.largo;
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar este Tipo de Ladrillo?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                tipoLadrillo.idTipoLadrillo = Int32.Parse(txtIDTipo.Text);
                tipoLadrillo.nombre = txtNombre.Text;
                tipoLadrillo.altura = (int)numAltura.Value;
                tipoLadrillo.ancho = (int)numAncho.Value;
                tipoLadrillo.largo = (int)numLargo.Value;
                int result = 0;
                result = daoTipoLadrillo.actualizarTipoLadrillo(tipoLadrillo);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDTipo.Text = "";
                    txtNombre.Text = "";
                    numAltura.Value = 0;
                    numAncho.Value = 0;
                    numLargo.Value = 0;
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
                daoTipoLadrillo.eliminarTipoLadrillo(Int32.Parse(txtIDTipo.Text));
                txtIDTipo.Text = "";
                txtNombre.Text = "";
                numAltura.Value = 0;
                numAncho.Value = 0;
                numLargo.Value = 0;
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDTipo.Text = "";
            txtNombre.Text = "";
            numAltura.Value = 0;
            numAncho.Value = 0;
            numLargo.Value = 0;
            EstablecerEstadoComponentes(Estado.Inicial);
        }

    }
}
