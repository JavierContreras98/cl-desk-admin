using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    public partial class frmReporte1FechasPacientes : Form
    {
        public frmReporte1FechasPacientes()
        {
            InitializeComponent();
        }

        private DateTime fecha2;
        private DateTime fecha1;

        public DateTime Fecha1 { get => fecha1; set => fecha1 = value; }
        public DateTime Fecha2 { get => fecha2; set => fecha2 = value; }

        private void ReporteFechasPacientes_Load(object sender, EventArgs e)
        {
            this.sP_CREATE_REPORT1TableAdapter.Fill(this.cLCARMELODBDataSet1.SP_CREATE_REPORT1, Fecha1, Fecha2);
            this.rvPacienteFechas.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
          
            rvPacienteFechas.LocalReport.Refresh();

            frmReporte1FechasPacientes Mostrar = new frmReporte1FechasPacientes();
            this.Hide();

            Mostrar.Fecha1 = dtpFechaInicial.Value;
            Mostrar.Fecha2 = dtFechaFinal.Value;
            Mostrar.ShowDialog();

            this.Close();


        }

        private void rvPacienteFechas_Load(object sender, EventArgs e)
        {

        }
    }
}
