namespace BuildUp
{
    partial class frmBuscarInsumo
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqNombreInsumo = new System.Windows.Forms.TextBox();
            this.lblBusqNombreInsumo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gbParametrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.btnBuscar);
            this.gbParametrosBusqueda.Controls.Add(this.txtBusqNombreInsumo);
            this.gbParametrosBusqueda.Controls.Add(this.lblBusqNombreInsumo);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(55, 28);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(571, 94);
            this.gbParametrosBusqueda.TabIndex = 4;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Parámetros de Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(433, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 36);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqNombreInsumo
            // 
            this.txtBusqNombreInsumo.Location = new System.Drawing.Point(158, 41);
            this.txtBusqNombreInsumo.Name = "txtBusqNombreInsumo";
            this.txtBusqNombreInsumo.Size = new System.Drawing.Size(225, 20);
            this.txtBusqNombreInsumo.TabIndex = 4;
            // 
            // lblBusqNombreInsumo
            // 
            this.lblBusqNombreInsumo.AutoSize = true;
            this.lblBusqNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqNombreInsumo.Location = new System.Drawing.Point(36, 41);
            this.lblBusqNombreInsumo.Name = "lblBusqNombreInsumo";
            this.lblBusqNombreInsumo.Size = new System.Drawing.Size(116, 15);
            this.lblBusqNombreInsumo.TabIndex = 0;
            this.lblBusqNombreInsumo.Text = "Nombre del Insumo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInsumo,
            this.NombreInsumo});
            this.dataGridView1.Location = new System.Drawing.Point(55, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(571, 267);
            this.dataGridView1.TabIndex = 5;
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
            this.NombreInsumo.Width = 350;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(232, 435);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(225, 36);
            this.btnSeleccionar.TabIndex = 6;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 493);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Insumos";
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.Label lblBusqNombreInsumo;
        private System.Windows.Forms.TextBox txtBusqNombreInsumo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
    }
}