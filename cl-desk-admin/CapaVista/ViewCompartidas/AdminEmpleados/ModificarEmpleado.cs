using cl_desk_admin.CapaModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminEmpleados
{
    public partial class frmModificarEmpleado : Form
    {
        string URI_EMPLEADO = "https://localhost:44310/api/Empleado";



        string URI_TIPO_DOCUMENTO = "https://localhost:44310/api/tipo_documento";



        string URI_PROFESION = "https://localhost:44310/api/profesion";



        string URI_USUARIO = "https://localhost:44310/api/Usuario";



        int id;



        string data;



        public int Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }



        public frmModificarEmpleado()
        {
            InitializeComponent();
        }



        private async void frmModificarEmpleado_Load(object sender, EventArgs e)
        {
            lbID.Text = Id.ToString();
            this.CargarDatos();



            string respuesta = await GetHttp();
            List<Tipo_DocumentoModels> lst = JsonConvert.DeserializeObject<List<Tipo_DocumentoModels>>(respuesta);
            cbxTipodocumentos.DataSource = lst;
            cbxTipodocumentos.ValueMember = "ID";
            cbxTipodocumentos.DisplayMember = "NOMBRE";
            cbxTipodocumentos.Refresh();



            string respuesta2 = await GetHttp2();
            List<ProfesionModels> lst2 = JsonConvert.DeserializeObject<List<ProfesionModels>>(respuesta2);
            cbxProfesion.DataSource = lst2;
            cbxProfesion.ValueMember = "ID";
            cbxProfesion.DisplayMember = "NOMBRE";
            cbxProfesion.Refresh();



            string respuesta3 = await GetHttp3();
            List<UsuarioModels> lst3 = JsonConvert.DeserializeObject<List<UsuarioModels>>(respuesta3);
            cbxUsuario.DataSource = lst3;
            cbxUsuario.ValueMember = "ID";
            cbxUsuario.DisplayMember = "NOM_USUARIO";
            cbxUsuario.Refresh();
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            actualizarEmpleado(Id);
            frmAdministrarEmpleados departamentos = new frmAdministrarEmpleados();
            this.Hide();
            departamentos.Show();
            departamentos.Refresh();
        }



        private async void actualizarEmpleado(int id)
        {
            EmpleadoModels empleado = new EmpleadoModels();
            empleado.Id = id;
            empleado.Primer_nom = txtPrimerNombre.Text;
            empleado.Segundo_nom = txtSegundoNombre.Text;
            empleado.Primer_ape = txtPrimerApellido.Text;
            empleado.Segundo_ape = SegundoApellido.Text;
            empleado.Fecha_nacimiento = dtpFechaNacimiento.Value;
            empleado.Correo = txtCorreo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.Num_documento = txtNombredocumento.Text;



            empleado.Id_tipo_doc = Convert.ToInt32(cbxTipodocumentos.SelectedValue);
            empleado.Id_profesion = Convert.ToInt32(cbxProfesion.SelectedValue);
            empleado.Id_usuario = Convert.ToInt32(cbxUsuario.SelectedValue);



            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(URI_EMPLEADO + "/" + empleado.Id, empleado);
                if (responseMessage.IsSuccessStatusCode)
                {



                }
                else
                {
                    MessageBox.Show("Error:Al intentar actualizar el Empleado " + responseMessage.StatusCode);
                }
            }
        }



        private async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URI_EMPLEADO + "/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        Data = await content.ReadAsStringAsync();
                        if (Data != null)
                        {
                            return Data;



                        }
                    }
                }
            }
            return string.Empty;
        }




        private async void CargarDatos()
        {
            var response = await Get(Id);
            var res = JsonConvert.DeserializeObject<dynamic>(response);



            txtPrimerNombre.Text = res[0].PRIMER_NOM;
            txtSegundoNombre.Text = res[0].SEGUNDO_NOM;
            txtPrimerApellido.Text = res[0].PRIMER_APE;
            SegundoApellido.Text = res[0].SEGUNDO_APE;
            dtpFechaNacimiento.Value = res[0].FECHA_NACIMIENTO;
            txtCorreo.Text = res[0].CORREO;
            txtTelefono.Text = res[0].TELEFONO;
            txtNombredocumento.Text = res[0].NUM_DOCUMENTO;



            cbxTipodocumentos.Text = res[0].TIPO_DOCUMENTO;
            cbxProfesion.Text = res[0].PROFESION;
            cbxUsuario.Text = res[0].NOM_USUARIO;



        }



        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_DOCUMENTO);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }



        private async Task<string> GetHttp2()
        {
            WebRequest oRequest2 = WebRequest.Create(URI_PROFESION);
            WebResponse oResponse2 = oRequest2.GetResponse();
            StreamReader sr2 = new StreamReader(oResponse2.GetResponseStream());
            return await sr2.ReadToEndAsync();
        }



        private async Task<string> GetHttp3()
        {
            WebRequest oRequest3 = WebRequest.Create(URI_USUARIO);
            WebResponse oResponse3 = oRequest3.GetResponse();
            StreamReader sr3 = new StreamReader(oResponse3.GetResponseStream());
            return await sr3.ReadToEndAsync();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarEmpleados regresar = new frmAdministrarEmpleados();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}