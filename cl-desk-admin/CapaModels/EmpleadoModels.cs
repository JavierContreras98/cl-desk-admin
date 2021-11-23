using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class EmpleadoModels
    {
        int id, id_tipo_doc, id_profesion, id_usuario;
        string primer_nom, segundo_nom, primer_ape, segundo_ape, correo, telefono, num_documento,expediente;
        DateTime fecha_nacimiento;

        public int Id { get => id; set => id = value; }

        public string Expediente { get => expediente; set => expediente = value; }

        public string Primer_nom { get => primer_nom; set => primer_nom = value; }
        public string Segundo_nom { get => segundo_nom; set => segundo_nom = value; }
        public string Primer_ape { get => primer_ape; set => primer_ape = value; }
        public string Segundo_ape { get => segundo_ape; set => segundo_ape = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Num_documento { get => num_documento; set => num_documento = value; }
        public int Id_tipo_doc { get => id_tipo_doc; set => id_tipo_doc = value; }
        public int Id_profesion { get => id_profesion; set => id_profesion = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
       
    }
}
