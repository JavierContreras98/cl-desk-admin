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
using cl_desk_admin.CapaModels;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    public partial class frmAdministrarTipoUsuario : Form
    {
        string URI = "https://localhost:44310/api/tipo_usuario";
        public frmAdministrarTipoUsuario()
        {
            InitializeComponent();
        }

        private async void frmAdministrarTipoUsuario_Load(object sender, EventArgs e)
        {
            dgvTipoUsuario.Refresh();
            this.Refresh();
            GetAllTiposUsuarios();
            radioButtonValidation();
        }

        private async void GetAllTiposUsuarios()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var TipoUsuarioJsonString = await response.Content.ReadAsStringAsync();
                        dgvTipoUsuario.DataSource = JsonConvert.DeserializeObject<Tipo_UsuarioModels[]>(TipoUsuarioJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los tipos de usuario " + response.StatusCode);
                    }
                }
            }
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarTipoUsuario.Enabled = false;
            btnModificarTipoUsuario.Enabled = false;
            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarTipoUsuario.Enabled = true;
                btnEliminarTipoUsuario.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarTipoUsuario.Enabled = true;
                btnModificarTipoUsuario.Enabled = false;
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

        private void btnCrearTipoUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarTipoUsuario agregarTipoUsuario = new frmAgregarTipoUsuario();
            this.Hide();
            agregarTipoUsuario.Show();
        }

        private void btnModificarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un tipo de usuario debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                frmModificarTipoUsuario modificarTipousuario = new frmModificarTipoUsuario();
                modificarTipousuario.Id = Convert.ToInt32(txtNumero.Text);
                modificarTipousuario.Show();
                this.Hide();
            }
        }

        private void btnEliminarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un tipo de usuario debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteTipoUsuario(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteTipoUsuario(int id)
        {
            int TipoUsuarioID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, TipoUsuarioID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el tipo de usuario " + responseMessage.StatusCode);
                }
            }
            GetAllTiposUsuarios();
        }

        
    }
}
