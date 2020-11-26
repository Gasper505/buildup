using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp
{
    public partial class frmGestionarUsuario : Form
    {
        String ruta;
        UsuarioWS.UsuarioWSClient daoUsuario;
        JefeAreaWS.JefeAreaWSClient daoJefeArea;
        SupervisorWS.SupervisorWSClient daoSupervisor;
        OperarioWS.OperarioWSClient daoOperario;
        IngenieroWS.IngenieroWSClient daoIngeniero;

        JefeAreaWS.jefeArea jefeArea;
        SupervisorWS.supervisor supervisor;
        OperarioWS.operario operario;
        IngenieroWS.ingeniero ingeniero;
        LineaProduccionWS.lineaProduccion lineaP;
        LineaProduccionWS.LineaProduccionWSClient daoLineaP;


        UsuarioWS.usuario usuario;

        public frmGestionarUsuario()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            daoJefeArea = new JefeAreaWS.JefeAreaWSClient();
            daoSupervisor = new SupervisorWS.SupervisorWSClient();
            daoOperario = new OperarioWS.OperarioWSClient();
            daoIngeniero = new IngenieroWS.IngenieroWSClient();

            jefeArea = new JefeAreaWS.jefeArea();
            supervisor = new SupervisorWS.supervisor();
            operario = new OperarioWS.operario();
            ingeniero = new IngenieroWS.ingeniero();

            daoLineaP = new LineaProduccionWS.LineaProduccionWSClient();
            exclusiveComboBox.DataSource = new BindingList<LineaProduccionWS.lineaProduccion>(daoLineaP.listarPorNombreLineaProduccion("").ToArray());
            exclusiveComboBox.ValueMember = "idLineaProduccion";
            exclusiveComboBox.DisplayMember = "nombre";

        }

        //-----------------------------------------------------------------

        public void EstablecerEstadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = false;
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpNacimiento.Enabled = false;
                    dtpFinContrato.Enabled = false;
                    txtNumero.Enabled = false;
                    txtCorreo.Enabled = false;
                    cbRol.Enabled = false;
                    pbFoto.Enabled = false;
                    btAgregarFoto.Enabled = false;

                    exclusiveComboBox.Visible = false;
                    exclusiveLabel.Visible = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtID.Enabled = false;
                    txtNombre.Enabled = true;
                    txtApellidos.Enabled = true;
                    dtpNacimiento.Enabled = true;
                    dtpFinContrato.Enabled = true;
                    txtNumero.Enabled = true;
                    txtCorreo.Enabled = true;
                    cbRol.Enabled = true;
                    pbFoto.Enabled = true;
                    btAgregarFoto.Enabled = true;

                    exclusiveComboBox.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtID.Enabled = false;
                    txtNombre.Enabled = false;
                    txtApellidos.Enabled = false;
                    dtpNacimiento.Enabled = false;
                    dtpFinContrato.Enabled = false;
                    txtNumero.Enabled = false;
                    txtCorreo.Enabled = false;
                    cbRol.Enabled = false;
                    pbFoto.Enabled = false;
                    btAgregarFoto.Enabled = false;

                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;

                    exclusiveComboBox.Enabled = true;
                    break;

            }
        }


        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar el apellido del usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbRol.Text == "")
            {
                MessageBox.Show("Debe ingresar el rol del usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar a este Usuario?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int result = 0;

                if (cbRol.Text == "Operario")
                {
                    operario.nombres = txtNombre.Text;
                    operario.apellidos = txtApellidos.Text;
                    operario.telefono = txtNumero.Text;
                    operario.correo = txtCorreo.Text;
                    operario.fechaFinContrato = dtpFinContrato.Value;
                    operario.rol = "Operario";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoOperario.insertarOperario(operario);
                }
                else if (cbRol.Text == "Supervisor")
                {
                    supervisor.nombres = txtNombre.Text;
                    supervisor.apellidos = txtApellidos.Text;
                    supervisor.telefono = txtNumero.Text;
                    supervisor.correo = txtCorreo.Text;
                    supervisor.fechaFinContrato = dtpFinContrato.Value;
                    supervisor.rol = "Supervisor";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoSupervisor.insertarSupervisor(supervisor);
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    ingeniero.nombres = txtNombre.Text;
                    ingeniero.apellidos = txtApellidos.Text;
                    ingeniero.telefono = txtNumero.Text;
                    ingeniero.correo = txtCorreo.Text;
                    ingeniero.fechaFinContrato = dtpFinContrato.Value;
                    ingeniero.rol = "Ingeniero";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoIngeniero.insertarIngeniero(ingeniero);
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    jefeArea.nombres = txtNombre.Text;
                    jefeArea.apellidos = txtApellidos.Text;
                    jefeArea.telefono = txtNumero.Text;
                    jefeArea.correo = txtCorreo.Text;
                    jefeArea.fechaFinContrato = dtpFinContrato.Value;
                    jefeArea.rol = "Jefe de Área";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoJefeArea.insertarJefeArea(jefeArea);
                }

                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    dtpNacimiento.Text = "";
                    dtpFinContrato.Text = "";
                    txtNumero.Text = "";
                    txtCorreo.Text = "";
                    cbRol.Text = "";
                    pbFoto.Image = null;
                    exclusiveLabel.Visible = false;
                    exclusiveComboBox.Visible = false;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario formBuscarUsuario = new frmBuscarUsuario();
            if (formBuscarUsuario.ShowDialog() == DialogResult.OK)
            {
                MemoryStream ms = new MemoryStream(usuario.foto);
                pbFoto.Image = new Bitmap(ms);

                usuario = formBuscarUsuario.UsuarioSeleccionado;
                txtNombre.Text = usuario.nombres;
                txtApellidos.Text = usuario.apellidos;
                txtNumero.Text = usuario.telefono;
                txtCorreo.Text = usuario.correo;
                dtpFinContrato.Value = usuario.fechaFinContrato;
                cbRol.Text = usuario.rol;

                if (cbRol.Text == "Operario")
                {
                    exclusiveComboBox.Text = daoOperario.obtenerLineaProduccionOperario(usuario.idPersona);
                    exclusiveLabel.Text = "Línea de Producción";
                }
                else if (cbRol.Text == "Supervisor")
                {
                    //exclusiveComboBox.Text = daoSupervisor.obt(usuario.idPersona);
                    exclusiveLabel.Text = "Línea de Producción";
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    exclusiveComboBox.Text = daoIngeniero.obtenerEspecialidadIngeniero(usuario.idPersona);
                    exclusiveLabel.Text = "Especialidad";
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    //exclusiveComboBox.Text = daoJefeArea.obtenerFotoFirmaJefeArea(usuario.idPersona);
                    exclusiveLabel.Text = "Firma Digital";
                }

                EstablecerEstadoComponentes(Estado.Modificacion);
            }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar los datos de este Usuario?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int result = 0;

                if (cbRol.Text == "Operario")
                {
                    operario.nombres = txtNombre.Text;
                    operario.apellidos = txtApellidos.Text;
                    operario.telefono = txtNumero.Text;
                    operario.correo = txtCorreo.Text;
                    operario.fechaFinContrato = dtpFinContrato.Value;
                    operario.rol = "Operario";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoOperario.modificarOperario(operario);
                }
                else if (cbRol.Text == "Supervisor")
                {
                    supervisor.nombres = txtNombre.Text;
                    supervisor.apellidos = txtApellidos.Text;
                    supervisor.telefono = txtNumero.Text;
                    supervisor.correo = txtCorreo.Text;
                    supervisor.fechaFinContrato = dtpFinContrato.Value;
                    supervisor.rol = "Supervisor";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoSupervisor.actualizarSupervisor(supervisor);
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    ingeniero.nombres = txtNombre.Text;
                    ingeniero.apellidos = txtApellidos.Text;
                    ingeniero.telefono = txtNumero.Text;
                    ingeniero.correo = txtCorreo.Text;
                    ingeniero.fechaFinContrato = dtpFinContrato.Value;
                    ingeniero.rol = "Ingeniero";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoIngeniero.modificarIngeniero(ingeniero);
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    jefeArea.nombres = txtNombre.Text;
                    jefeArea.apellidos = txtApellidos.Text;
                    jefeArea.telefono = txtNumero.Text;
                    jefeArea.correo = txtCorreo.Text;
                    jefeArea.fechaFinContrato = dtpFinContrato.Value;
                    jefeArea.rol = "Jefe de Área";

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoJefeArea.modificarJefeArea(jefeArea);
                }

                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    dtpNacimiento.Text = "";
                    dtpFinContrato.Text = "";
                    txtNumero.Text = "";
                    txtCorreo.Text = "";
                    cbRol.Text = "";
                    pbFoto.Image = null;
                    exclusiveLabel.Visible = false;
                    exclusiveComboBox.Visible = false;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Tipo de Ladrillo del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int result = 0;

                if (cbRol.Text == "Operario")
                {
                    result = daoOperario.eliminarOperario(Int32.Parse(txtID.Text));
                }
                else if (cbRol.Text == "Supervisor")
                {
                    result = daoSupervisor.eliminarSupervisor(Int32.Parse(txtID.Text));
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    result = daoIngeniero.eliminarIngeniero(Int32.Parse(txtID.Text));
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    result = daoJefeArea.eliminarJefeArea(Int32.Parse(txtID.Text));
                }

                if (result != 0)
                {
                    MessageBox.Show("La eliminación ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    dtpNacimiento.Text = "";
                    dtpFinContrato.Text = "";
                    txtNumero.Text = "";
                    txtCorreo.Text = "";
                    cbRol.Text = "";
                    pbFoto.Image = null;
                    exclusiveLabel.Visible = false;
                    exclusiveComboBox.Visible = false;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-----------------------------------------------------------------



        private void btAnadir_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtpNacimiento.Text = "";
            dtpFinContrato.Text = "";
            txtNumero.Text = "";
            txtCorreo.Text = "";
            cbRol.Text = "";
            pbFoto.Image = null;
            exclusiveLabel.Visible = false;
            exclusiveComboBox.Visible = false;
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btAgregarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofFoto.ShowDialog() == DialogResult.OK)
                {
                    ruta = ofFoto.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRol.Text)
            {
                case "Jefe de Área":
                    exclusiveLabel.Text = "Firma Digital";

                    exclusiveComboBox.Visible = false;
                    
                    break;
                case "Ingeniero":
                    BindingList<String> especialidades = new BindingList<String>();
                    especialidades.Add("Eléctrica");
                    especialidades.Add("Mecánica");
                    especialidades.Add("Mecatrónica");
                    especialidades.Add("Fluidos");

                    exclusiveLabel.Text = "Especialidad";
                    exclusiveComboBox.DataSource = especialidades;

                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    break;
                case "Operario":
                    exclusiveLabel.Text = "Línea de Producción";
                    exclusiveComboBox.DataSource = new BindingList<LineaProduccionWS.lineaProduccion>(daoLineaP.listarPorNombreLineaProduccion("").ToArray());
                    exclusiveComboBox.ValueMember = "idLineaProduccion";
                    exclusiveComboBox.DisplayMember = "nombre";

                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    break;
                case "Supervisor":
                    exclusiveLabel.Text = "Línea de Producción";
                    exclusiveComboBox.DataSource = new BindingList<LineaProduccionWS.lineaProduccion>(daoLineaP.listarPorNombreLineaProduccion("").ToArray());
                    exclusiveComboBox.ValueMember = "idLineaProduccion";
                    exclusiveComboBox.DisplayMember = "nombre";

                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    break;
            }
        }
    }

}
