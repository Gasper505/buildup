using BuildUp.TipoLadrilloWS;
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
    public partial class frmBuscarTipoLadrillo : Form
    {

        TipoLadrilloWS.TipoLadrilloWSClient daoTipoLadrillo;
        TipoLadrilloWS.tipoLadrillo tipoLadrilloSeleccionado;

        public tipoLadrillo TipoLadrilloSeleccionado { get => tipoLadrilloSeleccionado; set => tipoLadrilloSeleccionado = value; }

        public frmBuscarTipoLadrillo()
        {
            InitializeComponent();
            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();
            tipoLadrilloSeleccionado = new TipoLadrilloWS.tipoLadrillo();
            dgvTiposLadrillo.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvTiposLadrillo.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tipoLadrilloSeleccionado = (TipoLadrilloWS.tipoLadrillo)dgvTiposLadrillo.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<TipoLadrilloWS.tipoLadrillo> ladrillos = 
                new BindingList<TipoLadrilloWS.tipoLadrillo>(daoTipoLadrillo.listarTiposLadrillo().ToArray());

            dgvTiposLadrillo.DataSource = ladrillos;


        }
    }
}
