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
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEspecialidades
{
    public partial class frmModificarEspecialidades : Form
    {
        string URI = "https://localhost:44310/api/especialidad";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public frmModificarEspecialidades()
        {
            InitializeComponent();
        }
        private void frmModificarEspecialidades_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarEspecialidad(Id);
            AdministrarEspecialidades especialidades = new AdministrarEspecialidades();
            this.Hide();
            especialidades.Show();
            especialidades.Refresh();
        }

        private async void actualizarEspecialidad(int id)
        {
            EspecialidadModels especialidad = new EspecialidadModels();
            especialidad.Id = id;
            especialidad.Nombre = txtNombre.Text;
            especialidad.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + especialidad.Id, especialidad);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar la especialidad " + responseMessage.StatusCode);
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
            AdministrarEspecialidades regresar = new AdministrarEspecialidades();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
