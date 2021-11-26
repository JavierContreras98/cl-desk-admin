
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class frmReporteEmpleado
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
            this.rvReporteEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cLCARMELODBDataSet = new cl_desk_admin.CLCARMELODBDataSet();
            this.cLCARMELODBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPCREATEREPORT4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_CREATE_REPORT4TableAdapter = new cl_desk_admin.CLCARMELODBDataSetTableAdapters.SP_CREATE_REPORT4TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvReporteEmpleado
            // 
            this.rvReporteEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rvReporteEmpleado.BackColor = System.Drawing.SystemColors.Info;
            reportDataSource1.Name = "DataReporteEmpleado";
            reportDataSource1.Value = this.sPCREATEREPORT4BindingSource;
            this.rvReporteEmpleado.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporteEmpleado.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReporteEmpleado.rdlc";
            this.rvReporteEmpleado.Location = new System.Drawing.Point(12, 50);
            this.rvReporteEmpleado.Name = "rvReporteEmpleado";
            this.rvReporteEmpleado.ServerReport.BearerToken = null;
            this.rvReporteEmpleado.Size = new System.Drawing.Size(1001, 550);
            this.rvReporteEmpleado.TabIndex = 0;
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
            // sPCREATEREPORT4BindingSource
            // 
            this.sPCREATEREPORT4BindingSource.DataMember = "SP_CREATE_REPORT4";
            this.sPCREATEREPORT4BindingSource.DataSource = this.cLCARMELODBDataSetBindingSource;
            // 
            // sP_CREATE_REPORT4TableAdapter
            // 
            this.sP_CREATE_REPORT4TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1020, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "CLINICA EL CARMELO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvReporteEmpleado);
            this.Name = "frmReporteEmpleado";
            this.Text = "Reporte Empleado";
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporteEmpleado;
        private CLCARMELODBDataSet cLCARMELODBDataSet;
        private System.Windows.Forms.BindingSource cLCARMELODBDataSetBindingSource;
        private System.Windows.Forms.BindingSource sPCREATEREPORT4BindingSource;
        private CLCARMELODBDataSetTableAdapters.SP_CREATE_REPORT4TableAdapter sP_CREATE_REPORT4TableAdapter;
        private System.Windows.Forms.Label label1;
    }
}