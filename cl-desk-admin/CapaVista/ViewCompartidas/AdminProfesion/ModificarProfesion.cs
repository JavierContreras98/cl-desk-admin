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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminProfesion
{
    public partial class ModificarProfesion : Form
    {
        string URI = "https://localhost:44310/api/profesion";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public ModificarProfesion()
        {
            InitializeComponent();
        }

        private void ModificarProfesion_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarProfesion(Id);
            AdministrarProfesion profesiones = new AdministrarProfesion();
            this.Hide();
            profesiones.Show();
            profesiones.Refresh();
        }

        private async void actualizarProfesion(int id)
        {
            ProfesionModels profesion = new ProfesionModels();
            profesion.Id = id;
            profesion.Nombre = txtNombre.Text;
            profesion.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + profesion.Id, profesion);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar la profesion " + responseMessage.StatusCode);
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
            txtDescripcion.Text = res[0].DESCRIPCION;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministrarProfesion regresar = new AdministrarProfesion();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
