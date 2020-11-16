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
    public partial class frmLogIn : Form
    {

        private UsuarioWS.UsuarioWSClient daoUsuario;
        private static UsuarioWS.usuario usuario;

        public static usuario Usuario { get => usuario; set => usuario = value; }

        public frmLogIn()
        {
            
            InitializeComponent();
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            
        }

        private void btnIngresar(object sender, EventArgs e)
        {
            lblInfoLogueo.Text = "Autenticando...";
            autenticarUsuario();
        }

        public void autenticarUsuario()
        {
            usuario = new UsuarioWS.usuario();
            usuario.username = txtUsuario.Text;
            usuario.password = txtContrasena.Text;
            int resultado = daoUsuario.autenticarUsuario(usuario);

            lblInfoLogueo.Text = "Cargando datos del usuario...";
            usuario = daoUsuario.buscarUsuarioPorUsername(usuario.username);

            if (resultado == 1)
            {
                //test every possibility
                switch (usuario.rol)
                {
                    case "Jefe":
                        frmRolJefeArea formJefeArea = new frmRolJefeArea();
                        this.Hide();
                        formJefeArea.ShowDialog();
                        break;
                    case "Ingeniero":
                        frmRolIngeniero formIngeniero = new frmRolIngeniero();
                        this.Hide();
                        formIngeniero.ShowDialog();
                        break;
                    case "Operario":
                        frmRolOperario formOperario = new frmRolOperario();
                        this.Hide();
                        formOperario.ShowDialog();
                        break;
                    case "Supervisor":
                        frmRolSupervisor formSupervisor = new frmRolSupervisor();
                        this.Hide();
                        formSupervisor.ShowDialog();
                        break;
                    case "admin":
                        frmRolAdmin form = new frmRolAdmin();
                        this.Hide();
                        form.ShowDialog();
                        break;
                }

            }
            else
            {
                lblInfoLogueo.Text = "Error en el inicio de sesión";
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                autenticarUsuario();
            }
        }

        private void btnCancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            txtContrasena.Text = "";
            txtContrasena.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContrasena.PasswordChar = '*';
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
        }
    }
}
