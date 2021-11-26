
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEmpleados
{
    partial class frmAdministrarEmpleados
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
            this.txtBuscarEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
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
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(398, 108);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarEmpleado.TabIndex = 5;
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
            // dgvEmpleado
            // 
            this.dgvEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(130, 197);
            this.dgvEmpleado.MultiSelect = false;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(785, 291);
            this.dgvEmpleado.TabIndex = 7;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearEmpleado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearEmpleado.Location = new System.Drawing.Point(894, 78);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(119, 50);
            this.btnCrearEmpleado.TabIndex = 8;
            this.btnCrearEmpleado.Text = "CREAR NUEVO";
            this.btnCrearEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarEmpleado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarEmpleado.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarEmpleado.Location = new System.Drawing.Point(130, 523);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(119, 50);
            this.btnModificarEmpleado.TabIndex = 10;
            this.btnModificarEmpleado.Text = "MODIFICAR";
            this.btnModificarEmpleado.UseMnemonic = false;
            this.btnModificarEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarEmpleado.TabIndex = 11;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseMnemonic = false;
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(794, 501);
            this.rbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 25;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(130, 501);
            this.rbModificar.Margin = new System.Windows.Forms.Padding(2);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 24;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(395, 521);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 23;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(398, 538);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // frmAdministrarEmpleados
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
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.lblBusquedaAvanzada);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.lblBanner);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdministrarEmpleados";
            this.Text = "Administrar Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Label lblBusquedaAvanzada;
        private System.Windows.Forms.TextBox txtBuscarEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNumero;
    }
}