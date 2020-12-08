using BuildUp.RegistroMermaWS;
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
    public partial class frmBuscarRegistroMerma : Form
    {

        RegistroMermaWS.RegistroMermaWSClient daoRegistroMerma;
        RegistroMermaWS.registroMerma registroMermaSeleccionado;

        public frmBuscarRegistroMerma()
        {
            InitializeComponent();
            dgvRegistrosMerma.AutoGenerateColumns = false;
            daoRegistroMerma = new RegistroMermaWSClient();
            registroMermaSeleccionado = new registroMerma();
        }

        public registroMerma RegistroMermaSeleccionado { get => registroMermaSeleccionado; set => registroMermaSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRegistrosMerma.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un Registro de Merma", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            registroMermaSeleccionado = (RegistroMermaWS.registroMerma)dgvRegistrosMerma.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<RegistroMermaWS.registroMerma> ordenes = new BindingList<RegistroMermaWS.registroMerma>(daoRegistroMerma.listarRegistroMerma().ToList());

            dgvRegistrosMerma.DataSource = ordenes;
        }

        private void dgvRegistrosMerma_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            RegistroMermaWS.registroMerma data = dgvRegistrosMerma.Rows[e.RowIndex].DataBoundItem as RegistroMermaWS.registroMerma;
            dgvRegistrosMerma.Rows[e.RowIndex].Cells[2].Value = data.supervisor.nombres + data.supervisor.apellidos;
            dgvRegistrosMerma.Rows[e.RowIndex].Cells[3].Value = data.lineaProduccion.nombre;
        }
    }
}
