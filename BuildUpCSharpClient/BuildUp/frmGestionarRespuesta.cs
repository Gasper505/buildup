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
    public partial class frmGestionarRespuesta : Form
    {

        RespuestaWS.RespuestaWSClient daoRespuesta;
        RespuestaWS.respuesta respuesta;

        public frmGestionarRespuesta()
        {
            InitializeComponent();
            establecerEstadoComponentes(Estado.Inicial);
            daoRespuesta = new RespuestaWS.RespuestaWSClient();
            respuesta = new RespuestaWS.respuesta();
        }

        public void establecerEstadoComponentes(Estado estado)
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
                    txtIdRespuesta.Enabled = false;
                    txtTipo.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIdRespuesta.Enabled = false;
                    txtTipo.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIdRespuesta.Enabled = false;
                    txtTipo.Enabled = true;
                    break;

            }
        }


        //-----------------------------------------------------------------
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Debe escribir un tipo de respuesta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar esta Respuesta?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                respuesta.tipo = txtTipo.Text;
                int result = daoRespuesta.insertarRespuesta(respuesta);
                result = 1;//
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdRespuesta.Text = "";
                    txtTipo.Text = "";
                    establecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar esta Respuesta?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                respuesta.idRespuesta = Int32.Parse(txtIdRespuesta.Text);
                respuesta.tipo = txtTipo.Text;
                int result = daoRespuesta.actualizarRespuesta(respuesta);
                if(result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdRespuesta.Text = "";
                    txtTipo.Text = "";
                    establecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar esta Respuesta del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoRespuesta.eliminarRespuesta(Int32.Parse(txtIdRespuesta.Text));
                txtIdRespuesta.Text = "";
                txtTipo.Text = "";
                establecerEstadoComponentes(Estado.Inicial);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarRespuesta formBuscarRespuesta = new frmBuscarRespuesta();
            if (formBuscarRespuesta.ShowDialog() == DialogResult.OK)
            {
                respuesta = formBuscarRespuesta.RespuestaSeleccionada;
                txtIdRespuesta.Text = respuesta.idRespuesta.ToString();
                txtTipo.Text = respuesta.tipo;
                establecerEstadoComponentes(Estado.Modificacion);
            }

        }

        //-----------------------------------------------------------------

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            establecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta acción limpiará todos los campos llenados, echando a perder cualquier trabajo realizado.\n¿Está seguro que desea continuar?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtIdRespuesta.Text = "";
                txtTipo.Text = "";
                establecerEstadoComponentes(Estado.Inicial);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (ActiveForm != null) ActiveForm.Show();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
