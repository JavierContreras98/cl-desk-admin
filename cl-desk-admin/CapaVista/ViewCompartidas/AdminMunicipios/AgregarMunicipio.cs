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
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminMunicipios
{
    public partial class frmAgregarMunicipio : Form
    {
        string URI_MUNICIPIO = "https://localhost:44310/api/municipio";

        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";

        public frmAgregarMunicipio()
        {
            InitializeComponent();
        }

        private async void frmAgregarMunicipio_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<DepartamentoModels> lst = JsonConvert.DeserializeObject<List<DepartamentoModels>>(respuesta);
            cbxDepartamento.DataSource = lst;
            cbxDepartamento.ValueMember = "ID";
            cbxDepartamento.DisplayMember = "NOMBRE";
            cbxDepartamento.Refresh();
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_DEPARTAMENTO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddMunicipio();

                frmAdministrarMunicipios municipios = new frmAdministrarMunicipios();
                this.Close();
                municipios.Refresh();
                municipios.Show();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            } 
        }

        private async void AddMunicipio()
        {
            MunicipioModels municipio = new MunicipioModels();
            municipio.Nombre = txtNombre.Text;
            municipio.Id_departamento = Convert.ToInt32(cbxDepartamento.SelectedValue);

            using (var client = new HttpClient())
            {
                var serializedMunicipio = JsonConvert.SerializeObject(municipio);
                var content = new StringContent(serializedMunicipio, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI_MUNICIPIO, content);
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
