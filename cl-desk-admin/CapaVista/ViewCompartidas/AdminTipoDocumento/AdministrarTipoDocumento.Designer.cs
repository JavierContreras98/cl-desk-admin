
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    partial class AdministrarTipoDocumento
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
            this.dgvTipoDocumento = new System.Windows.Forms.DataGridView();
            this.btnCrearTipoDocumento = new System.Windows.Forms.Button();
            this.btnModificarTipoDocumento = new System.Windows.Forms.Button();
            this.btnEliminarTipoDocumento = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).BeginInit();
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
            // dgvTipoDocumento
            // 
            this.dgvTipoDocumento.AllowUserToResizeColumns = false;
            this.dgvTipoDocumento.AllowUserToResizeRows = false;
            this.dgvTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTipoDocumento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTipoDocumento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvTipoDocumento.ColumnHeadersHeight = 34;
            this.dgvTipoDocumento.Location = new System.Drawing.Point(126, 201);
            this.dgvTipoDocumento.MultiSelect = false;
            this.dgvTipoDocumento.Name = "dgvTipoDocumento";
            this.dgvTipoDocumento.RowHeadersVisible = false;
            this.dgvTipoDocumento.RowHeadersWidth = 62;
            this.dgvTipoDocumento.Size = new System.Drawing.Size(785, 291);
            this.dgvTipoDocumento.TabIndex = 7;
            // 
            // btnCrearTipoDocumento
            // 
            this.btnCrearTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearTipoDocumento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearTipoDocumento.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearTipoDocumento.Location = new System.Drawing.Point(890, 82);
            this.btnCrearTipoDocumento.Name = "btnCrearTipoDocumento";
            this.btnCrearTipoDocumento.Size = new System.Drawing.Size(119, 50);
            this.btnCrearTipoDocumento.TabIndex = 8;
            this.btnCrearTipoDocumento.Text = "CREAR NUEVO";
            this.btnCrearTipoDocumento.UseVisualStyleBackColor = false;
            this.btnCrearTipoDocumento.Click += new System.EventHandler(this.btnCrearTipoDocumento_Click);
            // 
            // btnModificarTipoDocumento
            // 
            this.btnModificarTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarTipoDocumento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarTipoDocumento.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarTipoDocumento.Location = new System.Drawing.Point(126, 527);
            this.btnModificarTipoDocumento.Name = "btnModificarTipoDocumento";
            this.btnModificarTipoDocumento.Size = new System.Drawing.Size(119, 50);
            this.btnModificarTipoDocumento.TabIndex = 10;
            this.btnModificarTipoDocumento.Text = "MODIFICAR";
            this.btnModificarTipoDocumento.UseMnemonic = false;
            this.btnModificarTipoDocumento.UseVisualStyleBackColor = false;
            this.btnModificarTipoDocumento.Click += new System.EventHandler(this.btnModificarTipoDocumento_Click);
            // 
            // btnEliminarTipoDocumento
            // 
            this.btnEliminarTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarTipoDocumento.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarTipoDocumento.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTipoDocumento.Location = new System.Drawing.Point(792, 527);
            this.btnEliminarTipoDocumento.Name = "btnEliminarTipoDocumento";
            this.btnEliminarTipoDocumento.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarTipoDocumento.TabIndex = 11;
            this.btnEliminarTipoDocumento.Text = "ELIMINAR";
            this.btnEliminarTipoDocumento.UseMnemonic = false;
            this.btnEliminarTipoDocumento.UseVisualStyleBackColor = false;
            this.btnEliminarTipoDocumento.Click += new System.EventHandler(this.btnEliminarTipoDocumento_Click);
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
            this.rbModificar.CheckedChanged += new System.EventHandler(this.AdministrarTipoDocumento_Load);
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
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.AdministrarTipoDocumento_Load);
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
            // AdministrarTipoDocumento
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
            this.Controls.Add(this.btnEliminarTipoDocumento);
            this.Controls.Add(this.btnModificarTipoDocumento);
            this.Controls.Add(this.btnCrearTipoDocumento);
            this.Controls.Add(this.dgvTipoDocumento);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdministrarTipoDocumento";
            this.Text = "Administrar Tipo de  Documento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdministrarTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.DataGridView dgvTipoDocumento;
        private System.Windows.Forms.Button btnCrearTipoDocumento;
        private System.Windows.Forms.Button btnModificarTipoDocumento;
        private System.Windows.Forms.Button btnEliminarTipoDocumento;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.TextBox txtNumero;
    }
}