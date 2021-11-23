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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoSangre
{
    public partial class frmAgregarTipoSangre : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/tipo_sangre";
        public frmAgregarTipoSangre()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddTiposangre();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            frmAdministrarTipoSangre tiposangre = new frmAdministrarTipoSangre();
            this.Close();
            tiposangre.Refresh();
            tiposangre.Show();
        }

        private async void AddTiposangre()
        {
            Tipo_SangreModels tiposangre = new Tipo_SangreModels();
            tiposangre.Nombre= txtNombre.Text;

            using (var client = new HttpClient())
            {
                var serializedTipoDocumento = JsonConvert.SerializeObject(tiposangre);
                var content = new StringContent(serializedTipoDocumento, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private void AgregarTipoSangre_Load(object sender, EventArgs e)
        {

        }
    }
}
