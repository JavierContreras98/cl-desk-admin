
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
            this.lblBusquedaAvanzada = new System.Windows.Forms.Label();
            this.txtBuscarTipoUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvTipoUsuario = new System.Windows.Forms.DataGridView();
            this.btnCrearTipoUsuario = new System.Windows.Forms.Button();
            this.btnModificarTipoUsuario = new System.Windows.Forms.Button();
            this.btnEliminarTipoUsuario = new System.Windows.Forms.Button();
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
            // txtBuscarTipoUsuario
            // 
            this.txtBuscarTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarTipoUsuario.Location = new System.Drawing.Point(398, 108);
            this.txtBuscarTipoUsuario.Name = "txtBuscarTipoUsuario";
            this.txtBuscarTipoUsuario.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTipoUsuario.TabIndex = 5;
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
            // 
            // btnModificarTipoUsuario
            // 
            this.btnModificarTipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarTipoUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarTipoUsuario.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarTipoUsuario.Location = new System.Drawing.Point(130, 523);
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
            this.btnEliminarTipoUsuario.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarTipoUsuario.Name = "btnEliminarTipoUsuario";
            this.btnEliminarTipoUsuario.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarTipoUsuario.TabIndex = 11;
            this.btnEliminarTipoUsuario.Text = "ELIMINAR";
            this.btnEliminarTipoUsuario.UseMnemonic = false;
            this.btnEliminarTipoUsuario.UseVisualStyleBackColor = false;
            // 
            // frmAdministrarTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.btnEliminarTipoUsuario);
            this.Controls.Add(this.btnModificarTipoUsuario);
            this.Controls.Add(this.btnCrearTipoUsuario);
            this.Controls.Add(this.dgvTipoUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarTipoUsuario);
            this.Controls.Add(this.lblBusquedaAvanzada);
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
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBuscarTipoUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvTipoUsuario;
        private System.Windows.Forms.Button btnCrearTipoUsuario;
        private System.Windows.Forms.Button btnModificarTipoUsuario;
        private System.Windows.Forms.Button btnEliminarTipoUsuario;
    }
}