using BuildUp.IncidenteMaquinariaWS;
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
    public partial class frmBuscarIncidencia : Form
    {

        IncidenteMaquinariaWS.IncidenteMaquinariaWSClient daoIncidente;
        IncidenteMaquinariaWS.incidenteMaquinaria incidenteSeleccionado;

        public frmBuscarIncidencia()
        {
            InitializeComponent();
            daoIncidente = new IncidenteMaquinariaWS.IncidenteMaquinariaWSClient();
            incidenteSeleccionado = new IncidenteMaquinariaWS.incidenteMaquinaria();
            dgvIncidentes.AutoGenerateColumns = false;
        }

        public incidenteMaquinaria IncidenteSeleccionado { get => incidenteSeleccionado; set => incidenteSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvIncidentes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un Incidente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            incidenteSeleccionado = (IncidenteMaquinariaWS.incidenteMaquinaria)dgvIncidentes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<IncidenteMaquinariaWS.incidenteMaquinaria> incs = 
                new BindingList<IncidenteMaquinariaWS.incidenteMaquinaria>(daoIncidente.listarPorRangoFechaIncidenteMaquinaria(dtpDesde.Value, dtpHasta.Value).ToList());

            dgvIncidentes.DataSource = incs;
        }

        private void dgvIncidentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            IncidenteMaquinariaWS.incidenteMaquinaria data = dgvIncidentes.Rows[e.RowIndex].DataBoundItem as IncidenteMaquinariaWS.incidenteMaquinaria;
            if (data.estado)
            {
                dgvIncidentes.Rows[e.RowIndex].Cells[2].Value = "Atendida";
            }
            else
            {
                dgvIncidentes.Rows[e.RowIndex].Cells[2].Value = "En espera";
            }
        }
    }
}
