
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class frmReporte1FechasPacientes
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
            this.sPCREATEREPORT1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLCARMELODBDataSet1 = new cl_desk_admin.CLCARMELODBDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.rvPacienteFechas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sP_CREATE_REPORT1TableAdapter = new cl_desk_admin.CLCARMELODBDataSet1TableAdapters.SP_CREATE_REPORT1TableAdapter();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sPCREATEREPORT1BindingSource
            // 
            this.sPCREATEREPORT1BindingSource.DataMember = "SP_CREATE_REPORT1";
            this.sPCREATEREPORT1BindingSource.DataSource = this.cLCARMELODBDataSet1;
            // 
            // cLCARMELODBDataSet1
            // 
            this.cLCARMELODBDataSet1.DataSetName = "CLCARMELODBDataSet1";
            this.cLCARMELODBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1013, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLINICA EL CARMELO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rvPacienteFechas
            // 
            this.rvPacienteFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvPacienteFechas.BackColor = System.Drawing.SystemColors.Info;
            reportDataSource1.Name = "Reporte1";
            reportDataSource1.Value = this.sPCREATEREPORT1BindingSource;
            this.rvPacienteFechas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPacienteFechas.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReporteCitaPaciente.rdlc";
            this.rvPacienteFechas.Location = new System.Drawing.Point(12, 170);
            this.rvPacienteFechas.Name = "rvPacienteFechas";
            this.rvPacienteFechas.ServerReport.BearerToken = null;
            this.rvPacienteFechas.Size = new System.Drawing.Size(1001, 430);
            this.rvPacienteFechas.TabIndex = 4;
            this.rvPacienteFechas.Load += new System.EventHandler(this.rvPacienteFechas_Load);
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
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(12, 97);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(189, 20);
            this.dtpFechaInicial.TabIndex = 8;
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(303, 97);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(218, 20);
            this.dtFechaFinal.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "FECHA INICIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "FECHA FINAL";
            // 
            // sP_CREATE_REPORT1TableAdapter
            // 
            this.sP_CREATE_REPORT1TableAdapter.ClearBeforeFill = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(618, 68);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(164, 49);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "MENU PRINCIPAL";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmReporte1FechasPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.rvPacienteFechas);
            this.Controls.Add(this.label2);
            this.Name = "frmReporte1FechasPacientes";
            this.Text = "Reporte(1) Fecha Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteFechasPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPacienteFechas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource sPCREATEREPORT1BindingSource;
        private CLCARMELODBDataSet1 cLCARMELODBDataSet1;
        private CLCARMELODBDataSet1TableAdapters.SP_CREATE_REPORT1TableAdapter sP_CREATE_REPORT1TableAdapter;
        private System.Windows.Forms.Button btnMenu;
    }
}