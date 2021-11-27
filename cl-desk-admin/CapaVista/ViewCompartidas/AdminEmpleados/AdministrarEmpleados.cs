using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaVista.ViewCompartidas;
using cl_desk_admin.CapaVista.ViewAdministradorGeneral;
using System.Net;
using System.IO;
using System.Net.Http;



namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEmpleados
{
    public partial class frmAdministrarEmpleados : Form
    {
        string URI_EMPLEADO = "https://localhost:44310/api/Empleado";

        string URI_TIPO_DOCUMENTO = "https://localhost:44310/api/tipo_documento";

        string URI_PROFESION = "https://localhost:44310/api/profesion";

        string URI_USUARIO = "https://localhost:44310/api/Usuario";

        int id;
        string data;

        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }

        public frmAdministrarEmpleados()
        {
            InitializeComponent();
        }

        private void frmAdministrarEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleado.Refresh();
            this.Refresh();
            GetAllEmpleado();
            radioButtonValidation();
        }

        private async void GetAllEmpleado()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI_EMPLEADO))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var EmpleadoJsonString = await response.Content.ReadAsStringAsync();
                        DataTable listado = JsonConvert.DeserializeObject<DataTable>(EmpleadoJsonString);
                        dgvEmpleado.DataSource = listado;
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los Empleados " + response.StatusCode);
                    }
                }
            }
        }

        private void radioButtonValidation()
        {
            txtNumero.Enabled = false;
            btnEliminarEmpleado.Enabled = false;
            btnModificarEmpleado.Enabled = false;

            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarEmpleado.Enabled = true;
                btnEliminarEmpleado.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarEmpleado.Enabled = true;
                btnModificarEmpleado.Enabled = false;
            }
        }

        private void btnCrearTipoUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarEmpleado agregarempleado = new frmAgregarEmpleado();
            this.Hide();
            agregarempleado.Show();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbEliminar.Enabled == true)
                {
                    MessageBox.Show("Para eliminar un Empleado debe ingresar el numero de ID a eliminar");
                }
            }
            else
            {
                DeleteEmpleado(Convert.ToInt32(txtNumero.Text));
                txtNumero.Text = string.Empty;
            }
        }
        private async void DeleteEmpleado(int id)
        {
            int EmpleadoID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI_EMPLEADO);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI_EMPLEADO, EmpleadoID));
                if (responseMessage.IsSuccessStatusCode)
                {

                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el Empleado " + responseMessage.StatusCode);
                }
            }
            GetAllEmpleado();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
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
                frmModificarEmpleado modificar = new frmModificarEmpleado();
                modificar.Id = Convert.ToInt32(txtNumero.Text);
                modificar.Show();
                this.Hide();
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmMenuAdminGeneral menuPricipal = new frmMenuAdminGeneral();

            this.Hide();
            menuPricipal.ShowDialog();
            this.Close();
        }

        private void frmAdministrarEmpleados_Load_1(object sender, EventArgs e)
        {

        }
    }
}

