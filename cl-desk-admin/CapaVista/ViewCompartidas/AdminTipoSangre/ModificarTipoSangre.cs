using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoSangre
{
    public partial class frmModificarTipoSangre : Form
    {
        string URI = "https://localhost:44310/api/tipo_sangre";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public frmModificarTipoSangre()
        {
            InitializeComponent();
        }

        private void ModificarTipoSangre_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarTipoSangre(Id);
            frmAdministrarTipoSangre tiposangre = new frmAdministrarTipoSangre();
            this.Hide();
            tiposangre.Show();
            tiposangre.Refresh();
        }

        private async void actualizarTipoSangre(int id)
        {
            Tipo_SangreModels tiposangre = new Tipo_SangreModels();
            tiposangre.Id = id;
            tiposangre.Nombre = txtNombre.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + tiposangre.Id, tiposangre);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el Tipo de Sangre " + responseMessage.StatusCode);
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

        private async void CargarDatos()
        {
            var response = await Get(Id);
            var res = JsonConvert.DeserializeObject<dynamic>(response);
            txtNombre.Text = res[0].NOMBRE;
        }

    }
}
