using BuildUp.ProblemaWS;
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
    public partial class frmBuscarProblema : Form
    {

        ProblemaWS.ProblemaWSClient daoProblema;
        ProblemaWS.problema problemaSeleccionado;

        public problema ProblemaSeleccionado { get => problemaSeleccionado; set => problemaSeleccionado = value; }

        public frmBuscarProblema()
        {
            InitializeComponent();
            daoProblema = new ProblemaWS.ProblemaWSClient();
            problemaSeleccionado = new ProblemaWS.problema();
            dgvProblemas.AutoGenerateColumns = false;

            BindingList<ProblemaWS.problema> probs = new BindingList<ProblemaWS.problema>(daoProblema.listarProblema().ToArray());
            dgvProblemas.DataSource = probs;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            problemaSeleccionado = (ProblemaWS.problema)dgvProblemas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
