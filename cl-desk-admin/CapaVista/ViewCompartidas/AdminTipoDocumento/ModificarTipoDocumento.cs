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
using System.Web;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
using RestSharp;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class ModificarTipoDocumento : Form
    {
        string URI = "https://localhost:44310/api/tipo_documento";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public ModificarTipoDocumento()
        {
            InitializeComponent();
        }

        private void ModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarTipoDocumento(Id);
            AdministrarTipoDocumento tipodocumento = new AdministrarTipoDocumento();
            this.Hide();
            tipodocumento.Show();
            tipodocumento.Refresh();
        }

        private async void actualizarTipoDocumento(int id)
        {
            Tipo_DocumentoModels tipodocumento = new Tipo_DocumentoModels();
            tipodocumento.Id = id;
            tipodocumento.Nombre = txtNombre.Text;
            tipodocumento.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + tipodocumento.Id, tipodocumento);
                if (responseMessage.IsSuccessStatusCode)
                {
                    
                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el Tipo de Documento " + responseMessage.StatusCode);
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

    }
}
