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
    public partial class frmReporte2PacienteDepartamento : Form
    {
        public frmReporte2PacienteDepartamento()
        {
            InitializeComponent();
        }

        private void frmReportePacienteDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cLCARMELODBDataSet2.SP_CREATE_REPORT2' Puede moverla o quitarla según sea necesario.

            this.rvPacientesDepto.Refresh();


            this.rvPacientesDepto.RefreshReport();
        }
    }
}
