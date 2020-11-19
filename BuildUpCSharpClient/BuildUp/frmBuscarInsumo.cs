using BuildUp.InsumoWS;
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
    public partial class frmBuscarInsumo : Form
    {

        InsumoWS.InsumoWSClient daoInsumo;
        InsumoWS.insumo insumoSeleccionado;

        public insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        public frmBuscarInsumo()
        {
            InitializeComponent();
            daoInsumo = new InsumoWS.InsumoWSClient();
            insumoSeleccionado = new InsumoWS.insumo();
            dgvInsumos.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            insumoSeleccionado = (InsumoWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<InsumoWS.insumo> insumos = new BindingList<InsumoWS.insumo>(daoInsumo.listarInsumo().ToArray());
            dgvInsumos.DataSource = insumos;
            
        }
    }
}
