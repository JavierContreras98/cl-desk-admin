using cl_desk_admin.CapaModels;
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

        public AgregarTipoDocumento()
        {
            InitializeComponent();

            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RunAsync(txtNombre.Text, txtDescripcion.Text).GetAwaiter().GetResult();

            
        }

        static async Task<Uri> CreateTipoDocumentoAsync(Tipo_DocumentoModels tipodocumento)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api/tipo_documento", tipodocumento);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;
        }

        static async Task RunAsync(string nombre, string descripcion)
        {
            client.BaseAddress = new Uri("https://localhost:44310/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Tipo_DocumentoModels tipodocumento = new Tipo_DocumentoModels
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                };

                var url = await CreateTipoDocumentoAsync(tipodocumento);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
