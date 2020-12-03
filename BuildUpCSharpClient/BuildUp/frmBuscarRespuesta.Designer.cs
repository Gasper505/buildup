namespace BuildUp
{
    partial class frmBuscarRespuesta
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
            this.dgvRespuestas = new System.Windows.Forms.DataGridView();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRespuestas
            // 
            this.dgvRespuestas.AllowUserToAddRows = false;
            this.dgvRespuestas.AllowUserToDeleteRows = false;
            this.dgvRespuestas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInsumo,
            this.NombreInsumo});
            this.dgvRespuestas.Location = new System.Drawing.Point(55, 43);
            this.dgvRespuestas.MultiSelect = false;
            this.dgvRespuestas.Name = "dgvRespuestas";
            this.dgvRespuestas.ReadOnly = true;
            this.dgvRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespuestas.Size = new System.Drawing.Size(393, 267);
            this.dgvRespuestas.TabIndex = 7;
            // 
            // IDInsumo
            // 
            this.IDInsumo.DataPropertyName = "idRespuesta";
            this.IDInsumo.HeaderText = "ID de Respuesta";
            this.IDInsumo.MaxInputLength = 10;
            this.IDInsumo.Name = "IDInsumo";
            this.IDInsumo.ReadOnly = true;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.DataPropertyName = "tipo";
            this.NombreInsumo.HeaderText = "Tipo de Respuesta";
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            this.NombreInsumo.Width = 250;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(128, 340);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(257, 36);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmBuscarRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 411);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvRespuestas);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBuscarRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Respuestas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRespuestas;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
    }
}