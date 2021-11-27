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
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminCitas
{
    public partial class frmAgregarCita : Form
    {
        string URI_CITA = "https://localhost:44310/api/cita";
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_HORA_CITA = "https://localhost:44310/api/horariocita";
        string URI_MEDICO = "https://localhost:44310/api/medico";
        public frmAgregarCita()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddCita();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            frmAdministrarCitas cita = new frmAdministrarCitas();
            this.Hide();
            cita.Refresh();
            cita.ShowDialog();
            this.Close();
        }

        private async void frmAgregarCita_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttpPaciente();
            List<PacienteModels> lst = JsonConvert.DeserializeObject<List<PacienteModels>>(respuesta);
            cbxNombrePaciente.DataSource = lst;
            cbxNombrePaciente.ValueMember = "ID";
            cbxNombrePaciente.DisplayMember = "PRIMER_NOM";
            cbxNombrePaciente.Refresh();

            string respuesta2 = await GetHttpHoracita();
            List<HorarioCitaModels> lst2 = JsonConvert.DeserializeObject<List<HorarioCitaModels>>(respuesta2);
            cbxHora.DataSource = lst2;
            cbxHora.ValueMember = "ID";
            cbxHora.DisplayMember = "HORA_CITA";
            cbxHora.Refresh();

            string respuesta3 = await GetHttpMedico();
            List<MedicoModels> lst3 = JsonConvert.DeserializeObject<List<MedicoModels>>(respuesta3);
            cbxMedico.DataSource = lst3;
            cbxMedico.ValueMember = "ID";
            cbxMedico.DisplayMember = "EMPLEADO";
            cbxMedico.Refresh();
        }

        private async Task<string> GetHttpPaciente()
        {
            WebRequest oRequest = WebRequest.Create(URI_PACIENTE);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpHoracita()
        {
            WebRequest oRequest = WebRequest.Create(URI_HORA_CITA);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpMedico()
        {
            WebRequest oRequest = WebRequest.Create(URI_MEDICO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async void AddCita()
        {
            CitaModels cita = new CitaModels();
            cita.Fecha = Convert.ToDateTime(dtpFecha.Value);
            cita.Asunto = txtAsunto.Text;
            cita.Id_Paciente = Convert.ToInt32(cbxNombrePaciente.SelectedValue);
            cita.Id_Horario = Convert.ToInt32(cbxHora.SelectedValue);
            cita.Id_Medico = Convert.ToInt32(cbxMedico.SelectedValue);
            

            using (var client = new HttpClient())
            {
                var serializedcita = JsonConvert.SerializeObject(cita);
                var content = new StringContent(serializedcita, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI_CITA, content);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarCitas regresar = new frmAdministrarCitas();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
