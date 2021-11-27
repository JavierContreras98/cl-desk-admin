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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminDepartamentos
{
    public partial class frmAdministrarDepartamentos : Form
    {
        string URI_DEPARTAMENTO = "https://localhost:44310/api/departamento";

        string URI_PAIS = "https://localhost:44310/api/pais";
        public frmAdministrarDepartamentos()
        {
            InitializeComponent();
        }

        

        private void frmAdministrarDepartamentos_Load(object sender, EventArgs e)
        {
            dgvDepartamentos.Refresh();
            this.Refresh();
            GetAllDepartamento();
            radioButtonValidation();
        }

        private async void GetAllDepartamento()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_DEPARTAMENTO))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var DepartamentoJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(DepartamentoJsonString);
                        dgvDepartamentos.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los departamentos " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAgregarDepartamento agregardepartamento = new frmAgregarDepartamento();
            this.Hide();
            agregardepartamento.ShowDialog();
            this.Close();

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
                DeleteDepartamento(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }
        private async void DeleteDepartamento(int id)
        {
            int DepartamentoID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_DEPARTAMENTO);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_DEPARTAMENTO, DepartamentoID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el departamento " + responseMessage.StatusCode);
                }
            }
            GetAllDepartamento();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
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
                frmModificarDepartamento modificarDepartamento = new frmModificarDepartamento();
                modificarDepartamento.Id = Convert.ToInt32(txtNumero.Text);

                this.Hide();
                modificarDepartamento.ShowDialog();
                this.Close();
            }
        }

        private void btnMenuP_Click(object sender, EventArgs e)
        {
            frmMenuAdminGeneral menuPricipal = new frmMenuAdminGeneral();

            this.Hide();
            menuPricipal.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
