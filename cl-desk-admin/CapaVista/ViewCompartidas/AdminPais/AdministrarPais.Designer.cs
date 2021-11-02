
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPais
{
    partial class frmAdministrarPais
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
            this.dgvPais = new System.Windows.Forms.DataGridView();
            this.btnCrearPais = new System.Windows.Forms.Button();
            this.btnModificarPais = new System.Windows.Forms.Button();
            this.btnEliminarPais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).BeginInit();
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
            // txtBuscarTipoDocumento
            // 
            this.txtBuscarTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarTipoDocumento.Location = new System.Drawing.Point(398, 108);
            this.txtBuscarTipoDocumento.Name = "txtBuscarTipoDocumento";
            this.txtBuscarTipoDocumento.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTipoDocumento.TabIndex = 5;
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
            // dgvPais
            // 
            this.dgvPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPais.Location = new System.Drawing.Point(130, 197);
            this.dgvPais.MultiSelect = false;
            this.dgvPais.Name = "dgvPais";
            this.dgvPais.Size = new System.Drawing.Size(785, 291);
            this.dgvPais.TabIndex = 7;
            // 
            // btnCrearPais
            // 
            this.btnCrearPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearPais.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearPais.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearPais.Location = new System.Drawing.Point(894, 78);
            this.btnCrearPais.Name = "btnCrearPais";
            this.btnCrearPais.Size = new System.Drawing.Size(119, 50);
            this.btnCrearPais.TabIndex = 8;
            this.btnCrearPais.Text = "CREAR NUEVO";
            this.btnCrearPais.UseVisualStyleBackColor = false;
            // 
            // btnModificarPais
            // 
            this.btnModificarPais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarPais.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarPais.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarPais.Location = new System.Drawing.Point(130, 523);
            this.btnModificarPais.Name = "btnModificarPais";
            this.btnModificarPais.Size = new System.Drawing.Size(119, 50);
            this.btnModificarPais.TabIndex = 10;
            this.btnModificarPais.Text = "MODIFICAR";
            this.btnModificarPais.UseMnemonic = false;
            this.btnModificarPais.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPais
            // 
            this.btnEliminarPais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarPais.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPais.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPais.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarPais.Name = "btnEliminarPais";
            this.btnEliminarPais.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarPais.TabIndex = 11;
            this.btnEliminarPais.Text = "ELIMINAR";
            this.btnEliminarPais.UseMnemonic = false;
            this.btnEliminarPais.UseVisualStyleBackColor = false;
            // 
            // frmAdministrarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.btnEliminarPais);
            this.Controls.Add(this.btnModificarPais);
            this.Controls.Add(this.btnCrearPais);
            this.Controls.Add(this.dgvPais);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarTipoDocumento);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministrarPais";
            this.Text = "Administrar Pais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBuscarTipoDocumento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPais;
        private System.Windows.Forms.Button btnCrearPais;
        private System.Windows.Forms.Button btnModificarPais;
        private System.Windows.Forms.Button btnEliminarPais;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
    }
}