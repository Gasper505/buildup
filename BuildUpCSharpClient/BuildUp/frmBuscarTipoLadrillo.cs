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

        public frmBuscarTipoLadrillo()
        {
            InitializeComponent();
            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
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
