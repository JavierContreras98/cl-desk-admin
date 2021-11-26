
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminInforMedicos
{
    partial class frmAdminInforMedicos
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
            this.btnMenuPrInfoMedico = new System.Windows.Forms.Button();
            this.btnCrearInfoMedico = new System.Windows.Forms.Button();
            this.lblClinicaBanner = new System.Windows.Forms.Label();
            this.dgvInfoMedicos = new System.Windows.Forms.DataGridView();
            this.btnModificarInfoMedico = new System.Windows.Forms.Button();
            this.btnEliminarInfoMedico = new System.Windows.Forms.Button();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuPrInfoMedico
            // 
            this.btnMenuPrInfoMedico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuPrInfoMedico.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuPrInfoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPrInfoMedico.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnMenuPrInfoMedico.Location = new System.Drawing.Point(19, 78);
            this.btnMenuPrInfoMedico.Name = "btnMenuPrInfoMedico";
            this.btnMenuPrInfoMedico.Size = new System.Drawing.Size(119, 50);
            this.btnMenuPrInfoMedico.TabIndex = 0;
            this.btnMenuPrInfoMedico.Text = "MENU PRINCIPAL";
            this.btnMenuPrInfoMedico.UseVisualStyleBackColor = false;
            // 
            // btnCrearInfoMedico
            // 
            this.btnCrearInfoMedico.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrearInfoMedico.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCrearInfoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearInfoMedico.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrearInfoMedico.Location = new System.Drawing.Point(894, 78);
            this.btnCrearInfoMedico.Name = "btnCrearInfoMedico";
            this.btnCrearInfoMedico.Size = new System.Drawing.Size(119, 50);
            this.btnCrearInfoMedico.TabIndex = 1;
            this.btnCrearInfoMedico.Text = "CREAR NUEVO";
            this.btnCrearInfoMedico.UseVisualStyleBackColor = false;
            this.btnCrearInfoMedico.Click += new System.EventHandler(this.btnCrearInfoMedico_Click);
            // 
            // lblClinicaBanner
            // 
            this.lblClinicaBanner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblClinicaBanner.BackColor = System.Drawing.SystemColors.Info;
            this.lblClinicaBanner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinicaBanner.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClinicaBanner.Location = new System.Drawing.Point(12, 9);
            this.lblClinicaBanner.Name = "lblClinicaBanner";
            this.lblClinicaBanner.Size = new System.Drawing.Size(1001, 37);
            this.lblClinicaBanner.TabIndex = 2;
            this.lblClinicaBanner.Text = "CLINICA EL CARMELO";
            this.lblClinicaBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvInfoMedicos
            // 
            this.dgvInfoMedicos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInfoMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoMedicos.Location = new System.Drawing.Point(130, 197);
            this.dgvInfoMedicos.Name = "dgvInfoMedicos";
            this.dgvInfoMedicos.Size = new System.Drawing.Size(785, 291);
            this.dgvInfoMedicos.TabIndex = 6;
            // 
            // btnModificarInfoMedico
            // 
            this.btnModificarInfoMedico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificarInfoMedico.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificarInfoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarInfoMedico.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnModificarInfoMedico.Location = new System.Drawing.Point(130, 523);
            this.btnModificarInfoMedico.Name = "btnModificarInfoMedico";
            this.btnModificarInfoMedico.Size = new System.Drawing.Size(119, 50);
            this.btnModificarInfoMedico.TabIndex = 7;
            this.btnModificarInfoMedico.Text = "MODIFICAR";
            this.btnModificarInfoMedico.UseVisualStyleBackColor = false;
            this.btnModificarInfoMedico.Click += new System.EventHandler(this.btnModificarInfoMedico_Click);
            // 
            // btnEliminarInfoMedico
            // 
            this.btnEliminarInfoMedico.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarInfoMedico.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEliminarInfoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarInfoMedico.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnEliminarInfoMedico.Location = new System.Drawing.Point(796, 523);
            this.btnEliminarInfoMedico.Name = "btnEliminarInfoMedico";
            this.btnEliminarInfoMedico.Size = new System.Drawing.Size(119, 50);
            this.btnEliminarInfoMedico.TabIndex = 9;
            this.btnEliminarInfoMedico.Text = "ELIMINAR";
            this.btnEliminarInfoMedico.UseVisualStyleBackColor = false;
            this.btnEliminarInfoMedico.Click += new System.EventHandler(this.btnEliminarInfoMedico_Click);
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(130, 500);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 10;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.frmAdminInforMedicos_Load);
            // 
            // rbEliminar
            // 
            this.rbEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(796, 500);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(120, 17);
            this.rbEliminar.TabIndex = 11;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Activar para eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            this.rbEliminar.CheckedChanged += new System.EventHandler(this.frmAdminInforMedicos_Load);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(391, 525);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 12;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(394, 542);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // frmAdminInforMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.rbEliminar);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.btnEliminarInfoMedico);
            this.Controls.Add(this.btnModificarInfoMedico);
            this.Controls.Add(this.dgvInfoMedicos);
            this.Controls.Add(this.lblClinicaBanner);
            this.Controls.Add(this.btnCrearInfoMedico);
            this.Controls.Add(this.btnMenuPrInfoMedico);
            this.Name = "frmAdminInforMedicos";
            this.Text = "Administrar Informacion de los Medicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminInforMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenuPrInfoMedico;
        private System.Windows.Forms.Button btnCrearInfoMedico;
        private System.Windows.Forms.Label lblClinicaBanner;
        private System.Windows.Forms.DataGridView dgvInfoMedicos;
        private System.Windows.Forms.Button btnModificarInfoMedico;
        private System.Windows.Forms.Button btnEliminarInfoMedico;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.TextBox txtNumero;
    }
}