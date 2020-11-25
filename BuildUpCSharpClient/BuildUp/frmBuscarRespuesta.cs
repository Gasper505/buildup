using BuildUp.RespuestaWS;
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
    public partial class frmBuscarRespuesta : Form
    {

        RespuestaWS.RespuestaWSClient daoRespuesta;
        RespuestaWS.respuesta respuestaSeleccionada;

        public respuesta RespuestaSeleccionada { get => respuestaSeleccionada; set => respuestaSeleccionada = value; }

        public frmBuscarRespuesta()
        {
            InitializeComponent();
            daoRespuesta = new RespuestaWS.RespuestaWSClient();
            respuestaSeleccionada = new RespuestaWS.respuesta();
            dgvRespuestas.AutoGenerateColumns = false;

            BindingList<RespuestaWS.respuesta> resp = new BindingList<RespuestaWS.respuesta>(daoRespuesta.listarRespuesta().ToArray());
            dgvRespuestas.DataSource = resp;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRespuestas.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una respuesta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            respuestaSeleccionada = (RespuestaWS.respuesta)dgvRespuestas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
