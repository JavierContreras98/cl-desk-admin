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

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    public partial class frmModificarTipoUsuario : Form
    {
        string URI = "https://localhost:44310/api/tipo_usuario";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public frmModificarTipoUsuario()
        {
            InitializeComponent();
        }

        private void frmModificarTipoUsuario_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarTipoUsuario(Id);
            frmAdministrarTipoUsuario tipousuario = new frmAdministrarTipoUsuario();
            this.Hide();
            tipousuario.Show();
            tipousuario.Refresh();
        }

        private async void actualizarTipoUsuario(int id)
        {
            Tipo_UsuarioModels tipousuario = new Tipo_UsuarioModels();
            tipousuario.Id = id;
            tipousuario.Nombre = txtNombre.Text;
            tipousuario.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + tipousuario.Id, tipousuario);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el Tipo de usuario " + responseMessage.StatusCode);
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
            frmAdministrarTipoUsuario regresar = new frmAdministrarTipoUsuario();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
