namespace BuildUp
{
    partial class frmGestionarMaquinaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarMaquinaria));
            this.gbDatosMaquinaria = new System.Windows.Forms.GroupBox();
            this.lblFinGarantia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdMaquinaria = new System.Windows.Forms.TextBox();
            this.dtpFechaGarantia = new System.Windows.Forms.DateTimePicker();
            this.lblNombreMaquinaria = new System.Windows.Forms.Label();
            this.lblIdMaquinaria = new System.Windows.Forms.Label();
            this.gbDatosLinea = new System.Windows.Forms.GroupBox();
            this.btnBuscarLinea = new System.Windows.Forms.Button();
            this.txtNombreLinea = new System.Windows.Forms.TextBox();
            this.txtIdLinea = new System.Windows.Forms.TextBox();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.lblIdInsumo = new System.Windows.Forms.Label();
            this.gbDatosProveedor = new System.Windows.Forms.GroupBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtCorreoRep = new System.Windows.Forms.TextBox();
            this.lblCorreoRep = new System.Windows.Forms.Label();
            this.txtRepresentante = new System.Windows.Forms.TextBox();
            this.lblRepresentante = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
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
            this.gbDatosMaquinaria.SuspendLayout();
            this.gbDatosLinea.SuspendLayout();
            this.gbDatosProveedor.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosMaquinaria
            // 
            this.gbDatosMaquinaria.Controls.Add(this.lblFinGarantia);
            this.gbDatosMaquinaria.Controls.Add(this.txtNombre);
            this.gbDatosMaquinaria.Controls.Add(this.txtIdMaquinaria);
            this.gbDatosMaquinaria.Controls.Add(this.dtpFechaGarantia);
            this.gbDatosMaquinaria.Controls.Add(this.lblNombreMaquinaria);
            this.gbDatosMaquinaria.Controls.Add(this.lblIdMaquinaria);
            this.gbDatosMaquinaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosMaquinaria.Location = new System.Drawing.Point(47, 49);
            this.gbDatosMaquinaria.Name = "gbDatosMaquinaria";
            this.gbDatosMaquinaria.Size = new System.Drawing.Size(545, 144);
            this.gbDatosMaquinaria.TabIndex = 13;
            this.gbDatosMaquinaria.TabStop = false;
            this.gbDatosMaquinaria.Text = "Datos de la Maquinaria";
            // 
            // lblFinGarantia
            // 
            this.lblFinGarantia.AutoSize = true;
            this.lblFinGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinGarantia.Location = new System.Drawing.Point(91, 106);
            this.lblFinGarantia.Name = "lblFinGarantia";
            this.lblFinGarantia.Size = new System.Drawing.Size(110, 17);
            this.lblFinGarantia.TabIndex = 8;
            this.lblFinGarantia.Text = "Fin de la Garantía";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(207, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 25);
            this.txtNombre.TabIndex = 7;
            // 
            // txtIdMaquinaria
            // 
            this.txtIdMaquinaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMaquinaria.Location = new System.Drawing.Point(207, 33);
            this.txtIdMaquinaria.Name = "txtIdMaquinaria";
            this.txtIdMaquinaria.Size = new System.Drawing.Size(100, 25);
            this.txtIdMaquinaria.TabIndex = 5;
            // 
            // dtpFechaGarantia
            // 
            this.dtpFechaGarantia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGarantia.Location = new System.Drawing.Point(207, 100);
            this.dtpFechaGarantia.Name = "dtpFechaGarantia";
            this.dtpFechaGarantia.Size = new System.Drawing.Size(154, 25);
            this.dtpFechaGarantia.TabIndex = 1;
            // 
            // lblNombreMaquinaria
            // 
            this.lblNombreMaquinaria.AutoSize = true;
            this.lblNombreMaquinaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMaquinaria.Location = new System.Drawing.Point(144, 68);
            this.lblNombreMaquinaria.Name = "lblNombreMaquinaria";
            this.lblNombreMaquinaria.Size = new System.Drawing.Size(57, 17);
            this.lblNombreMaquinaria.TabIndex = 6;
            this.lblNombreMaquinaria.Text = "Nombre";
            // 
            // lblIdMaquinaria
            // 
            this.lblIdMaquinaria.AutoSize = true;
            this.lblIdMaquinaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMaquinaria.Location = new System.Drawing.Point(78, 36);
            this.lblIdMaquinaria.Name = "lblIdMaquinaria";
            this.lblIdMaquinaria.Size = new System.Drawing.Size(123, 17);
            this.lblIdMaquinaria.TabIndex = 5;
            this.lblIdMaquinaria.Text = "ID de la Maquinaria";
            // 
            // gbDatosLinea
            // 
            this.gbDatosLinea.Controls.Add(this.btnBuscarLinea);
            this.gbDatosLinea.Controls.Add(this.txtNombreLinea);
            this.gbDatosLinea.Controls.Add(this.txtIdLinea);
            this.gbDatosLinea.Controls.Add(this.lblNombreInsumo);
            this.gbDatosLinea.Controls.Add(this.lblIdInsumo);
            this.gbDatosLinea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosLinea.Location = new System.Drawing.Point(47, 388);
            this.gbDatosLinea.Name = "gbDatosLinea";
            this.gbDatosLinea.Size = new System.Drawing.Size(545, 120);
            this.gbDatosLinea.TabIndex = 12;
            this.gbDatosLinea.TabStop = false;
            this.gbDatosLinea.Text = "Datos de la Línea de Producción";
            // 
            // btnBuscarLinea
            // 
            this.btnBuscarLinea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLinea.Location = new System.Drawing.Point(318, 34);
            this.btnBuscarLinea.Name = "btnBuscarLinea";
            this.btnBuscarLinea.Size = new System.Drawing.Size(130, 30);
            this.btnBuscarLinea.TabIndex = 10;
            this.btnBuscarLinea.Text = "Buscar Línea...";
            this.btnBuscarLinea.UseVisualStyleBackColor = true;
            this.btnBuscarLinea.Click += new System.EventHandler(this.btnBuscarLinea_Click);
            // 
            // txtNombreLinea
            // 
            this.txtNombreLinea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLinea.Location = new System.Drawing.Point(207, 70);
            this.txtNombreLinea.Name = "txtNombreLinea";
            this.txtNombreLinea.Size = new System.Drawing.Size(241, 25);
            this.txtNombreLinea.TabIndex = 7;
            // 
            // txtIdLinea
            // 
            this.txtIdLinea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdLinea.Location = new System.Drawing.Point(207, 38);
            this.txtIdLinea.Name = "txtIdLinea";
            this.txtIdLinea.Size = new System.Drawing.Size(100, 25);
            this.txtIdLinea.TabIndex = 5;
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInsumo.Location = new System.Drawing.Point(78, 73);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(124, 17);
            this.lblNombreInsumo.TabIndex = 6;
            this.lblNombreInsumo.Text = "Nombre de la Línea";
            // 
            // lblIdInsumo
            // 
            this.lblIdInsumo.AutoSize = true;
            this.lblIdInsumo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInsumo.Location = new System.Drawing.Point(114, 41);
            this.lblIdInsumo.Name = "lblIdInsumo";
            this.lblIdInsumo.Size = new System.Drawing.Size(87, 17);
            this.lblIdInsumo.TabIndex = 5;
            this.lblIdInsumo.Text = "ID de la Línea";
            // 
            // gbDatosProveedor
            // 
            this.gbDatosProveedor.Controls.Add(this.btnBuscarProveedor);
            this.gbDatosProveedor.Controls.Add(this.txtCorreoRep);
            this.gbDatosProveedor.Controls.Add(this.lblCorreoRep);
            this.gbDatosProveedor.Controls.Add(this.txtRepresentante);
            this.gbDatosProveedor.Controls.Add(this.lblRepresentante);
            this.gbDatosProveedor.Controls.Add(this.txtRazonSocial);
            this.gbDatosProveedor.Controls.Add(this.lblRazonSocial);
            this.gbDatosProveedor.Controls.Add(this.lblIdProveedor);
            this.gbDatosProveedor.Controls.Add(this.txtIdProveedor);
            this.gbDatosProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosProveedor.Location = new System.Drawing.Point(47, 199);
            this.gbDatosProveedor.Name = "gbDatosProveedor";
            this.gbDatosProveedor.Size = new System.Drawing.Size(545, 183);
            this.gbDatosProveedor.TabIndex = 11;
            this.gbDatosProveedor.TabStop = false;
            this.gbDatosProveedor.Text = "Datos del Proveedor";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.Location = new System.Drawing.Point(318, 38);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(131, 30);
            this.btnBuscarProveedor.TabIndex = 11;
            this.btnBuscarProveedor.Text = "Buscar Proveedor...";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtCorreoRep
            // 
            this.txtCorreoRep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoRep.Location = new System.Drawing.Point(207, 137);
            this.txtCorreoRep.Name = "txtCorreoRep";
            this.txtCorreoRep.Size = new System.Drawing.Size(241, 25);
            this.txtCorreoRep.TabIndex = 9;
            // 
            // lblCorreoRep
            // 
            this.lblCorreoRep.AutoSize = true;
            this.lblCorreoRep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoRep.Location = new System.Drawing.Point(152, 140);
            this.lblCorreoRep.Name = "lblCorreoRep";
            this.lblCorreoRep.Size = new System.Drawing.Size(49, 17);
            this.lblCorreoRep.TabIndex = 8;
            this.lblCorreoRep.Text = "Correo";
            // 
            // txtRepresentante
            // 
            this.txtRepresentante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepresentante.Location = new System.Drawing.Point(207, 105);
            this.txtRepresentante.Name = "txtRepresentante";
            this.txtRepresentante.Size = new System.Drawing.Size(241, 25);
            this.txtRepresentante.TabIndex = 7;
            // 
            // lblRepresentante
            // 
            this.lblRepresentante.AutoSize = true;
            this.lblRepresentante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepresentante.Location = new System.Drawing.Point(109, 108);
            this.lblRepresentante.Name = "lblRepresentante";
            this.lblRepresentante.Size = new System.Drawing.Size(92, 17);
            this.lblRepresentante.TabIndex = 6;
            this.lblRepresentante.Text = "Representante";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(207, 74);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(242, 25);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(119, 77);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(82, 17);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProveedor.Location = new System.Drawing.Point(94, 43);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(107, 17);
            this.lblIdProveedor.TabIndex = 3;
            this.lblIdProveedor.Text = "ID del Proveedor";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(207, 40);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 25);
            this.txtIdProveedor.TabIndex = 2;
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
            this.toolStrip2.Size = new System.Drawing.Size(637, 25);
            this.toolStrip2.TabIndex = 26;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::BuildUp.Properties.Resources.new_file_icon_4;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevaMaquinaria_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarMaquinaria_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(66, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarMaquinaria_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(84, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(81, 22);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.tsbVolver_Click);
            // 
            // frmGestionarMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 538);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gbDatosMaquinaria);
            this.Controls.Add(this.gbDatosLinea);
            this.Controls.Add(this.gbDatosProveedor);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionarMaquinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Maquinarias";
            this.gbDatosMaquinaria.ResumeLayout(false);
            this.gbDatosMaquinaria.PerformLayout();
            this.gbDatosLinea.ResumeLayout(false);
            this.gbDatosLinea.PerformLayout();
            this.gbDatosProveedor.ResumeLayout(false);
            this.gbDatosProveedor.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDatosMaquinaria;
        private System.Windows.Forms.Label lblFinGarantia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdMaquinaria;
        private System.Windows.Forms.DateTimePicker dtpFechaGarantia;
        private System.Windows.Forms.Label lblNombreMaquinaria;
        private System.Windows.Forms.Label lblIdMaquinaria;
        private System.Windows.Forms.GroupBox gbDatosLinea;
        private System.Windows.Forms.Button btnBuscarLinea;
        private System.Windows.Forms.TextBox txtNombreLinea;
        private System.Windows.Forms.TextBox txtIdLinea;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.Label lblIdInsumo;
        private System.Windows.Forms.GroupBox gbDatosProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtCorreoRep;
        private System.Windows.Forms.Label lblCorreoRep;
        private System.Windows.Forms.TextBox txtRepresentante;
        private System.Windows.Forms.Label lblRepresentante;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
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
    }
}