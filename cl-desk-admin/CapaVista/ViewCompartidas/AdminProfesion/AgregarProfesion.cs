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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminProfesion
{
    public partial class AgregarProfesion : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/profesion";
        public AgregarProfesion()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddProfesion();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            AdministrarProfesion profesion = new AdministrarProfesion();
            this.Hide();
            profesion.Refresh();
            profesion.ShowDialog();
            this.Close();
        }

        private async void AddProfesion()
        {
            ProfesionModels profesion = new ProfesionModels();
            profesion.Nombre = txtNombre.Text;
            profesion.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                var serializedProfesion = JsonConvert.SerializeObject(profesion);
                var content = new StringContent(serializedProfesion, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministrarProfesion regresar = new AdministrarProfesion();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
