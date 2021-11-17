using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class AgregarTipoDocumento : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/tipo_documento";

        public AgregarTipoDocumento()
        {
            InitializeComponent();

            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddTipodocumento();
            }catch(Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            AdministrarTipoDocumento tipodocumento = new AdministrarTipoDocumento();
            this.Close();
            tipodocumento.Refresh();
            tipodocumento.Show();
            
        }

        private async void AddTipodocumento()
        {
            Tipo_DocumentoModels tipodocumento = new Tipo_DocumentoModels();
            tipodocumento.Nombre = txtNombre.Text;
            tipodocumento.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                var serializedTipoDocumento = JsonConvert.SerializeObject(tipodocumento);
                var content = new StringContent(serializedTipoDocumento, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }


        private void AgregarTipoDocumento_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
