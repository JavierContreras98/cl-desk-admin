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

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminUsuario
{
    public partial class frmAdministrarUsuario : Form
    {
        string URI_USUARIO = "https://localhost:44310/api/Usuario";
        public frmAdministrarUsuario()
        {
            InitializeComponent();
        }

        private async void frmAdministrarUsuario_Load(object sender, EventArgs e)
        {
            dgvUsuario.Refresh();
            this.Refresh();
            GetAllUsuarios();
            radioButtonValidation();
        }

        private async void GetAllUsuarios()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_USUARIO))
                {
                    if (response.IsSuccessStatusCode)
                    {

                        var UsuarioJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(UsuarioJsonString);
                        dgvUsuario.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los usuarios " + response.StatusCode);
                    }
                }
            }
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            btnModificarUsuario.Enabled = false;
            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarUsuario.Enabled = true;
                btnEliminarUsuario.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnModificarUsuario.Enabled = false;
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

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregarUsuario = new frmAgregarUsuario();

            this.Hide();
            agregarUsuario.ShowDialog();
            this.Close();

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un usuario debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                ModificarUsuario modificarUsuario = new ModificarUsuario();
                modificarUsuario.Id = Convert.ToInt32(txtNumero.Text);

                this.Hide();
                modificarUsuario.ShowDialog();
                modificarUsuario.Refresh();
                this.Close();

            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un usuario debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteUsuario(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteUsuario(int id)
        {
            int UsuarioID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_USUARIO);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_USUARIO, UsuarioID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el usuario.\nPara Eliminar un usuario debe eliminar el empleado que tiene ese usuario ");
                }
            }
            GetAllUsuarios();
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
