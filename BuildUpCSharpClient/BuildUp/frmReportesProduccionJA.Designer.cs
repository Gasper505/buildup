namespace BuildUp
{
    partial class frmReportesProduccionJA
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
            this.btnReporteDiario = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnReporteMensual = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sfdReportesProduccion = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteDiario
            // 
            this.btnReporteDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteDiario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteDiario.Location = new System.Drawing.Point(156, 45);
            this.btnReporteDiario.Name = "btnReporteDiario";
            this.btnReporteDiario.Size = new System.Drawing.Size(157, 45);
            this.btnReporteDiario.TabIndex = 0;
            this.btnReporteDiario.Text = "Generar Reporte Diario";
            this.btnReporteDiario.UseVisualStyleBackColor = true;
            this.btnReporteDiario.Click += new System.EventHandler(this.btnReporteDiario_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(29, 53);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 25);
            this.dtpFecha.TabIndex = 1;
            // 
            // cboMes
            // 
            this.cboMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMes.Location = new System.Drawing.Point(29, 151);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(121, 25);
            this.cboMes.TabIndex = 2;
            // 
            // btnReporteMensual
            // 
            this.btnReporteMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteMensual.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMensual.Location = new System.Drawing.Point(156, 140);
            this.btnReporteMensual.Name = "btnReporteMensual";
            this.btnReporteMensual.Size = new System.Drawing.Size(157, 45);
            this.btnReporteMensual.TabIndex = 3;
            this.btnReporteMensual.Text = "Generar Reporte Mensual";
            this.btnReporteMensual.UseVisualStyleBackColor = true;
            this.btnReporteMensual.Click += new System.EventHandler(this.btnReporteMensual_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReporteMensual);
            this.groupBox1.Controls.Add(this.cboMes);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.btnReporteDiario);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 222);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generación de Reportes";
            // 
            // frmReportesProduccionJA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(430, 276);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportesProduccionJA";
            this.Text = "Reportes de Producción";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporteDiario;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnReporteMensual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog sfdReportesProduccion;
    }
}