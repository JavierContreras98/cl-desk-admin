
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminHorarioCitas
{
    partial class AdministrarHorarioCitas
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
            this.txtBuscarTipoDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvHorariocitas = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariocitas)).BeginInit();
            this.SuspendLayout();
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
            this.btnMenuPrincipal.Location = new System.Drawing.Point(15, 82);
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
            this.lblBusquedaAvanzada.Location = new System.Drawing.Point(238, 114);
            this.lblBusquedaAvanzada.Name = "lblBusquedaAvanzada";
            this.lblBusquedaAvanzada.Size = new System.Drawing.Size(153, 16);
            this.lblBusquedaAvanzada.TabIndex = 4;
            this.lblBusquedaAvanzada.Text = "BUSQUEDA AVANZADA:";
            this.lblBusquedaAvanzada.Visible = false;
            // 
            // txtBuscarTipoDocumento
            // 
            this.txtBuscarTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarTipoDocumento.Location = new System.Drawing.Point(394, 112);
            this.txtBuscarTipoDocumento.Name = "txtBuscarTipoDocumento";
            this.txtBuscarTipoDocumento.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTipoDocumento.TabIndex = 5;
            this.txtBuscarTipoDocumento.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(675, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 26);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            // 
            // dgvHorariocitas
            // 
            this.dgvHorariocitas.AllowUserToResizeColumns = false;
            this.dgvHorariocitas.AllowUserToResizeRows = false;
            this.dgvHorariocitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHorariocitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvHorariocitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvHorariocitas.ColumnHeadersHeight = 34;
            this.dgvHorariocitas.Location = new System.Drawing.Point(126, 201);
            this.dgvHorariocitas.MultiSelect = false;
            this.dgvHorariocitas.Name = "dgvHorariocitas";
            this.dgvHorariocitas.RowHeadersVisible = false;
            this.dgvHorariocitas.RowHeadersWidth = 62;
            this.dgvHorariocitas.Size = new System.Drawing.Size(785, 291);
            this.dgvHorariocitas.TabIndex = 7;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(890, 82);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 50);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "CREAR NUEVO";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(126, 527);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 50);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseMnemonic = false;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(792, 527);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 50);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseMnemonic = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 14;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rbModificar.CheckedChanged += new System.EventHandler(this.AdministrarHorarioCitas_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(790, 505);
            this.rbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 17;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.AdministrarHorarioCitas_Load);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(394, 542);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // AdministrarHorarioCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvHorariocitas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarTipoDocumento);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrarHorarioCitas";
            this.Text = "Administrar Tipo de  Documento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdministrarHorarioCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariocitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBuscarTipoDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvHorariocitas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}