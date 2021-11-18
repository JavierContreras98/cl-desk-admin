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

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminUsuario
{
    public partial class frmAdministrarUsuario : Form
    {
        string URI = "https://localhost:44310/api/usuario";
        public frmAdministrarUsuario()
        {
            InitializeComponent();
        }

        private async void frmAdministrarUsuario_Load(object sender, EventArgs e)
        {
            GetAllUsuarios();
        }

        private async void GetAllUsuarios()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(UsuarioJsonString);
                        dgvUsuario.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los usuarios " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregarUsuario = new frmAgregarUsuario();
            this.Hide();
            agregarUsuario.Show();
        }
    }
}
