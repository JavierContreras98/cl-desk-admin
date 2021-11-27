using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    public partial class frmAgregarTipoUsuario : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/tipo_usuario";
        public frmAgregarTipoUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddTipousuario();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            frmAdministrarTipoUsuario tipousuario = new frmAdministrarTipoUsuario();

            this.Hide();
            tipousuario.ShowDialog();
            tipousuario.Refresh();
            this.Close();
        }

        private async void AddTipousuario()
        {
            Tipo_UsuarioModels tipousuario = new Tipo_UsuarioModels();
            tipousuario.Nombre = txtNombre.Text;
            tipousuario.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                var serializedTipoUsuario = JsonConvert.SerializeObject(tipousuario);
                var content = new StringContent(serializedTipoUsuario, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
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
