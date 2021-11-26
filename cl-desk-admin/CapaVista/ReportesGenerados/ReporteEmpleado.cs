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
    public partial class frmReporteEmpleado : Form
    {
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cLCARMELODBDataSet.SP_CREATE_REPORT4' Puede moverla o quitarla según sea necesario.
            this.sP_CREATE_REPORT4TableAdapter.Fill(this.cLCARMELODBDataSet.SP_CREATE_REPORT4);

            this.rvReporteEmpleado.RefreshReport();
        }
    }
}
