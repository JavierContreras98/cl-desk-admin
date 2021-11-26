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
            this.SP_VIEW_REPORTE_EMPLEADOBindingSource.DataSource.ToString();

            //this.SP_VIEW_REPORTE_EMPLEADOAdapter.Fill(this.DataSet1.TIPO_USUARIO);
           // this.reportViewer1.RefreshReport();
            reportViewer1.Visible = true;
            this.reportViewer1.RefreshReport();
            
        }

        private void lblClinicaCarmelo_Click(object sender, EventArgs e)
        {

        }
    }
}
