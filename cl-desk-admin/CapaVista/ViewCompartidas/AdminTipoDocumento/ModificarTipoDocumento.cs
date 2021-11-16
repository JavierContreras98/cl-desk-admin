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
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
using RestSharp;
using System.Web;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class ModificarTipoDocumento : Form
    {
        string URI = "https://localhost:44310/api/tipo_documento";

        int id;

        public int Id { get => id; set => id = value; }

        public ModificarTipoDocumento()
        {
            InitializeComponent();
        }

        private void ModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            lblId.Text = Id.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarProducto(Id);
        }


        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }


        private async void actualizarProducto(int id)
        {
            URI = URI;
            Tipo_DocumentoModels tipodocumento = new Tipo_DocumentoModels();
            tipodocumento.Id = id;
            tipodocumento.Nombre = txtNombre.Text;
            tipodocumento.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + tipodocumento.Id, tipodocumento);
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tipo Documento Actualziado");
                }
                else
                {
                    MessageBox.Show("Error:Al intentar axtualizar el Tipo de Documento " + responseMessage.StatusCode);
                }
            }
        }

    }
}
