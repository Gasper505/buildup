namespace BuildUp
{
    partial class frmGestionarProblema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarProblema));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatosMaquinaria = new System.Windows.Forms.GroupBox();
            this.lblNivelImportancia = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtIdProblema = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblIdProblema = new System.Windows.Forms.Label();
            this.txtNivelImportancia = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnRegresar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.gbDatosMaquinaria.SuspendLayout();
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
            this.toolStrip2.Size = new System.Drawing.Size(682, 25);
            this.toolStrip2.TabIndex = 45;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 44;
            // 
            // gbDatosMaquinaria
            // 
            this.gbDatosMaquinaria.Controls.Add(this.txtActivo);
            this.gbDatosMaquinaria.Controls.Add(this.lblActivo);
            this.gbDatosMaquinaria.Controls.Add(this.txtNivelImportancia);
            this.gbDatosMaquinaria.Controls.Add(this.lblNivelImportancia);
            this.gbDatosMaquinaria.Controls.Add(this.txtTipo);
            this.gbDatosMaquinaria.Controls.Add(this.txtIdProblema);
            this.gbDatosMaquinaria.Controls.Add(this.lblTipo);
            this.gbDatosMaquinaria.Controls.Add(this.lblIdProblema);
            this.gbDatosMaquinaria.Location = new System.Drawing.Point(53, 67);
            this.gbDatosMaquinaria.Name = "gbDatosMaquinaria";
            this.gbDatosMaquinaria.Size = new System.Drawing.Size(509, 169);
            this.gbDatosMaquinaria.TabIndex = 46;
            this.gbDatosMaquinaria.TabStop = false;
            this.gbDatosMaquinaria.Text = "Datos del Problema";
            // 
            // lblNivelImportancia
            // 
            this.lblNivelImportancia.AutoSize = true;
            this.lblNivelImportancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelImportancia.Location = new System.Drawing.Point(68, 95);
            this.lblNivelImportancia.Name = "lblNivelImportancia";
            this.lblNivelImportancia.Size = new System.Drawing.Size(119, 15);
            this.lblNivelImportancia.TabIndex = 8;
            this.lblNivelImportancia.Text = "Nivel de Importancia";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(189, 59);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(241, 20);
            this.txtTipo.TabIndex = 7;
            // 
            // txtIdProblema
            // 
            this.txtIdProblema.Location = new System.Drawing.Point(189, 27);
            this.txtIdProblema.Name = "txtIdProblema";
            this.txtIdProblema.Size = new System.Drawing.Size(100, 20);
            this.txtIdProblema.TabIndex = 5;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(152, 60);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 15);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblIdProblema
            // 
            this.lblIdProblema.AutoSize = true;
            this.lblIdProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProblema.Location = new System.Drawing.Point(87, 28);
            this.lblIdProblema.Name = "lblIdProblema";
            this.lblIdProblema.Size = new System.Drawing.Size(96, 15);
            this.lblIdProblema.TabIndex = 5;
            this.lblIdProblema.Text = "ID del Problema";
            // 
            // txtNivelImportancia
            // 
            this.txtNivelImportancia.Location = new System.Drawing.Point(189, 94);
            this.txtNivelImportancia.Name = "txtNivelImportancia";
            this.txtNivelImportancia.Size = new System.Drawing.Size(241, 20);
            this.txtNivelImportancia.TabIndex = 9;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(189, 131);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(27, 20);
            this.txtActivo.TabIndex = 11;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(145, 132);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(38, 15);
            this.lblActivo.TabIndex = 10;
            this.lblActivo.Text = "Activo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
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
            this.btnGuardar.Size = new System.Drawing.Size(81, 22);
            this.btnGuardar.Text = "&Registrar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmGestionarProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 357);
            this.Controls.Add(this.gbDatosMaquinaria);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionarProblema";
            this.Text = "frmGestionarProblema";
            this.Load += new System.EventHandler(this.frmGestionarProblema_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gbDatosMaquinaria.ResumeLayout(false);
            this.gbDatosMaquinaria.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDatosMaquinaria;
        private System.Windows.Forms.Label lblNivelImportancia;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtIdProblema;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblIdProblema;
        private System.Windows.Forms.TextBox txtNivelImportancia;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Label lblActivo;
    }
}