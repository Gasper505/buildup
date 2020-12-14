namespace BuildUp
{
    partial class frmBuscarOrdenSalida
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
            this.dgvOrdenesSalida = new System.Windows.Forms.DataGridView();
            this.gbParametrosBusqueda = new System.Windows.Forms.GroupBox();
            this.dtpFechaSup = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpFechaInf = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreOperario = new System.Windows.Forms.TextBox();
            this.lblNombreOperario = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoOperario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesSalida)).BeginInit();
            this.gbParametrosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdenesSalida
            // 
            this.dgvOrdenesSalida.AllowUserToAddRows = false;
            this.dgvOrdenesSalida.AllowUserToDeleteRows = false;
            this.dgvOrdenesSalida.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvOrdenesSalida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrdenesSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.ApellidoOperario,
            this.Column5});
            this.dgvOrdenesSalida.Location = new System.Drawing.Point(38, 194);
            this.dgvOrdenesSalida.MultiSelect = false;
            this.dgvOrdenesSalida.Name = "dgvOrdenesSalida";
            this.dgvOrdenesSalida.ReadOnly = true;
            this.dgvOrdenesSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenesSalida.Size = new System.Drawing.Size(665, 325);
            this.dgvOrdenesSalida.TabIndex = 0;
            this.dgvOrdenesSalida.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrdenesSalida_CellFormatting);
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.dtpFechaSup);
            this.gbParametrosBusqueda.Controls.Add(this.lblHasta);
            this.gbParametrosBusqueda.Controls.Add(this.lblDesde);
            this.gbParametrosBusqueda.Controls.Add(this.dtpFechaInf);
            this.gbParametrosBusqueda.Controls.Add(this.btnBuscar);
            this.gbParametrosBusqueda.Controls.Add(this.txtNombreOperario);
            this.gbParametrosBusqueda.Controls.Add(this.lblNombreOperario);
            this.gbParametrosBusqueda.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(38, 32);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(665, 156);
            this.gbParametrosBusqueda.TabIndex = 9;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Parámetros de Búsqueda";
            // 
            // dtpFechaSup
            // 
            this.dtpFechaSup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSup.Location = new System.Drawing.Point(224, 105);
            this.dtpFechaSup.Name = "dtpFechaSup";
            this.dtpFechaSup.Size = new System.Drawing.Size(174, 25);
            this.dtpFechaSup.TabIndex = 21;
            this.dtpFechaSup.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(177, 111);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 17);
            this.lblHasta.TabIndex = 20;
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(173, 80);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(45, 17);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde";
            // 
            // dtpFechaInf
            // 
            this.dtpFechaInf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInf.Location = new System.Drawing.Point(224, 74);
            this.dtpFechaInf.Name = "dtpFechaInf";
            this.dtpFechaInf.Size = new System.Drawing.Size(174, 25);
            this.dtpFechaInf.TabIndex = 18;
            this.dtpFechaInf.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(464, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(165, 37);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreOperario
            // 
            this.txtNombreOperario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreOperario.Location = new System.Drawing.Point(224, 43);
            this.txtNombreOperario.Name = "txtNombreOperario";
            this.txtNombreOperario.Size = new System.Drawing.Size(248, 25);
            this.txtNombreOperario.TabIndex = 4;
            // 
            // lblNombreOperario
            // 
            this.lblNombreOperario.AutoSize = true;
            this.lblNombreOperario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOperario.Location = new System.Drawing.Point(15, 46);
            this.lblNombreOperario.Name = "lblNombreOperario";
            this.lblNombreOperario.Size = new System.Drawing.Size(203, 17);
            this.lblNombreOperario.TabIndex = 0;
            this.lblNombreOperario.Text = "Nombre del Operario Encargado";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(243, 525);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(257, 46);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdOrdenSalida";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nombres";
            this.Column2.HeaderText = "Nombre(s) del Operario";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // ApellidoOperario
            // 
            this.ApellidoOperario.DataPropertyName = "Apellidos";
            this.ApellidoOperario.HeaderText = "Apellidos del Operario";
            this.ApellidoOperario.Name = "ApellidoOperario";
            this.ApellidoOperario.ReadOnly = true;
            this.ApellidoOperario.Width = 160;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Fecha";
            this.Column5.HeaderText = "Fecha de Registro";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // frmBuscarOrdenSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 582);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.Controls.Add(this.dgvOrdenesSalida);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarOrdenSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Órdenes de Salida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesSalida)).EndInit();
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenesSalida;
        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreOperario;
        private System.Windows.Forms.Label lblNombreOperario;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DateTimePicker dtpFechaSup;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoOperario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}