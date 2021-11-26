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
    public partial class frmReporteFechasPacientes : Form
    {
        public frmReporteFechasPacientes()
        {
            InitializeComponent();
        }

        private void ReporteFechasPacientes_Load(object sender, EventArgs e)
        {

            this.rvPacienteFechas.RefreshReport();
        }
    }
}
