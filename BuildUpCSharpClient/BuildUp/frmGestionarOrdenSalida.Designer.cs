namespace BuildUp
{
    partial class frmGestionarOrdenSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarOrdenSalida));
            this.lblNroLotes = new System.Windows.Forms.Label();
            this.lblNombreOperario = new System.Windows.Forms.Label();
            this.txtIDOrden = new System.Windows.Forms.TextBox();
            this.lblIDOrden = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.numNroAproxLadrillos = new System.Windows.Forms.NumericUpDown();
            this.lblNombreTipoLadrillo = new System.Windows.Forms.Label();
            this.cboNombreTipoLadrillo = new System.Windows.Forms.ComboBox();
            this.gbDatosOrden = new System.Windows.Forms.GroupBox();
            this.gbDatosOperario = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDOperario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbLotesSalientes = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.NumeroLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoLadrillo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEnElLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.numNroAproxLadrillos)).BeginInit();
            this.gbDatosOrden.SuspendLayout();
            this.gbDatosOperario.SuspendLayout();
            this.gbLotesSalientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroLotes
            // 
            this.lblNroLotes.AutoSize = true;
            this.lblNroLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLotes.Location = new System.Drawing.Point(49, 69);
            this.lblNroLotes.Name = "lblNroLotes";
            this.lblNroLotes.Size = new System.Drawing.Size(157, 15);
            this.lblNroLotes.TabIndex = 23;
            this.lblNroLotes.Text = "N° Aproximado de Ladrillos";
            // 
            // lblNombreOperario
            // 
            this.lblNombreOperario.AutoSize = true;
            this.lblNombreOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOperario.Location = new System.Drawing.Point(209, 56);
            this.lblNombreOperario.Name = "lblNombreOperario";
            this.lblNombreOperario.Size = new System.Drawing.Size(58, 15);
            this.lblNombreOperario.TabIndex = 21;
            this.lblNombreOperario.Text = "Nombres";
            // 
            // txtIDOrden
            // 
            this.txtIDOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrden.Location = new System.Drawing.Point(273, 19);
            this.txtIDOrden.Name = "txtIDOrden";
            this.txtIDOrden.Size = new System.Drawing.Size(107, 21);
            this.txtIDOrden.TabIndex = 20;
            // 
            // lblIDOrden
            // 
            this.lblIDOrden.AutoSize = true;
            this.lblIDOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOrden.Location = new System.Drawing.Point(156, 20);
            this.lblIDOrden.Name = "lblIDOrden";
            this.lblIDOrden.Size = new System.Drawing.Size(111, 15);
            this.lblIDOrden.TabIndex = 19;
            this.lblIDOrden.Text = "ID Orden de Salida";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(177, 51);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(90, 15);
            this.lblFechaRegistro.TabIndex = 27;
            this.lblFechaRegistro.Text = "Fecha Registro";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRegistro.Location = new System.Drawing.Point(273, 51);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(205, 21);
            this.dtpFechaRegistro.TabIndex = 28;
            // 
            // numNroAproxLadrillos
            // 
            this.numNroAproxLadrillos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNroAproxLadrillos.Location = new System.Drawing.Point(212, 69);
            this.numNroAproxLadrillos.Name = "numNroAproxLadrillos";
            this.numNroAproxLadrillos.Size = new System.Drawing.Size(86, 21);
            this.numNroAproxLadrillos.TabIndex = 31;
            // 
            // lblNombreTipoLadrillo
            // 
            this.lblNombreTipoLadrillo.AutoSize = true;
            this.lblNombreTipoLadrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTipoLadrillo.Location = new System.Drawing.Point(46, 34);
            this.lblNombreTipoLadrillo.Name = "lblNombreTipoLadrillo";
            this.lblNombreTipoLadrillo.Size = new System.Drawing.Size(160, 15);
            this.lblNombreTipoLadrillo.TabIndex = 32;
            this.lblNombreTipoLadrillo.Text = "Nombre del Tipo de Ladrillo";
            // 
            // cboNombreTipoLadrillo
            // 
            this.cboNombreTipoLadrillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNombreTipoLadrillo.FormattingEnabled = true;
            this.cboNombreTipoLadrillo.Location = new System.Drawing.Point(212, 33);
            this.cboNombreTipoLadrillo.Name = "cboNombreTipoLadrillo";
            this.cboNombreTipoLadrillo.Size = new System.Drawing.Size(182, 23);
            this.cboNombreTipoLadrillo.TabIndex = 33;
            // 
            // gbDatosOrden
            // 
            this.gbDatosOrden.Controls.Add(this.txtIDOrden);
            this.gbDatosOrden.Controls.Add(this.lblIDOrden);
            this.gbDatosOrden.Controls.Add(this.lblFechaRegistro);
            this.gbDatosOrden.Controls.Add(this.dtpFechaRegistro);
            this.gbDatosOrden.Location = new System.Drawing.Point(68, 63);
            this.gbDatosOrden.Name = "gbDatosOrden";
            this.gbDatosOrden.Size = new System.Drawing.Size(653, 92);
            this.gbDatosOrden.TabIndex = 35;
            this.gbDatosOrden.TabStop = false;
            this.gbDatosOrden.Text = "Datos de la Orden de Salida";
            // 
            // gbDatosOperario
            // 
            this.gbDatosOperario.Controls.Add(this.txtApellidos);
            this.gbDatosOperario.Controls.Add(this.label3);
            this.gbDatosOperario.Controls.Add(this.txtIDOperario);
            this.gbDatosOperario.Controls.Add(this.label1);
            this.gbDatosOperario.Controls.Add(this.txtNombres);
            this.gbDatosOperario.Controls.Add(this.lblNombreOperario);
            this.gbDatosOperario.Location = new System.Drawing.Point(68, 170);
            this.gbDatosOperario.Name = "gbDatosOperario";
            this.gbDatosOperario.Size = new System.Drawing.Size(653, 123);
            this.gbDatosOperario.TabIndex = 36;
            this.gbDatosOperario.TabStop = false;
            this.gbDatosOperario.Text = "Datos del Operario encargado del registro de la Orden";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(273, 81);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(259, 21);
            this.txtApellidos.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Apellidos";
            // 
            // txtIDOperario
            // 
            this.txtIDOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOperario.Location = new System.Drawing.Point(273, 29);
            this.txtIDOperario.Name = "txtIDOperario";
            this.txtIDOperario.Size = new System.Drawing.Size(107, 21);
            this.txtIDOperario.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(273, 55);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(259, 21);
            this.txtNombres.TabIndex = 22;
            // 
            // gbLotesSalientes
            // 
            this.gbLotesSalientes.Controls.Add(this.btnRemover);
            this.gbLotesSalientes.Controls.Add(this.btnAgregar);
            this.gbLotesSalientes.Controls.Add(this.dgvLotes);
            this.gbLotesSalientes.Controls.Add(this.cboNombreTipoLadrillo);
            this.gbLotesSalientes.Controls.Add(this.lblNombreTipoLadrillo);
            this.gbLotesSalientes.Controls.Add(this.numNroAproxLadrillos);
            this.gbLotesSalientes.Controls.Add(this.lblNroLotes);
            this.gbLotesSalientes.Location = new System.Drawing.Point(68, 311);
            this.gbLotesSalientes.Name = "gbLotesSalientes";
            this.gbLotesSalientes.Size = new System.Drawing.Size(653, 302);
            this.gbLotesSalientes.TabIndex = 38;
            this.gbLotesSalientes.TabStop = false;
            this.gbLotesSalientes.Text = "Lotes Salientes";
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(550, 49);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(59, 35);
            this.btnRemover.TabIndex = 36;
            this.btnRemover.Text = "-";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(485, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 35);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            this.dgvLotes.AllowUserToDeleteRows = false;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroLote,
            this.NombreTipoLadrillo,
            this.CantidadEnElLote});
            this.dgvLotes.Location = new System.Drawing.Point(30, 110);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(594, 162);
            this.dgvLotes.TabIndex = 34;
            this.dgvLotes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLotes_CellFormatting);
            // 
            // NumeroLote
            // 
            this.NumeroLote.DataPropertyName = "IdLineaOrdenSalida";
            this.NumeroLote.HeaderText = "Nro. Lote";
            this.NumeroLote.Name = "NumeroLote";
            this.NumeroLote.ReadOnly = true;
            // 
            // NombreTipoLadrillo
            // 
            this.NombreTipoLadrillo.HeaderText = "Nombre Tipo Ladrillo";
            this.NombreTipoLadrillo.Name = "NombreTipoLadrillo";
            this.NombreTipoLadrillo.ReadOnly = true;
            this.NombreTipoLadrillo.Width = 300;
            // 
            // CantidadEnElLote
            // 
            this.CantidadEnElLote.DataPropertyName = "Cantidad";
            this.CantidadEnElLote.HeaderText = "Cantidad en el Lote";
            this.CantidadEnElLote.Name = "CantidadEnElLote";
            this.CantidadEnElLote.ReadOnly = true;
            this.CantidadEnElLote.Width = 150;
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
            this.toolStrip2.Size = new System.Drawing.Size(794, 25);
            this.toolStrip2.TabIndex = 39;
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnRegresar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGestionarOrdenSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 641);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gbLotesSalientes);
            this.Controls.Add(this.gbDatosOperario);
            this.Controls.Add(this.gbDatosOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarOrdenSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Órdenes de Salida";
            ((System.ComponentModel.ISupportInitialize)(this.numNroAproxLadrillos)).EndInit();
            this.gbDatosOrden.ResumeLayout(false);
            this.gbDatosOrden.PerformLayout();
            this.gbDatosOperario.ResumeLayout(false);
            this.gbDatosOperario.PerformLayout();
            this.gbLotesSalientes.ResumeLayout(false);
            this.gbLotesSalientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNroLotes;
        private System.Windows.Forms.Label lblNombreOperario;
        private System.Windows.Forms.TextBox txtIDOrden;
        private System.Windows.Forms.Label lblIDOrden;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.NumericUpDown numNroAproxLadrillos;
        private System.Windows.Forms.Label lblNombreTipoLadrillo;
        private System.Windows.Forms.ComboBox cboNombreTipoLadrillo;
        private System.Windows.Forms.GroupBox gbDatosOrden;
        private System.Windows.Forms.GroupBox gbDatosOperario;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDOperario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbLotesSalientes;
        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAgregar;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoLadrillo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadEnElLote;
    }
}