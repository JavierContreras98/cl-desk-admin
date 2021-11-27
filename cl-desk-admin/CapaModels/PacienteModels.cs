using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class PacienteModels
    {
        int id;
        string num_expediente;
        string primer_nom;
        string segundo_nom;
        string primer_ape;
        string segundo_ape;
        DateTime fecha_nacimiento;
        string telefono;
        string num_documento;
        int id_tipo_sangre;
        int id_pais;
        int id_departamento;
        int id_municipio;
        int id_tipo_doc;



        public int Id { get => id; set => id = value; }
        public string Num_expediente { get => num_expediente; set => num_expediente = value; }
        public string Primer_nom { get => primer_nom; set => primer_nom = value; }
        public string Segundo_nom { get => segundo_nom; set => segundo_nom = value; }
        public string Primer_ape { get => primer_ape; set => primer_ape = value; }
        public string Segundo_ape { get => segundo_ape; set => segundo_ape = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public int Id_tipo_sangre { get => id_tipo_sangre; set => id_tipo_sangre = value; }
        public int Id_pais { get => id_pais; set => id_pais = value; }
        public int Id_departamento { get => id_departamento; set => id_departamento = value; }
        public int Id_municipio { get => id_municipio; set => id_municipio = value; }
        public int Id_tipo_doc { get => id_tipo_doc; set => id_tipo_doc = value; }
    }
}
