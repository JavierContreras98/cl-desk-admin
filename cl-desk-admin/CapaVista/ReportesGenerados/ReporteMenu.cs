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
    public partial class frmReporteMenu : Form
    {
        public frmReporteMenu()
        {
            InitializeComponent();
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            frmReporteEmpleado mostrar = new frmReporteEmpleado();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            frmReporte2PacienteDepartamento mostrar = new frmReporte2PacienteDepartamento();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            frmReporte1FechasPacientes mostrar = new frmReporte1FechasPacientes();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            frmReporte3CitasAsistidasPacientes mostrar = new frmReporte3CitasAsistidasPacientes();
            this.Hide();
            mostrar.ShowDialog();
            this.Close();
        }
    }
}
