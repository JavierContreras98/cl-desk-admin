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
using cl_desk_admin.CapaVista.ViewAdministradorGeneral;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPais
{
    public partial class frmAdministrarPais : Form
    {
        string URI = "https://localhost:44310/api/pais";
        public frmAdministrarPais()
        {
            InitializeComponent();
        }

        private async void frmAdministrarPais_Load(object sender, EventArgs e)
        {
            dgvPais.Refresh();
            this.Refresh();
            GetAllPais();
            radioButtonValidation();
        }

        private async void GetAllPais()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var PaisJsonString = await response.Content.ReadAsStringAsync();
                        dgvPais.DataSource = JsonConvert.DeserializeObject<PaisModels[]>(PaisJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los paises " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrearPais_Click(object sender, EventArgs e)
        {
            frmAgregarPais agregarpais = new frmAgregarPais();
            this.Hide();
            agregarpais.Show();
        }

        private void btnModificarPais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un pais debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarPais modificarpais = new frmModificarPais();
                modificarpais.Id = Convert.ToInt32(txtNumero.Text);
                modificarpais.Show();
                this.Hide();
            }
        }
        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarPais.Enabled = false;
            btnModificarPais.Enabled = false;

            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarPais.Enabled = true;
                btnEliminarPais.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarPais.Enabled = true;
                btnModificarPais.Enabled = false;
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

        private void btnEliminarPais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un tipo de documento debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeletePais(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }
        private async void DeletePais(int id)
        {
            int PaisID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, PaisID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el tipo de documento " + responseMessage.StatusCode);
                }
            }
            GetAllPais();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmMenuAdminGeneral menuPricipal = new frmMenuAdminGeneral();

            this.Hide();
            menuPricipal.ShowDialog();
            this.Close();
        }
    }
}
