namespace BuildUp
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLogeo = new System.Windows.Forms.Panel();
            this.lblInfoLogueo = new System.Windows.Forms.Label();
            this.picContrasena = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.panelLogeo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtContrasena
            // 
            resources.ApplyResources(this.txtContrasena, "txtContrasena");
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // panelLogeo
            // 
            this.panelLogeo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelLogeo.Controls.Add(this.lblInfoLogueo);
            this.panelLogeo.Controls.Add(this.picContrasena);
            this.panelLogeo.Controls.Add(this.picUsuario);
            this.panelLogeo.Controls.Add(this.lblTitulo);
            this.panelLogeo.Controls.Add(this.btn_Ingresar);
            this.panelLogeo.Controls.Add(this.txtContrasena);
            this.panelLogeo.Controls.Add(this.txtUsuario);
            resources.ApplyResources(this.panelLogeo, "panelLogeo");
            this.panelLogeo.Name = "panelLogeo";
            // 
            // lblInfoLogueo
            // 
            resources.ApplyResources(this.lblInfoLogueo, "lblInfoLogueo");
            this.lblInfoLogueo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfoLogueo.Name = "lblInfoLogueo";
            // 
            // picContrasena
            // 
            resources.ApplyResources(this.picContrasena, "picContrasena");
            this.picContrasena.Name = "picContrasena";
            this.picContrasena.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.picUsuario, "picUsuario");
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.TabStop = false;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Ingresar.BackgroundImage = global::BuildUp.Properties.Resources._152533;
            resources.ApplyResources(this.btn_Ingresar, "btn_Ingresar");
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btnIngresar);
            this.btn_Ingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCancelar);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // frmLogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ControlBox = false;
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.panelLogeo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Opacity = 0.95D;
            this.panelLogeo.ResumeLayout(false);
            this.panelLogeo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picContrasena;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelLogeo;
        private System.Windows.Forms.Label lblInfoLogueo;
        private System.Windows.Forms.Button btnMinimizar;
    }
}