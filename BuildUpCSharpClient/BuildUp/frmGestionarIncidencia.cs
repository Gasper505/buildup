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
    public partial class frmGestionarIncidencia : Form
    {
        public frmGestionarIncidencia()
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
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    break;

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            frmBuscarIncidencia formBuscarIncidencia = new frmBuscarIncidencia();
            if (formBuscarIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
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
            //limpiar campos (no implementado)
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscarMaquinaria_Click(object sender, EventArgs e)
        {
            frmBuscarMaquinaria formBuscarMaquinaria = new frmBuscarMaquinaria();
            if (formBuscarMaquinaria.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
            }
        }
    }
}
