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
        TipoLadrilloWS.tipoLadrillo tipoLad;

        public frmGestionarTipoLadrillo()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tipoLad = new TipoLadrilloWS.tipoLadrillo();
            tipoLad.nombre = txtNombre.Text;
            tipoLad.altura = (int)numAltura.Value;
            tipoLad.ancho = (int)numAncho.Value;
            tipoLad.largo = (int)numLargo.Value;
            daoTipoLadrillo.insertarTipoLadrillo(tipoLad);
            MessageBox.Show("Se ha registrado correctamente el Tipo de Ladrillo", "Mensaje Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            EstablecerEstadoComponentes(Estado.Inicial);
            txtIDTipo.Text = "";
            txtNombre.Text = "";
            numAltura.Value = 0;
            numAncho.Value = 0;
            numLargo.Value = 0;
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarTipoLadrillo formBuscarTipoLad = new frmBuscarTipoLadrillo();
            if (formBuscarTipoLad.ShowDialog() == DialogResult.OK)
            {
                //...
                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //...
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
