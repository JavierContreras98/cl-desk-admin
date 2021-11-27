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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPais
{
    public partial class frmAgregarPais : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/pais";
        public frmAgregarPais()
        {
            InitializeComponent();
        }

        private void frmAgregarPais_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddPais();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            frmAdministrarPais pais = new frmAdministrarPais();
            this.Hide();
            pais.Refresh();
            pais.ShowDialog();
            this.Close();

        }

        private async void AddPais()
        {
            PaisModels pais = new PaisModels();
            pais.Nombre = txtNombre.Text;

            using (var client = new HttpClient())
            {
                var serializedPais = JsonConvert.SerializeObject(pais);
                var content = new StringContent(serializedPais, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

    }
}
