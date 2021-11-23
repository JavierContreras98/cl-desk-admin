using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaVista.ViewCompartidas;
using System.Net;
using System.IO;
using System.Net.Http;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEmpleados
{
    public partial class frmAdministrarEmpleados : Form
    {

        string URI_EMPLEADO = "https://localhost:44310/api/Empleado";

        string URI_TIPO_DOCUMENTO = "https://localhost:44310/api/tipo_documento";

        string URI_PROFESION = "https://localhost:44310/api/profesion";

        string URI_USUARIO = "https://localhost:44310/api/Usuario";

        int id;

        string data;
        public frmAdministrarEmpleados()
        {
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        private async void frmAdministrarEmpleados_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();

            string respuesta = await GetHttp();
            List<PaisModels> lst = JsonConvert.DeserializeObject<List<PaisModels>>(respuesta);
            cbxPais.DataSource = lst;
            cbxPais.ValueMember = "ID";
            cbxPais.DisplayMember = "NOMBRE";
            cbxPais.Refresh();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            actualizarEmpleado(Id);
            frmAdministrarEmpleados empleado = new frmAdministrarEmpleados();
            this.Hide();
            empleado.Show();
            empleado.Refresh();
        }

        private async void actualizarEmpleado(int id)
        {
            DepartamentoModels departamento = new DepartamentoModels();
            departamento.Id = id;
            departamento.Nombre = txtNombre.Text;
            departamento.Id_pais = Convert.ToInt32(cbxPais.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_EMPLEADO + "/" + departamento.Id, departamento);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el departamento " + responseMessage.StatusCode);
                }
            }
        }

        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_EMPLEADO + "/" + id))
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
           // txtNombre.Text = res[0].DEPARTAMENTO;
           // cbxPais.Text = res[0].PAIS;
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_DOCUMENTO);
            //WebRequest oRequest = WebRequest.Create(URI_PROFESION);
           // WebRequest oRequest = WebRequest.Create(URI_TIPO_DOCUMENTO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

    }
}
