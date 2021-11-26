
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class ReporteEmpleado
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
            this.lblClinicaCarmelo = new System.Windows.Forms.Label();
            this.rvReportesEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cLCARMELODBDataSet = new cl_desk_admin.CLCARMELODBDataSet();
            this.cLCARMELODBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPVIEWREPORTEEMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_VIEW_REPORTE_EMPLEADOTableAdapter = new cl_desk_admin.CLCARMELODBDataSetTableAdapters.SP_VIEW_REPORTE_EMPLEADOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVIEWREPORTEEMPLEADOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClinicaCarmelo
            // 
            this.lblClinicaCarmelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClinicaCarmelo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.lblClinicaCarmelo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClinicaCarmelo.Location = new System.Drawing.Point(0, 0);
            this.lblClinicaCarmelo.Name = "lblClinicaCarmelo";
            this.lblClinicaCarmelo.Size = new System.Drawing.Size(1025, 55);
            this.lblClinicaCarmelo.TabIndex = 0;
            this.lblClinicaCarmelo.Text = "CLINICA EL CARMELO";
            this.lblClinicaCarmelo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClinicaCarmelo.Click += new System.EventHandler(this.lblClinicaCarmelo_Click);
            // 
            // rvReportesEmpleado
            // 
            this.rvReportesEmpleado.BackColor = System.Drawing.SystemColors.Info;
            this.rvReportesEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPVIEWREPORTEEMPLEADOBindingSource;
            this.rvReportesEmpleado.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReportesEmpleado.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReporteEmpleado.rdlc";
            this.rvReportesEmpleado.Location = new System.Drawing.Point(0, 55);
            this.rvReportesEmpleado.Name = "rvReportesEmpleado";
            this.rvReportesEmpleado.ServerReport.BearerToken = null;
            this.rvReportesEmpleado.Size = new System.Drawing.Size(1025, 557);
            this.rvReportesEmpleado.TabIndex = 1;
            this.rvReportesEmpleado.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cLCARMELODBDataSet
            // 
            this.cLCARMELODBDataSet.DataSetName = "CLCARMELODBDataSet";
            this.cLCARMELODBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLCARMELODBDataSetBindingSource
            // 
            this.cLCARMELODBDataSetBindingSource.DataSource = this.cLCARMELODBDataSet;
            this.cLCARMELODBDataSetBindingSource.Position = 0;
            // 
            // sPVIEWREPORTEEMPLEADOBindingSource
            // 
            this.sPVIEWREPORTEEMPLEADOBindingSource.DataMember = "SP_VIEW_REPORTE_EMPLEADO";
            this.sPVIEWREPORTEEMPLEADOBindingSource.DataSource = this.cLCARMELODBDataSetBindingSource;
            // 
            // sP_VIEW_REPORTE_EMPLEADOTableAdapter
            // 
            this.sP_VIEW_REPORTE_EMPLEADOTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.rvReportesEmpleado);
            this.Controls.Add(this.lblClinicaCarmelo);
            this.Name = "ReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVIEWREPORTEEMPLEADOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClinicaCarmelo;
        private Microsoft.Reporting.WinForms.ReportViewer rvReportesEmpleado;
        private System.Windows.Forms.BindingSource cLCARMELODBDataSetBindingSource;
        private CLCARMELODBDataSet cLCARMELODBDataSet;
        private System.Windows.Forms.BindingSource sPVIEWREPORTEEMPLEADOBindingSource;
        private CLCARMELODBDataSetTableAdapters.SP_VIEW_REPORTE_EMPLEADOTableAdapter sP_VIEW_REPORTE_EMPLEADOTableAdapter;
    }
}
