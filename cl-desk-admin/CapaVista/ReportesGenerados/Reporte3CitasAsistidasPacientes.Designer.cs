
namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    partial class frmReporte3CitasAsistidasPacientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sPCREATEREPORT3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLCARMELODBDataSet3 = new cl_desk_admin.CLCARMELODBDataSet3();
            this.label2 = new System.Windows.Forms.Label();
            this.rvPacienteDepartamento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.sP_CREATE_REPORT3TableAdapter = new cl_desk_admin.CLCARMELODBDataSet3TableAdapters.SP_CREATE_REPORT3TableAdapter();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // sPCREATEREPORT3BindingSource
            // 
            this.sPCREATEREPORT3BindingSource.DataMember = "SP_CREATE_REPORT3";
            this.sPCREATEREPORT3BindingSource.DataSource = this.cLCARMELODBDataSet3;
            // 
            // cLCARMELODBDataSet3
            // 
            this.cLCARMELODBDataSet3.DataSetName = "CLCARMELODBDataSet3";
            this.cLCARMELODBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource2.Name = "Reporte3";
            reportDataSource2.Value = this.sPCREATEREPORT3BindingSource;
            this.rvPacienteDepartamento.LocalReport.DataSources.Add(reportDataSource2);
            this.rvPacienteDepartamento.LocalReport.ReportEmbeddedResource = "cl_desk_admin.CapaVista.Reportes.ReporteCitasAsistidasPacientes.rdlc";
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
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "FECHA FINAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "FECHA INICIAL";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(236, 97);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(163, 20);
            this.dtFechaFinal.TabIndex = 14;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(16, 97);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(169, 20);
            this.dtpFechaInicial.TabIndex = 13;
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(433, 97);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(214, 21);
            this.cbxPaciente.TabIndex = 17;
            // 
            // sP_CREATE_REPORT3TableAdapter
            // 
            this.sP_CREATE_REPORT3TableAdapter.ClearBeforeFill = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(666, 68);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(164, 49);
            this.btnMenu.TabIndex = 18;
            this.btnMenu.Text = "MENU PRINCIPAL";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmReporte3CitasAsistidasPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbxPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaFinal);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.rvPacienteDepartamento);
            this.Controls.Add(this.label2);
            this.Name = "frmReporte3CitasAsistidasPacientes";
            this.Text = "Reporte de Pacientes en Departamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReporte3CitasAsistidasPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sPCREATEREPORT3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLCARMELODBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPacienteDepartamento;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.ComboBox cbxPaciente;
        private System.Windows.Forms.BindingSource sPCREATEREPORT3BindingSource;
        private CLCARMELODBDataSet3 cLCARMELODBDataSet3;
        private CLCARMELODBDataSet3TableAdapters.SP_CREATE_REPORT3TableAdapter sP_CREATE_REPORT3TableAdapter;
        private System.Windows.Forms.Button btnMenu;
    }
}