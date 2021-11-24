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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPacientes
{
    public partial class frmModificarPaciente : Form
    {
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_TIPO_SANGRE = "https://localhost:44310/api/tipo_sangre";
        string URI_PAIS = "https://localhost:44310/api/pais";
        string URI_TIPO_DOC = "https://localhost:44310/api/tipo_documento";
        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";
        string URI_MUNICIPIO = "https://localhost:44310/api/municipio";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public frmModificarPaciente()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarPaciente(Id);
            frmAdministrarPacientes paciente = new frmAdministrarPacientes();
            this.Hide();
            paciente.Show();
            paciente.Refresh();
        }

        private async void frmModificarPaciente_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();

            string respuesta = await GetHttpPais();
            List<PaisModels> lst = JsonConvert.DeserializeObject<List<PaisModels>>(respuesta);
            cbxPais.DataSource = lst;
            cbxPais.ValueMember = "ID";
            cbxPais.DisplayMember = "NOMBRE";
            cbxPais.Refresh();

            string respuesta2 = await GetHttpSangre();
            List<Tipo_SangreModels> lst2 = JsonConvert.DeserializeObject<List<Tipo_SangreModels>>(respuesta2);
            cbxtiposangre.DataSource = lst2;
            cbxtiposangre.ValueMember = "ID";
            cbxtiposangre.DisplayMember = "NOMBRE";
            cbxtiposangre.Refresh();

            string respuesta3 = await GetHttpDocumento();
            List<Tipo_DocumentoModels> lst3 = JsonConvert.DeserializeObject<List<Tipo_DocumentoModels>>(respuesta3);
            cbxTipoDocumento.DataSource = lst3;
            cbxTipoDocumento.ValueMember = "ID";
            cbxTipoDocumento.DisplayMember = "NOMBRE";
            cbxTipoDocumento.Refresh();

            string respuesta4 = await GetHttpDepartamento();
            List<DepartamentoModels> lst4 = JsonConvert.DeserializeObject<List<DepartamentoModels>>(respuesta4);
            cbxDepartamento.DataSource = lst4;
            cbxDepartamento.ValueMember = "ID";
            cbxDepartamento.DisplayMember = "NOMBRE";
            cbxDepartamento.Refresh();

            string respuesta5 = await GetHttpMunicipio();
            List<MunicipioModels> lst5 = JsonConvert.DeserializeObject<List<MunicipioModels>>(respuesta5);
            cbxMunicipio.DataSource = lst5;
            cbxMunicipio.ValueMember = "ID";
            cbxMunicipio.DisplayMember = "NOMBRE";
            cbxMunicipio.Refresh();

        }

        private async void actualizarPaciente(int id)
        {
            PacienteModels paciente = new PacienteModels();
            paciente.Id = id;
            paciente.Num_expediente = txtExpediente.Text;
            paciente.Primer_nom = txtPrimerNombre.Text;
            paciente.Segundo_nom = txtSegundoNombre.Text;
            paciente.Primer_ape = txtPrimerApellido.Text;
            paciente.Segundo_ape = SegundoApellido.Text;
            paciente.Fecha_nacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            paciente.Telefono = txtTelefono.Text;
            paciente.Num_documento = txtNumeroDocumento.Text;
            paciente.Id_tipo_sangre = Convert.ToInt32(cbxtiposangre.SelectedValue);
            paciente.Id_pais = Convert.ToInt32(cbxPais.SelectedValue);
            paciente.Id_departamento = Convert.ToInt32(cbxDepartamento.SelectedValue);
            paciente.Id_municipio = Convert.ToInt32(cbxMunicipio.SelectedValue);
            paciente.Id_tipo_doc = Convert.ToInt32(cbxTipoDocumento.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_PACIENTE + "/" + paciente.Id, paciente);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el paciente" + responseMessage.StatusCode);
                }
            }
        }
        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_PACIENTE + "/" + id))
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
            txtExpediente.Text = res[0].NUM_EXPEDIENTE;
            txtPrimerNombre.Text = res[0].PRIMER_NOM;
            txtSegundoNombre.Text = res[0].SEGUNDO_NOM;
            txtPrimerApellido.Text = res[0].PRIMER_APE;
            SegundoApellido.Text = res[0].SEGUNDO_APE;
            dtpFechaNacimiento.Value = res[0].FECHA_NACIMIENTO;
            txtTelefono.Text = res[0].TELEFONO;
            txtNumeroDocumento.Text = res[0].NUM_DOCUMENTO;
            cbxtiposangre.Text = res[0].TIPO_SANGRE;
            cbxPais.Text = res[0].PAIS;
            cbxDepartamento.Text = res[0].DEPARTAMENTO;
            cbxMunicipio.Text = res[0].MUNICIPIO;
            cbxTipoDocumento.Text = res[0].TIPO_DOC;
            
        }

        private async Task<string> GetHttpPais()
        {
            WebRequest oRequest = WebRequest.Create(URI_PAIS);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpSangre()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_SANGRE);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpDocumento()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_DOC);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpDepartamento()
        {
            WebRequest oRequest = WebRequest.Create(URI_DEPARTAMENTO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpMunicipio()
        {
            WebRequest oRequest = WebRequest.Create(URI_MUNICIPIO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           frmAdministrarPacientes regresar = new frmAdministrarPacientes();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
