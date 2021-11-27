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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminProfesion
{
    public partial class AdministrarProfesion : Form
    {
        string URI = "https://localhost:44310/api/profesion";
        public AdministrarProfesion()
        {
            InitializeComponent();
        }

        private async void AdministrarProfesion_Load(object sender, EventArgs e)
        {
            dgvProfesion.Refresh();
            this.Refresh();
            GetAllProfesiones();
            radioButtonValidation();
        }

        private async void GetAllProfesiones()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var ProfesionJsonString = await response.Content.ReadAsStringAsync();
                        dgvProfesion.DataSource = JsonConvert.DeserializeObject<ProfesionModels[]>(ProfesionJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener las profesiones " + response.StatusCode);
                    }
                }
            }
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarProfesion.Enabled = false;
            btnModificarProfesion.Enabled = false;
            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarProfesion.Enabled = true;
                btnEliminarProfesion.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarProfesion.Enabled = true;
                btnModificarProfesion.Enabled = false;
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

        private void btnCrearProfesion_Click(object sender, EventArgs e)
        {
            AgregarProfesion agregarProfesion = new AgregarProfesion();
            this.Hide();
            agregarProfesion.Show();
        }

        private void btnModificarProfesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar una profesion debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                ModificarProfesion modificarProfesion= new ModificarProfesion();
                modificarProfesion.Id = Convert.ToInt32(txtNumero.Text);
                modificarProfesion.Show();
                this.Hide();
            }
        }

        private void btnEliminarProfesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar una profesion debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteProfesion(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteProfesion(int id)
        {
            int ProfesionID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, ProfesionID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar la profesion " + responseMessage.StatusCode);
                }
            }
            GetAllProfesiones();
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
