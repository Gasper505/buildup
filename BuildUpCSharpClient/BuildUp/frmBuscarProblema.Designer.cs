namespace BuildUp
{
    partial class frmBuscarProblema
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvProblemas = new System.Windows.Forms.DataGridView();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(103, 367);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(280, 48);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvProblemas
            // 
            this.dgvProblemas.AllowUserToAddRows = false;
            this.dgvProblemas.AllowUserToDeleteRows = false;
            this.dgvProblemas.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dgvProblemas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProblemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProblemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInsumo,
            this.NombreInsumo,
            this.Nivel});
            this.dgvProblemas.Location = new System.Drawing.Point(34, 31);
            this.dgvProblemas.MultiSelect = false;
            this.dgvProblemas.Name = "dgvProblemas";
            this.dgvProblemas.ReadOnly = true;
            this.dgvProblemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProblemas.Size = new System.Drawing.Size(413, 316);
            this.dgvProblemas.TabIndex = 7;
            // 
            // IDInsumo
            // 
            this.IDInsumo.DataPropertyName = "idProblema";
            this.IDInsumo.HeaderText = "ID";
            this.IDInsumo.Name = "IDInsumo";
            this.IDInsumo.ReadOnly = true;
            this.IDInsumo.Width = 65;
            // 
            // NombreInsumo
            // 
            this.NombreInsumo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreInsumo.DataPropertyName = "tipo";
            this.NombreInsumo.HeaderText = "Problema";
            this.NombreInsumo.MaxInputLength = 45;
            this.NombreInsumo.Name = "NombreInsumo";
            this.NombreInsumo.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "nivelImportancia";
            this.Nivel.HeaderText = "Importancia";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            this.Nivel.Width = 150;
            // 
            // frmBuscarProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 435);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvProblemas);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBuscarProblema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Problemas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblemas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvProblemas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
    }
}