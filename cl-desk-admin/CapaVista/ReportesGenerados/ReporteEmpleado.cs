using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    public partial class ReporteEmpleado : Form
    {
        public ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cLCARMELODBDataSet.SP_VIEW_REPORTE_EMPLEADO' Puede moverla o quitarla según sea necesario.
            this.sP_VIEW_REPORTE_EMPLEADOTableAdapter.Fill(this.cLCARMELODBDataSet.SP_VIEW_REPORTE_EMPLEADO);
            // this.SP_VIEW_REPORTE_EMPLEADOBindingSource.DataSource;

            //this.SP_VIEW_REPORTE_EMPLEADOAdapter.Fill(this.DataSet1.TIPO_USUARIO);
            // this.reportViewer1.RefreshReport();


            rvReportesEmpleado.Visible = true;
            this.rvReportesEmpleado.RefreshReport();

            this.rvReportesEmpleado.RefreshReport();
        }

        private void lblClinicaCarmelo_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
