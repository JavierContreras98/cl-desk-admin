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
using System.Web.Script.Serialization;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;
using Newtonsoft.Json;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class AdministrarTipoDocumento : Form
    {
        string URI = "https://localhost:44310/api/tipo_documento";

        public AdministrarTipoDocumento()
        {
            InitializeComponent();
        }

        private async void AdministrarTipoDocumento_Load(object sender, EventArgs e)
        {
            GetAllProdutos();
            radiobModificar();
        }


        private async void GetAllProdutos()
        {
            URI = URI;
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URI))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        //clienteUri = response.Headers.Location;
                        var TipodocumentoJsonString = await response.Content.ReadAsStringAsync();
                        dgvTipoDocumento.DataSource = JsonConvert.DeserializeObject<Tipo_DocumentoModels[]>(TipodocumentoJsonString).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No fue posible obtener los tipos de documentos " + response.StatusCode);
                    }
                }
            }
        }

        private void btnCrearTipoDocumento_Click(object sender, EventArgs e)
        {
            AgregarTipoDocumento crear = new AgregarTipoDocumento();
            crear.Show();
        }

        private void btnModificarTipoDocumento_Click(object sender, EventArgs e)
        {
            ModificarTipoDocumento modificarTipoDocumento = new ModificarTipoDocumento();
            modificarTipoDocumento.Id = Convert.ToInt32(txtNumero.Text);
            modificarTipoDocumento.Show();
        }

        private void radiobModificar()
        {
            txtNumero.Enabled = false;
            btnEliminarTipoDocumento.Enabled = false;
            btnModificarTipoDocumento.Enabled = false;
            if (rbModificar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a modificar";
                txtNumero.Enabled = true;
                btnModificarTipoDocumento.Enabled = true;
                btnEliminarTipoDocumento.Enabled = false;
            }
            if (rbEliminar.Checked == true)
            {
                lblInformacion.Text = "Ingrese el ID del dato a eliminar";
                txtNumero.Enabled = true;
                btnEliminarTipoDocumento.Enabled = true;
                btnModificarTipoDocumento.Enabled = false;
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

        private void btnEliminarTipoDocumento_Click(object sender, EventArgs e)
        {
            DeleteTipoDocumento(Convert.ToInt32(txtNumero.Text));
        }

        private async void DeleteTipoDocumento(int id)
        {
            URI = URI;
            int TipoDocumentoID = id;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URI);
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", URI, TipoDocumentoID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Tipo documento Eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error: No se puedo eliminar el tipo de documento " + responseMessage.StatusCode);
                }
            }
            GetAllProdutos();
        }

    }
}
