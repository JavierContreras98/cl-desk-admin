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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminCitas
{
    public partial class frmAdministrarCitas : Form
    {
        string URI_CITA = "https://localhost:44310/api/cita";
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_HORA_CITA = "https://localhost:44310/api/horariocita";
        string URI_EMPLEADO = "https://localhost:44310/api/empleado";
        string URI_MEDICO = "https://localhost:44310/api/medico";
        public frmAdministrarCitas()
        {
            InitializeComponent();
        }

        private void frmAdministrarCitas_Load(object sender, EventArgs e)
        {
            dgvCitas.Refresh();
            this.Refresh();
            GetAllCitas();
            radioButtonValidation();
        }

        private async void GetAllCitas()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_CITA))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var CitaJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(CitaJsonString);
                        dgvCitas.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener las Citas " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrearNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarCita agregarpaciente = new frmAgregarCita();
            this.Hide();
            agregarpaciente.Show();
        }

        private void radioButtonValidation()
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
                    MessageBox.Show("Para eliminar una cita debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteCita(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteCita(int id)
        {
            int CitaID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_CITA);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_CITA, CitaID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar la cita " + responseMessage.StatusCode);
                }
            }
            GetAllCitas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un paciente debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarCita modificarCita = new frmModificarCita();
                modificarCita.Id = Convert.ToInt32(txtNumero.Text);
                modificarCita.Show();
                this.Hide();
            }
        }
    }
}
