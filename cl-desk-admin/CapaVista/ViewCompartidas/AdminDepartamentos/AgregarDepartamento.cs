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
    public partial class frmAgregarDepartamento : Form
    {

        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";

        string URI_PAIS = "https://localhost:44310/api/pais";



        public frmAgregarDepartamento()
        {
            InitializeComponent();
        }

        private async void frmAgregarDepartamento_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PaisModels> lst = JsonConvert.DeserializeObject<List<PaisModels>>(respuesta);
            cbxPais.DataSource = lst;
            cbxPais.ValueMember = "ID";
            cbxPais.DisplayMember = "NOMBRE";
            cbxPais.Refresh();
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_PAIS);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddDepartamento();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            frmAdministrarDepartamentos departamentos = new frmAdministrarDepartamentos();
            this.Hide();
            departamentos.Refresh();
            departamentos.ShowDialog();
            this.Close();
        }

        private async void AddDepartamento()
        {
            DepartamentoModels departamento = new DepartamentoModels();
            departamento.Nombre = txtNombre.Text;
            departamento.Id_pais = Convert.ToInt32(cbxPais.SelectedValue);

            using (var client = new HttpClient())
            {
                var serializedPais = JsonConvert.SerializeObject(departamento);
                var content = new StringContent(serializedPais, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI_DEPARTAMENTO, content);
            }
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
