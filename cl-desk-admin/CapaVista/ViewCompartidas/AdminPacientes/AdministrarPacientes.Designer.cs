
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPacientes
{
    partial class frmAdministrarPacientes
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
            this.btnMenuP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgAdminPaciente = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenuP
            // 
            this.btnMenuP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuP.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuP.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuP.Location = new System.Drawing.Point(19, 78);
            this.btnMenuP.Name = "btnMenuP";
            this.btnMenuP.Size = new System.Drawing.Size(119, 50);
            this.btnMenuP.TabIndex = 2;
            this.btnMenuP.Text = "MENU PRINCIPAL";
            this.btnMenuP.UseVisualStyleBackColor = false;
            this.btnMenuP.Click += new System.EventHandler(this.btnMenuP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLINICA EL CARMELO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dvgAdminPaciente
            // 
            this.dvgAdminPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dvgAdminPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAdminPaciente.Location = new System.Drawing.Point(130, 197);
            this.dvgAdminPaciente.Name = "dvgAdminPaciente";
            this.dvgAdminPaciente.Size = new System.Drawing.Size(785, 291);
            this.dvgAdminPaciente.TabIndex = 6;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(130, 523);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 50);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCrear.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(894, 78);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 50);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "CREAR NUEVO";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.Location = new System.Drawing.Point(393, 540);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 20);
            this.txtNumero.TabIndex = 36;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInformacion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInformacion.Location = new System.Drawing.Point(390, 523);
            this.lblInformacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(278, 15);
            this.lblInformacion.TabIndex = 35;
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbModificar
            // 
            this.rbModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbModificar.AutoSize = true;
            this.rbModificar.Location = new System.Drawing.Point(125, 503);
            this.rbModificar.Margin = new System.Windows.Forms.Padding(2);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(127, 17);
            this.rbModificar.TabIndex = 34;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "Activar para modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            this.rbModificar.CheckedChanged += new System.EventHandler(this.frmAdministrarPacientes_Load);
            // 
            // frmAdministrarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.rbModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dvgAdminPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenuP);
            this.Name = "frmAdministrarPacientes";
            this.Text = "Administrar Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdministrarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAdminPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenuP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgAdminPaciente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.RadioButton rbModificar;
    }
}