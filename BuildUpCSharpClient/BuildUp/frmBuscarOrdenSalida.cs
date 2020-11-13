using BuildUp.OSalidaWS;
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
    public partial class frmBuscarOrdenSalida : Form
    {
        OSalidaWS.ordenSalida ordenSeleccionada;
        OSalidaWS.OrdenSalidaWSClient daoOrdenSalida;

        public ordenSalida OrdenSeleccionada { get => ordenSeleccionada; set => ordenSeleccionada = value; }

        public frmBuscarOrdenSalida()
        {
            InitializeComponent();
            dgvOrdenesSalida.AutoGenerateColumns = false;
            daoOrdenSalida = new OSalidaWS.OrdenSalidaWSClient();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ordenSeleccionada = new OSalidaWS.ordenSalida();
            ordenSeleccionada = (OSalidaWS.ordenSalida)dgvOrdenesSalida.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtNombreOperario.Text = "";
            BindingList<OSalidaWS.ordenSalida> ordenes = new BindingList<OSalidaWS.ordenSalida>(daoOrdenSalida.listarOrdenesSalidaConParametros
                (txtNombreOperario.Text, dtpFechaRegistro.Value).ToArray());
            /*BindingList<OSalidaWS.ordenSalida> ordenes = new BindingList<OSalidaWS.ordenSalida>(daoOrdenSalida.listarOrdenesSalida().ToArray());*/




            dgvOrdenesSalida.DataSource = ordenes;

        }

        private void dgvOrdenesSalida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            OSalidaWS.ordenSalida data = dgvOrdenesSalida.Rows[e.RowIndex].DataBoundItem as OSalidaWS.ordenSalida;
            dgvOrdenesSalida.Rows[e.RowIndex].Cells[1].Value = data.operario.nombres;
            dgvOrdenesSalida.Rows[e.RowIndex].Cells[2].Value = data.operario.apellidos;
        }
    }
}
