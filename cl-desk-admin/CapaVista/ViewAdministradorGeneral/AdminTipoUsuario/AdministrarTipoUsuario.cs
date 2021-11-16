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
using cl_desk_admin.CapaModelo;
using System.Net;
using System.IO;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    public partial class frmAdministrarTipoUsuario : Form
    {
        Tipo_UsuarioModels resultado;
        int id;
        string nombre, descrpcion;

        internal Tipo_UsuarioModels Resultado { get => resultado; set => resultado = value; }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descrpcion { get => descrpcion; set => descrpcion = value; }

        public frmAdministrarTipoUsuario()
        {
            InitializeComponent();
        }

        private async void frmAdministrarTipoUsuario_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Tipo_UsuarioModels> list =
                JsonConvert.DeserializeObject<List<Tipo_UsuarioModels>>(respuesta);
            dgvTipoUsuario.DataSource = list;
            dgvTipoUsuario.Refresh();

            this.dgvTipoUsuario.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTipoUsuario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvTipoUsuario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44310/api/Tipo_Usuario");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnModificarTipoUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private async Task<string> GetIdHttp() 
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44310/api/Tipo_Usuario/" + id);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
    }
}
