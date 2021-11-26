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
    public partial class frmModificarCita : Form
    {
        string URI_CITA = "https://localhost:44310/api/cita";
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_HORA_CITA = "https://localhost:44310/api/horariocita";
        string URI_MEDICO = "https://localhost:44310/api/medico";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public frmModificarCita()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarCita(Id);
            frmAdministrarCitas cita = new frmAdministrarCitas();
            this.Hide();
            cita.Show();
            cita.Refresh();
        }

        private async void frmModificarCita_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();

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

        private async void actualizarCita(int id)
        {
            CitaModels cita = new CitaModels();
            cita.Id = id;
            cita.Fecha = Convert.ToDateTime(dtpFecha.Value);
            cita.Asunto = txtAsunto.Text;
            cita.Id_Paciente = Convert.ToInt32(cbxNombrePaciente.SelectedValue);
            cita.Id_Horario = Convert.ToInt32(cbxHora.SelectedValue);
            cita.Id_Medico = Convert.ToInt32(cbxMedico.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_CITA + "/" + cita.Id, cita);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar la cita" + responseMessage.StatusCode);
                }
            }
        }

        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_CITA + "/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        Data = await content.ReadAsStringAsync();
                        if (Data != null)
                        {
                            return Data;

                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void CargarDatos()
        {
            var response = await Get(Id);
            var res = JsonConvert.DeserializeObject<dynamic>(response);
            dtpFecha.Value = res[0].FECHA;
            txtAsunto.Text = res[0].ASUNTO;
            cbxNombrePaciente.Text = res[0].PACIENTE;
            cbxHora.Text = res[0].HORA_CITA;
            cbxMedico.Text = res[0].MEDICO;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarCitas regresar = new frmAdministrarCitas();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
