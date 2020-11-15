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

        public frmGestionarLineaProduccion()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

            daoLineaProduccion = new LineaProduccionWS.LineaProduccionWSClient();
            lineaProduccion = new LineaProduccionWS.lineaProduccion();

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
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    break;

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            txtIDLinea.Text = "";
            txtNombre.Text = "";
            cboTipoLadrillo.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarLineaProduccion formBuscarLineaProduccion = new frmBuscarLineaProduccion();
            if (formBuscarLineaProduccion.ShowDialog() == DialogResult.OK)
            {
                //...
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
