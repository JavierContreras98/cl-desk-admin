using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewReportes
{
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 Salir = new Form1();

            this.Hide();
            Salir.ShowDialog();
            this.Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            ViewAdministradorGeneral.frmMenuAdminGeneral menuPrincipal = new ViewAdministradorGeneral.frmMenuAdminGeneral();
            this.Hide();
            menuPrincipal.ShowDialog();
            this.Close();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            ReporteEmpleados reportEmpleados = new ReporteEmpleados();

            this.Hide();
            reportEmpleados.ShowDialog();
            this.Close();
        }
    }
}
