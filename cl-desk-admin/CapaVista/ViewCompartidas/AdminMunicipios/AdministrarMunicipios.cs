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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminMunicipios
{
    public partial class frmAdministrarMunicipios : Form
    {
        string URI_MUNICIPIO = "https://localhost:44310/api/municipio";

        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";
        public frmAdministrarMunicipios()
        {
            InitializeComponent();
        }

        private void frmAdministrarMunicipios_Load(object sender, EventArgs e)
        {
            dgvMunicipios.Refresh();
            this.Refresh();
            GetAllMunicipio();
            radioButtonValidation();
        }

        private async void GetAllMunicipio()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_MUNICIPIO))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var MunicipioJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(MunicipioJsonString);
                        dgvMunicipios.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los municipios " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAgregarMunicipio agregarmunicipio = new frmAgregarMunicipio();
            this.Hide();
            agregarmunicipio.Show();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un municipio debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarMunicipio modificarDepartamento = new frmModificarMunicipio();
                modificarDepartamento.Id = Convert.ToInt32(txtNumero.Text);
                modificarDepartamento.Show();
                this.Hide();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un departamento debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteMunicipio(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteMunicipio(int id)
        {
            int DepartamentoID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_MUNICIPIO);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_MUNICIPIO, DepartamentoID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el municipio " + responseMessage.StatusCode);
                }
            }
            GetAllMunicipio();
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
    }
}
