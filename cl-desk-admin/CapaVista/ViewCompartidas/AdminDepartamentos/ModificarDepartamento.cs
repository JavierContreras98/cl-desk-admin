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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminDepartamentos
{
    public partial class frmModificarDepartamento : Form
    {
        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";

        string URI_PAIS = "https://localhost:44310/api/pais";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public frmModificarDepartamento()
        {
            InitializeComponent();
        }

        private async void frmModificarDepartamento_Load(object sender, EventArgs e)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarDepartamento(Id);
            frmAdministrarDepartamentos departamentos = new frmAdministrarDepartamentos();
            this.Hide();
            departamentos.Show();
            departamentos.Refresh();
        }

        private async void actualizarDepartamento(int id)
        {
            DepartamentoModels departamento = new DepartamentoModels();
            departamento.Id = id;
            departamento.Nombre = txtNombre.Text;
            departamento.Id_pais = Convert.ToInt32(cbxPais.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_DEPARTAMENTO + "/" + departamento.Id, departamento);
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
                using (HttpResponseMessage res = await client.GetAsync(URI_DEPARTAMENTO + "/" + id))
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
            txtNombre.Text = res[0].DEPARTAMENTO;
            cbxPais.Text = res[0].PAIS;
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_PAIS);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
