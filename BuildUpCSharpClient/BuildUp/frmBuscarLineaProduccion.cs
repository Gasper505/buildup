using BuildUp.LineaProduccionWS;
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
    public partial class frmBuscarLineaProduccion : Form
    {

        LineaProduccionWS.lineaProduccion lineaProduccionSeleccionada;
        LineaProduccionWS.LineaProduccionWSClient daoLineaProduccion;

        public frmBuscarLineaProduccion()
        {
            InitializeComponent();
            lineaProduccionSeleccionada = new LineaProduccionWS.lineaProduccion();
            daoLineaProduccion = new LineaProduccionWS.LineaProduccionWSClient();

            dgvLineasProduccion.AutoGenerateColumns = false;
        }

        public lineaProduccion LineaProduccionSeleccionada { get => lineaProduccionSeleccionada; set => lineaProduccionSeleccionada = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLineasProduccion.SelectedRows.Count<1)
            {
                MessageBox.Show("Debe seleccionar una linea de produccion", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lineaProduccionSeleccionada = (LineaProduccionWS.lineaProduccion)dgvLineasProduccion.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLineasProduccion.DataSource = 
                new BindingList<LineaProduccionWS.lineaProduccion>(daoLineaProduccion.listarPorNombreLineaProduccion(txtNombre.Text).ToList());
        }

    }
}
