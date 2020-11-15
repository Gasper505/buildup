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

        MermaWS.merma merma;

        public frmGestionarMerma()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
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
                    txtUnidad.Enabled = false;
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
                    txtUnidad.Enabled = true;
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
                    txtUnidad.Enabled = true;
                    break;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarMerma formBuscarMerma = new frmBuscarMerma();
            if (formBuscarMerma.ShowDialog() == DialogResult.OK)
            {
                //...
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtIDMerma.Text = "";
            txtTipo.Text = "";
            txtUnidad.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
