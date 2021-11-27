using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
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

namespace cl_desk_admin.CapaVista.ReportesGenerados
{
    public partial class frmReporte3CitasAsistidasPacientes : Form
    {

        string URI_PACIENTE = "https://localhost:44310/api/Paciente";
        public frmReporte3CitasAsistidasPacientes()
        {
            InitializeComponent();
        }

        private DateTime fecha2;
        private DateTime fecha1;
        int id;

        public DateTime Fecha1 { get => fecha1; set => fecha1 = value; }
        public DateTime Fecha2 { get => fecha2; set => fecha2 = value; }
        public int Id { get => id; set => id = value; }

        private async void frmReporte3CitasAsistidasPacientes_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PacienteModels> lst = JsonConvert.DeserializeObject<List<PacienteModels>>(respuesta);
            cbxPaciente.DataSource = lst;
            cbxPaciente.ValueMember = "ID";
            cbxPaciente.DisplayMember = "PRIMER_NOM";
            cbxPaciente.Refresh();


            this.sP_CREATE_REPORT3TableAdapter.Fill(this.cLCARMELODBDataSet3.SP_CREATE_REPORT3, Fecha1, Fecha2,Id);
            this.rvPacienteDepartamento.RefreshReport();
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_PACIENTE);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();


        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            rvPacienteDepartamento.LocalReport.Refresh();

            frmReporte3CitasAsistidasPacientes Mostrar = new frmReporte3CitasAsistidasPacientes();
            this.Hide();

            Mostrar.Fecha1 = dtpFechaInicial.Value;
            Mostrar.Fecha2 = dtFechaFinal.Value;
            Mostrar.Id =Convert.ToInt32(cbxPaciente.SelectedValue);

            Mostrar.ShowDialog();

            this.Close();

        }

        
    }
}
