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
            dgvOrdenes.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ordenInsumoSeleccionado = (OrdenInsumosWS.ordenInsumos)dgvOrdenes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<OrdenInsumosWS.ordenInsumos> ordenes = new BindingList<OrdenInsumosWS.ordenInsumos>(daoOrdenInsumos.listarOrdenInsumosPorRangoFecha(dtpDesde.Value, dtpHasta.Value).ToArray());
                dgvOrdenes.DataSource = ordenes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe ordenes de insumo", "Mensaje aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrdenInsumosWS.ordenInsumos data = dgvOrdenes.Rows[e.RowIndex].DataBoundItem as OrdenInsumosWS.ordenInsumos;
            dgvOrdenes.Rows[e.RowIndex].Cells[2].Value = data.operario.idPersona;
            dgvOrdenes.Rows[e.RowIndex].Cells[3].Value = data.operario.nombres;
            dgvOrdenes.Rows[e.RowIndex].Cells[4].Value = data.insumo.idInsumo;
            dgvOrdenes.Rows[e.RowIndex].Cells[5].Value = data.insumo.nombre;
        }
    }

}
