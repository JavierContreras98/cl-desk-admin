using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    public partial class frmReporte2PacienteDepartamento : Form
    {
        string URI_DEPTO = "https://localhost:44310/api/Departamento";
        public frmReporte2PacienteDepartamento()
        {
            InitializeComponent();
        }

        int iddepto;

        public int Iddepto { get => iddepto; set => iddepto = value; }

        private async void frmReportePacienteDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cLCARMELODBDataSet2.SP_CREATE_REPORT2' Puede moverla o quitarla según sea necesario.


            string respuesta = await GetHttp();
            DataTable lst = JsonConvert.DeserializeObject<DataTable>(respuesta);
            cbxDepartamentos.DataSource = lst;
            cbxDepartamentos.ValueMember = "ID";
            cbxDepartamentos.DisplayMember = "DEPARTAMENTO";
            cbxDepartamentos.Refresh();


            this.sP_CREATE_REPORT2TableAdapter.Fill(this.cLCARMELODBDataSet2.SP_CREATE_REPORT2, Iddepto);
            this.rvPacientesDepto.RefreshReport();
        }
        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_DEPTO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rvPacientesDepto.LocalReport.Refresh();

            frmReporte2PacienteDepartamento Mostrar = new frmReporte2PacienteDepartamento();
            this.Hide();

            Mostrar.Iddepto = Convert.ToInt32(cbxDepartamentos.SelectedValue); 
            Mostrar.ShowDialog();

            this.Close();

        }
    }
}
