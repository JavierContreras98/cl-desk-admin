
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminMunicipios
{
    partial class frmAdministrarMunicipios
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuP = new System.Windows.Forms.Button();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(796, 523);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 50);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(130, 523);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 50);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrear.Location = new System.Drawing.Point(894, 78);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 50);
            this.btnCrear.TabIndex = 20;
            this.btnCrear.Text = "CREAR NUEVO";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1001, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "CLINICA EL CARMELO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMenuP
            // 
            this.btnMenuP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuP.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuP.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnMenuP.Location = new System.Drawing.Point(19, 78);
            this.btnMenuP.Name = "btnMenuP";
            this.btnMenuP.Size = new System.Drawing.Size(119, 50);
            this.btnMenuP.TabIndex = 16;
            this.btnMenuP.Text = "MENU PRINCIPAL";
            this.btnMenuP.UseVisualStyleBackColor = false;
            this.btnMenuP.Click += new System.EventHandler(this.btnMenuP_Click);
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Location = new System.Drawing.Point(130, 197);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.Size = new System.Drawing.Size(785, 291);
            this.dgvMunicipios.TabIndex = 15;
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(130, 495);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 24;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.frmAdministrarMunicipios_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(796, 500);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 25;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.frmAdministrarMunicipios_Load);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(394, 542);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 26;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 27;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmAdministrarMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuP);
            this.Controls.Add(this.dgvMunicipios);
            this.Name = "frmAdministrarMunicipios";
            this.Text = "Administrar Municipios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrarMunicipios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuP;
        private System.Windows.Forms.DataGridView dgvMunicipios;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblInformacion;
    }
}