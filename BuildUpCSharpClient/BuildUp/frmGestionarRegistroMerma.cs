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
    public partial class frmGestionarRegistroMerma : Form
    {

        RegistroMermaWS.RegistroMermaWSClient daoRegistroMerma;
        RegistroMermaWS.registroMerma registroMerma;
        SupervisorWS.SupervisorWSClient daoSupervisor;
        MermaWS.MermaWSClient daoMerma;

        public frmGestionarRegistroMerma()
        {
            InitializeComponent();
            daoRegistroMerma = new RegistroMermaWS.RegistroMermaWSClient();
            registroMerma = new RegistroMermaWS.registroMerma();
            daoSupervisor = new SupervisorWS.SupervisorWSClient();
            daoMerma = new MermaWS.MermaWSClient();

            cboTipoMerma.DataSource = daoMerma.listarMerma();

            EstablecerEstadoComponentes(Estado.Inicial);

        }
        public void EstablecerEstadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                    txtIDRegMerma.Enabled = false;
                    cboTipoMerma.Enabled = false;
                    txtCantidad.Enabled = false;
                    dtpFechaMerma.Enabled = false;
                    txtSupervisor.Enabled = false;
                    txtLineaProduccion.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                    txtIDRegMerma.Enabled = false;
                    cboTipoMerma.Enabled = true;
                    txtCantidad.Enabled = true;
                    dtpFechaMerma.Enabled = true;
                    txtSupervisor.Enabled = false;
                    txtLineaProduccion.Enabled = false;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;

                    txtIDRegMerma.Enabled = false;
                    cboTipoMerma.Enabled = true;
                    txtCantidad.Enabled = true;
                    dtpFechaMerma.Enabled = true;
                    txtSupervisor.Enabled = false;
                    txtLineaProduccion.Enabled = false;
                    break;
            }
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Acontecimiento de Merma?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                registroMerma.merma = new RegistroMermaWS.merma();
                registroMerma.lineaProduccion = new RegistroMermaWS.lineaProduccion();
                registroMerma.merma = (RegistroMermaWS.merma)cboTipoMerma.SelectedItem;
                registroMerma.lineaProduccion.nombre = daoSupervisor.obtenerLineaProduccionSupervisor(frmLogIn.Usuario.idPersona);

                int resultado = 0;
                resultado = daoRegistroMerma.insertarRegistroMerma(registroMerma);
                txtIDRegMerma.Text = resultado.ToString();

                if (resultado != 0)
                {
                    txtIDRegMerma.Text = "";
                    cboTipoMerma.Text = "";
                    txtCantidad.Text = "";
                    dtpFechaMerma.Value = DateTime.Now;
                    txtSupervisor.Text = "";
                    txtLineaProduccion.Text = "";

                    EstablecerEstadoComponentes(Estado.Inicial);
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            frmBuscarRegistroMerma formBuscarMerma = new frmBuscarRegistroMerma();
            formBuscarMerma.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------------------------

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtSupervisor.Text = frmLogIn.Usuario.nombres + frmLogIn.Usuario.apellidos; //Recordar que el único que tiene acceso a este form es el supervisor
            txtLineaProduccion.Text = daoSupervisor.obtenerLineaProduccionSupervisor(frmLogIn.Usuario.idPersona);
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDRegMerma.Text = "";
            cboTipoMerma.Text = "";
            txtCantidad.Text = "";
            dtpFechaMerma.Value = DateTime.Now;
            txtSupervisor.Text = "";
            txtLineaProduccion.Text = "";
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
