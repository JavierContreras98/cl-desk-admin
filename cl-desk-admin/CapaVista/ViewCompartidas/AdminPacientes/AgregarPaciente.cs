﻿using cl_desk_admin.CapaModels;
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

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminPacientes
{
    public partial class AgregarPaciente : Form
    {
        string URI_PACIENTE = "https://localhost:44310/api/paciente";
        string URI_TIPO_SANGRE = "https://localhost:44310/api/tipo_sangre";
        string URI_PAIS = "https://localhost:44310/api/pais";
        string URI_TIPO_DOC = "https://localhost:44310/api/tipo_documento";

        public AgregarPaciente()
        {
            InitializeComponent();
        }

        private async void AgregarPaciente_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttpPais();
            List<PaisModels> lst = JsonConvert.DeserializeObject<List<PaisModels>>(respuesta);
            cbxPais.DataSource = lst;
            cbxPais.ValueMember = "ID";
            cbxPais.DisplayMember = "NOMBRE";
            cbxPais.Refresh();

            string respuesta2 = await GetHttpSangre();
            List<Tipo_SangreModels> lst2 = JsonConvert.DeserializeObject<List<Tipo_SangreModels>>(respuesta2);
            cbxtiposangre.DataSource = lst2;
            cbxtiposangre.ValueMember = "ID";
            cbxtiposangre.DisplayMember = "NOMBRE";
            cbxtiposangre.Refresh();
            
            string respuesta3 = await GetHttpDocumento();
            List<Tipo_DocumentoModels> lst3 = JsonConvert.DeserializeObject<List<Tipo_DocumentoModels>>(respuesta3);
            cbxTipoDocumento.DataSource = lst3;
            cbxTipoDocumento.ValueMember = "ID";
            cbxTipoDocumento.DisplayMember = "NOMBRE";
            cbxTipoDocumento.Refresh();
        }

        private async Task<string> GetHttpPais()
        {
            WebRequest oRequest = WebRequest.Create(URI_PAIS);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpSangre()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_SANGRE);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async Task<string> GetHttpDocumento()
        {
            WebRequest oRequest = WebRequest.Create(URI_TIPO_DOC);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddPaciente();
            }
            catch (Exception)
            {
                Console.WriteLine("Algo salio mal");
            }
            frmAdministrarPacientes paciente = new frmAdministrarPacientes();
            this.Close();
            paciente.Refresh();
            paciente.Show();
        }

        private async void AddPaciente()
        {
            PacienteModels paciente = new PacienteModels();
            paciente.Num_expediente = txtExpediente.Text;
            paciente.Primer_nom = txtPrimerNombre.Text;
            paciente.Segundo_nom = txtSegundoNombre.Text;
            paciente.Primer_ape = txtPrimerApellido.Text;
            paciente.Segundo_ape = SegundoApellido.Text;
            paciente.Fecha_nacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
            paciente.Telefono = txtTelefono.Text;
            paciente.Num_documento = txtNumeroDocumento.Text;
            paciente.Id_tipo_sangre = Convert.ToInt32(cbxtiposangre.SelectedValue);
            paciente.Id_tipo_doc = Convert.ToInt32(cbxTipoDocumento.SelectedValue);
            paciente.Id_pais = Convert.ToInt32(cbxPais.SelectedValue);
            

            using (var client = new HttpClient())
            {
                var serializedpaciente = JsonConvert.SerializeObject(paciente);
                var content = new StringContent(serializedpaciente, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(URI_PACIENTE, content);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAdministrarPacientes regresar = new frmAdministrarPacientes();
            this.Hide();
            regresar.ShowDialog();
            this.Close();
        }
    }
}
