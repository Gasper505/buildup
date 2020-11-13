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
        public frmBuscarProveedor()
        {
            InitializeComponent();
            daoProveedor = new ProveedorWS.ProveedorWSClient();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtRazonSocial.Text = "";
            BindingList<ProveedorWS.proveedor> provs = new BindingList<ProveedorWS.proveedor>(daoProveedor.listarProveedor().ToArray());
           




            dataGridView1.DataSource = provs;
        }
    }
}
