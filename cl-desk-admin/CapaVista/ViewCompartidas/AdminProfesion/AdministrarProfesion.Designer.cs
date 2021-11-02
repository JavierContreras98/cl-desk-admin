
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
            this.txtBuscarProfesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarProfesion.Location = new System.Drawing.Point(398, 108);
            this.txtBuscarProfesion.Name = "txtBuscarTipoUsuario";
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
            // dgvTipoUsuario
            // 
            this.dgvProfesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProfesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesion.Location = new System.Drawing.Point(130, 197);
            this.dgvProfesion.MultiSelect = false;
            this.dgvProfesion.Name = "dgvTipoUsuario";
            this.dgvProfesion.Size = new System.Drawing.Size(785, 291);
            this.dgvProfesion.TabIndex = 7;

            // 
            // btnCrearTipoUsuario
            // 
            this.btnCrearProfesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearProfesion.Location = new System.Drawing.Point(894, 78);
            this.btnCrearProfesion.Name = "btnCrearTipoUsuario";
            this.btnCrearProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnCrearProfesion.TabIndex = 8;
            this.btnCrearProfesion.Text = "CREAR NUEVO";
            this.btnCrearProfesion.UseVisualStyleBackColor = false;

            // 
            // btnModificarTipoUsuario
            // 
            this.btnModificarProfesion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarProfesion.Location = new System.Drawing.Point(130, 523);
            this.btnModificarProfesion.Name = "btnModificarTipoUsuario";
            this.btnModificarProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnModificarProfesion.TabIndex = 10;
            this.btnModificarProfesion.Text = "MODIFICAR";
            this.btnModificarProfesion.UseMnemonic = false;
            this.btnModificarProfesion.UseVisualStyleBackColor = false;

            // 
            // btnEliminarTipoUsuario
            // 
            this.btnEliminarProfesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarProfesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProfesion.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarProfesion.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarProfesion.Name = "btnEliminarTipoUsuario";
            this.btnEliminarProfesion.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarProfesion.TabIndex = 11;
            this.btnEliminarProfesion.Text = "ELIMINAR";
            this.btnEliminarProfesion.UseMnemonic = false;
            this.btnEliminarProfesion.UseVisualStyleBackColor = false;

            // 
            // frmAdminTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 612);
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
            this.Name = "frmAdminTipoUsuario";
            this.Text = "Administrar Tipo de Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}