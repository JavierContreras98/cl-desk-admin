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
    public partial class AdministrarHorarioCitas : Form
    {
        string URI = "https://localhost:44310/api/HorarioCita";

        public AdministrarHorarioCitas()
        {
            InitializeComponent();
        }

        private async void AdministrarHorarioCitas_Load(object sender, EventArgs e)
        {
            dgvHorariocitas.Refresh();
            this.Refresh();
            GetAllProdutos();
            radioButtonValidation();
        }

        private async void GetAllProdutos()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var horarioJsonString = await response.Content.ReadAsStringAsync();
                        dgvHorariocitas.DataSource = JsonConvert.DeserializeObject<HorarioCitaModels[]>(horarioJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los horarios citas " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarHorarioCita agregar  = new AgregarHorarioCita();
            this.Hide();
            agregar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un tipo de documento debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                ModificarHorarioCita modificar = new ModificarHorarioCita();
                modificar.Id = Convert.ToInt32(txtNumero.Text);
                modificar.Show();
                this.Hide();
            }
        }

        public void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = false;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un tipo de horario cita debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                Deletehorariocita(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void Deletehorariocita(int id)
        {
            int horariocitaID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, horariocitaID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el horario cita " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

    }
}

