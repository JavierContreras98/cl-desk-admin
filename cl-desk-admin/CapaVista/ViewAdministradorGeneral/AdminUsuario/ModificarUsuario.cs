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

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminUsuario
{
    public partial class ModificarUsuario : Form
    {
        string URI = "https://localhost:44310/api/usuario";

        string URI2 = "https://localhost:44310/api/tipo_usuario";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private async void ModificarUsuario_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Root> lst = JsonConvert.DeserializeObject<List<Root>>(respuesta);
            cbxUsuario.DataSource = lst;
            cbxUsuario.ValueMember = "ID";
            cbxUsuario.DisplayMember = "NOMBRE";
            cbxUsuario.Refresh();

            lblId.Text = Id.ToString();
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarUsuario(Id);
            frmAdministrarUsuario usuario = new frmAdministrarUsuario();
            this.Hide();
            usuario.Show();
            usuario.Refresh();
        }

        private async void actualizarUsuario(int id)
        {
            UsuarioModels usuario = new UsuarioModels();
            usuario.Id = id;
            usuario.Nom_Usuario = txtNombre.Text;
            usuario.Pass = txtDescripcion.Text;
            usuario.Id_Tipo = Convert.ToInt32(cbxUsuario.SelectedValue);

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + usuario.Id, usuario);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el Usuario " + responseMessage.StatusCode);
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
            txtNombre.Text = res[0].NOM_USUARIO;
            txtDescripcion.Text = res[0].PASS;
            cbxUsuario = res[0].ID_TIPO;
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI2);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        //Root DeserializedTipoUsuario = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public int ID { get; set; }
            public string NOMBRE { get; set; }
            public string DESCRIPCION { get; set; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarUsuario regresar = new frmAdministrarUsuario();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
