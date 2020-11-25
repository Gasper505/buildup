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
    public partial class frmBuscarOrdenInsumos : Form
    {
        OrdenInsumosWS.OrdenInsumosWSClient daoOrdenInsumos;
        OrdenInsumosWS.ordenInsumos ordenInsumoSeleccionado;


        public OrdenInsumosWS.ordenInsumos OrdenInsumoSeleccionado { get => ordenInsumoSeleccionado; set => ordenInsumoSeleccionado = value; }
        public frmBuscarOrdenInsumos()
        {
            daoOrdenInsumos = new OrdenInsumosWS.OrdenInsumosWSClient();
            InitializeComponent();
            dgvOrdenesInsumos.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ordenInsumoSeleccionado = new OrdenInsumosWS.ordenInsumos();
            ordenInsumoSeleccionado = (OrdenInsumosWS.ordenInsumos)dgvOrdenesInsumos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrdenesInsumos.DataSource = daoOrdenInsumos.listarOrdenInsumosPorRangoFecha(dtpDesde.Value, dtpHasta.Value).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe ordenes de insumo", "Mensaje aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
