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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEspecialidades
{
    public partial class frmAgregarEspecialidad : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/especialidad";
        public frmAgregarEspecialidad()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddEspecialidad();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }

            AdministrarEspecialidades especialidades = new AdministrarEspecialidades();
            this.Hide();
            especialidades.Refresh();
            especialidades.ShowDialog();
            this.Close();
        }

        private async void AddEspecialidad()
        {
            EspecialidadModels especialidad = new EspecialidadModels();
            especialidad.Nombre = txtNombre.Text;
            especialidad.Descripcion = txtDescripcion.Text;

            using (var client = new HttpClient())
            {
                var serializedEspecialidad = JsonConvert.SerializeObject(especialidad);
                var content = new StringContent(serializedEspecialidad, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AdministrarEspecialidades regresar = new AdministrarEspecialidades();

            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
