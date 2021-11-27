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

        private void ReporteFechasPacientes_Load(object sender, EventArgs e)
        {

            this.rvPacienteFechas.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("Data Source =DESKTOP-4EK7VVO\\SQLEXPRESS02; Initial Catalog = CLCARMELODB; Integrated Security = True");

            SqlDataAdapter da = new SqlDataAdapter("SP_CREATE_REPORT1", Conexion);
            DataTable dt = new DataTable();

            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add("@FECHA_INICIAL", SqlDbType.DateTime).Value = Convert.ToDateTime(dtpFechaInicial.Value);
            da.SelectCommand.Parameters.Add("@FECHA_FINAL", SqlDbType.DateTime).Value = Convert.ToDateTime(dtFechaFinal.Value);


            rvPacienteFechas.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("Reporte1",dt);

            rvPacienteFechas.LocalReport.DataSources.Add(rp);
            rvPacienteFechas.LocalReport.Refresh();



        }

        private void rvPacienteFechas_Load(object sender, EventArgs e)
        {

        }
    }
}
