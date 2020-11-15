using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp
{
    public partial class frmGestionarUsuario : Form
    {
        String ruta;
        public frmGestionarUsuario()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

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
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpNacimiento.Enabled = false;
                    dtpFinContrato.Enabled = false;
                    txtNumero.Enabled = false;
                    txtCorreo.Enabled = false;
                    cbRol.Enabled = false;
                    pbFoto.Enabled = false;
                    btAgregarFoto.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtID.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpNacimiento.Enabled = true;
                    dtpFinContrato.Enabled = true;
                    txtNumero.Enabled = true;
                    txtCorreo.Enabled = true;
                    cbRol.Enabled = true;
                    pbFoto.Enabled = true;
                    btAgregarFoto.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpNacimiento.Enabled = false;
                    dtpFinContrato.Enabled = false;
                    txtNumero.Enabled = false;
                    txtCorreo.Enabled = false;
                    cbRol.Enabled = false;
                    pbFoto.Enabled = false;
                    btAgregarFoto.Enabled = false;
                    break;

            }
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtpNacimiento.Text = "";
            dtpFinContrato.Text = "";
            txtNumero.Text = "";
            txtCorreo.Text = "";
            cbRol.Text = "";
            pbFoto.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario formBuscarUsuario = new frmBuscarUsuario();
            if (formBuscarUsuario.ShowDialog() == DialogResult.OK)
            {
                //PASO DE INFORMACION
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro de eliminar el usuario?", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtpNacimiento.Text = "";
            dtpFinContrato.Text = "";
            txtNumero.Text = "";
            txtCorreo.Text = "";
            cbRol.Text = "";
            pbFoto.Image = null;
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btAgregarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofFoto.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofFoto.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmGestionarUsuario_Load(object sender, EventArgs e)
        {

        }
    }

}
