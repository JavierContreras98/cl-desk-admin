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
    //static HttpClient Client = new HttpClient();
    public partial class frmAgregarUsuario : Form
    {
        string URI = "https://localhost:44310/api/tipo_usuario";

        string URI2 = "https://localhost:44310/api/usuario";

        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private async void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Root> lst = JsonConvert.DeserializeObject<List<Root>>(respuesta);
            cbxUsuario.DataSource = lst;
            cbxUsuario.ValueMember = "ID";
            cbxUsuario.DisplayMember = "NOMBRE";
            cbxUsuario.Refresh();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddUsuario();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            frmAdministrarUsuario adminUsuario = new frmAdministrarUsuario();
            this.Close();
            adminUsuario.Refresh();
            adminUsuario.Show();
        }

        private async void AddUsuario()
        {
            UsuarioModels usuario = new UsuarioModels();
            usuario.Nom_Usuario = txtNombre.Text;
            usuario.Pass = txtDescripcion.Text;
            usuario.Id_Tipo = Convert.ToInt32(cbxUsuario.SelectedValue);

            using (var client = new HttpClient())
            {
                var serializedUsuario = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(serializedUsuario, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI2, content);
            }
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI);
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
