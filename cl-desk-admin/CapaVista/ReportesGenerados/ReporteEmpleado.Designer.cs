
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
            this.SP_VIEW_REPORTE_EMPLEADOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLCARMELODBDataSet = new cl_desk_admin.CLCARMELODBDataSet1();
            this.cLCARMELODBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClinicaCarmelo = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VIEW_REPORTE_EMPLEADOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_VIEW_REPORTE_EMPLEADOBindingSource
            // 
            this.SP_VIEW_REPORTE_EMPLEADOBindingSource.DataMember = "SP_VIEW_REPORTE_EMPLEADO";
            this.SP_VIEW_REPORTE_EMPLEADOBindingSource.DataSource = this.cLCARMELODBDataSet;
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
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.Info;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosEmpleado";
            reportDataSource1.Value = this.SP_VIEW_REPORTE_EMPLEADOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReporteEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1025, 557);
            this.reportViewer1.TabIndex = 1;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.lblClinicaCarmelo);
            this.Name = "ReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VIEW_REPORTE_EMPLEADOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClinicaCarmelo;
        private System.Windows.Forms.BindingSource cLCARMELODBDataSetBindingSource;
        private CLCARMELODBDataSet1 cLCARMELODBDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_VIEW_REPORTE_EMPLEADOBindingSource;
    }
}
