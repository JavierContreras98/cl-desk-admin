
namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    partial class frmAdministrarTipoUsuario
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.dgvTipoUsuario = new System.Windows.Forms.DataGridView();
            this.btnCrearTipoUsuario = new System.Windows.Forms.Button();
            this.btnModificarTipoUsuario = new System.Windows.Forms.Button();
            this.btnEliminarTipoUsuario = new System.Windows.Forms.Button();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBanner.Location = new System.Drawing.Point(12, 9);
            this.lblBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(1003, 44);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "CLINICA EL CARMELO";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(19, 78);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(119, 50);
            this.btnMenuPrincipal.TabIndex = 1;
            this.btnMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // dgvTipoUsuario
            // 
            this.dgvTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsuario.Location = new System.Drawing.Point(130, 197);
            this.dgvTipoUsuario.MultiSelect = false;
            this.dgvTipoUsuario.Name = "dgvTipoUsuario";
            this.dgvTipoUsuario.Size = new System.Drawing.Size(785, 291);
            this.dgvTipoUsuario.TabIndex = 7;
            // 
            // btnCrearTipoUsuario
            // 
            this.btnCrearTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearTipoUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearTipoUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearTipoUsuario.Location = new System.Drawing.Point(894, 78);
            this.btnCrearTipoUsuario.Name = "btnCrearTipoUsuario";
            this.btnCrearTipoUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnCrearTipoUsuario.TabIndex = 8;
            this.btnCrearTipoUsuario.Text = "CREAR NUEVO";
            this.btnCrearTipoUsuario.UseVisualStyleBackColor = false;
            this.btnCrearTipoUsuario.Click += new System.EventHandler(this.btnCrearTipoUsuario_Click);
            // 
            // btnModificarTipoUsuario
            // 
            this.btnModificarTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarTipoUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarTipoUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarTipoUsuario.Location = new System.Drawing.Point(126, 527);
            this.btnModificarTipoUsuario.Name = "btnModificarTipoUsuario";
            this.btnModificarTipoUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnModificarTipoUsuario.TabIndex = 10;
            this.btnModificarTipoUsuario.Text = "MODIFICAR";
            this.btnModificarTipoUsuario.UseMnemonic = false;
            this.btnModificarTipoUsuario.UseVisualStyleBackColor = false;
            this.btnModificarTipoUsuario.Click += new System.EventHandler(this.btnModificarTipoUsuario_Click);
            // 
            // btnEliminarTipoUsuario
            // 
            this.btnEliminarTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarTipoUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTipoUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTipoUsuario.Location = new System.Drawing.Point(792, 527);
            this.btnEliminarTipoUsuario.Name = "btnEliminarTipoUsuario";
            this.btnEliminarTipoUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarTipoUsuario.TabIndex = 11;
            this.btnEliminarTipoUsuario.Text = "ELIMINAR";
            this.btnEliminarTipoUsuario.UseMnemonic = false;
            this.btnEliminarTipoUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarTipoUsuario.Click += new System.EventHandler(this.btnEliminarTipoUsuario_Click);
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(126, 505);
            this.rbModificar.Margin = new System.Windows.Forms.Padding(2);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 16;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.frmAdministrarTipoUsuario_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(790, 505);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(122, 17);
            this.rbEliminar.TabIndex = 13;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activiar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.frmAdministrarTipoUsuario_Load);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 14;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(394, 542);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // frmAdministrarTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.btnEliminarTipoUsuario);
            this.Controls.Add(this.btnModificarTipoUsuario);
            this.Controls.Add(this.btnCrearTipoUsuario);
            this.Controls.Add(this.dgvTipoUsuario);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministrarTipoUsuario";
            this.Text = "Administrar Tipo de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrarTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.DataGridView dgvTipoUsuario;
        private System.Windows.Forms.Button btnCrearTipoUsuario;
        private System.Windows.Forms.Button btnModificarTipoUsuario;
        private System.Windows.Forms.Button btnEliminarTipoUsuario;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNumero;
    }
}