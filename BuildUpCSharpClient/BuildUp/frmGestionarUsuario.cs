using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildUp
{


    public partial class frmGestionarUsuario : Form
    {
        string ruta;
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


        UsuarioWS.persona usuario;

        public frmGestionarUsuario()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            daoJefeArea = new JefeAreaWS.JefeAreaWSClient();
            daoSupervisor = new SupervisorWS.SupervisorWSClient();
            daoOperario = new OperarioWS.OperarioWSClient();
            daoIngeniero = new IngenieroWS.IngenieroWSClient();

            usuario = new UsuarioWS.persona();
            jefeArea = new JefeAreaWS.jefeArea();
            supervisor = new SupervisorWS.supervisor();
            supervisor.lineaProduccion = new SupervisorWS.lineaProduccion();
            operario = new OperarioWS.operario();
            operario.lineaProduccion = new OperarioWS.lineaProduccion();
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
                    txtUsername.Enabled = false;
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
                    txtUsername.Enabled = true;
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
                    dtpFinContrato.Enabled = true;
                    txtNumero.Enabled = true;
                    txtCorreo.Enabled = true;
                    cbRol.Enabled = false;
                    pbFoto.Enabled = true;
                    btAgregarFoto.Enabled = true;
                    txtUsername.Enabled = true;

                    exclusiveComboBox.Enabled = true;
                    break;

            }
        }


        private void btGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar el apellido del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbRol.Text == "")
            {
                MessageBox.Show("Debe seleccionar el rol del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar el teléfono del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar un correo para el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtCorreo.Text.IndexOf('@') == -1)
            {
                MessageBox.Show("Debe ingresar un correo válido para el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbRol.Text == "Operario" || cbRol.Text == "Supervisor")
            {
                if (exclusiveComboBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar la línea de producción a la que pertenece el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (cbRol.Text == "Ingeniero")
            {
                if (exclusiveComboBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar la especialidad del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (pbFoto.Image == null)
            {
                MessageBox.Show("Debe ingresar una foto para el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar a este Usuario?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int result = 0;
                string passwordGenerado = RandomString(8);

                if (cbRol.Text == "Operario")
                {
                    lineaP = new LineaProduccionWS.lineaProduccion();
                    lineaP = (LineaProduccionWS.lineaProduccion)exclusiveComboBox.SelectedItem;
                    operario.lineaProduccion.idLineaProduccion = lineaP.idLineaProduccion;
                    operario.nombres = txtNombre.Text;
                    operario.apellidos = txtApellidos.Text;
                    operario.fechaNacimiento = dtpNacimiento.Value;
                    operario.fechaNacimientoSpecified = true;
                    operario.telefono = txtNumero.Text;
                    operario.correo = txtCorreo.Text;
                    operario.fechaFinContrato = dtpFinContrato.Value;
                    operario.fechaFinContratoSpecified = true;
                    operario.rol = cbRol.Text;

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    operario.foto= br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoOperario.insertarOperario(operario, txtUsername.Text, passwordGenerado);
                    txtID.Text = result.ToString();
                }
                else if (cbRol.Text == "Supervisor")
                {
                    lineaP = new LineaProduccionWS.lineaProduccion();
                    lineaP = (LineaProduccionWS.lineaProduccion)exclusiveComboBox.SelectedItem;
                    supervisor.lineaProduccion.idLineaProduccion = lineaP.idLineaProduccion;
                    supervisor.nombres = txtNombre.Text;
                    supervisor.apellidos = txtApellidos.Text;
                    supervisor.fechaNacimiento = dtpNacimiento.Value;
                    supervisor.fechaNacimientoSpecified = true;
                    supervisor.telefono = txtNumero.Text;
                    supervisor.correo = txtCorreo.Text;
                    supervisor.fechaFinContrato = dtpFinContrato.Value;
                    supervisor.fechaFinContratoSpecified = true;
                    supervisor.rol = cbRol.Text;

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    supervisor.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoSupervisor.insertarSupervisor(supervisor, txtUsername.Text, passwordGenerado);
                    txtID.Text = result.ToString();
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    ingeniero.nombres = txtNombre.Text;
                    ingeniero.apellidos = txtApellidos.Text;
                    ingeniero.fechaNacimiento = dtpNacimiento.Value;
                    ingeniero.telefono = txtNumero.Text;
                    ingeniero.correo = txtCorreo.Text;
                    ingeniero.fechaFinContrato = dtpFinContrato.Value;
                    ingeniero.rol = cbRol.Text;
                    ingeniero.especialidad = exclusiveComboBox.Text;
                    ingeniero.fechaNacimientoSpecified = true;
                    ingeniero.fechaFinContratoSpecified = true;

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    ingeniero.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoIngeniero.insertarIngeniero(ingeniero, txtUsername.Text, passwordGenerado);
                    txtID.Text = result.ToString();
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    jefeArea.nombres = txtNombre.Text;
                    jefeArea.apellidos = txtApellidos.Text;
                    jefeArea.fechaNacimiento = dtpNacimiento.Value;
                    jefeArea.telefono = txtNumero.Text;
                    jefeArea.correo = txtCorreo.Text;
                    jefeArea.fechaFinContrato = dtpFinContrato.Value;
                    jefeArea.rol = cbRol.Text;
                    jefeArea.fechaNacimientoSpecified = true;
                    jefeArea.fechaFinContratoSpecified = true;

                    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    jefeArea.foto = br.ReadBytes((int)fs.Length);
                    fs.Close();

                    result = daoJefeArea.insertarJefeArea(jefeArea, txtUsername.Text, passwordGenerado);
                    txtID.Text = result.ToString();
                }

                
                if (result != 0)
                {
                    try
                    {
                        //Envío de email con credenciales
                        var fromAddress = new MailAddress("buildup.system@gmail.com", "BuildUpSystem");
                        var toAddress = new MailAddress(txtCorreo.Text, txtNombre.Text + txtApellidos.Text);
                        const string fromPassword = "elepedos";
                        const string subject = "Credenciales de acceso al sistema BuildUp";
                        string body = "Estimado "+ txtNombre.Text + " " + txtApellidos.Text + ",\nTe damos la bienvenida." +
                            "Estas son sus credenciales para acceder al sistema:\n" +
                            "- Usuario: " + txtUsername.Text + "\n" +
                            "- Contraseña: " + passwordGenerado + "\n" +
                            "Recuerde que no debe compartir esta información con nadie.";

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }

                        MessageBox.Show("El registro ha sido exitoso.\nSe ha enviado un correo electrónico al nuevo usuario con sus credenciales.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtNombre.Text = "";
                        txtApellidos.Text = "";
                        dtpNacimiento.Text = "";
                        dtpFinContrato.Text = "";
                        txtNumero.Text = "";
                        txtCorreo.Text = "";
                        cbRol.Text = "";
                        pbFoto.Image = null;
                        txtUsername.Text = "";
                        exclusiveLabel.Visible = false;
                        exclusiveComboBox.Visible = false;
                        EstablecerEstadoComponentes(Estado.Inicial);
                    }
                    catch
                    {
                        MessageBox.Show("No se ha logrado enviar el correo con las credenciales al usuario. Por favor, verifique que el correo ingresado es correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error en el registro del usuario. Inténtelo más tarde.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            dtpNacimiento.Text = "";
            dtpFinContrato.Text = "";
            txtNumero.Text = "";
            txtCorreo.Text = "";
            cbRol.Text = "";
            txtUsername.Text = "";

            if (pbFoto.Image != null)
            {
                pbFoto.Image.Dispose();
                pbFoto.Image = null;
            }


            frmBuscarUsuario formBuscarUsuario = new frmBuscarUsuario();
            if (formBuscarUsuario.ShowDialog() == DialogResult.OK)
            {
                usuario = formBuscarUsuario.UsuarioSeleccionado;

                MemoryStream ms;
                if (usuario.foto != null)
                {
                    ms = new MemoryStream(usuario.foto);
                    if (ms.Length != 0) pbFoto.Image = new Bitmap(ms);
                }
                
                txtID.Text = usuario.idPersona.ToString();
                txtNombre.Text = usuario.nombres;
                txtApellidos.Text = usuario.apellidos;
                txtNumero.Text = usuario.telefono;
                txtCorreo.Text = usuario.correo;
                dtpFinContrato.Value = usuario.fechaFinContrato;
                cbRol.Text = usuario.rol;

                if(usuario.rol=="Operario") {
                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    exclusiveComboBox.Text = daoOperario.obtenerLineaProduccionOperario(usuario.idPersona);
                }
                if (usuario.rol == "Supervisor")
                {
                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    exclusiveComboBox.Text = ((SupervisorWS.lineaProduccion)daoSupervisor.obtenerLineaProduccionSupervisor(usuario.idPersona)).nombre;
                }
                if (usuario.rol == "Ingeniero")
                {
                    exclusiveLabel.Visible = true;
                    exclusiveComboBox.Visible = true;
                    exclusiveComboBox.Text = daoIngeniero.obtenerEspecialidadIngeniero(usuario.idPersona);
                }

                
                EstablecerEstadoComponentes(Estado.Modificacion);
            }

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Debe ingresar el teléfono del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCorreo.Text == "")
            {
                MessageBox.Show("Debe ingresar el correo electrónico del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbRol.Text == "Operario" || cbRol.Text == "Supervisor")
            {
                if (exclusiveComboBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar la línea de producción a la que pertenece el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (cbRol.Text == "Ingeniero")
            {
                if (exclusiveComboBox.Text == "")
                {
                    MessageBox.Show("Debe ingresar la especialidad del Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (pbFoto.Image==null)
            {
                MessageBox.Show("Debe ingresar una foto para el Usuario", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar los datos de este Usuario?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                int result=0;

                if (cbRol.Text == "Operario")
                {
                    operario.idPersona = Int32.Parse(txtID.Text);
                    lineaP = new LineaProduccionWS.lineaProduccion();
                    lineaP = (LineaProduccionWS.lineaProduccion)exclusiveComboBox.SelectedItem;
                    operario.lineaProduccion.idLineaProduccion = lineaP.idLineaProduccion;;
                    operario.nombres = txtNombre.Text;
                    operario.apellidos = txtApellidos.Text;
                    operario.fechaNacimiento = dtpNacimiento.Value;
                    operario.fechaNacimientoSpecified = true;
                    operario.telefono = txtNumero.Text;
                    operario.correo = txtCorreo.Text;
                    operario.fechaFinContrato = dtpFinContrato.Value;
                    operario.fechaFinContratoSpecified = true;
                    operario.rol = "Operario";

                    if (ruta != null)
                    {
                        FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        operario.foto = br.ReadBytes((int)fs.Length);
                        fs.Close();
                    }
                    else
                    {
                        operario.foto = usuario.foto;
                    }

                    result = daoOperario.modificarOperario(operario);
                }
                else if (cbRol.Text == "Supervisor")
                {
                    supervisor.idPersona= Int32.Parse(txtID.Text);
                    lineaP = new LineaProduccionWS.lineaProduccion();
                    lineaP = (LineaProduccionWS.lineaProduccion)exclusiveComboBox.SelectedItem;
                    supervisor.lineaProduccion.idLineaProduccion = lineaP.idLineaProduccion;
                    supervisor.nombres = txtNombre.Text;
                    supervisor.apellidos = txtApellidos.Text;
                    supervisor.fechaNacimiento = dtpNacimiento.Value;
                    supervisor.fechaNacimientoSpecified = true;
                    supervisor.telefono = txtNumero.Text;
                    supervisor.correo = txtCorreo.Text;
                    supervisor.fechaFinContrato = dtpFinContrato.Value;
                    supervisor.fechaFinContratoSpecified = true;
                    supervisor.rol = cbRol.Text;

                    if (ruta != null)
                    {
                        FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        supervisor.foto = br.ReadBytes((int)fs.Length);
                        fs.Close();
                    }
                    else
                    {
                        supervisor.foto = usuario.foto;
                    }

                    result = daoSupervisor.actualizarSupervisor(supervisor);
                }
                else if (cbRol.Text == "Ingeniero")
                {
                    ingeniero.idPersona = Int32.Parse(txtID.Text);
                    ingeniero.nombres = txtNombre.Text;
                    ingeniero.apellidos = txtApellidos.Text;
                    ingeniero.fechaNacimiento = dtpNacimiento.Value;
                    ingeniero.telefono = txtNumero.Text;
                    ingeniero.correo = txtCorreo.Text;
                    ingeniero.fechaFinContrato = dtpFinContrato.Value;
                    ingeniero.rol = cbRol.Text;
                    ingeniero.especialidad = exclusiveComboBox.Text;
                    ingeniero.fechaNacimientoSpecified = true;
                    ingeniero.fechaFinContratoSpecified = true;

                    if (ruta != null)
                    {
                        FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ingeniero.foto = br.ReadBytes((int)fs.Length);
                        fs.Close();
                    }
                    else
                    {
                        ingeniero.foto = usuario.foto;
                    }

                    result = daoIngeniero.modificarIngeniero(ingeniero);
                }
                else if (cbRol.Text == "Jefe de Área")
                {
                    jefeArea.idPersona = Int32.Parse(txtID.Text);
                    jefeArea.nombres = txtNombre.Text;
                    jefeArea.apellidos = txtApellidos.Text;
                    jefeArea.fechaNacimiento = dtpNacimiento.Value;
                    jefeArea.telefono = txtNumero.Text;
                    jefeArea.correo = txtCorreo.Text;
                    jefeArea.fechaFinContrato = dtpFinContrato.Value;
                    jefeArea.rol = cbRol.Text;
                    jefeArea.fechaNacimientoSpecified = true;
                    jefeArea.fechaFinContratoSpecified = true;

                    if (ruta != null)
                    {
                        FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        jefeArea.foto = br.ReadBytes((int)fs.Length);
                        fs.Close();
                    }
                    else
                    {
                        jefeArea.foto = usuario.foto;
                    }

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
                    txtUsername.Text = "";
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
                    txtUsername.Text = "";
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
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
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
                txtUsername.Text = "";
                exclusiveLabel.Visible = false;
                exclusiveComboBox.Visible = false;
                EstablecerEstadoComponentes(Estado.Inicial);
            }
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
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            if(ActiveForm!=null) ActiveForm.Show();

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbRol.Text)
            {
                case "Jefe de Área":
                    exclusiveLabel.Visible = false;
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

        static string RandomString(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
    }

}
