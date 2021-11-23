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
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminHorarioCitas
{
    public partial class AgregarHorarioCita : Form
    {
        static HttpClient client = new HttpClient();

        string URI = "https://localhost:44310/api/HorarioCita";
        public AgregarHorarioCita()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.Addhorario();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            AdministrarHorarioCitas horariocita = new AdministrarHorarioCitas();
            this.Close();
            horariocita.Refresh();
            horariocita.Show();

        }

        private async void Addhorario()
        {
            HorarioCitaModels horario = new HorarioCitaModels();
            horario.Hora_cita = TimeSpan.Parse(txHora.Text);
           

            using (var client = new HttpClient())
            {
                var serializedhorariocita = JsonConvert.SerializeObject(horario);
                var content = new StringContent(serializedhorariocita, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI, content);
            }
        }

        private void AgregarHorarioCita_Load(object sender, EventArgs e)
        {

        }
    }
}

