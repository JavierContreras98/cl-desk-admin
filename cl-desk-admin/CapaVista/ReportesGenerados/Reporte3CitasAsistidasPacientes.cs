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
    public partial class frmReporte3CitasAsistidasPacientes : Form
    {
        public frmReporte3CitasAsistidasPacientes()
        {
            InitializeComponent();
        }

        private void frmReporte3CitasAsistidasPacientes_Load(object sender, EventArgs e)
        {
           

            this.rvPacienteDepartamento.RefreshReport();
        }
    }
}
