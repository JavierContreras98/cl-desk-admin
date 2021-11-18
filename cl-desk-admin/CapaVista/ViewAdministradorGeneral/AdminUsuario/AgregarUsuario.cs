using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminUsuario
{
    public partial class frmAgregarUsuario : Form
    {
        string URI = "https://localhost:44310/api/tipo_usuario";
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private async void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Root> lst = JsonConvert.DeserializeObject<List<Root>>(respuesta);
            cbxUsuario.DataSource = lst;
            cbxUsuario.DisplayMember = "";
            cbxUsuario.ValueMember = "NOMBRE";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

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
    }
}
