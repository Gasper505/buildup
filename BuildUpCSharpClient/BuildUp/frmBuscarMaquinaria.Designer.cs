namespace BuildUp
{
    partial class frmBuscarMaquinaria
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvMaquinarias = new System.Windows.Forms.DataGridView();
            this.gbParametrosBusqueda = new System.Windows.Forms.GroupBox();
            this.txtBusqLineaProduccion = new System.Windows.Forms.TextBox();
            this.lblBusqLineaProduccion = new System.Windows.Forms.Label();
            this.txtBusqNombreMaq = new System.Windows.Forms.TextBox();
            this.lblBusqNombreMaq = new System.Windows.Forms.Label();
            this.IDMaquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMaquinaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLineaProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinarias)).BeginInit();
            this.gbParametrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(562, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 36);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(289, 450);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(225, 36);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvMaquinarias
            // 
            this.dgvMaquinarias.AllowUserToAddRows = false;
            this.dgvMaquinarias.AllowUserToDeleteRows = false;
            this.dgvMaquinarias.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvMaquinarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquinarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMaquinaria,
            this.NombreMaquinaria,
            this.NombreLineaProduccion,
            this.Proveedor});
            this.dgvMaquinarias.Location = new System.Drawing.Point(65, 178);
            this.dgvMaquinarias.Name = "dgvMaquinarias";
            this.dgvMaquinarias.ReadOnly = true;
            this.dgvMaquinarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquinarias.Size = new System.Drawing.Size(700, 250);
            this.dgvMaquinarias.TabIndex = 9;
            this.dgvMaquinarias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMaquinarias_CellFormatting);
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.btnBuscar);
            this.gbParametrosBusqueda.Controls.Add(this.txtBusqLineaProduccion);
            this.gbParametrosBusqueda.Controls.Add(this.lblBusqLineaProduccion);
            this.gbParametrosBusqueda.Controls.Add(this.txtBusqNombreMaq);
            this.gbParametrosBusqueda.Controls.Add(this.lblBusqNombreMaq);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(65, 25);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(700, 132);
            this.gbParametrosBusqueda.TabIndex = 8;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Parámetros de Búsqueda";
            // 
            // txtBusqLineaProduccion
            // 
            this.txtBusqLineaProduccion.Location = new System.Drawing.Point(217, 76);
            this.txtBusqLineaProduccion.Name = "txtBusqLineaProduccion";
            this.txtBusqLineaProduccion.Size = new System.Drawing.Size(263, 20);
            this.txtBusqLineaProduccion.TabIndex = 6;
            // 
            // lblBusqLineaProduccion
            // 
            this.lblBusqLineaProduccion.AutoSize = true;
            this.lblBusqLineaProduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqLineaProduccion.Location = new System.Drawing.Point(13, 76);
            this.lblBusqLineaProduccion.Name = "lblBusqLineaProduccion";
            this.lblBusqLineaProduccion.Size = new System.Drawing.Size(198, 15);
            this.lblBusqLineaProduccion.TabIndex = 5;
            this.lblBusqLineaProduccion.Text = "Nombre de la Linea de Produccion";
            // 
            // txtBusqNombreMaq
            // 
            this.txtBusqNombreMaq.Location = new System.Drawing.Point(217, 46);
            this.txtBusqNombreMaq.Name = "txtBusqNombreMaq";
            this.txtBusqNombreMaq.Size = new System.Drawing.Size(263, 20);
            this.txtBusqNombreMaq.TabIndex = 4;
            // 
            // lblBusqNombreMaq
            // 
            this.lblBusqNombreMaq.AutoSize = true;
            this.lblBusqNombreMaq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqNombreMaq.Location = new System.Drawing.Point(63, 46);
            this.lblBusqNombreMaq.Name = "lblBusqNombreMaq";
            this.lblBusqNombreMaq.Size = new System.Drawing.Size(148, 15);
            this.lblBusqNombreMaq.TabIndex = 0;
            this.lblBusqNombreMaq.Text = "Nombre de la Maquinaria";
            // 
            // IDMaquinaria
            // 
            this.IDMaquinaria.DataPropertyName = "IdMaquinaria";
            this.IDMaquinaria.HeaderText = "ID Maquinaria";
            this.IDMaquinaria.Name = "IDMaquinaria";
            this.IDMaquinaria.ReadOnly = true;
            // 
            // NombreMaquinaria
            // 
            this.NombreMaquinaria.DataPropertyName = "Nombre";
            this.NombreMaquinaria.HeaderText = "Nombre Maquinaria";
            this.NombreMaquinaria.Name = "NombreMaquinaria";
            this.NombreMaquinaria.ReadOnly = true;
            this.NombreMaquinaria.Width = 240;
            // 
            // NombreLineaProduccion
            // 
            this.NombreLineaProduccion.HeaderText = "Linea de Produccion";
            this.NombreLineaProduccion.Name = "NombreLineaProduccion";
            this.NombreLineaProduccion.ReadOnly = true;
            this.NombreLineaProduccion.Width = 150;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 170;
            // 
            // frmBuscarMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 508);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvMaquinarias);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarMaquinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Maquinaria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinarias)).EndInit();
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvMaquinarias;
        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.TextBox txtBusqNombreMaq;
        private System.Windows.Forms.Label lblBusqNombreMaq;
        private System.Windows.Forms.TextBox txtBusqLineaProduccion;
        private System.Windows.Forms.Label lblBusqLineaProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMaquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaquinaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLineaProduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
    }
}