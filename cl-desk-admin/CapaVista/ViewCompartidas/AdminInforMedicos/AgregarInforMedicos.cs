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
    public partial class AgregarInforMedicos : Form
    {
        string URI_MEDICO = "https://localhost:44310/api/medico";

        string URI_EMPLEADO = "https://localhost:44310/api/empleado";

        string URI_ESPECIALIDAD = "https://localhost:44310/api/especialidad";

        public AgregarInforMedicos()
        {
            InitializeComponent();
        }

        private async void AgregarInforMedicos_Load(object sender, EventArgs e)
        {
            string empleado = await GetHttpEmpleado();
            List<EmpleadoModels> lstEmpleado = JsonConvert.DeserializeObject<List<EmpleadoModels>>(empleado);
            cbxEmpleado.DataSource = lstEmpleado;
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

        private void btnCrearnfoMedico_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddDepartamento();

                frmAdminInforMedicos infomedicos = new frmAdminInforMedicos();
                this.Close();
                infomedicos.Refresh();
                infomedicos.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
        }

        private async void AddDepartamento()
        {
            MedicoModels medico = new MedicoModels();
            medico.Dias_De_Llegada = txtDiasdeLlegada.Text;
            medico.Hora_Entrada = TimeSpan.Parse(txtHoraEntrada.Text);
            medico.Hora_Salida = TimeSpan.Parse(txtHoraEntrada.Text);
            medico.Id_Empleado = Convert.ToInt32(cbxEmpleado.SelectedValue);
            medico.Id_Especialidad = Convert.ToInt32(cbxEspecialidad.SelectedValue);

            using (var client = new HttpClient())
            {
                var serializedMedico = JsonConvert.SerializeObject(medico);
                var content = new StringContent(serializedMedico, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI_MEDICO, content);
            }
        }

        private void btnCancelarInfoMedico_Click(object sender, EventArgs e)
        {
            frmAdminInforMedicos regresar = new frmAdminInforMedicos();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
