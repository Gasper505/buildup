namespace BuildUp
{
    partial class frmBuscarOrdenInsumos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBusqFechaRegOrden = new System.Windows.Forms.Label();
            this.lblBusqIdOrden = new System.Windows.Forms.Label();
            this.dtpBusqFechaRegOrden = new System.Windows.Forms.DateTimePicker();
            this.gbParametrosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqIdOrdenInsumos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDOrdenInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbParametrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqFechaRegOrden
            // 
            this.lblBusqFechaRegOrden.AutoSize = true;
            this.lblBusqFechaRegOrden.Location = new System.Drawing.Point(95, 69);
            this.lblBusqFechaRegOrden.Name = "lblBusqFechaRegOrden";
            this.lblBusqFechaRegOrden.Size = new System.Drawing.Size(94, 13);
            this.lblBusqFechaRegOrden.TabIndex = 0;
            this.lblBusqFechaRegOrden.Text = "Fecha de Registro";
            // 
            // lblBusqIdOrden
            // 
            this.lblBusqIdOrden.AutoSize = true;
            this.lblBusqIdOrden.Location = new System.Drawing.Point(171, 34);
            this.lblBusqIdOrden.Name = "lblBusqIdOrden";
            this.lblBusqIdOrden.Size = new System.Drawing.Size(18, 13);
            this.lblBusqIdOrden.TabIndex = 1;
            this.lblBusqIdOrden.Text = "ID";
            // 
            // dtpBusqFechaRegOrden
            // 
            this.dtpBusqFechaRegOrden.Location = new System.Drawing.Point(195, 69);
            this.dtpBusqFechaRegOrden.Name = "dtpBusqFechaRegOrden";
            this.dtpBusqFechaRegOrden.Size = new System.Drawing.Size(240, 20);
            this.dtpBusqFechaRegOrden.TabIndex = 2;
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.btnBuscar);
            this.gbParametrosBusqueda.Controls.Add(this.txtBusqIdOrdenInsumos);
            this.gbParametrosBusqueda.Controls.Add(this.dtpBusqFechaRegOrden);
            this.gbParametrosBusqueda.Controls.Add(this.lblBusqIdOrden);
            this.gbParametrosBusqueda.Controls.Add(this.lblBusqFechaRegOrden);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(42, 28);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(700, 108);
            this.gbParametrosBusqueda.TabIndex = 3;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Parámetros de Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(506, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqIdOrdenInsumos
            // 
            this.txtBusqIdOrdenInsumos.Location = new System.Drawing.Point(195, 31);
            this.txtBusqIdOrdenInsumos.Name = "txtBusqIdOrdenInsumos";
            this.txtBusqIdOrdenInsumos.Size = new System.Drawing.Size(84, 20);
            this.txtBusqIdOrdenInsumos.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOrdenInsumos,
            this.FechaReg,
            this.IDOperario,
            this.NombreOperario,
            this.IDInsumo,
            this.NombreInsumo,
            this.Cantidad});
            this.dataGridView1.Location = new System.Drawing.Point(42, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 264);
            this.dataGridView1.TabIndex = 4;
            // 
            // IDOrdenInsumos
            // 
            this.IDOrdenInsumos.HeaderText = "ID Orden Insumos";
            this.IDOrdenInsumos.Name = "IDOrdenInsumos";
            this.IDOrdenInsumos.ReadOnly = true;
            // 
            // FechaReg
            // 
            this.FechaReg.HeaderText = "Fecha de Registro";
            this.FechaReg.Name = "FechaReg";
            this.FechaReg.ReadOnly = true;
            // 
            // IDOperario
            // 
            this.IDOperario.HeaderText = "ID Operario";
            this.IDOperario.Name = "IDOperario";
            this.IDOperario.ReadOnly = true;
            // 
            // NombreOperario
            // 
            this.NombreOperario.HeaderText = "Nombre del Operario";
            this.NombreOperario.Name = "NombreOperario";
            this.NombreOperario.ReadOnly = true;
            // 
            // IDInsumo
            // 
            this.IDInsumo.HeaderText = "ID Insumo";
            this.IDInsumo.Name = "IDInsumo";
            this.IDInsumo.ReadOnly = true;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.HeaderText = "Nombre Insumo";
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(267, 442);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(257, 36);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarOrdenInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 501);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarOrdenInsumos";
            this.Text = "Búsqueda de Orden de Insumos";
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBusqFechaRegOrden;
        private System.Windows.Forms.Label lblBusqIdOrden;
        private System.Windows.Forms.DateTimePicker dtpBusqFechaRegOrden;
        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.TextBox txtBusqIdOrdenInsumos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOrdenInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
    }
}