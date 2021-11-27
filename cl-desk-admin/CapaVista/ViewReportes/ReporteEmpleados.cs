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
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetPrincipal.SP_CREATE_REPORT4' Puede moverla o quitarla según sea necesario.
            this.sP_CREATE_REPORT4TableAdapter.Fill(this.dataSetPrincipal.SP_CREATE_REPORT4);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
