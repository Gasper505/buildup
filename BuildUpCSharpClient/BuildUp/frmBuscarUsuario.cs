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
        UsuarioWS.usuario usuarioSeleccionado;
        PersonaWS.PersonaWSClient daoPersona;

        //JefeAreaWS.jefeArea jefeSeleccionado;
        //IngenieroWS.ingeniero ingenieroSeleccionado;
        //SupervisorWS.supervisor supervisorSeleccionado;
        //OperarioWS.operario operarioSeleccionado;

        public usuario UsuarioSeleccionado { get => usuarioSeleccionado; set => usuarioSeleccionado = value; }

        public frmBuscarUsuario()
        {
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            usuarioSeleccionado = new UsuarioWS.usuario();
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            usuarioSeleccionado = (UsuarioWS.usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<UsuarioWS.usuario> us = new BindingList<UsuarioWS.usuario>(daoUsuario.lia("").ToArray());

            dgvUsuarios.DataSource = us;
        }
    }
}
