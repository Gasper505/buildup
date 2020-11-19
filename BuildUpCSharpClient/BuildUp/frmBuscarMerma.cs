using BuildUp.MermaWS;
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
    public partial class frmBuscarMerma : Form
    {

        MermaWS.merma mermaSeleccionada;
        MermaWS.MermaWSClient daoMerma;

        public frmBuscarMerma()
        {
            InitializeComponent();
            mermaSeleccionada = new MermaWS.merma();
            daoMerma = new MermaWS.MermaWSClient();

            dgvMermas.AutoGenerateColumns = false;
        }

        public merma MermaSeleccionada { get => mermaSeleccionada; set => mermaSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<MermaWS.merma> merms = new BindingList<MermaWS.merma>(daoMerma.listarMerma().ToArray());
            dgvMermas.DataSource = merms;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            mermaSeleccionada = (MermaWS.merma)dgvMermas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
