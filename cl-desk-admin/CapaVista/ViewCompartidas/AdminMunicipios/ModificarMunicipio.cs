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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminMunicipios
{
    public partial class frmModificarMunicipio : Form
    {
        string URI_MUNICIPIO = "https://localhost:44310/api/municipio";

        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public frmModificarMunicipio()
        {
            InitializeComponent();
        }

        private async void frmModificarMunicipio_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();

            string respuesta = await GetHttp();
            List<DepartamentoModels> lst = JsonConvert.DeserializeObject<List<DepartamentoModels>>(respuesta);
            cbxDepartamento.DataSource = lst;
            cbxDepartamento.ValueMember = "ID";
            cbxDepartamento.DisplayMember = "NOMBRE";
            cbxDepartamento.Refresh();
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_DEPARTAMENTO) ;
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_MUNICIPIO + "/" + id))
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
            txtNombre.Text = res[0].MUNICIPIO;
            cbxDepartamento.Text = res[0].DEPARTAMENTO;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarMunicipio(Id);
            frmAdministrarMunicipios municipios = new frmAdministrarMunicipios();
            this.Hide();
            municipios.Show();
            municipios.Refresh();
        }

        private async void actualizarMunicipio(int id)
        {
            MunicipioModels municipio = new MunicipioModels();
            municipio.Id = id;
            municipio.Nombre = txtNombre.Text;
            municipio.Id_departamento = Convert.ToInt32(cbxDepartamento.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_MUNICIPIO + "/" + municipio.Id, municipio);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el departamento " + responseMessage.StatusCode);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarMunicipios regresar = new frmAdministrarMunicipios();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
