namespace BuildUp
{
    partial class frmGestionarOrdenInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarOrdenInsumos));
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.txtIdOrdenInsumos = new System.Windows.Forms.TextBox();
            this.lblIdOrdenInsumos = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.gbDatosOrdenInsumos = new System.Windows.Forms.GroupBox();
            this.gbDatosInsumo = new System.Windows.Forms.GroupBox();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.lblNombreInsumo = new System.Windows.Forms.Label();
            this.lblIdInsumo = new System.Windows.Forms.Label();
            this.gbDatosOperario = new System.Windows.Forms.GroupBox();
            this.txtApellidosOperario = new System.Windows.Forms.TextBox();
            this.lblApellidosOperario = new System.Windows.Forms.Label();
            this.txtNombresOperario = new System.Windows.Forms.TextBox();
            this.txtIdOperario = new System.Windows.Forms.TextBox();
            this.lblNombresOperario = new System.Windows.Forms.Label();
            this.lblIdOperario = new System.Windows.Forms.Label();
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
            this.pnlAceptacionOrden = new System.Windows.Forms.Panel();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.btnRechazarOrden = new System.Windows.Forms.Button();
            this.btnAceptarOrden = new System.Windows.Forms.Button();
            this.picEquis = new System.Windows.Forms.PictureBox();
            this.gbDatosOrdenInsumos.SuspendLayout();
            this.gbDatosInsumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbDatosOperario.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlAceptacionOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaActual.Location = new System.Drawing.Point(189, 62);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(241, 21);
            this.dtpFechaActual.TabIndex = 1;
            // 
            // txtIdOrdenInsumos
            // 
            this.txtIdOrdenInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOrdenInsumos.Location = new System.Drawing.Point(189, 28);
            this.txtIdOrdenInsumos.Name = "txtIdOrdenInsumos";
            this.txtIdOrdenInsumos.Size = new System.Drawing.Size(100, 21);
            this.txtIdOrdenInsumos.TabIndex = 2;
            // 
            // lblIdOrdenInsumos
            // 
            this.lblIdOrdenInsumos.AutoSize = true;
            this.lblIdOrdenInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrdenInsumos.Location = new System.Drawing.Point(30, 29);
            this.lblIdOrdenInsumos.Name = "lblIdOrdenInsumos";
            this.lblIdOrdenInsumos.Size = new System.Drawing.Size(153, 15);
            this.lblIdOrdenInsumos.TabIndex = 3;
            this.lblIdOrdenInsumos.Text = "ID de la Orden de Insumos";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.Location = new System.Drawing.Point(106, 66);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(77, 15);
            this.lblFechaActual.TabIndex = 4;
            this.lblFechaActual.Text = "Fecha Actual";
            // 
            // gbDatosOrdenInsumos
            // 
            this.gbDatosOrdenInsumos.Controls.Add(this.lblFechaActual);
            this.gbDatosOrdenInsumos.Controls.Add(this.lblIdOrdenInsumos);
            this.gbDatosOrdenInsumos.Controls.Add(this.txtIdOrdenInsumos);
            this.gbDatosOrdenInsumos.Controls.Add(this.dtpFechaActual);
            this.gbDatosOrdenInsumos.Location = new System.Drawing.Point(90, 206);
            this.gbDatosOrdenInsumos.Name = "gbDatosOrdenInsumos";
            this.gbDatosOrdenInsumos.Size = new System.Drawing.Size(502, 106);
            this.gbDatosOrdenInsumos.TabIndex = 5;
            this.gbDatosOrdenInsumos.TabStop = false;
            this.gbDatosOrdenInsumos.Text = "Datos de la Orden de Insumos";
            // 
            // gbDatosInsumo
            // 
            this.gbDatosInsumo.Controls.Add(this.cboUnidadMedida);
            this.gbDatosInsumo.Controls.Add(this.numericUpDown1);
            this.gbDatosInsumo.Controls.Add(this.lblCantidad);
            this.gbDatosInsumo.Controls.Add(this.btnBuscarInsumo);
            this.gbDatosInsumo.Controls.Add(this.lblUnidadMedida);
            this.gbDatosInsumo.Controls.Add(this.txtNombreInsumo);
            this.gbDatosInsumo.Controls.Add(this.txtIdInsumo);
            this.gbDatosInsumo.Controls.Add(this.lblNombreInsumo);
            this.gbDatosInsumo.Controls.Add(this.lblIdInsumo);
            this.gbDatosInsumo.Location = new System.Drawing.Point(90, 331);
            this.gbDatosInsumo.Name = "gbDatosInsumo";
            this.gbDatosInsumo.Size = new System.Drawing.Size(502, 172);
            this.gbDatosInsumo.TabIndex = 6;
            this.gbDatosInsumo.TabStop = false;
            this.gbDatosInsumo.Text = "Datos del Insumo";
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Items.AddRange(new object[] {
            "Kilogramos",
            "Toneladas",
            "Litros",
            "Onzas",
            "Libras"});
            this.cboUnidadMedida.Location = new System.Drawing.Point(189, 128);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(121, 23);
            this.cboUnidadMedida.TabIndex = 47;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(189, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 12;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(127, 94);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.Location = new System.Drawing.Point(307, 25);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(123, 23);
            this.btnBuscarInsumo.TabIndex = 10;
            this.btnBuscarInsumo.Text = "Buscar Insumo...";
            this.btnBuscarInsumo.UseVisualStyleBackColor = true;
            this.btnBuscarInsumo.Click += new System.EventHandler(this.btnBuscarInsumo_Click);
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(74, 128);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(109, 15);
            this.lblUnidadMedida.TabIndex = 8;
            this.lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInsumo.Location = new System.Drawing.Point(189, 59);
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(241, 21);
            this.txtNombreInsumo.TabIndex = 7;
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInsumo.Location = new System.Drawing.Point(189, 27);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(100, 21);
            this.txtIdInsumo.TabIndex = 5;
            // 
            // lblNombreInsumo
            // 
            this.lblNombreInsumo.AutoSize = true;
            this.lblNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInsumo.Location = new System.Drawing.Point(67, 60);
            this.lblNombreInsumo.Name = "lblNombreInsumo";
            this.lblNombreInsumo.Size = new System.Drawing.Size(116, 15);
            this.lblNombreInsumo.TabIndex = 6;
            this.lblNombreInsumo.Text = "Nombre del Insumo";
            // 
            // lblIdInsumo
            // 
            this.lblIdInsumo.AutoSize = true;
            this.lblIdInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInsumo.Location = new System.Drawing.Point(100, 28);
            this.lblIdInsumo.Name = "lblIdInsumo";
            this.lblIdInsumo.Size = new System.Drawing.Size(83, 15);
            this.lblIdInsumo.TabIndex = 5;
            this.lblIdInsumo.Text = "ID del Insumo";
            // 
            // gbDatosOperario
            // 
            this.gbDatosOperario.Controls.Add(this.txtApellidosOperario);
            this.gbDatosOperario.Controls.Add(this.lblApellidosOperario);
            this.gbDatosOperario.Controls.Add(this.txtNombresOperario);
            this.gbDatosOperario.Controls.Add(this.txtIdOperario);
            this.gbDatosOperario.Controls.Add(this.lblNombresOperario);
            this.gbDatosOperario.Controls.Add(this.lblIdOperario);
            this.gbDatosOperario.Location = new System.Drawing.Point(90, 53);
            this.gbDatosOperario.Name = "gbDatosOperario";
            this.gbDatosOperario.Size = new System.Drawing.Size(502, 132);
            this.gbDatosOperario.TabIndex = 10;
            this.gbDatosOperario.TabStop = false;
            this.gbDatosOperario.Text = "Datos del Operario";
            // 
            // txtApellidosOperario
            // 
            this.txtApellidosOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosOperario.Location = new System.Drawing.Point(189, 91);
            this.txtApellidosOperario.Name = "txtApellidosOperario";
            this.txtApellidosOperario.Size = new System.Drawing.Size(100, 21);
            this.txtApellidosOperario.TabIndex = 9;
            // 
            // lblApellidosOperario
            // 
            this.lblApellidosOperario.AutoSize = true;
            this.lblApellidosOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosOperario.Location = new System.Drawing.Point(127, 91);
            this.lblApellidosOperario.Name = "lblApellidosOperario";
            this.lblApellidosOperario.Size = new System.Drawing.Size(57, 15);
            this.lblApellidosOperario.TabIndex = 8;
            this.lblApellidosOperario.Text = "Apellidos";
            // 
            // txtNombresOperario
            // 
            this.txtNombresOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresOperario.Location = new System.Drawing.Point(189, 59);
            this.txtNombresOperario.Name = "txtNombresOperario";
            this.txtNombresOperario.Size = new System.Drawing.Size(241, 21);
            this.txtNombresOperario.TabIndex = 7;
            // 
            // txtIdOperario
            // 
            this.txtIdOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdOperario.Location = new System.Drawing.Point(189, 27);
            this.txtIdOperario.Name = "txtIdOperario";
            this.txtIdOperario.Size = new System.Drawing.Size(100, 21);
            this.txtIdOperario.TabIndex = 5;
            // 
            // lblNombresOperario
            // 
            this.lblNombresOperario.AutoSize = true;
            this.lblNombresOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresOperario.Location = new System.Drawing.Point(125, 60);
            this.lblNombresOperario.Name = "lblNombresOperario";
            this.lblNombresOperario.Size = new System.Drawing.Size(58, 15);
            this.lblNombresOperario.TabIndex = 6;
            this.lblNombresOperario.Text = "Nombres";
            // 
            // lblIdOperario
            // 
            this.lblIdOperario.AutoSize = true;
            this.lblIdOperario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOperario.Location = new System.Drawing.Point(93, 28);
            this.lblIdOperario.Name = "lblIdOperario";
            this.lblIdOperario.Size = new System.Drawing.Size(90, 15);
            this.lblIdOperario.TabIndex = 5;
            this.lblIdOperario.Text = "ID del Operario";
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
            this.toolStrip2.Size = new System.Drawing.Size(682, 27);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::BuildUp.Properties.Resources.new_file_icon_4;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(72, 24);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevaOrdenInsumos_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarOrdenInsumos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscarOrdenInsumos_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 24);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 24);
            this.btnCancelar.Text = "Limpiar y Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(81, 24);
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pnlAceptacionOrden
            // 
            this.pnlAceptacionOrden.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAceptacionOrden.Controls.Add(this.picCheck);
            this.pnlAceptacionOrden.Controls.Add(this.btnRechazarOrden);
            this.pnlAceptacionOrden.Controls.Add(this.btnAceptarOrden);
            this.pnlAceptacionOrden.Controls.Add(this.picEquis);
            this.pnlAceptacionOrden.Location = new System.Drawing.Point(160, 522);
            this.pnlAceptacionOrden.Name = "pnlAceptacionOrden";
            this.pnlAceptacionOrden.Size = new System.Drawing.Size(360, 75);
            this.pnlAceptacionOrden.TabIndex = 41;
            this.pnlAceptacionOrden.Visible = false;
            // 
            // picCheck
            // 
            this.picCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCheck.BackgroundImage")));
            this.picCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCheck.Location = new System.Drawing.Point(300, 19);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(37, 36);
            this.picCheck.TabIndex = 43;
            this.picCheck.TabStop = false;
            // 
            // btnRechazarOrden
            // 
            this.btnRechazarOrden.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRechazarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRechazarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRechazarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechazarOrden.Location = new System.Drawing.Point(26, 19);
            this.btnRechazarOrden.Name = "btnRechazarOrden";
            this.btnRechazarOrden.Size = new System.Drawing.Size(82, 36);
            this.btnRechazarOrden.TabIndex = 0;
            this.btnRechazarOrden.Text = "Rechazar";
            this.btnRechazarOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRechazarOrden.UseVisualStyleBackColor = false;
            this.btnRechazarOrden.Click += new System.EventHandler(this.btnRechazarOrden_Click);
            // 
            // btnAceptarOrden
            // 
            this.btnAceptarOrden.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAceptarOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptarOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarOrden.Location = new System.Drawing.Point(213, 19);
            this.btnAceptarOrden.Name = "btnAceptarOrden";
            this.btnAceptarOrden.Size = new System.Drawing.Size(82, 36);
            this.btnAceptarOrden.TabIndex = 1;
            this.btnAceptarOrden.Text = "Aceptar";
            this.btnAceptarOrden.UseVisualStyleBackColor = false;
            this.btnAceptarOrden.Click += new System.EventHandler(this.btnAceptarOrden_Click);
            // 
            // picEquis
            // 
            this.picEquis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picEquis.BackgroundImage")));
            this.picEquis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEquis.Location = new System.Drawing.Point(114, 19);
            this.picEquis.Name = "picEquis";
            this.picEquis.Size = new System.Drawing.Size(37, 36);
            this.picEquis.TabIndex = 42;
            this.picEquis.TabStop = false;
            // 
            // frmGestionarOrdenInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 619);
            this.ControlBox = false;
            this.Controls.Add(this.pnlAceptacionOrden);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.gbDatosOperario);
            this.Controls.Add(this.gbDatosInsumo);
            this.Controls.Add(this.gbDatosOrdenInsumos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGestionarOrdenInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Órdenes de Insumo";
            this.gbDatosOrdenInsumos.ResumeLayout(false);
            this.gbDatosOrdenInsumos.PerformLayout();
            this.gbDatosInsumo.ResumeLayout(false);
            this.gbDatosInsumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbDatosOperario.ResumeLayout(false);
            this.gbDatosOperario.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlAceptacionOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEquis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.TextBox txtIdOrdenInsumos;
        private System.Windows.Forms.Label lblIdOrdenInsumos;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.GroupBox gbDatosOrdenInsumos;
        private System.Windows.Forms.GroupBox gbDatosInsumo;
        private System.Windows.Forms.TextBox txtNombreInsumo;
        private System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Label lblNombreInsumo;
        private System.Windows.Forms.Label lblIdInsumo;
        private System.Windows.Forms.GroupBox gbDatosOperario;
        private System.Windows.Forms.Label lblApellidosOperario;
        private System.Windows.Forms.TextBox txtNombresOperario;
        private System.Windows.Forms.TextBox txtIdOperario;
        private System.Windows.Forms.Label lblNombresOperario;
        private System.Windows.Forms.Label lblIdOperario;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtApellidosOperario;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnRegresar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel pnlAceptacionOrden;
        private System.Windows.Forms.PictureBox picEquis;
        private System.Windows.Forms.Button btnAceptarOrden;
        private System.Windows.Forms.Button btnRechazarOrden;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ComboBox cboUnidadMedida;
    }
}