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
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class AdministrarTipoDocumento : Form
    {
        string url = "https://localhost:44310/api/tipo_documento";
        public AdministrarTipoDocumento()
        {
            InitializeComponent();
        }

        private async void AdministrarTipoDocumento_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Tipo_DocumentoModels> lst = JsonConvert.DeserializeObject<List<Tipo_DocumentoModels>>(respuesta);
            dgvTipoDocumento.DataSource = lst;
        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oReponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oReponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnCrearTipoDocumento_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminTipoDocumento.AgregarTipoDocumento crear = new AgregarTipoDocumento();
            crear.Show();
        }
    }
}
