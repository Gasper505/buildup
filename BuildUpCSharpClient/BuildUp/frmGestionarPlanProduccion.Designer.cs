namespace BuildUp
{
    partial class frmGestionarPlanProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPlanProduccion));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnRegresar = new System.Windows.Forms.ToolStripButton();
            this.gbLotesSalientes = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAsignacion = new System.Windows.Forms.DataGridView();
            this.NombreTipoLadrillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboNombreTipoLadrillo = new System.Windows.Forms.ComboBox();
            this.lblNombreTipoLadrillo = new System.Windows.Forms.Label();
            this.numNroAproxLadrillos = new System.Windows.Forms.NumericUpDown();
            this.lblNro = new System.Windows.Forms.Label();
            this.gbDatosOperario = new System.Windows.Forms.GroupBox();
            this.txtAnho = new System.Windows.Forms.ComboBox();
            this.txtIDPlan = new System.Windows.Forms.TextBox();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.lblAnho = new System.Windows.Forms.Label();
            this.toolStrip2.SuspendLayout();
            this.gbLotesSalientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroAproxLadrillos)).BeginInit();
            this.gbDatosOperario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnNuevo,
            this.btnGuardar,
            this.toolStripSeparator3,
            this.btnBuscar,
            this.btnActualizar,
            this.btnEliminar,
            this.toolStripSeparator4,
            this.btnCancelar,
            this.btnRegresar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(793, 25);
            this.toolStrip2.TabIndex = 40;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::BuildUp.Properties.Resources.new_file_icon_4;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 22);
            this.btnCancelar.Text = "Limpiar y Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(81, 22);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // gbLotesSalientes
            // 
            this.gbLotesSalientes.Controls.Add(this.btnRemover);
            this.gbLotesSalientes.Controls.Add(this.btnAgregar);
            this.gbLotesSalientes.Controls.Add(this.dgvAsignacion);
            this.gbLotesSalientes.Controls.Add(this.cboNombreTipoLadrillo);
            this.gbLotesSalientes.Controls.Add(this.lblNombreTipoLadrillo);
            this.gbLotesSalientes.Controls.Add(this.numNroAproxLadrillos);
            this.gbLotesSalientes.Controls.Add(this.lblNro);
            this.gbLotesSalientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLotesSalientes.Location = new System.Drawing.Point(69, 201);
            this.gbLotesSalientes.Name = "gbLotesSalientes";
            this.gbLotesSalientes.Size = new System.Drawing.Size(623, 364);
            this.gbLotesSalientes.TabIndex = 42;
            this.gbLotesSalientes.TabStop = false;
            this.gbLotesSalientes.Text = "Asignación de Producción";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(522, 70);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(59, 35);
            this.btnRemover.TabIndex = 36;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(457, 70);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 35);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAsignacion
            // 
            this.dgvAsignacion.AllowUserToAddRows = false;
            this.dgvAsignacion.AllowUserToDeleteRows = false;
            this.dgvAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreTipoLadrillo,
            this.Cantidad});
            this.dgvAsignacion.Location = new System.Drawing.Point(15, 140);
            this.dgvAsignacion.MultiSelect = false;
            this.dgvAsignacion.Name = "dgvAsignacion";
            this.dgvAsignacion.ReadOnly = true;
            this.dgvAsignacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignacion.Size = new System.Drawing.Size(593, 202);
            this.dgvAsignacion.TabIndex = 34;
            this.dgvAsignacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAsignacion_CellFormatting);
            // 
            // NombreTipoLadrillo
            // 
            this.NombreTipoLadrillo.HeaderText = "Nombre Tipo de Ladrillo";
            this.NombreTipoLadrillo.Name = "NombreTipoLadrillo";
            this.NombreTipoLadrillo.ReadOnly = true;
            this.NombreTipoLadrillo.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 250;
            // 
            // cboNombreTipoLadrillo
            // 
            this.cboNombreTipoLadrillo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombreTipoLadrillo.FormattingEnabled = true;
            this.cboNombreTipoLadrillo.Location = new System.Drawing.Point(216, 52);
            this.cboNombreTipoLadrillo.Name = "cboNombreTipoLadrillo";
            this.cboNombreTipoLadrillo.Size = new System.Drawing.Size(189, 23);
            this.cboNombreTipoLadrillo.TabIndex = 33;
            // 
            // lblNombreTipoLadrillo
            // 
            this.lblNombreTipoLadrillo.AutoSize = true;
            this.lblNombreTipoLadrillo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoLadrillo.Location = new System.Drawing.Point(56, 55);
            this.lblNombreTipoLadrillo.Name = "lblNombreTipoLadrillo";
            this.lblNombreTipoLadrillo.Size = new System.Drawing.Size(154, 15);
            this.lblNombreTipoLadrillo.TabIndex = 32;
            this.lblNombreTipoLadrillo.Text = "Nombre del Tipo de Ladrillo";
            // 
            // numNroAproxLadrillos
            // 
            this.numNroAproxLadrillos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNroAproxLadrillos.Location = new System.Drawing.Point(216, 88);
            this.numNroAproxLadrillos.Name = "numNroAproxLadrillos";
            this.numNroAproxLadrillos.Size = new System.Drawing.Size(91, 23);
            this.numNroAproxLadrillos.TabIndex = 31;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(57, 90);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(153, 15);
            this.lblNro.TabIndex = 23;
            this.lblNro.Text = "N° Aproximado de Ladrillos";
            // 
            // gbDatosOperario
            // 
            this.gbDatosOperario.Controls.Add(this.txtAnho);
            this.gbDatosOperario.Controls.Add(this.txtIDPlan);
            this.gbDatosOperario.Controls.Add(this.lblIDPlan);
            this.gbDatosOperario.Controls.Add(this.lblAnho);
            this.gbDatosOperario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosOperario.Location = new System.Drawing.Point(69, 67);
            this.gbDatosOperario.Name = "gbDatosOperario";
            this.gbDatosOperario.Size = new System.Drawing.Size(623, 106);
            this.gbDatosOperario.TabIndex = 41;
            this.gbDatosOperario.TabStop = false;
            this.gbDatosOperario.Text = "Datos del Plan de Producción";
            // 
            // txtAnho
            // 
            this.txtAnho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnho.FormattingEnabled = true;
            this.txtAnho.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.txtAnho.Location = new System.Drawing.Point(258, 60);
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(116, 23);
            this.txtAnho.TabIndex = 25;
            // 
            // txtIDPlan
            // 
            this.txtIDPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPlan.Location = new System.Drawing.Point(258, 32);
            this.txtIDPlan.Name = "txtIDPlan";
            this.txtIDPlan.Size = new System.Drawing.Size(84, 23);
            this.txtIDPlan.TabIndex = 24;
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPlan.Location = new System.Drawing.Point(236, 35);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(18, 15);
            this.lblIDPlan.TabIndex = 23;
            this.lblIDPlan.Text = "ID";
            // 
            // lblAnho
            // 
            this.lblAnho.AutoSize = true;
            this.lblAnho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnho.Location = new System.Drawing.Point(223, 63);
            this.lblAnho.Name = "lblAnho";
            this.lblAnho.Size = new System.Drawing.Size(29, 15);
            this.lblAnho.TabIndex = 21;
            this.lblAnho.Text = "Año";
            // 
            // frmGestionarPlanProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 602);
            this.ControlBox = false;
            this.Controls.Add(this.gbLotesSalientes);
            this.Controls.Add(this.gbDatosOperario);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarPlanProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Planes de Producción";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gbLotesSalientes.ResumeLayout(false);
            this.gbLotesSalientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNroAproxLadrillos)).EndInit();
            this.gbDatosOperario.ResumeLayout(false);
            this.gbDatosOperario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnRegresar;
        private System.Windows.Forms.GroupBox gbLotesSalientes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAsignacion;
        private System.Windows.Forms.ComboBox cboNombreTipoLadrillo;
        private System.Windows.Forms.Label lblNombreTipoLadrillo;
        private System.Windows.Forms.NumericUpDown numNroAproxLadrillos;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.GroupBox gbDatosOperario;
        private System.Windows.Forms.TextBox txtIDPlan;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.Label lblAnho;
        private System.Windows.Forms.ComboBox txtAnho;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoLadrillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}