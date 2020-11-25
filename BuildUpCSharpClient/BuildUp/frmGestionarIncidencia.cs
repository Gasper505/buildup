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
    public partial class frmGestionarIncidencia : Form
    {

        IncidenteMaquinariaWS.IncidenteMaquinariaWSClient daoIncidenteMaq;
        IncidenteMaquinariaWS.incidenteMaquinaria incidenteMaq;
        IncidenteMaquinariaWS.ingeniero ingeniero;
        IncidenteMaquinariaWS.supervisor supervisor;
        IncidenteMaquinariaWS.problema problema;
        IncidenteMaquinariaWS.respuesta respuesta;
        IncidenteMaquinariaWS.maquinaria maquinaria;

        public frmGestionarIncidencia()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

            daoIncidenteMaq = new IncidenteMaquinariaWS.IncidenteMaquinariaWSClient();
            incidenteMaq = new IncidenteMaquinariaWS.incidenteMaquinaria();
            ingeniero = new IncidenteMaquinariaWS.ingeniero();
            supervisor = new IncidenteMaquinariaWS.supervisor();
            problema = new IncidenteMaquinariaWS.problema();
            respuesta = new IncidenteMaquinariaWS.respuesta();
            maquinaria = new IncidenteMaquinariaWS.maquinaria();


            if (frmLogIn.Usuario.rol == "Jefe"
                || frmLogIn.Usuario.rol == "JEFE"
                || frmLogIn.Usuario.rol == "Jefe de Área"
                || frmLogIn.Usuario.rol == "Jefe de Area"
                || frmLogIn.Usuario.rol == "JEFE DE AREA"
                || frmLogIn.Usuario.rol == "JEFE DE ÁREA")
            {
                btnActualizar.Visible = false;
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
                btnCancelar.Visible = false;
            }

            else if(frmLogIn.Usuario.rol == "Ingeniero")
            {
                btnNuevo.Visible = false;
                btnGuardar.Visible = false;
                btnEliminar.Visible = false;
            }
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

                    txtID.Enabled = false;
                    dtpFechaRegistro.Enabled = false;

                    
                    txtIDMaq.Enabled = false;
                    txtNombreMaq.Enabled = false;
                    txtProveedor.Enabled = false;
                    btnBuscarMaquinaria.Enabled = false;

                    txtIDSup.Enabled = false;
                    txtNombreSup.Enabled = false;
                    txtApellidosSup.Enabled = false;

                    txtIDIng.Enabled = false;
                    txtNombreIng.Enabled = false;
                    txtApellidosIng.Enabled = false;

                    txtIDProblema.Enabled = false;
                    txtProblema.Enabled = false;
                    txtNivelImp.Enabled = false;
                    btnBuscarProblema.Enabled = false;

                    btnBuscarRespuesta.Enabled = false;
                    txtIDResp.Enabled = false;
                    txtRespuesta.Enabled = false;
                    tbDescripcionRespuesta.Enabled = false;
                    dtpFechaRespuesta.Enabled = false;

                    break;

                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;

                    txtID.Enabled = false;
                    dtpFechaRegistro.Enabled = false;

                    if (frmLogIn.Usuario.rol == "Supervisor")
                    {
                        btnBuscarMaquinaria.Enabled = true;

                        txtIDSup.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreSup.Text = frmLogIn.Usuario.nombres;
                        txtApellidosSup.Text = frmLogIn.Usuario.apellidos;

                        btnBuscarProblema.Enabled = true;
                    }
                    

                    if(frmLogIn.Usuario.rol == "Ingeniero")
                    {
                        txtIDIng.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreIng.Text = frmLogIn.Usuario.nombres;
                        txtApellidosIng.Text = frmLogIn.Usuario.apellidos;

                        btnBuscarRespuesta.Enabled = true;
                        tbDescripcionRespuesta.Enabled = true;
                    }

                    break;

                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;

                    txtID.Enabled = false;
                    dtpFechaRegistro.Enabled = false;

                    if (frmLogIn.Usuario.rol == "Supervisor")
                    {
                        btnBuscarMaquinaria.Enabled = true;

                        txtIDSup.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreSup.Text = frmLogIn.Usuario.nombres;
                        txtApellidosSup.Text = frmLogIn.Usuario.apellidos;

                        txtProblema.Enabled = false;
                        btnBuscarProblema.Enabled = true;
                    }


                    if (frmLogIn.Usuario.rol == "Ingeniero")
                    {
                        txtIDIng.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreIng.Text = frmLogIn.Usuario.nombres;
                        txtApellidosIng.Text = frmLogIn.Usuario.apellidos;

                        btnBuscarRespuesta.Enabled = true;
                        txtRespuesta.Enabled = false;
                        tbDescripcionRespuesta.Enabled = false;
                        dtpFechaRespuesta.Enabled = true;
                    }
                    break;

            }
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Incidente?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                incidenteMaq.fechaIncidente = dtpFechaRegistro.Value;

                maquinaria.idMaquinaria = Int32.Parse(txtIDMaq.Text);
                maquinaria.nombre = txtNombreMaq.Text;
                maquinaria.proveedor.razonSocial = txtProveedor.Text;

                supervisor.idPersona = Int32.Parse(txtIDSup.Text);
                supervisor.nombres = txtNombreSup.Text;
                supervisor.apellidos = txtApellidosSup.Text;

                ingeniero.idPersona = Int32.Parse(txtIDIng.Text);
                ingeniero.nombres = txtNombreIng.Text;
                ingeniero.apellidos = txtApellidosIng.Text;

                problema.idProblema = Int32.Parse(txtIDProblema.Text);
                problema.tipo = txtProblema.Text;
                problema.nivelImportancia = Int32.Parse(txtNivelImp.Text);

                respuesta.idRespuesta = Int32.Parse(txtIDResp.Text);
                respuesta.tipo = txtRespuesta.Text;

                incidenteMaq.ingeniero = ingeniero;
                incidenteMaq.supervisor = supervisor;
                incidenteMaq.maquinaria = maquinaria;
                incidenteMaq.problema = problema;
                incidenteMaq.respuesta = respuesta;
                incidenteMaq.fechaAtencion = dtpFechaRespuesta.Value;
                incidenteMaq.detalle = tbDescripcionRespuesta.Text;


                int result = daoIncidenteMaq.insertarIncidenteMaquinaria(incidenteMaq);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    dtpFechaRegistro.Text = "";

                    txtIDMaq.Text = "";
                    txtNombreMaq.Text = "";
                    txtProveedor.Text = "";

                    txtIDSup.Text = "";
                    txtNombreSup.Text = "";
                    txtApellidosSup.Text = "";

                    txtIDIng.Text = "";
                    txtNombreIng.Text = "";
                    txtApellidosIng.Text = "";

                    txtIDProblema.Text = "";
                    txtProblema.Text = "";
                    txtNivelImp.Text = "";

                    txtIDResp.Text = "";
                    txtRespuesta.Text = "";
                    tbDescripcionRespuesta.Text = "";
                    dtpFechaRespuesta.Text = "";
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarIncidencia formBuscarIncidencia = new frmBuscarIncidencia();
            if (formBuscarIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
                incidenteMaq = formBuscarIncidencia.IncidenteSeleccionado;
                txtID.Text = incidenteMaq.idIncidente.ToString();
                dtpFechaRegistro.Value = incidenteMaq.fechaIncidente;

                //incidenteMaq.ingeniero = daoIncidenteMaq.obtenerIngenieroIncidenteMaquinaria(incidenteMaq.idIncidente);
                //incidenteMaq.respuesta = daoIncidenteMaq.obtenerRespuestaIncidenteMaquinaria(incidenteMaq.idIncidente);

                txtIDMaq.Text = incidenteMaq.maquinaria.idMaquinaria.ToString();
                txtNombreMaq.Text = incidenteMaq.maquinaria.nombre;
                txtProveedor.Text = incidenteMaq.maquinaria.proveedor.razonSocial;

                txtIDSup.Text = incidenteMaq.supervisor.idPersona.ToString();
                txtNombreSup.Text = incidenteMaq.supervisor.nombres;
                txtApellidosSup.Text = incidenteMaq.supervisor.apellidos;

                txtIDIng.Text = incidenteMaq.ingeniero.idPersona.ToString();
                txtNombreIng.Text = incidenteMaq.ingeniero.nombres;
                txtApellidosIng.Text = incidenteMaq.ingeniero.apellidos;

                txtIDProblema.Text = incidenteMaq.problema.idProblema.ToString();
                txtProblema.Text = incidenteMaq.problema.tipo;
                txtNivelImp.Text = incidenteMaq.problema.nivelImportancia.ToString();

                txtIDResp.Text = incidenteMaq.respuesta.idRespuesta.ToString();
                txtRespuesta.Text = incidenteMaq.respuesta.tipo;
                tbDescripcionRespuesta.Text = incidenteMaq.detalle;
                dtpFechaRespuesta.Text = incidenteMaq.fechaAtencion.ToString();

                EstablecerEstadoComponentes(Estado.Modificacion);
            }
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea actualizar este Incidente?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                incidenteMaq.idIncidente = Int32.Parse(txtID.Text);
                incidenteMaq.fechaIncidente = dtpFechaRegistro.Value;

                maquinaria.idMaquinaria = Int32.Parse(txtIDMaq.Text);
                maquinaria.nombre = txtNombreMaq.Text;
                maquinaria.proveedor.razonSocial = txtProveedor.Text;

                supervisor.idPersona = Int32.Parse(txtIDSup.Text);
                supervisor.nombres = txtNombreSup.Text;
                supervisor.apellidos = txtApellidosSup.Text;

                ingeniero.idPersona = Int32.Parse(txtIDIng.Text);
                ingeniero.nombres = txtNombreIng.Text;
                ingeniero.apellidos = txtApellidosIng.Text;

                problema.idProblema = Int32.Parse(txtIDProblema.Text);
                problema.tipo = txtProblema.Text;
                problema.nivelImportancia = Int32.Parse(txtNivelImp.Text);

                respuesta.idRespuesta = Int32.Parse(txtIDResp.Text);
                respuesta.tipo = txtRespuesta.Text;

                incidenteMaq.ingeniero = ingeniero;
                incidenteMaq.supervisor = supervisor;
                incidenteMaq.maquinaria = maquinaria;
                incidenteMaq.problema = problema;
                incidenteMaq.respuesta = respuesta;
                incidenteMaq.fechaAtencion = dtpFechaRespuesta.Value;
                incidenteMaq.detalle = tbDescripcionRespuesta.Text;

                int result = 0;
                //result = daoIncidenteMaq.m(maquinaria); //<-----------------------------

                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    dtpFechaRegistro.Text = "";

                    txtIDMaq.Text = "";
                    txtNombreMaq.Text = "";
                    txtProveedor.Text = "";

                    txtIDSup.Text = "";
                    txtNombreSup.Text = "";
                    txtApellidosSup.Text = "";

                    txtIDIng.Text = "";
                    txtNombreIng.Text = "";
                    txtApellidosIng.Text = "";

                    txtIDProblema.Text = "";
                    txtProblema.Text = "";
                    txtNivelImp.Text = "";

                    txtIDResp.Text = "";
                    txtRespuesta.Text = "";
                    tbDescripcionRespuesta.Text = "";
                    dtpFechaRespuesta.Text = "";
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Incidente del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoIncidenteMaq.eliminarIncidenteMaquinaria(Int32.Parse(txtID.Text));
                txtID.Text = "";
                dtpFechaRegistro.Text = "";

                txtIDMaq.Text = "";
                txtNombreMaq.Text = "";
                txtProveedor.Text = "";

                txtIDSup.Text = "";
                txtNombreSup.Text = "";
                txtApellidosSup.Text = "";

                txtIDIng.Text = "";
                txtNombreIng.Text = "";
                txtApellidosIng.Text = "";

                txtIDProblema.Text = "";
                txtProblema.Text = "";
                txtNivelImp.Text = "";

                txtIDResp.Text = "";
                txtRespuesta.Text = "";
                tbDescripcionRespuesta.Text = "";
                dtpFechaRespuesta.Text = "";
                EstablecerEstadoComponentes(Estado.Inicial);
            }
        }

        //-----------------------------------------------------------------

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            dtpFechaRegistro.Text = "";

            txtIDMaq.Text = "";
            txtNombreMaq.Text = "";
            txtProveedor.Text = "";

            txtIDSup.Text = "";
            txtNombreSup.Text = "";
            txtApellidosSup.Text = "";

            txtIDIng.Text = "";
            txtNombreIng.Text = "";
            txtApellidosIng.Text = "";

            txtIDProblema.Text = "";
            txtProblema.Text = "";
            txtNivelImp.Text = "";

            txtIDResp.Text = "";
            txtRespuesta.Text = "";
            tbDescripcionRespuesta.Text = "";
            dtpFechaRespuesta.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscarMaquinaria_Click(object sender, EventArgs e)
        {
            frmBuscarMaquinaria formBuscarMaquinaria = new frmBuscarMaquinaria();
            if (formBuscarMaquinaria.ShowDialog() == DialogResult.OK)
            {
                txtIDMaq.Text = formBuscarMaquinaria.MaquinariaSeleccionada.idMaquinaria.ToString();
                txtNombreMaq.Text = formBuscarMaquinaria.MaquinariaSeleccionada.nombre;
                txtProveedor.Text = formBuscarMaquinaria.MaquinariaSeleccionada.proveedor.razonSocial;
            }
        }

        private void btnBuscarProblema_Click(object sender, EventArgs e)
        {
            frmBuscarProblema formBuscarProblema = new frmBuscarProblema();
            if (formBuscarProblema.ShowDialog() == DialogResult.OK)
            {
                txtIDProblema.Text = formBuscarProblema.ProblemaSeleccionado.idProblema.ToString();
                txtProblema.Text = formBuscarProblema.ProblemaSeleccionado.tipo;
                txtNivelImp.Text = formBuscarProblema.ProblemaSeleccionado.nivelImportancia.ToString();
            }
        }

        private void btnBuscarRespuesta_Click(object sender, EventArgs e)
        {
            frmBuscarRespuesta formBuscarRespuesta = new frmBuscarRespuesta();
            if (formBuscarRespuesta.ShowDialog() == DialogResult.OK)
            {
                txtIDResp.Text = formBuscarRespuesta.RespuestaSeleccionada.idRespuesta.ToString();
                txtRespuesta.Text = formBuscarRespuesta.RespuestaSeleccionada.tipo;
            }
        }
    }
}

