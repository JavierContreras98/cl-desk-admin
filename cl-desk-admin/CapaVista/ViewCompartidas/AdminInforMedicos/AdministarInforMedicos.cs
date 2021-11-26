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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminInforMedicos
{
    public partial class frmAdminInforMedicos : Form
    {
        string URI_MEDICO = "https://localhost:44310/api/medico";

        //string URI_PAIS = "";

        public frmAdminInforMedicos()
        {
            InitializeComponent();
        }

        private void frmAdminInforMedicos_Load(object sender, EventArgs e)
        {
            dgvInfoMedicos.Refresh();
            this.Refresh();
            GetAllMedicos();
            radioButtonValidation();
        }

        private async void GetAllMedicos()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_MEDICO))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var MedicoJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(MedicoJsonString);
                        dgvInfoMedicos.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los medicos " + response.StatusCode);
                    }
                }
            }
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarInfoMedico.Enabled = false;
            btnModificarInfoMedico.Enabled = false;

            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarInfoMedico.Enabled = true;
                btnEliminarInfoMedico.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarInfoMedico.Enabled = true;
                btnModificarInfoMedico.Enabled = false;
            }
        }
        private void btnCrearInfoMedico_Click(object sender, EventArgs e)
        {
            AgregarInforMedicos agregarInfoMedico = new AgregarInforMedicos();
            this.Hide();
            agregarInfoMedico.Show();
        }

        private void btnModificarInfoMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un medico debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                ModificarInforMedicos modificarInfoMedico = new ModificarInforMedicos();
                modificarInfoMedico.Id = Convert.ToInt32(txtNumero.Text);
                modificarInfoMedico.Show();
                this.Hide();
            }
        }

        private void btnEliminarInfoMedico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un medico debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteMedico(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }

        private async void DeleteMedico(int id)
        {
            int DepartamentoID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_MEDICO);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_MEDICO, DepartamentoID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el medico " + responseMessage.StatusCode);
                }
            }
            GetAllMedicos();
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
