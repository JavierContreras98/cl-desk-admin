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
using RestSharp;


namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminHorarioCitas
{
    public partial class ModificarHorarioCita : Form
    {
        string URI = "https://localhost:44310/api/HorarioCita";

        int id;

        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public ModificarHorarioCita()
        {
            InitializeComponent();
        }


        private void ModificarHorarioCita_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarhorariocita(Id);
            AdministrarHorarioCitas horariocita = new AdministrarHorarioCitas();
            this.Hide();
            horariocita.Refresh();
            horariocita.ShowDialog();
            this.Close();
        }
        private async void actualizarhorariocita(int id)
        {
            HorarioCitaModels horariocita = new HorarioCitaModels();
            horariocita.Id = id;
            horariocita.Hora_cita =TimeSpan.Parse(txHora.Text);
            
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI + "/" + horariocita.Id, horariocita);
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el horario cita " + responseMessage.StatusCode);
                }
            }
        }

        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI + "/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        Data = await content.ReadAsStringAsync();
                        if (Data != null)
                        {
                            return Data;

                        }
                    }
                }
            }
            return string.Empty;
        }

        private async void CargarDatos()
        {
            var response = await Get(Id);
            var res = JsonConvert.DeserializeObject<dynamic>(response);
            txHora.Text = res[0].HORA_CITA;
           
        }

        private void txthora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
