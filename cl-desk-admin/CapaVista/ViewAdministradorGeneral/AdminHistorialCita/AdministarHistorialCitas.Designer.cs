
namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminHistorialCita
{
    partial class frmAdministarHistorialCitas
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
            this.lblClinicaCarmelo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dvgHistorialCitas = new System.Windows.Forms.DataGridView();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClinicaCarmelo
            // 
            this.lblClinicaCarmelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClinicaCarmelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.lblClinicaCarmelo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClinicaCarmelo.Location = new System.Drawing.Point(0, 0);
            this.lblClinicaCarmelo.Name = "lblClinicaCarmelo";
            this.lblClinicaCarmelo.Size = new System.Drawing.Size(1025, 39);
            this.lblClinicaCarmelo.TabIndex = 0;
            this.lblClinicaCarmelo.Text = "CLINICA EL CARMELO";
            this.lblClinicaCarmelo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Location = new System.Drawing.Point(398, 108);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(275, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(223, 110);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(174, 16);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "NUMERO DE EXPEDIENTE";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(202)))), ((int)(((byte)(240)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(679, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 26);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dvgHistorialCitas
            // 
            this.dvgHistorialCitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dvgHistorialCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgHistorialCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHistorialCitas.Location = new System.Drawing.Point(130, 197);
            this.dvgHistorialCitas.Name = "dvgHistorialCitas";
            this.dvgHistorialCitas.Size = new System.Drawing.Size(785, 291);
            this.dvgHistorialCitas.TabIndex = 9;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.btnMenuPrincipal.Location = new System.Drawing.Point(12, 81);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(119, 50);
            this.btnMenuPrincipal.TabIndex = 10;
            this.btnMenuPrincipal.Text = "MENU PRINCIPAL";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // frmAdministarHistorialCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.dvgHistorialCitas);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblClinicaCarmelo);
            this.Name = "frmAdministarHistorialCitas";
            this.Text = "Aministrador Historial Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dvgHistorialCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClinicaCarmelo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dvgHistorialCitas;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}