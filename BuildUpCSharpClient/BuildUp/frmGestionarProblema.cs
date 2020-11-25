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
    public partial class frmGestionarProblema : Form
    {

        ProblemaWS.ProblemaWSClient daoProblema;
        ProblemaWS.problema problema;

        public frmGestionarProblema()
        {
            InitializeComponent();
            establecerEstadoComponentes(Estado.Inicial);
            daoProblema = new ProblemaWS.ProblemaWSClient();
            problema = new ProblemaWS.problema();

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
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = false;
                    txtNivelImportancia.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = true;
                    txtNivelImportancia.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIdProblema.Enabled = false;
                    txtTipo.Enabled = true;
                    txtNivelImportancia.Enabled = true;
                    break;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            establecerEstadoComponentes(Estado.Nuevo);
        }

        //-----------------------------------------------------------------

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                MessageBox.Show("Debe escribir un tipo de problema", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNivelImportancia.Text == "")
            {
                MessageBox.Show("Debe seleccionar un nivel de importancia", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Problema?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                problema.tipo = txtTipo.Text;
                problema.nivelImportancia = Int32.Parse(txtNivelImportancia.Text);

                int result = daoProblema.insertarProblema(problema);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdProblema.Text = "";
                    txtTipo.Text = "";
                    txtNivelImportancia.Text = "";
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
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar este Problema?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                problema = new ProblemaWS.problema();
                problema.idProblema = Int32.Parse(txtIdProblema.Text);
                problema.tipo = txtTipo.Text;
                problema.nivelImportancia = Int32.Parse(txtNivelImportancia.Text);

                int result = daoProblema.actualizarProblema(problema);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdProblema.Text = "";
                    txtTipo.Text = "";
                    txtNivelImportancia.Text = "";
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este Problema del registro?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoProblema.eliminarProblema(Int32.Parse(txtIdProblema.Text));
                txtIdProblema.Text = "";
                txtTipo.Text = "";
                txtNivelImportancia.Text = "";
                establecerEstadoComponentes(Estado.Inicial);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProblema formBuscarProblema = new frmBuscarProblema();
            if (formBuscarProblema.ShowDialog() == DialogResult.OK)
            {
                this.problema = formBuscarProblema.ProblemaSeleccionado;
                txtIdProblema.Text = problema.idProblema.ToString();
                txtTipo.Text = problema.tipo;
                txtNivelImportancia.Text = problema.nivelImportancia.ToString();
                establecerEstadoComponentes(Estado.Modificacion);
            }
            
        }
        //-----------------------------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdProblema.Text = "";
            txtTipo.Text = "";
            txtNivelImportancia.Text = "";
            establecerEstadoComponentes(Estado.Inicial);
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
