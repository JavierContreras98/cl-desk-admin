
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminProfesion
{
    partial class AdministrarProfesion
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
            this.lblBusquedaAvanzada = new System.Windows.Forms.Label();
            this.txtBuscarProfesion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvProfesion = new System.Windows.Forms.DataGridView();
            this.btnCrearProfesion = new System.Windows.Forms.Button();
            this.btnModificarProfesion = new System.Windows.Forms.Button();
            this.btnEliminarProfesion = new System.Windows.Forms.Button();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesion)).BeginInit();
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
            // lblBusquedaAvanzada
            // 
            this.lblBusquedaAvanzada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusquedaAvanzada.AutoSize = true;
            this.lblBusquedaAvanzada.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(242, 110);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(153, 16);
            this.lblBusquedaAvanzada.TabIndex = 4;
            this.lblBusquedaAvanzada.Text = "BUSQUEDA AVANZADA:";
            // 
            // txtBuscarProfesion
            // 
            this.txtBuscarProfesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarProfesion.Location = new System.Drawing.Point(398, 108);
            this.txtBuscarProfesion.Name = "txtBuscarProfesion";
            this.txtBuscarProfesion.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarProfesion.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(679, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 26);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvProfesion
            // 
            this.dgvProfesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProfesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesion.Location = new System.Drawing.Point(130, 197);
            this.dgvProfesion.MultiSelect = false;
            this.dgvProfesion.Name = "dgvProfesion";
            this.dgvProfesion.Size = new System.Drawing.Size(785, 291);
            this.dgvProfesion.TabIndex = 7;
            // 
            // btnCrearProfesion
            // 
            this.btnCrearProfesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearProfesion.Location = new System.Drawing.Point(894, 78);
            this.btnCrearProfesion.Name = "btnCrearProfesion";
            this.btnCrearProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnCrearProfesion.TabIndex = 8;
            this.btnCrearProfesion.Text = "CREAR NUEVO";
            this.btnCrearProfesion.UseVisualStyleBackColor = false;
            this.btnCrearProfesion.Click += new System.EventHandler(this.btnCrearProfesion_Click);
            // 
            // btnModificarProfesion
            // 
            this.btnModificarProfesion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarProfesion.Location = new System.Drawing.Point(130, 523);
            this.btnModificarProfesion.Name = "btnModificarProfesion";
            this.btnModificarProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnModificarProfesion.TabIndex = 10;
            this.btnModificarProfesion.Text = "MODIFICAR";
            this.btnModificarProfesion.UseMnemonic = false;
            this.btnModificarProfesion.UseVisualStyleBackColor = false;
            this.btnModificarProfesion.Click += new System.EventHandler(this.btnModificarProfesion_Click);
            // 
            // btnEliminarProfesion
            // 
            this.btnEliminarProfesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProfesion.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarProfesion.Name = "btnEliminarProfesion";
            this.btnEliminarProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarProfesion.TabIndex = 11;
            this.btnEliminarProfesion.Text = "ELIMINAR";
            this.btnEliminarProfesion.UseMnemonic = false;
            this.btnEliminarProfesion.UseVisualStyleBackColor = false;
            this.btnEliminarProfesion.Click += new System.EventHandler(this.btnEliminarProfesion_Click);
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(130, 500);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 12;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.AdministrarProfesion_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(796, 500);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 13;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.AdministrarProfesion_Load);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 14;
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
            // AdministrarProfesion
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
            this.Controls.Add(this.btnEliminarProfesion);
            this.Controls.Add(this.btnModificarProfesion);
            this.Controls.Add(this.btnCrearProfesion);
            this.Controls.Add(this.dgvProfesion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarProfesion);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrarProfesion";
            this.Text = "Administrar Profesion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdministrarProfesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBuscarProfesion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProfesion;
        private System.Windows.Forms.Button btnCrearProfesion;
        private System.Windows.Forms.Button btnModificarProfesion;
        private System.Windows.Forms.Button btnEliminarProfesion;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNumero;
    }
}