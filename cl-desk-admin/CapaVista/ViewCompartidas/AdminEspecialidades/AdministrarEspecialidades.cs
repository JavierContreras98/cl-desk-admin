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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEspecialidades
{
    public partial class AdministrarEspecialidades : Form
    {
        string URI = "https://localhost:44310/api/especialidad";
        public AdministrarEspecialidades()
        {
            InitializeComponent();
        }

        private async void AdministrarEspecialidades_Load(object sender, EventArgs e)
        {
            dgvEspecialidad.Refresh();
            this.Refresh();
            GetAllEspecialidades();
            radioButtonValidation();
        }

        private async void GetAllEspecialidades()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EspecialidadJsonString = await response.Content.ReadAsStringAsync();
                        dgvEspecialidad.DataSource = JsonConvert.DeserializeObject<EspecialidadModels[]>(EspecialidadJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener las especialidades " + response.StatusCode);
                    }
                }
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAgregarEspecialidad agregarEspecialidad = new frmAgregarEspecialidad();
            this.Hide();
            agregarEspecialidad.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar una especialidad debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarEspecialidades modificarEspecialidad = new frmModificarEspecialidades();
                modificarEspecialidad.Id = Convert.ToInt32(txtNumero.Text);
                modificarEspecialidad.Show();
                this.Hide();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar una especialidad debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteEspecialidad(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteEspecialidad(int id)
        {
            int EspecialidadID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, EspecialidadID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar la especialidad " + responseMessage.StatusCode);
                }
            }
            GetAllEspecialidades();
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
