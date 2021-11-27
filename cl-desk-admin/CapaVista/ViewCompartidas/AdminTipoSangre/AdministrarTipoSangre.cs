using cl_desk_admin.CapaModels;
using cl_desk_admin.CapaVista.ViewAdministradorGeneral;
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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoSangre
{
    public partial class frmAdministrarTipoSangre : Form
    {
        string URI = "https://localhost:44310/api/tipo_sangre";
        public frmAdministrarTipoSangre()
        {
            InitializeComponent();
        }
        private async void AdministrarTipoSangre_Load(object sender, EventArgs e)
        {
            dgvTipoSangre.Refresh();
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
                        var TiposangreJsonString = await response.Content.ReadAsStringAsync();
                        dgvTipoSangre.DataSource = JsonConvert.DeserializeObject<Tipo_SangreModels[]>(TiposangreJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los tipos de sangre " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAgregarTipoSangre agregartiposangre = new frmAgregarTipoSangre();
            this.Hide();
            agregartiposangre.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un tipo de sangre debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarTipoSangre modificarTipoSangre = new frmModificarTipoSangre();
                modificarTipoSangre.Id = Convert.ToInt32(txtNumero.Text);
                modificarTipoSangre.Show();
                this.Hide();
            }
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
                    MessageBox.Show("Para eliminar un tipo de sangre debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteTipoSangre(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }
        private async void DeleteTipoSangre(int id)
        {
            int TipoSangreID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, TipoSangreID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el tipo de sangre " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

        private void btnMenuP_Click(object sender, EventArgs e)
        {
            frmMenuAdminGeneral menuPricipal = new frmMenuAdminGeneral();

            this.Hide();
            menuPricipal.ShowDialog();
            this.Close();
        }
    }
}
