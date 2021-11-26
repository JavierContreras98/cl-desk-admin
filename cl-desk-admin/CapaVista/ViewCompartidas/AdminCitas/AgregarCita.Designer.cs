
namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminCitas
{
    partial class frmAgregarCita
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
            this.lblCrearRegistroCita = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.labelhora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxNombrePaciente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1001, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLINICA EL CARMELO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCrearRegistroCita
            // 
            this.lblCrearRegistroCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCrearRegistroCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearRegistroCita.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCrearRegistroCita.Location = new System.Drawing.Point(3, 3);
            this.lblCrearRegistroCita.Name = "lblCrearRegistroCita";
            this.lblCrearRegistroCita.Size = new System.Drawing.Size(722, 25);
            this.lblCrearRegistroCita.TabIndex = 5;
            this.lblCrearRegistroCita.Text = "CREAR CITA";
            this.lblCrearRegistroCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMedico);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAsunto);
            this.panel1.Controls.Add(this.cbxHora);
            this.panel1.Controls.Add(this.labelhora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.cbxNombrePaciente);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblCrearRegistroCita);
            this.panel1.Location = new System.Drawing.Point(152, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 443);
            this.panel1.TabIndex = 6;
            // 
            // cbxMedico
            // 
            this.cbxMedico.FormattingEnabled = true;
            this.cbxMedico.Location = new System.Drawing.Point(342, 313);
            this.cbxMedico.Name = "cbxMedico";
            this.cbxMedico.Size = new System.Drawing.Size(275, 21);
            this.cbxMedico.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(128, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "ASUNTO";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAsunto.Location = new System.Drawing.Point(342, 232);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(275, 44);
            this.txtAsunto.TabIndex = 41;
            // 
            // cbxHora
            // 
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(342, 113);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(275, 21);
            this.cbxHora.TabIndex = 39;
            // 
            // labelhora
            // 
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelhora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelhora.Location = new System.Drawing.Point(131, 115);
            this.labelhora.Name = "labelhora";
            this.labelhora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelhora.Size = new System.Drawing.Size(45, 16);
            this.labelhora.TabIndex = 38;
            this.labelhora.Text = "HORA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(342, 55);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(275, 20);
            this.dtpFecha.TabIndex = 36;
            this.dtpFecha.Value = new System.DateTime(2021, 10, 29, 0, 0, 0, 0);
            // 
            // cbxNombrePaciente
            // 
            this.cbxNombrePaciente.FormattingEnabled = true;
            this.cbxNombrePaciente.Location = new System.Drawing.Point(342, 171);
            this.cbxNombrePaciente.Name = "cbxNombrePaciente";
            this.cbxNombrePaciente.Size = new System.Drawing.Size(275, 21);
            this.cbxNombrePaciente.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(131, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 50);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrear.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCrear.Location = new System.Drawing.Point(498, 377);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 50);
            this.btnCrear.TabIndex = 32;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(131, 173);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHora.Size = new System.Drawing.Size(130, 16);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "NOMBRE PACIENTE";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Cambria", 10F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(131, 315);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFecha.Size = new System.Drawing.Size(117, 16);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "NOMBRE MEDICO";
            // 
            // frmAgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1025, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmAgregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrearRegistroCita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cbxNombrePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.ComboBox cbxHora;
    }
}