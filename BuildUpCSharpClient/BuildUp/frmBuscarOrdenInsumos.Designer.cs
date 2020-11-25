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
            this.gbParametrosBusqueda = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvOrdenesInsumos = new System.Windows.Forms.DataGridView();
            this.IDOrdenInsumos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbParametrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.dtpHasta);
            this.gbParametrosBusqueda.Controls.Add(this.lblHasta);
            this.gbParametrosBusqueda.Controls.Add(this.lblDesde);
            this.gbParametrosBusqueda.Controls.Add(this.dtpDesde);
            this.gbParametrosBusqueda.Controls.Add(this.btnBuscar);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(42, 28);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(744, 108);
            this.gbParametrosBusqueda.TabIndex = 3;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Parámetros de Búsqueda";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(172, 71);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(254, 20);
            this.dtpHasta.TabIndex = 21;
            this.dtpHasta.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(127, 75);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 15);
            this.lblHasta.TabIndex = 20;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(123, 45);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(172, 41);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(254, 20);
            this.dtpDesde.TabIndex = 18;
            this.dtpDesde.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(522, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 36);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvOrdenesInsumos
            // 
            this.dgvOrdenesInsumos.AllowUserToAddRows = false;
            this.dgvOrdenesInsumos.AllowUserToDeleteRows = false;
            this.dgvOrdenesInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesInsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOrdenInsumos,
            this.FechaReg,
            this.IDOperario,
            this.NombreOperario,
            this.IDInsumo,
            this.NombreInsumo,
            this.Cantidad});
            this.dgvOrdenesInsumos.Location = new System.Drawing.Point(42, 153);
            this.dgvOrdenesInsumos.MultiSelect = false;
            this.dgvOrdenesInsumos.Name = "dgvOrdenesInsumos";
            this.dgvOrdenesInsumos.ReadOnly = true;
            this.dgvOrdenesInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenesInsumos.Size = new System.Drawing.Size(744, 264);
            this.dgvOrdenesInsumos.TabIndex = 4;
            // 
            // IDOrdenInsumos
            // 
            this.IDOrdenInsumos.DataPropertyName = "idOrdenInsumos";
            this.IDOrdenInsumos.HeaderText = "ID Orden Insumos";
            this.IDOrdenInsumos.Name = "IDOrdenInsumos";
            this.IDOrdenInsumos.ReadOnly = true;
            // 
            // FechaReg
            // 
            this.FechaReg.DataPropertyName = "fecha";
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
            this.Cantidad.DataPropertyName = "cantidad";
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
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvOrdenesInsumos);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarOrdenInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Orden de Insumos";
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesInsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.DataGridView dgvOrdenesInsumos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOrdenInsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}