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
                this.AddProduto();
            }catch(Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            AdministrarTipoDocumento tipodocumento = new AdministrarTipoDocumento();
            this.Close();
            tipodocumento.Show();
        }

        private async void AddProduto()
        {
            URI = URI;
            Tipo_DocumentoModels tipodocumento = new Tipo_DocumentoModels();
            //prod.Id = codProduto;
            tipodocumento.Nombre = txtNombre.Text;
            tipodocumento.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(tipodocumento);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }


        private void AgregarTipoDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
