using cl_desk_admin.CapaModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        

        private void frmModificarDepartamento_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
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
                using (HttpResponseMessage res = await client.GetAsync(URI + "/" + id))
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

    }
}
