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
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ordenInsumoSeleccionado = (OrdenInsumosWS.ordenInsumos)dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<OrdenInsumosWS.ordenInsumos> ordenes = new BindingList<OrdenInsumosWS.ordenInsumos>(daoOrdenInsumos.listarOrdenInsumosPorRangoFecha(dateTimePicker1.Value, dateTimePicker2.Value).ToArray());
                //BindingList<OrdenInsumosWS.ordenInsumos> ordenes = new BindingList<OrdenInsumosWS.ordenInsumos>(daoOrdenInsumos.listarOrdenInsumos().ToArray());
                dataGridView1.DataSource = ordenes;



            }
            catch (Exception ex)
            {
                MessageBox.Show("No existe ordenes de insumo", "Mensaje aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OrdenInsumosWS.ordenInsumos data = dataGridView1.Rows[e.RowIndex].DataBoundItem as OrdenInsumosWS.ordenInsumos;
            dataGridView1.Rows[e.RowIndex].Cells[2].Value = data.operario.idPersona;
            dataGridView1.Rows[e.RowIndex].Cells[3].Value = data.operario.nombres;
            dataGridView1.Rows[e.RowIndex].Cells[4].Value = data.insumo.idInsumo;
            dataGridView1.Rows[e.RowIndex].Cells[5].Value = data.insumo.nombre;
        }
    }

}
