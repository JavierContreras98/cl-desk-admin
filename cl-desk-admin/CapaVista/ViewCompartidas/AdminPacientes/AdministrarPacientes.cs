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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPacientes
{
    public partial class frmAdministrarPacientes : Form
    {
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_TIPO_SANGRE= "https://localhost:44310/api/tipo_sangre";
        string URI_PAIS = "https://localhost:44310/api/pais";
        string URI_TIPO_DOC = "https://localhost:44310/api/tipo_documento";
        public frmAdministrarPacientes()
        {
            InitializeComponent();
        }

        private void frmAdministrarPacientes_Load(object sender, EventArgs e)
        {
            dvgAdminPaciente.Refresh();
            this.Refresh();
            GetAllPaciente();
            radioButtonValidation();

        }

        private async void GetAllPaciente()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_PACIENTE))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var PacienteJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(PacienteJsonString);
                        dvgAdminPaciente.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los pacientes " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregarpaciente = new AgregarPaciente();
            this.Hide();
            agregarpaciente.Show();
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnModificar.Enabled = false;

            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificar.Enabled = true;
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
                frmModificarPaciente modificarPaciente = new frmModificarPaciente();
                modificarPaciente.Id = Convert.ToInt32(txtNumero.Text);
                modificarPaciente.Show();
                this.Hide();
            }
        }
    }
}
