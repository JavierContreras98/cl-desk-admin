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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminInforMedicos
{
    public partial class ModificarInforMedicos : Form
    {
        string URI_MEDICO = "https://localhost:44310/api/medico";

        string URI_EMPLEADO = "https://localhost:44310/api/empleado";

        string URI_ESPECIALIDAD = "https://localhost:44310/api/especialidad";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public ModificarInforMedicos()
        {
            InitializeComponent();
        }

        private async void ModificarInforMedicos_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();

            string empleado = await GetHttpEmpleado();
            List<EmpleadoModels> lst = JsonConvert.DeserializeObject<List<EmpleadoModels>>(empleado);
            cbxEmpleado.DataSource = lst;
            cbxEmpleado.ValueMember = "ID";
            cbxEmpleado.DisplayMember = "PRIMER_NOM";
            cbxEmpleado.Refresh();

            string especialidad = await GetHttpEspecialidad();
            List<EspecialidadModels> lstEspecialidad = JsonConvert.DeserializeObject<List<EspecialidadModels>>(especialidad);
            cbxEspecialidad.DataSource = lstEspecialidad;
            cbxEspecialidad.ValueMember = "ID";
            cbxEspecialidad.DisplayMember = "NOMBRE";
            cbxEspecialidad.Refresh();
        }

        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_MEDICO + "/" + id))
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
            txtDiasdeLlegada.Text = res[0].DIAS_DE_LLEGADA;
            txtHoraEntrada.Text = res[0].HORA_ENTRADA;
            txtHoraSalida.Text = res[0].HORA_SALIDA;
            cbxEmpleado.Text = res[0].NOMBRE;
            cbxEspecialidad.Text = res[0].ESPECIALIDAD;
        }

        private async Task<string> GetHttpEmpleado()
        {
            WebRequest oRequest = WebRequest.Create(URI_EMPLEADO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpEspecialidad()
        {
            WebRequest oRequest = WebRequest.Create(URI_ESPECIALIDAD);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnModificarInfoMedico_Click(object sender, EventArgs e)
        {
            actualizarMedico(Id);

            frmAdminInforMedicos medicos = new frmAdminInforMedicos();
            this.Hide();
            medicos.Show();
            medicos.Refresh();
        }

        private async void actualizarMedico(int id)
        {
            MedicoModels medico = new MedicoModels();
            medico.Id = id;
            medico.Dias_De_Llegada = txtDiasdeLlegada.Text;
            medico.Hora_Entrada = TimeSpan.Parse(txtHoraEntrada.Text);
            medico.Hora_Salida = TimeSpan.Parse(txtHoraEntrada.Text);
            medico.Id_Empleado = Convert.ToInt32(cbxEmpleado.SelectedValue);
            medico.Id_Especialidad = Convert.ToInt32(cbxEspecialidad.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_MEDICO + "/" + medico.Id, medico);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el medico " + responseMessage.StatusCode);
                }
            }
        }
    }
}
