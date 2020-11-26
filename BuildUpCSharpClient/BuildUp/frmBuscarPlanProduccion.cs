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
    public partial class frmBuscarPlanProduccion : Form
    {
        PlanProduccionWS.planProduccion planSeleccionado;
        PlanProduccionWS.PlanProduccionWSClient daoPlanProduccion;

        public PlanProduccionWS.planProduccion PlanSeleccionado { get => planSeleccionado; set => planSeleccionado = value; }
        public frmBuscarPlanProduccion()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            daoPlanProduccion = new PlanProduccionWS.PlanProduccionWSClient();
            planSeleccionado = new PlanProduccionWS.planProduccion();

            BindingList<PlanProduccionWS.planProduccion> plans = new BindingList<PlanProduccionWS.planProduccion>(daoPlanProduccion.listarPlanesProduccion().ToArray());
            dataGridView1.DataSource = plans;

        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un Plan de Producción", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            planSeleccionado = (PlanProduccionWS.planProduccion)dataGridView1.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

    }
}
