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

        public frmGestionarIncidencia()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);

            daoIncidenteMaq = new IncidenteMaquinariaWS.IncidenteMaquinariaWSClient();
            incidenteMaq = new IncidenteMaquinariaWS.incidenteMaquinaria();

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

                    txtIDIng.Enabled = false;
                    txtNombreIng.Enabled = false;

                    txtProblema.Enabled = false;
                    btnBuscarProblema.Enabled = false;

                    btnBuscarRespuesta.Enabled = false;
                    txtRespuesta.Enabled = false;
                    tbDescripcionRespuesta.Enabled = false;
                    dateTimePicker1.Enabled = false;

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
                        txtNombreSup.Text = frmLogIn.Usuario.nombres + " " + frmLogIn.Usuario.apellidos;

                        txtProblema.Enabled = true;
                        btnBuscarProblema.Enabled = true;
                    }
                    

                    if(frmLogIn.Usuario.rol == "Ingeniero")
                    {
                        txtIDIng.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreIng.Text = frmLogIn.Usuario.nombres + " " + frmLogIn.Usuario.apellidos;

                        btnBuscarRespuesta.Enabled = true;
                        txtRespuesta.Enabled = true;
                        tbDescripcionRespuesta.Enabled = true;
                        dateTimePicker1.Enabled = true;
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
                        txtNombreSup.Text = frmLogIn.Usuario.nombres + " " + frmLogIn.Usuario.apellidos;

                        txtProblema.Enabled = true;
                        btnBuscarProblema.Enabled = true;
                    }


                    if (frmLogIn.Usuario.rol == "Ingeniero")
                    {
                        txtIDIng.Text = frmLogIn.Usuario.idPersona.ToString();
                        txtNombreIng.Text = frmLogIn.Usuario.nombres + " " + frmLogIn.Usuario.apellidos;

                        btnBuscarRespuesta.Enabled = true;
                        txtRespuesta.Enabled = true;
                        tbDescripcionRespuesta.Enabled = true;
                        dateTimePicker1.Enabled = true;
                    }
                    break;

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarIncidencia formBuscarIncidencia = new frmBuscarIncidencia();
            if (formBuscarIncidencia.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
            }
            EstablecerEstadoComponentes(Estado.Modificacion);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            dtpFechaRegistro.Text = "";


            txtIDMaq.Text = "";
            txtNombreMaq.Text = "";
            txtProveedor.Text = "";
            btnBuscarMaquinaria.Text = "";

            txtIDSup.Text = "";
            txtNombreSup.Text = "";

            txtIDIng.Text = "";
            txtNombreIng.Text = "";

            txtProblema.Text = "";
            btnBuscarProblema.Text = "";

            txtRespuesta.Text = "";
            tbDescripcionRespuesta.Text = "";
            dateTimePicker1.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnBuscarMaquinaria_Click(object sender, EventArgs e)
        {
            frmBuscarMaquinaria formBuscarMaquinaria = new frmBuscarMaquinaria();
            if (formBuscarMaquinaria.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
            }
        }

        private void btnBuscarProblema_Click(object sender, EventArgs e)
        {
            frmBuscarProblema formBuscarProblema = new frmBuscarProblema();
            if (formBuscarProblema.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
            }
        }

        private void btnBuscarRespuesta_Click(object sender, EventArgs e)
        {
            frmBuscarRespuesta formBuscarRespuesta = new frmBuscarRespuesta();
            if (formBuscarRespuesta.ShowDialog() == DialogResult.OK)
            {
                //Paso de información
            }
        }
    }
}

