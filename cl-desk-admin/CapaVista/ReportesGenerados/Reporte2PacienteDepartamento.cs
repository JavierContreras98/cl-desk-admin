using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;

namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    public partial class frmReporte2PacienteDepartamento : Form
    {
        public frmReporte2PacienteDepartamento()
        {
            InitializeComponent();
        }

        int iddepto;

        public int Iddepto { get => iddepto; set => iddepto = value; }

        private void frmReportePacienteDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cLCARMELODBDataSet2.SP_CREATE_REPORT2' Puede moverla o quitarla según sea necesario.
           
            List<DepartamentoModels> lst = new List<DepartamentoModels>();
            cbxDepartamentos.DataSource = lst;
            cbxDepartamentos.ValueMember = "ID";
            cbxDepartamentos.DisplayMember = "NOMBRE";
            cbxDepartamentos.Refresh();


            this.sP_CREATE_REPORT2TableAdapter.Fill(this.cLCARMELODBDataSet2.SP_CREATE_REPORT2, Iddepto);
            this.rvPacientesDepto.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rvPacientesDepto.LocalReport.Refresh();

            frmReporte2PacienteDepartamento Mostrar = new frmReporte2PacienteDepartamento();
            Mostrar.Iddepto = Convert.ToInt32(cbxDepartamentos.SelectedValue); 
            Mostrar.ShowDialog();

        }
    }
}
