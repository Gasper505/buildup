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
    public partial class frmGestionarPlanProduccion : Form
    {
        PlanProduccionWS.PlanProduccionWSClient daoPlanProduccion;
        PlanProduccionWS.planProduccion planProduccion;
        BindingList<PlanProduccionWS.lineaPlanProduccion> lineasPlan;
        TipoLadrilloWS.TipoLadrilloWSClient daoTipoLadrillo;

        public frmGestionarPlanProduccion()
        {
            InitializeComponent();
            EstablecerEstadoComponentes(Estado.Inicial);
            daoPlanProduccion = new PlanProduccionWS.PlanProduccionWSClient();
            planProduccion = new PlanProduccionWS.planProduccion();

            daoTipoLadrillo = new TipoLadrilloWS.TipoLadrilloWSClient();

            dgvAsignacion.AutoGenerateColumns = false;
            dgvAsignacion.DataSource = planProduccion.lineasPlan;

            cboNombreTipoLadrillo.DataSource = new BindingList<TipoLadrilloWS.tipoLadrillo>(daoTipoLadrillo.listarTiposLadrillo().ToArray());
            cboNombreTipoLadrillo.ValueMember = "idTipoLadrillo";
            cboNombreTipoLadrillo.DisplayMember = "nombre";

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
                    btnAgregar.Enabled = false;
                    btnRemover.Enabled = false;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = false;
                    cboNombreTipoLadrillo.Enabled = false;
                    dgvAsignacion.Enabled = false;
                    numNroAproxLadrillos.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = true;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvAsignacion.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    break;
                case Estado.Modificacion:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnActualizar.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    txtIDPlan.Enabled = false;
                    txtAnho.Enabled = true;
                    cboNombreTipoLadrillo.Enabled = true;
                    dgvAsignacion.Enabled = true;
                    numNroAproxLadrillos.Enabled = true;
                    break;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EstablecerEstadoComponentes(Estado.Nuevo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAnho.Text == "")
            {
                MessageBox.Show("Debe agregar un año para el plan", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lineasPlan == null || lineasPlan.Count == 0)
            {
                MessageBox.Show("Debe agregar lineas para orden de salida", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult dr = MessageBox.Show("¿Está seguro que desea registrar este Plan de Produccion?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                planProduccion.anhoPlan = Int32.Parse(txtAnho.Text);
                planProduccion.lineasPlan = lineasPlan.ToArray();


                int result = daoPlanProduccion.insertarPlanProduccion(planProduccion);
                if (result != 0)
                {
                    MessageBox.Show("El registro ha sido exitoso", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDPlan.Text = "";
                    txtAnho.Text = "";
                    cboNombreTipoLadrillo.Text = "";
                    dgvAsignacion.DataSource = null;
                    numNroAproxLadrillos.Value = 0;
                    EstablecerEstadoComponentes(Estado.Inicial);
                }
                else
                {
                    MessageBox.Show("Error en el proceso", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


        private void btnHistorial_Click(object sender, EventArgs e)
        {
            lineasPlan = new BindingList<PlanProduccionWS.lineaPlanProduccion>();
            frmBuscarPlanProduccion formBuscarPlanProduccion = new frmBuscarPlanProduccion();
            if (formBuscarPlanProduccion.ShowDialog() == DialogResult.OK)
            {
                planProduccion = new PlanProduccionWS.planProduccion();
                planProduccion = formBuscarPlanProduccion.PlanSeleccionado;
                txtIDPlan.Text = planProduccion.idPlan.ToString();
                txtAnho.Text = planProduccion.anhoPlan.ToString();


                if (planProduccion.lineasPlan != null)
                {
                    foreach (PlanProduccionWS.lineaPlanProduccion linea in planProduccion.lineasPlan)
                    {
                        lineasPlan.Add(linea);
                    }
                }

                //dgvLotes.DataSource = ordenSalida.lineasOrdenSalida; //<---
                dgvAsignacion.DataSource = lineasPlan.ToArray();

                EstablecerEstadoComponentes(Estado.Modificacion);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea actualizar este plan de produccion?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                planProduccion.idPlan = Int32.Parse(txtIDPlan.Text);
                planProduccion.anhoPlan = Int32.Parse(txtAnho.Text);


                int result = 0;
                result = daoPlanProduccion.actualizarPlanProduccion(planProduccion);
                if (result != 0)
                {
                    MessageBox.Show("La actualización ha sido exitosa", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDPlan.Text = "";
                    txtAnho.Text = "";
                    cboNombreTipoLadrillo.Text = "";
                    dgvAsignacion.DataSource = null;
                    numNroAproxLadrillos.Value = 0;
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
            DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este plan de produccion?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                daoPlanProduccion.eliminarPlanProduccion(Int32.Parse(txtIDPlan.Text));
                txtIDPlan.Text = "";
                txtAnho.Text = "";
                cboNombreTipoLadrillo.Text = "";
                dgvAsignacion.DataSource = null;
                numNroAproxLadrillos.Value = 0;
                EstablecerEstadoComponentes(Estado.Inicial);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDPlan.Text = "";
            txtAnho.Text = "";
            cboNombreTipoLadrillo.Text = "";
            numNroAproxLadrillos.Text = "";
            EstablecerEstadoComponentes(Estado.Inicial);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lineasPlan == null)
            {
                lineasPlan = new BindingList<PlanProduccionWS.lineaPlanProduccion>();
            }

            if (cboNombreTipoLadrillo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numNroAproxLadrillos.Text == "") 
            {
                MessageBox.Show("Debe ingresar una cantidad del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          
            if (Int32.Parse(numNroAproxLadrillos.Text) == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad del ladrillo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (planProduccion.lineasPlan != null)
            {
                foreach (PlanProduccionWS.lineaPlanProduccion linea in planProduccion.lineasPlan)
                {
                    if (linea.tipoLadrillo.nombre.Equals(cboNombreTipoLadrillo.Text))
                    {
                        linea.cantidad = linea.cantidad + Int32.Parse(numNroAproxLadrillos.Text);
                        dgvAsignacion.DataSource = planProduccion.lineasPlan;
                        dgvAsignacion.Refresh();
                        return;
                    }
                }
            }

            PlanProduccionWS.lineaPlanProduccion lpp = new PlanProduccionWS.lineaPlanProduccion();

            lpp.tipoLadrillo = new PlanProduccionWS.tipoLadrillo();
            TipoLadrilloWS.tipoLadrillo tipLad = (TipoLadrilloWS.tipoLadrillo)cboNombreTipoLadrillo.SelectedItem;
            lpp.tipoLadrillo.idTipoLadrillo = tipLad.idTipoLadrillo;
            lpp.tipoLadrillo.nombre = tipLad.nombre;
            lpp.cantidad = Int32.Parse(numNroAproxLadrillos.Text);


            lineasPlan.Add(lpp);
            planProduccion.lineasPlan = lineasPlan.ToArray();

            dgvAsignacion.DataSource = lineasPlan.ToArray();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAsignacion.CurrentRow != null)
            {
                PlanProduccionWS.lineaPlanProduccion l = (PlanProduccionWS.lineaPlanProduccion)dgvAsignacion.CurrentRow.DataBoundItem;
                lineasPlan.Remove(l);
                planProduccion.lineasPlan = lineasPlan.ToArray();
                dgvAsignacion.DataSource = lineasPlan.ToArray();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una linea de plan", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void dgvAsignacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PlanProduccionWS.lineaPlanProduccion data = dgvAsignacion.Rows[e.RowIndex].DataBoundItem as PlanProduccionWS.lineaPlanProduccion;
            dgvAsignacion.Rows[e.RowIndex].Cells[0].Value = data.tipoLadrillo.nombre;

        }
    }
    }
