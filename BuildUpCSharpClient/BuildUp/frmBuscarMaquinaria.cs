using BuildUp.MaqWS;
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
    public partial class frmBuscarMaquinaria : Form
    {
        MaqWS.MaquinariaWSClient daoMaquinaria;
        MaqWS.maquinaria maquinariaSeleccionada;

        public MaqWS.maquinaria MaquinariaSeleccionada { get => maquinariaSeleccionada; set => maquinariaSeleccionada = value; }

        public frmBuscarMaquinaria()
        {
            InitializeComponent();
            dgvMaquinarias.AutoGenerateColumns = false;
            daoMaquinaria = new MaqWS.MaquinariaWSClient();
            //dgvMaquinarias.DataSource = 
            //    new BindingList<MaqWS.maquinaria> (daoMaquinaria.listarMaquinariasConParametros(txtBusqNombreMaq.Text, txtBusqLineaProduccion.Text).ToArray());
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //maquinariaSeleccionada = new MaqWS.maquinaria();
            //maquinariaSeleccionada = (MaqWS.maquinaria)dgvMaquinarias.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvMaquinarias.DataSource =
            //    new BindingList<MaqWS.maquinaria>(daoMaquinaria.listarMaquinariasConParametros(txtBusqNombreMaq.Text, txtBusqLineaProduccion.Text).ToArray());
        }
    

        private void dgvMaquinarias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MaqWS.maquinaria data = dgvMaquinarias.Rows[e.RowIndex].DataBoundItem as MaqWS.maquinaria;
            dgvMaquinarias.Rows[e.RowIndex].Cells[2].Value = data.lineaProduccion.nombre;
            dgvMaquinarias.Rows[e.RowIndex].Cells[3].Value = data.proveedor.razonSocial;
        }

    }
}
