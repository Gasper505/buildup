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
            //dgvIncidentes.Rows[e.RowIndex].Cells[1].Value = data.supervisor.nombres + data.supervisor.apellidos;
            //dgvIncidentes.Rows[e.RowIndex].Cells[2].Value = data.ingeniero.nombres + data.ingeniero.apellidos;
        }
    }
}
