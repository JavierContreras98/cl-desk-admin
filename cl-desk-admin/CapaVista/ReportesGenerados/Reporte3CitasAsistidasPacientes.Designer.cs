
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class Reporte3CitasAsistidasPacientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.rvPacienteDepartamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1013, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLINICA EL CARMELO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rvPacienteDepartamento
            // 
            this.rvPacienteDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvPacienteDepartamento.BackColor = System.Drawing.SystemColors.Info;
            this.rvPacienteDepartamento.Location = new System.Drawing.Point(12, 128);
            this.rvPacienteDepartamento.Name = "rvPacienteDepartamento";
            this.rvPacienteDepartamento.ServerReport.BearerToken = null;
            this.rvPacienteDepartamento.Size = new System.Drawing.Size(1001, 472);
            this.rvPacienteDepartamento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Reporte3CitasAsistidasPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rvPacienteDepartamento);
            this.Controls.Add(this.label2);
            this.Name = "Reporte3CitasAsistidasPacientes";
            this.Text = "Reporte de Pacientes en Departamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPacienteDepartamento;
        private System.Windows.Forms.Button button1;
    }
}