
namespace cl_desk_admin
{
    partial class Form1
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPsuario = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.BackColor = System.Drawing.Color.LightBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.Location = new System.Drawing.Point(304, 363);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(119, 50);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "CLINICA EL CARMELO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Administrador General",
            "Administrador Nivel 1"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(318, 87);
            this.cbxTipoUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(275, 21);
            this.cbxTipoUsuario.TabIndex = 16;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionar.Location = new System.Drawing.Point(133, 89);
            this.lblSeleccionar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(181, 15);
            this.lblSeleccionar.TabIndex = 15;
            this.lblSeleccionar.Text = "SELECCIONE TIPO DE USUARIO";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(318, 233);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(275, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(318, 157);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(275, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(133, 235);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 15);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "CONTRASEÑA";
            // 
            // lblPsuario
            // 
            this.lblPsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPsuario.AutoSize = true;
            this.lblPsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsuario.Location = new System.Drawing.Point(133, 159);
            this.lblPsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPsuario.Name = "lblPsuario";
            this.lblPsuario.Size = new System.Drawing.Size(58, 15);
            this.lblPsuario.TabIndex = 11;
            this.lblPsuario.Text = "USUARIO";
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Bold);
            this.lblInicio.ForeColor = System.Drawing.Color.SlateGray;
            this.lblInicio.Location = new System.Drawing.Point(3, 9);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(724, 32);
            this.lblInicio.TabIndex = 10;
            this.lblInicio.Text = "INICIO DE SESION";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.lblInicio);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.cbxTipoUsuario);
            this.panel1.Controls.Add(this.lblPsuario);
            this.panel1.Controls.Add(this.lblSeleccionar);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(152, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 443);
            this.panel1.TabIndex = 19;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Maroon;
            this.lblMensaje.Location = new System.Drawing.Point(8, 271);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(717, 57);
            this.lblMensaje.TabIndex = 19;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Iniciar Sesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPsuario;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMensaje;
    }
}