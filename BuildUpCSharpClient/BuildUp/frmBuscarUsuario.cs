using BuildUp.UsuarioWS;
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
    public partial class frmBuscarUsuario : Form
    {

        UsuarioWS.UsuarioWSClient daoUsuario;
        UsuarioWS.persona usuarioSeleccionado;
        PersonaWS.PersonaWSClient daoPersona;

        //JefeAreaWS.jefeArea jefeSeleccionado;
        //IngenieroWS.ingeniero ingenieroSeleccionado;
        //SupervisorWS.supervisor supervisorSeleccionado;
        //OperarioWS.operario operarioSeleccionado;

        public persona UsuarioSeleccionado { get => usuarioSeleccionado; set => usuarioSeleccionado = value; }

        public frmBuscarUsuario()
        {
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            usuarioSeleccionado = new UsuarioWS.persona();
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            usuarioSeleccionado = (UsuarioWS.persona)dgvUsuarios.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<UsuarioWS.persona> us =
                new BindingList<UsuarioWS.persona>
                (daoUsuario.listarUsuarioPorParametros(txtUsername.Text, txtNombre.Text, txtApellido.Text, cboCargo.Text).ToArray());
                dgvUsuarios.DataSource = us;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se han encontrado resultados", "Mensaje aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
