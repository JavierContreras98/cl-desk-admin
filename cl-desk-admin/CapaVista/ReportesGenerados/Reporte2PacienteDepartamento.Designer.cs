
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class frmReportePacienteDepartamento
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label2 = new System.Windows.Forms.Label();
            this.rvPacienteDepartamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.cbxDepartamentos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cLCARMELODBDataSet2 = new cl_desk_admin.CLCARMELODBDataSet2();
            this.sPCREATEREPORT2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CREATE_REPORT2TableAdapter = new cl_desk_admin.CLCARMELODBDataSet2TableAdapters.SP_CREATE_REPORT2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT2BindingSource)).BeginInit();
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
            reportDataSource1.Name = "Reporte2";
            reportDataSource1.Value = this.sPCREATEREPORT2BindingSource;
            this.rvPacienteDepartamento.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPacienteDepartamento.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReportePacienteDepto.rdlc";
            this.rvPacienteDepartamento.Location = new System.Drawing.Point(12, 128);
            this.rvPacienteDepartamento.Name = "rvPacienteDepartamento";
            this.rvPacienteDepartamento.ServerReport.BearerToken = null;
            this.rvPacienteDepartamento.Size = new System.Drawing.Size(1001, 472);
            this.rvPacienteDepartamento.TabIndex = 4;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporte.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(849, 68);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(164, 49);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "GENERAR REPORTE";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // cbxDepartamentos
            // 
            this.cbxDepartamentos.FormattingEnabled = true;
            this.cbxDepartamentos.Location = new System.Drawing.Point(19, 88);
            this.cbxDepartamentos.Name = "cbxDepartamentos";
            this.cbxDepartamentos.Size = new System.Drawing.Size(446, 21);
            this.cbxDepartamentos.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "SELECCIONE DEPARTAMENTO";
            // 
            // cLCARMELODBDataSet2
            // 
            this.cLCARMELODBDataSet2.DataSetName = "CLCARMELODBDataSet2";
            this.cLCARMELODBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPCREATEREPORT2BindingSource
            // 
            this.sPCREATEREPORT2BindingSource.DataMember = "SP_CREATE_REPORT2";
            this.sPCREATEREPORT2BindingSource.DataSource = this.cLCARMELODBDataSet2;
            // 
            // sP_CREATE_REPORT2TableAdapter
            // 
            this.sP_CREATE_REPORT2TableAdapter.ClearBeforeFill = true;
            // 
            // frmReportePacienteDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDepartamentos);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.rvPacienteDepartamento);
            this.Controls.Add(this.label2);
            this.Name = "frmReportePacienteDepartamento";
            this.Text = "Reporte(2) de Pacientes en Departamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPacienteDepartamento;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.ComboBox cbxDepartamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sPCREATEREPORT2BindingSource;
        private CLCARMELODBDataSet2 cLCARMELODBDataSet2;
        private CLCARMELODBDataSet2TableAdapters.SP_CREATE_REPORT2TableAdapter sP_CREATE_REPORT2TableAdapter;
    }
}