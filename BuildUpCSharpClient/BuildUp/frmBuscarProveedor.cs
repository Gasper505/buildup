using BuildUp.ProveedorWS;
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
   
    public partial class frmBuscarProveedor : Form
    {
        ProveedorWS.ProveedorWSClient daoProveedor;
        ProveedorWS.proveedor proveedorSeleccionado;

        public proveedor ProveedorSeleccionado { get => proveedorSeleccionado; set => proveedorSeleccionado = value; }

        public frmBuscarProveedor()
        {
            InitializeComponent();
            daoProveedor = new ProveedorWS.ProveedorWSClient();
            proveedorSeleccionado = new ProveedorWS.proveedor();
            dgvProveedores.AutoGenerateColumns = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            proveedorSeleccionado = (ProveedorWS.proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BindingList<ProveedorWS.proveedor> provs = new BindingList<ProveedorWS.proveedor>(daoProveedor.listarProveedor().ToArray());
            dgvProveedores.DataSource = provs;
        }
    }
}
