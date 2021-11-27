
namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminUsuario
{
    partial class frmAdministrarUsuario
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
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.lblBanner = new System.Windows.Forms.Label();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarUsuario.Location = new System.Drawing.Point(795, 538);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarUsuario.TabIndex = 21;
            this.btnEliminarUsuario.Text = "ELIMINAR";
            this.btnEliminarUsuario.UseMnemonic = false;
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarUsuario.Location = new System.Drawing.Point(129, 538);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnModificarUsuario.TabIndex = 20;
            this.btnModificarUsuario.Text = "MODIFICAR";
            this.btnModificarUsuario.UseMnemonic = false;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuario.Location = new System.Drawing.Point(893, 93);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnCrearUsuario.TabIndex = 18;
            this.btnCrearUsuario.Text = "CREAR NUEVO";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(129, 212);
            this.dgvUsuario.MultiSelect = false;
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(785, 291);
            this.dgvUsuario.TabIndex = 17;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(18, 93);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(119, 50);
            this.btnMenuPrincipal.TabIndex = 13;
            this.btnMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // lblBanner
            // 
            this.lblBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBanner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBanner.Location = new System.Drawing.Point(11, 9);
            this.lblBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(1003, 44);
            this.lblBanner.TabIndex = 12;
            this.lblBanner.Text = "CLINICA EL CARMELO";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(129, 515);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 22;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.frmAdministrarUsuario_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(795, 515);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 23;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.frmAdministrarUsuario_Load);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 24;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(394, 542);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 25;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // frmAdministrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.Name = "frmAdministrarUsuario";
            this.Text = "Administrar Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNumero;
    }
}